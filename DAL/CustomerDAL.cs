using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        private HotelManagementDataContext db = new HotelManagementDataContext();

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

                // 🔹 Xác định giá phòng
                var dynamicPrice = db.RoomTypePrices
                    .Where(p => p.RoomTypeID == roomType.RoomTypeID &&
                                booking.CheckIn.Date >= p.StartDate &&
                                booking.CheckIn.Date <= p.EndDate)
                    .OrderByDescending(p => p.StartDate)
                    .FirstOrDefault();

                decimal pricePerUnit = 0;
                if (dynamicPrice != null)
                {
                    pricePerUnit = (booking.RentalType == "Day") ? dynamicPrice.PricePerDay : dynamicPrice.PricePerHour;
                }
                else
                {
                    pricePerUnit = (booking.RentalType == "Day") ? roomType.PricePerDay : roomType.PricePerHour;
                }

                // 🔹 Tính thời gian thuê (nếu chưa checkout thì lấy giờ hiện tại)
                DateTime checkOutTime = booking.CheckOut ?? DateTime.Now;
                double totalHours = (checkOutTime - booking.CheckIn).TotalHours;

                // Số lượng đơn vị thuê (ngày hoặc giờ)
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

                // 🔹 Tổng cộng
                decimal total = roomTotal + serviceTotal + feeTotal;
                return total;
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi CalculateBookingTotal: " + ex.Message);
                return 0m;
            }
        }

        // --- Tổng tiền gốc (để xét hạng) ---
        public decimal GetTotalSpendingForRank(string customerId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(customerId))
                    return 0m;

                // 🔹 Lấy danh sách BookingID của khách hàng
                var bookingIds = db.Bookings
                    .Where(b => b.CustomerID == customerId)
                    .Select(b => b.BookingID)
                    .ToList();

                if (!bookingIds.Any())
                    return 0m;

                // 🔹 Tính tổng tiền của các hóa đơn đã thanh toán
                decimal total = db.Invoices
                    .Where(i => bookingIds.Contains(i.BookingID) && i.PaidStatus == "Paid")
                    .Sum(i => (decimal?)i.TotalAmount) ?? 0m;

                return total;
            }
            catch (Exception ex)
            {
                // Có thể log lỗi nếu cần: Console.WriteLine(ex.Message);
                return 0m;
            }
        }
        public decimal GetTotalSpending(string customerId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(customerId))
                    return 0m;

                // 🔹 Lấy danh sách BookingID của khách hàng
                var bookingIds = db.Bookings
                    .Where(b => b.CustomerID == customerId)
                    .Select(b => b.BookingID)
                    .ToList();

                if (!bookingIds.Any())
                    return 0m;

                // 🔹 Lấy danh sách hóa đơn đã thanh toán
                var paidInvoices = db.Invoices
                    .Where(i => bookingIds.Contains(i.BookingID) && i.PaidStatus == "Paid")
                    .ToList();

                if (!paidInvoices.Any())
                    return 0m;

                decimal total = paidInvoices.Sum(i => i.TotalAmount);

                // 🔹 Áp dụng giảm giá theo hạng thành viên
                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);
                if (customer != null)
                {
                    var rank = db.CustomerRanks.FirstOrDefault(r => r.RankID == customer.RankID);
                    if (rank != null && rank.DiscountPercent > 0)
                    {
                        total -= total * rank.DiscountPercent / 100;
                    }
                }

                return total;
            }
            catch
            {
                return 0m;
            }
        }

        // Hàm tự động nâng hạng khách hàng
        public string AutoUpgradeRank(string customerId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(customerId))
                    return null;

                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);
                if (customer == null)
                    return null;

                decimal totalSpent = GetTotalSpending(customerId); // dùng hàm mới đã sửa kiểu string

                // 🔹 Tìm rank phù hợp với tổng chi tiêu
                var newRank = db.CustomerRanks
                    .Where(r => totalSpent >= r.MinSpending)
                    .OrderByDescending(r => r.MinSpending)
                    .FirstOrDefault();

                if (newRank != null && newRank.RankID != customer.RankID)
                {
                    customer.RankID = newRank.RankID;
                    db.SubmitChanges();
                    return newRank.RankName; // Trả về tên hạng mới
                }

                return null; // Không thay đổi hạng
            }
            catch
            {
                return null;
            }
        }
        public List<CustomerET> GetAllCustomers()
        {
            var customers = (from c in db.Customers
                             join r in db.CustomerRanks on c.RankID equals r.RankID into rankJoin
                             from r in rankJoin.DefaultIfEmpty()
                             select new CustomerET
                             {
                                 CustomerID = c.CustomerID,
                                 FullName = c.FullName,
                                 PhoneNumber = c.PhoneNumber,
                                 NationalID = c.NationalID,
                                 Address = c.Address,
                                 Country = c.Country,
                                 Gender = c.Gender,
                                 DateOfBirth = c.DateOfBirth,
                                 RankID = c.RankID,
                                 RankName = r != null ? r.RankName : "Chưa có hạng"
                             }).ToList();

            // Gọi hàm tính tổng chi tiêu cho từng khách
            foreach (var customer in customers)
            {
                customer.TotalSpending = GetTotalSpendingForRank(customer.CustomerID);
            }

            return customers;
        }

        public bool InsertCustomer(CustomerET customer)
        {
            try
            {
                var entity = new Customer
                {
                    FullName = customer.FullName,
                    PhoneNumber = customer.PhoneNumber,
                    NationalID = customer.NationalID,
                    Address = customer.Address,
                    Country = customer.Country,
                    Gender = customer.Gender,
                    DateOfBirth = customer.DateOfBirth,
                    RankID = 1 // mặc định hạng cơ bản
                };
                db.Customers.InsertOnSubmit(entity);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(CustomerET customer)
        {
            try
            {
                var entity = db.Customers.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
                if (entity == null) return false;

                entity.FullName = customer.FullName;
                entity.PhoneNumber = customer.PhoneNumber;
                entity.NationalID = customer.NationalID;
                entity.Address = customer.Address;
                entity.Country = customer.Country;
                entity.Gender = customer.Gender;
                entity.DateOfBirth = customer.DateOfBirth;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

      
        public List<CustomerET> SearchCustomers(string fullName, string phoneNumber, string nationalId)
        {
            try
            {
                var query = from c in db.Customers
                            join r in db.CustomerRanks on c.RankID equals r.RankID into rankJoin
                            from r in rankJoin.DefaultIfEmpty()
                            select new { c, r };

                // 🔹 Thêm điều kiện tìm kiếm
                if (!string.IsNullOrWhiteSpace(fullName))
                    query = query.Where(x => x.c.FullName.Contains(fullName));

                if (!string.IsNullOrWhiteSpace(phoneNumber))
                    query = query.Where(x => x.c.PhoneNumber.Contains(phoneNumber));

                if (!string.IsNullOrWhiteSpace(nationalId))
                    query = query.Where(x => x.c.NationalID.Contains(nationalId));

                var customers = query.Select(x => new CustomerET
                {
                    CustomerID = x.c.CustomerID,
                    FullName = x.c.FullName,
                    PhoneNumber = x.c.PhoneNumber,
                    NationalID = x.c.NationalID,
                    Address = x.c.Address,
                    Country = x.c.Country,
                    Gender = x.c.Gender,
                    DateOfBirth = x.c.DateOfBirth,
                    RankID = x.c.RankID,
                    RankName = x.r != null ? x.r.RankName : "Chưa có hạng"
                }).ToList();

                // 🔹 Tính tổng chi tiêu cho từng khách
                foreach (var customer in customers)
                {
                    customer.TotalSpending = GetTotalSpendingForRank(customer.CustomerID);
                }

                return customers;
            }
            catch
            {
                return new List<CustomerET>();
            }
        }

        public bool IsPhoneExists(string phone)
        {
            return db.Customers.Any(c => c.PhoneNumber == phone);
        }

        public bool IsNationalIDExists(string nationalId)
        {
            return db.Customers.Any(c => c.NationalID == nationalId);
        }
        public CustomerET GetCustomerByPhoneOrId(string phone, string nationalId)
        {
            var c = db.Customers.FirstOrDefault(x =>
                (!string.IsNullOrEmpty(phone) && x.PhoneNumber == phone) ||
                (!string.IsNullOrEmpty(nationalId) && x.NationalID == nationalId));

            if (c == null) return null;

            return new CustomerET
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName,
                PhoneNumber = c.PhoneNumber,
                NationalID = c.NationalID,
                Address = c.Address,
                Country = c.Country,
                Gender = c.Gender,
                DateOfBirth = c.DateOfBirth,
                RankID = c.RankID,
                RankName = c.CustomerRank?.RankName ?? "Không xác định" 
            };
        }

        // ✅ Lấy rank mặc định
        public int GetDefaultRankId()
        {
            var defaultRank = db.CustomerRanks.OrderBy(r => r.RankID).FirstOrDefault();
            return defaultRank?.RankID ?? 1;
        }

        // ✅ Lấy tên rank theo ID
        public string GetRankNameById(int rankId)
        {
            return db.CustomerRanks.FirstOrDefault(r => r.RankID == rankId)?.RankName ?? "Không xác định";
        }
    }
}

