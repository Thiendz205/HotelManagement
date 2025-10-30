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

        public decimal CalculateBookingTotal(int bookingId)
        {
            try
            {
                var booking = db.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
                if (booking == null) return 0;

                decimal roomPrice = 0;

                // Lấy loại phòng
                var roomTypeId = db.Rooms.FirstOrDefault(r => r.RoomID == booking.RoomID)?.RoomTypeID;
                if (roomTypeId == null) return 0;

                // Tìm giá động trong thời gian check-in
                var dynamicPrice = db.RoomTypePrices
                    .Where(p => p.RoomTypeID == roomTypeId &&
                                booking.CheckIn.Date >= p.StartDate &&
                                booking.CheckIn.Date <= p.EndDate)
                    .OrderByDescending(p => p.StartDate)
                    .FirstOrDefault();

                if (dynamicPrice != null)
                {
                    roomPrice = (booking.RentalType == "Day") ? dynamicPrice.PricePerDay : dynamicPrice.PricePerHour;
                }
                else
                {
                    var defaultRoomType = db.RoomTypes.FirstOrDefault(rt => rt.RoomTypeID == roomTypeId);
                    if (defaultRoomType != null)
                        roomPrice = (booking.RentalType == "Day") ? defaultRoomType.PricePerDay : defaultRoomType.PricePerHour;
                }

                // Tính thời gian thuê
                double totalHours = booking.CheckOut != null
                    ? (booking.CheckOut.Value - booking.CheckIn).TotalHours
                    : 24;

                decimal roomTotal = (booking.RentalType == "Day")
                    ? roomPrice * (decimal)Math.Ceiling(totalHours / 24)
                    : roomPrice * (decimal)Math.Ceiling(totalHours);

                // Dịch vụ
                decimal serviceTotal = (from su in db.ServiceUsages
                                        join s in db.Services on su.ServiceID equals s.ServiceID
                                        where su.BookingID == booking.BookingID
                                        select (decimal?)(s.Price * su.Quantity)).Sum() ?? 0m;

                // Phụ phí
                decimal feeTotal = (from bf in db.BookingFees
                                    join ft in db.FeeTypes on bf.FeeTypeID equals ft.FeeTypeID
                                    where bf.BookingID == booking.BookingID
                                    select (decimal?)(ft.DefaultPrice * bf.Quantity)).Sum() ?? 0m;

                // Tổng
                decimal bookingTotal = roomTotal + serviceTotal + feeTotal;
                return bookingTotal;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        //  Hàm lấy tổng chi tiêu khách hàng 
        // --- Tổng tiền gốc (để xét hạng) ---
        public decimal GetTotalSpendingForRank(int customerId)
        {
            try
            {
                // Lấy danh sách BookingID của khách hàng
                var bookingIds = db.Bookings
                    .Where(b => b.CustomerID == customerId)
                    .Select(b => b.BookingID)
                    .ToList();

                if (!bookingIds.Any())
                    return 0;

                // Tổng tiền gốc (chưa trừ giảm giá)
                decimal total = db.Invoices
                    .Where(i => bookingIds.Contains(i.BookingID) && i.PaidStatus == "Paid")
                    .Sum(i => (decimal?)i.TotalAmount) ?? 0m;

                return total; // Không trừ giảm giá ở đây
            }
            catch
            {
                return 0;
            }
        }
        public decimal GetTotalSpending(int customerId)
        {
            try
            {
                // Lấy danh sách BookingID của khách hàng
                var bookingIds = db.Bookings
                    .Where(b => b.CustomerID == customerId)
                    .Select(b => b.BookingID)
                    .ToList();

                if (!bookingIds.Any())
                    return 0;

                // Lấy danh sách Invoice đã thanh toán
                var paidInvoices = db.Invoices
                    .Where(i => bookingIds.Contains(i.BookingID) && i.PaidStatus == "Paid")
                    .ToList();

                decimal total = paidInvoices.Sum(i => i.TotalAmount);

                // Áp dụng giảm giá theo rank 
                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);
                if (customer != null)
                {
                    var rank = db.CustomerRanks.FirstOrDefault(r => r.RankID == customer.RankID);
                    if (rank != null && rank.DiscountPercent > 0)
                    {
                        total = total - (total * rank.DiscountPercent / 100);
                    }
                }

                return total;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        // Hàm tự động nâng hạng khách hàng
        public string AutoUpgradeRank(int customerId)
        {
            try
            {
                var customer = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);
                if (customer == null) return null;

                decimal totalSpent = GetTotalSpendingForRank(customerId);

                var newRank = db.CustomerRanks
                    .Where(r => totalSpent >= r.MinSpending)
                    .OrderByDescending(r => r.MinSpending)
                    .FirstOrDefault();

                if (newRank != null && newRank.RankID != customer.RankID)
                {
                    customer.RankID = newRank.RankID;
                    db.SubmitChanges();
                    return newRank.RankName;
                }

                return null;
            }
            catch (Exception ex)
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

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var entity = db.Customers.FirstOrDefault(c => c.CustomerID == customerId);
                if (entity == null) return false;

                db.Customers.DeleteOnSubmit(entity);
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

    }
}

