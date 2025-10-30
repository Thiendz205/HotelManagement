using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using System.Data;

namespace DAL
{
    public class UseServiceDAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable<UseServiceET> getAllServiceUsages()
        {
            try
            {
                var serviceUsages = from su in db.ServiceUsages
                                    join s in db.Services on su.ServiceID equals s.ServiceID
                                    join st in db.Staffs on su.StaffID equals st.StaffID
                                    join b in db.Bookings on su.BookingID equals b.BookingID
                                    join c in db.Customers on b.CustomerID equals c.CustomerID
                                    join r in db.Rooms on b.RoomID equals r.RoomID
                                    select new UseServiceET
                                    {
                                        UsageID = su.UsageID,
                                        BookingID = su.BookingID,
                                        ServiceID = su.ServiceID,
                                        Quantity = su.Quantity,
                                        StaffID = su.StaffID,
                                        UsageDate = su.UsageDate,
                                        ServiceName = s.ServiceName,
                                        StaffName = st.FullName,
                                        CustomerName = c.FullName,
                                        RoomName = r.RoomName,
                                        ServicePrice = s.Price,
                                        TotalAmount = s.Price * su.Quantity
                                    };
                return serviceUsages;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy dữ liệu ServiceUsage: " + ex.Message);
            }
        }

        public bool addServiceUsage(UseServiceET serviceUsage)
        {
            try
            {
                ServiceUsage newUsage = new ServiceUsage
                {
                    BookingID = serviceUsage.BookingID,
                    ServiceID = serviceUsage.ServiceID,
                    Quantity = serviceUsage.Quantity,
                    StaffID = serviceUsage.StaffID,
                    UsageDate = serviceUsage.UsageDate
                };
                db.ServiceUsages.InsertOnSubmit(newUsage);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool removeServiceUsage(int usageID)
        {
            try
            {
                var usageToDelete = db.ServiceUsages.SingleOrDefault(u => u.UsageID == usageID);
                if (usageToDelete == null) return false;

                db.ServiceUsages.DeleteOnSubmit(usageToDelete);
                db.SubmitChanges();
                return true;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547)
                {
                    throw new Exception("Không thể xóa vì bản ghi đang được tham chiếu ở bảng khác (ràng buộc khóa ngoại).");
                }
                else
                {
                    throw new Exception("Lỗi SQL: " + ex.Message);
                }
            }


        }
        public IQueryable<StaffET> getServiceStaffs()
        {
            try
            {
                var staffs = from s in db.Staffs
                             where (s.Role ?? "").ToLower().Contains("dịch vụ")
                                || (s.Role ?? "").ToLower().Contains("service")
                             select new StaffET
                             {
                                 StaffID = s.StaffID,
                                 FullName = s.FullName
                             };

                if (!staffs.Any())
                {
                    // fallback: trả toàn bộ staff để UI không bị trống
                    return from s in db.Staffs
                           select new StaffET { StaffID = s.StaffID, FullName = s.FullName };
                }

                return staffs;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên dịch vụ: " + ex.Message);
            }
        }


        public bool updateServiceUsage(UseServiceET serviceUsage)
        {
            try
            {
                var usageToUpdate = db.ServiceUsages.SingleOrDefault(u => u.UsageID == serviceUsage.UsageID);
                if (usageToUpdate != null)
                {
                    usageToUpdate.BookingID = serviceUsage.BookingID;
                    usageToUpdate.ServiceID = serviceUsage.ServiceID;
                    usageToUpdate.Quantity = serviceUsage.Quantity;
                    usageToUpdate.StaffID = serviceUsage.StaffID;
                    usageToUpdate.UsageDate = serviceUsage.UsageDate;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

     
        public IQueryable<ServiceET> getAllServices()
        {
            try
            {
                var services = from s in db.Services
                               select new ServiceET
                               {
                                   ServiceID = s.ServiceID,
                                   ServiceName = s.ServiceName,
                                   Category = s.Category,
                                   Price = s.Price,
                                   Description = s.Description
                               };
                return services;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách dịch vụ: " + ex.Message);
            }
        }

        public IQueryable<BookingET> getAllBookings()
        {
            try
            {
                var bookings = from b in db.Bookings
                               join c in db.Customers on b.CustomerID equals c.CustomerID
                               join r in db.Rooms on b.RoomID equals r.RoomID
                               join s in db.Staffs on b.StaffID equals s.StaffID
                               select new BookingET
                               {
                                   BookingID = b.BookingID,
                                   CustomerID = b.CustomerID,
                                   RoomID = b.RoomID,
                                   RentalType = b.RentalType,
                                   CheckIn = b.CheckIn,
                                   CheckOut = b.CheckOut,
                                   Price = b.Price,
                                   Status = b.Status,
                                   StaffID = b.StaffID,
                                   CustomerName = c.FullName,
                                   RoomName = r.RoomName,
                                   StaffName = s.FullName
                               };
                return bookings;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách booking: " + ex.Message);
            }
        }

        public IQueryable<StaffET> getAllStaffs()
        {
            try
            {
                var staffs = from s in db.Staffs
                             select new StaffET
                             {
                                 StaffID = s.StaffID,
                                 FullName = s.FullName
                             };
                return staffs;
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lấy danh sách nhân viên: " + ex.Message);
            }
        }

    }
}
