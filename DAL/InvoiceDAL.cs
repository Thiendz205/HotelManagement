using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class InvoiceDAL
    {
        private readonly HotelManagementDataContext db = new HotelManagementDataContext();

        // ✅ Lấy BookingID đang CheckIn từ roomId
        private string GetActiveBookingIdByRoom(string roomId)
        {
            return db.Bookings
                     .Where(b => b.RoomID == roomId && b.Status == "CheckIn")
                     .Select(b => b.BookingID)
                     .FirstOrDefault();
        }

        public decimal CalculateBookingTotal(string bookingId)
        {
            try
            {
                var booking = db.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
                if (booking == null) return 0m;

                // 🔹 Lấy loại phòng
                var room = db.Rooms.FirstOrDefault(r => r.RoomID == booking.RoomID);
                if (room == null) return 0m;

                var roomType = db.RoomTypes.FirstOrDefault(rt => rt.RoomTypeID == room.RoomTypeID);
                if (roomType == null) return 0m;

                // 🔹 Xác định giá phòng (ưu tiên giá động)
                var dynamicPrice = db.RoomTypePrices
                    .Where(p => p.RoomTypeID == roomType.RoomTypeID &&
                                booking.CheckIn.Date >= p.StartDate &&
                                booking.CheckIn.Date <= p.EndDate)
                    .OrderByDescending(p => p.StartDate)
                    .FirstOrDefault();

                decimal pricePerUnit = (booking.RentalType == "Day")
                    ? (dynamicPrice?.PricePerDay ?? roomType.PricePerDay)
                    : (dynamicPrice?.PricePerHour ?? roomType.PricePerHour);

                // 🔹 Tính thời gian thuê (nếu chưa checkout thì lấy giờ hiện tại)
                DateTime checkOutTime = booking.CheckOut ?? DateTime.Now;
                double totalHours = (checkOutTime - booking.CheckIn).TotalHours;

                int quantity = (booking.RentalType == "Day")
                    ? Math.Max(1, (int)Math.Ceiling(totalHours / 24))
                    : Math.Max(1, (int)Math.Ceiling(totalHours));

                decimal roomTotal = pricePerUnit * quantity;

                // 🔹 Dịch vụ
                decimal serviceTotal = (from su in db.ServiceUsages
                                        join s in db.Services on su.ServiceID equals s.ServiceID
                                        where su.BookingID == booking.BookingID
                                        select (decimal?)(s.Price * su.Quantity)).Sum() ?? 0m;

                // 🔹 Phụ phí
                decimal feeTotal = (from bf in db.BookingFees
                                    join ft in db.FeeTypes on bf.FeeTypeID equals ft.FeeTypeID
                                    where bf.BookingID == booking.BookingID
                                    select (decimal?)(ft.DefaultPrice * bf.Quantity)).Sum() ?? 0m;

                // 🔹 Tổng tiền trước giảm giá
                decimal totalBeforeDiscount = roomTotal + serviceTotal + feeTotal;

                // 🔹 Giảm giá theo hạng khách hàng (CustomerRank)
                decimal discountPercent = 0m;
                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == booking.CustomerID);
                if (customer != null)
                {
                    var rank = db.CustomerRanks.FirstOrDefault(r => r.RankID == customer.RankID);
                    if (rank != null)
                        discountPercent = rank.DiscountPercent; // % giảm giá
                }

                decimal discountAmount = totalBeforeDiscount * discountPercent / 100;
                decimal totalAfterDiscount = totalBeforeDiscount - discountAmount;

                return totalAfterDiscount;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi CalculateBookingTotal: " + ex.Message);
                return 0m;
            }
        }
        public List<BookingUsageET> GetUsageDetailsByBooking(string bookingId)
        {
            var list = new List<BookingUsageET>();

            var booking = db.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
            if (booking == null) return list;

            var room = db.Rooms.FirstOrDefault(r => r.RoomID == booking.RoomID);
            var roomType = db.RoomTypes.FirstOrDefault(rt => rt.RoomTypeID == room.RoomTypeID);

            // --- Giá động ---
            var dynamicPrice = db.RoomTypePrices
                .Where(p => p.RoomTypeID == roomType.RoomTypeID &&
                            booking.CheckIn.Date >= p.StartDate &&
                            booking.CheckIn.Date <= p.EndDate)
                .OrderByDescending(p => p.StartDate)
                .FirstOrDefault();

            decimal pricePerUnit = (booking.RentalType == "Day")
                ? (dynamicPrice?.PricePerDay ?? roomType.PricePerDay)
                : (dynamicPrice?.PricePerHour ?? roomType.PricePerHour);

            DateTime checkOutTime = booking.CheckOut ?? DateTime.Now;
            double totalHours = (checkOutTime - booking.CheckIn).TotalHours;

            int quantity = (booking.RentalType == "Day")
                ? Math.Max(1, (int)Math.Ceiling(totalHours / 24))
                : Math.Max(1, (int)Math.Ceiling(totalHours));

            // --- Thêm tiền phòng ---
            list.Add(new BookingUsageET
            {
                Type = "Tiền phòng",
                ItemName = roomType?.TypeName ?? "Phòng",
                Price = pricePerUnit,
                Quantity = quantity,
                UsedAt = booking.CheckIn
            });

            // --- Dịch vụ ---
            var services = from su in db.ServiceUsages
                           join s in db.Services on su.ServiceID equals s.ServiceID
                           where su.BookingID == bookingId
                           select new BookingUsageET
                           {
                               Type = "Dịch vụ",
                               ItemName = s.ServiceName,
                               Price = s.Price,
                               Quantity = su.Quantity,
                               UsedAt = su.UsageDate
                           };
            list.AddRange(services);

            // --- Phụ phí ---
            var fees = from bf in db.BookingFees
                       join ft in db.FeeTypes on bf.FeeTypeID equals ft.FeeTypeID
                       where bf.BookingID == bookingId
                       select new BookingUsageET
                       {
                           Type = "Phụ phí",
                           ItemName = ft.FeeTypeName,
                           Price = ft.DefaultPrice,
                           Quantity = bf.Quantity,
                           UsedAt = bf.CreatedAt ?? DateTime.Now
                       };
            list.AddRange(fees);

            return list;
        }

        private string GenerateShortId(string prefix, int totalLength = 10)
        {
            // prefix length must be < totalLength
            var guidPart = Guid.NewGuid().ToString("N").ToUpper(); // 32 chars
            int remain = Math.Max(1, totalLength - prefix.Length);
            return (prefix + guidPart).Substring(0, Math.Min(prefix.Length + remain, totalLength));
        }

        public bool CreateInvoiceByBooking(string bookingId, string staffId, string paymentMethod, string note)
        {
            try
            {
                var booking = db.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
                if (booking == null) return false;

                decimal total = CalculateBookingTotal(bookingId);

                var invoice = new Invoice
                {
                    InvoiceID = GenerateShortId("INV", 10),
                    BookingID = bookingId,
                    InvoiceDate = DateTime.Now,
                    TotalAmount = total,
                    PaymentMethod = paymentMethod,
                    PaidStatus = "Paid",
                    StaffID = staffId,
                    Note = note,
                    CreatedBy = "UNKNOWN",
                    AuditStatus = "OK"
                };

                db.Invoices.InsertOnSubmit(invoice);

                // ✅ Cập nhật trạng thái Booking thành CheckOut
                booking.Status = "CheckOut";

                // ✅ Kiểm tra xem phòng này có booking nào khác còn ở trạng thái 'Reserved' không
                var hasReserved = db.Bookings.Any(b =>
                    b.RoomID == booking.RoomID &&
                    b.Status == "Reserved" &&
                    b.BookingID != booking.BookingID
                );

                // ✅ Cập nhật trạng thái phòng phù hợp
                var room = db.Rooms.FirstOrDefault(r => r.RoomID == booking.RoomID);
                if (room != null)
                {
                    if (hasReserved)
                        room.Status = "Reserved"; // Có khách đặt trước → phòng vẫn giữ trạng thái Đặt trước
                    else
                        room.Status = "Dọn dẹp"; // Không có khách đặt trước → phòng trống
                }

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi CreateInvoiceByBooking: " + ex.Message + " | Stack: " + ex.StackTrace);
                return false;
            }
        }


        // ✅ Lấy usage qua roomId (cho form)
        public List<BookingUsageET> GetUsageByRoom(string roomId)
        {
            string bookingId = GetActiveBookingIdByRoom(roomId);
            if (string.IsNullOrEmpty(bookingId)) return new List<BookingUsageET>();
            return GetUsageDetailsByBooking(bookingId);
        }
        public CustomerPaymentInfoET GetCustomerInfoByRoom(string roomId)
        {
            var info = (from b in db.Bookings
                        join c in db.Customers on b.CustomerID equals c.CustomerID
                        join r in db.Rooms on b.RoomID equals r.RoomID
                        where b.RoomID == roomId && b.Status == "CheckIn"
                        select new CustomerPaymentInfoET
                        {
                            BookingID = b.BookingID,
                            CustomerName = c.FullName,
                            Phone = c.PhoneNumber,
                            RentalType = b.RentalType,
                            CheckIn = b.CheckIn,
                            CheckOut = b.CheckOut,
                            RoomName = r.RoomName
                        }).FirstOrDefault();

            return info;
        }
        public bool AddExtraFeeToBooking(string bookingId, string feeTypeId, int quantity = 1)
        {
            try
            {
                using (var dbctx = new HotelManagementDataContext())
                {
                    var fee = new BookingFee
                    {
                        BookingFeeID = GenerateShortId("BF", 10), // ≦ 10 chars
                        BookingID = bookingId,
                        FeeTypeID = feeTypeId,
                        Quantity = quantity,
                        CreatedAt = DateTime.Now
                    };
                    dbctx.BookingFees.InsertOnSubmit(fee);
                    dbctx.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi AddExtraFeeToBooking: " + ex.Message + " | Stack: " + ex.StackTrace);
                return false;
            }
        }
        public List<(string Period, decimal Revenue)> GetRevenueStatistics(string mode, int year, int? month = null)
        {
            try
            {
                var query = db.Invoices
                              .Where(i => i.PaidStatus.ToLower() == "paid")
                              .AsQueryable();

                if (mode == "Day" && month.HasValue)
                {
                    // Doanh thu theo ngày trong 1 tháng
                    return query
                        .Where(i => i.InvoiceDate.Year == year && i.InvoiceDate.Month == month.Value)
                        .GroupBy(i => i.InvoiceDate.Day)
                        .Select(g => new { Day = g.Key, Revenue = g.Sum(i => i.TotalAmount) })
                        .AsEnumerable()
                        .Select(x => ($"{x.Day:D2}/{month.Value:D2}", x.Revenue))
                        .OrderBy(x => x.Item1)
                        .ToList();
                }
                else if (mode == "Month")
                {
                    // Doanh thu theo tháng trong 1 năm
                    return query
                        .Where(i => i.InvoiceDate.Year == year)
                        .GroupBy(i => i.InvoiceDate.Month)
                        .Select(g => new { Month = g.Key, Revenue = g.Sum(i => i.TotalAmount) })
                        .AsEnumerable()
                        .Select(x => ($"Tháng {x.Month}", x.Revenue))
                        .OrderBy(x => x.Item1)
                        .ToList();
                }
                else if (mode == "Year")
                {
                    // Doanh thu theo từng năm
                    return query
                        .GroupBy(i => i.InvoiceDate.Year)
                        .Select(g => new { Year = g.Key, Revenue = g.Sum(i => i.TotalAmount) })
                        .AsEnumerable()
                        .Select(x => ($"Năm {x.Year}", x.Revenue))
                        .OrderBy(x => x.Item1)
                        .ToList();
                }

                return new List<(string, decimal)>();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi GetRevenueStatistics: " + ex.Message);
                return new List<(string, decimal)>();
            }
        }
        public List<InvoiceET> GetRevenueByRoom(string mode, int year, int? month = null, int? day = null)
        {
            try
            {
                // 1️⃣ Join dữ liệu: Invoices + Bookings + Rooms + RoomTypes
                var query = from inv in db.Invoices
                            join b in db.Bookings on inv.BookingID equals b.BookingID
                            join r in db.Rooms on b.RoomID equals r.RoomID
                            join rt in db.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                            where inv.PaidStatus.ToLower() == "paid"
                            select new
                            {
                                Invoice = inv,
                                Booking = b,
                                RoomID = r.RoomID,
                                RoomName = r.RoomName,
                                RoomType = rt.TypeName,
                                RoomTypeID = rt.RoomTypeID,
                                PricePerDay = rt.PricePerDay,
                                PricePerHour = rt.PricePerHour
                            };

                // 2️⃣ Lọc theo thời gian
                if (day.HasValue && month.HasValue)
                {
                    query = query.Where(x =>
                        x.Invoice.InvoiceDate.Year == year &&
                        x.Invoice.InvoiceDate.Month == month.Value &&
                        x.Invoice.InvoiceDate.Day == day.Value
                    );
                }
                else if (month.HasValue)
                {
                    query = query.Where(x =>
                        x.Invoice.InvoiceDate.Year == year &&
                        x.Invoice.InvoiceDate.Month == month.Value
                    );
                }
                else
                {
                    query = query.Where(x =>
                        x.Invoice.InvoiceDate.Year == year
                    );
                }

                // 3️⃣ Group theo phòng để tính tổng doanh thu
                var result = query
                    .AsEnumerable() // vì RoomTypePrices là table khác, cần Enumerable để LINQ-to-Objects
                    .GroupBy(x => new
                    {
                        x.RoomID,
                        x.RoomName,
                        x.RoomType,
                        x.RoomTypeID,
                        x.PricePerDay,
                        x.PricePerHour
                    })
                    .Select(g =>
                    {
                        var sample = g.First();

                        // 4️⃣ Tìm giá động theo ngày hóa đơn
                        var dynamicPrice = db.RoomTypePrices
                            .Where(p =>
                                p.RoomTypeID == sample.RoomTypeID &&
                                sample.Invoice.InvoiceDate.Date >= p.StartDate &&
                                sample.Invoice.InvoiceDate.Date <= p.EndDate
                            )
                            .OrderByDescending(p => p.StartDate)
                            .FirstOrDefault();

                        decimal finalPrice = (sample.Booking.RentalType == "Day")
                            ? (dynamicPrice?.PricePerDay ?? sample.PricePerDay)
                            : (dynamicPrice?.PricePerHour ?? sample.PricePerHour);

                        return new InvoiceET
                        {
                            RoomID = sample.RoomID,
                            RoomName = sample.RoomName,
                            RoomType = sample.RoomType,
                            Price = finalPrice,
                            Revenue = g.Sum(x => x.Invoice.TotalAmount)
                        };
                    })
                    .OrderByDescending(x => x.Revenue)
                    .ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ ERROR GetRevenueByRoom: " + ex.Message);
                return new List<InvoiceET>();
            }
        }

        public int ParseMonth(string dal)
        {
            string digits = new string(dal.Where(char.IsDigit).ToArray());
            return int.TryParse(digits, out int m) ? m : 0;
        }

    }
}
