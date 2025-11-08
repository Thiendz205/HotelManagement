using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookingDAL
    {
        private HotelManagementDataContext db = new HotelManagementDataContext();

        // Lấy danh sách Booking
        public List<BookingET> GetAll()
        {
            var list = from b in db.Bookings
                       join c in db.Customers on b.CustomerID equals c.CustomerID
                       join r in db.Rooms on b.RoomID equals r.RoomID
                       join s in db.Staffs on b.StaffID equals s.StaffID into staffJoin
                       from s in staffJoin.DefaultIfEmpty()
                       select new BookingET
                       {
                           //BookingID = b.BookingID,
                           //CustomerID = b.CustomerID,
                           //CustomerName = c.FullName,
                           //RoomID = b.RoomID,
                           RoomName = r.RoomName,
                           RentalType = b.RentalType,
                           CheckIn = b.CheckIn,
                           CheckOut = b.CheckOut,
                           Price = b.Price,
                           Status = b.Status,
                           RoomStatus = r.Status, 
                           StaffID = b.StaffID,
                           StaffName = s != null ? s.FullName : "Không rõ"
                       };

            return list.ToList();
        }
        // Tìm kiếm theo tên khách hoặc tên phòng
        // trong BookingDAL
        public List<BookingET> Search(string customerName, string roomName)
        {
            customerName = (customerName ?? "").Trim();
            roomName = (roomName ?? "").Trim();

            var list = from b in db.Bookings
                       join c in db.Customers on b.CustomerID equals c.CustomerID
                       join r in db.Rooms on b.RoomID equals r.RoomID
                       join s in db.Staffs on b.StaffID equals s.StaffID into staffJoin
                       from s in staffJoin.DefaultIfEmpty()
                       select new { b, c, r, s };

            // Nếu có filter customer
            if (!string.IsNullOrWhiteSpace(customerName))
            {
                string lower = customerName.ToLower();
                list = list.Where(x => x.c.FullName.ToLower().Contains(lower));
            }

            // Nếu có filter room
            if (!string.IsNullOrWhiteSpace(roomName))
            {
                string lower = roomName.ToLower();
                list = list.Where(x => x.r.RoomName.ToLower().Contains(lower));
            }

            var result = list.Select(x => new BookingET
            {
                //BookingID = x.b.BookingID,
                //CustomerID = x.b.CustomerID,
                //CustomerName = x.c.FullName,
                //RoomID = x.b.RoomID,
                RoomName = x.r.RoomName,
                RentalType = x.b.RentalType,
                CheckIn = x.b.CheckIn,
                CheckOut = x.b.CheckOut,
                Price = x.b.Price,
                Status = x.b.Status,
                RoomStatus = x.r.Status,
                StaffID = x.b.StaffID,
                StaffName = x.s != null ? x.s.FullName : "Không rõ"
            }).ToList();

            return result;
        }


        public bool HasInvoice(int bookingId)
        {
            //return db.Invoices.Any(i => i.BookingID == bookingId);
            return false;// tạm thời bỏ kiểm tra
        }

        public UpdateResult UpdateBookingInfoOnly(BookingET booking)
        {
            //var existing = db.Bookings.SingleOrDefault(b => b.BookingID == booking.BookingID);
            //if (existing == null)
            //    return UpdateResult.NotFound;

            //// Chỉ cho phép cập nhật khi trạng thái booking là Check-in
            //if (existing.Status.Trim() != "CheckIn")
            //    return UpdateResult.InvalidStatus;

            //// Lưu lại phòng cũ để xử lý sau
            //int oldRoomId = existing.RoomID;

            //// Kiểm tra phòng mục tiêu
            //var targetRoom = db.Rooms.SingleOrDefault(r => r.RoomID == booking.RoomID);
            //if (targetRoom == null)
            //    return UpdateResult.RoomNotAvailable;

            //// Giới hạn loại phòng được cập nhật
            //if (targetRoom.Status.Trim() != "CheckIn" && targetRoom.Status != "Đặt trước" && targetRoom.Status != "Available")
            //    return UpdateResult.RoomNotAvailable;

            //DateTime sqlMinDate = new DateTime(1753, 1, 1);
            //DateTime sqlMaxDate = new DateTime(9999, 12, 31);

            //// Nếu phòng là "Đặt trước", kiểm tra trùng giờ cách ít nhất 1 tiếng
            //if (targetRoom.Status == "Đặt trước")
            //{
            //    bool isConflict = db.Bookings.Any(b =>
            //        b.RoomID == booking.RoomID &&
            //        b.BookingID != booking.BookingID &&
            //        b.Status == "Đặt trước" &&
            //        b.CheckIn < (booking.CheckOut ?? sqlMaxDate).AddHours(1) &&
            //        (b.CheckOut ?? sqlMinDate) > booking.CheckIn.AddHours(-1)
            //    );

            //    if (isConflict)
            //        return UpdateResult.RoomConflict;
            //}

            //// Cập nhật thông tin đặt phòng
            //existing.RoomID = booking.RoomID;
            //existing.RentalType = booking.RentalType;
            //existing.CheckIn = booking.CheckIn;
            //existing.CheckOut = booking.CheckOut;
            //existing.Price = booking.Price;

            // Cập nhật trạng thái phòng mới theo ComboBox (RoomStatus)
            if (!string.IsNullOrEmpty(booking.RoomStatus))
            {
                //targetRoom.Status = booking.RoomStatus.Trim();
            }

            // ✅ Nếu chuyển phòng → xử lý phòng cũ
            //if (oldRoomId != booking.RoomID)
            //{
            //    var oldRoom = db.Rooms.SingleOrDefault(r => r.RoomID == oldRoomId);
            //    if (oldRoom != null)
            //    {
            //        // Kiểm tra còn booking nào đặt/ở trong phòng cũ không
            //        bool hasActiveBooking = db.Bookings.Any(b =>
            //            b.RoomID == oldRoomId &&
            //            (b.Status == "CheckIn" || b.Status == "Đặt trước") &&
            //            b.BookingID != existing.BookingID
            //        );

            //        if (!hasActiveBooking)
            //        {
            //            // Nếu phòng vừa CheckIn trước đó → chuyển sang Đang dọn dẹp
            //            if (oldRoom.Status.Trim() == "CheckIn")
            //                oldRoom.Status = "Đang dọn dẹp";
            //            else
            //                oldRoom.Status = "Available"; // nếu không có booking nào → set trống
            //        }
            //    }
            //}

            db.SubmitChanges();
            return UpdateResult.Success;
        }
        public List<BookingET> GetAllCustomers()
        {
            return db.Customers
                     .OrderBy(c => c.FullName)
                     .Select(c => new BookingET
                     {
                         //CustomerID = c.CustomerID,
                         CustomerName = c.FullName
                     })
                     .ToList();
        }

        public List<BookingET> GetRoomsForBookingCombo()
        {
            return db.Rooms
                     .Where(r => r.Status == "Available" || r.Status == "Đặt trước")
                     .OrderBy(r => r.RoomName)
                     .Select(r => new BookingET
                     {
                        // RoomID = r.RoomID,
                         RoomName = r.RoomName
                     })
                     .ToList();
        }

        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            
            var conflictRoomIds = db.Bookings
                .Where(b =>
                    b.Status == "Đặt trước" &&
                    (
                        (b.CheckIn < checkOut.AddHours(1) && b.CheckOut > checkIn.AddHours(-1))
                    )
                )
                .Select(b => b.RoomID)
                .Distinct()
                .ToList();

        
            var availableRooms = db.Rooms
                .Where(r =>
                    r.Status == "Available" ||
                    (r.Status == "Đặt trước" && !conflictRoomIds.Contains(r.RoomID))
                )
                .ToList();

            return availableRooms;
        }
        public bool CancelBooking(int bookingId)
        {
           // var booking = db.Bookings.SingleOrDefault(b => b.BookingID == bookingId);
           // if (booking == null)
                return false;

           // var room = db.Rooms.SingleOrDefault(r => r.RoomID == booking.RoomID);
          //  if (room == null)
          //      return false;

          //  if (room.Status.Trim() != "Đặt trước")
          //      return false;

          ////  booking.Status = "Hủy lịch";
          //  room.Status = "Trống";

            db.SubmitChanges();
            return true;
        }


        public decimal GetRoomPrice(int roomId, string rentalType, DateTime checkIn)
        {
            try
            {
                //var room = db.Rooms.FirstOrDefault(r => r.RoomID == roomId);
                //if (room == null) return 0;

                //var roomTypeId = room.RoomTypeID;

                //// 🔹 Ưu tiên lấy giá trong bảng RoomTypePrice nếu có hiệu lực tại thời điểm checkIn
                //var priceRecord = db.RoomTypePrices
                //    .Where(p => p.RoomTypeID == roomTypeId
                //             && p.StartDate <= checkIn
                //             && p.EndDate >= checkIn)
                //    .OrderByDescending(p => p.StartDate)
                //    .FirstOrDefault();

                //decimal price = 0;

                //if (priceRecord != null)
                //{
                //    // ✅ Lấy giá theo loại thuê
                //    price = rentalType == "Day"
                //        ? priceRecord.PricePerDay
                //        : priceRecord.PricePerHour;
                //}
                //else
                //{
                //    // 🔹 Nếu không có giá đặc biệt, lấy giá mặc định từ RoomType
                //    var defaultPrice = db.RoomTypes.FirstOrDefault(t => t.RoomTypeID == roomTypeId);
                //    if (defaultPrice != null)
                //    {
                //        price = rentalType == "Day"
                //            ? defaultPrice.PricePerDay
                //            : defaultPrice.PricePerHour;
                //    }
                //}

                //return price;
                return 0;// tạm thời bỏ lấy giá
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetRoomPrice: " + ex.Message);
                return 0;
            }
        }
        public List<BookingET> GetRoomTypes()
        {
            return db.RoomTypes
                     .Select(rt => new BookingET
                     {
                         RoomID = 0,
                         RoomName = null,
                         RoomStatus = null,
                         RentalType = rt.TypeName,
                         Price = rt.PricePerDay,
                         //BookingID = rt.RoomTypeID 
                     })
                     .ToList();
        }

        public List<BookingET> GetRoomsByType(int roomTypeId)
        {
            return db.Rooms
                    // .Where(r => r.RoomTypeID == roomTypeId)
                     .Select(r => new BookingET
                     {
                        // RoomID = r.RoomID,
                         RoomName = r.RoomName,
                         RoomStatus = r.Status
                     })
                     .ToList();
        }

        public bool UpdateRoomStatus(BookingET dto)
        {
           // var room = db.Rooms.FirstOrDefault(r => r.RoomID == dto.RoomID);
            //if (room == null) return false;

            //room.Status = dto.RoomStatus;
            //db.SubmitChanges();
            return true;
        }

        public string GetRoomStatus(int roomId)
        {
            return db.Rooms
                  //   .Where(r => r.RoomID == roomId)
                     .Select(r => r.Status)
                     .FirstOrDefault();
        }

        public decimal CalculateTotalPrice(int roomId, string rentalType, DateTime checkIn, DateTime checkOut)
        {
            try
            {
               // var room = db.Rooms.FirstOrDefault(r => r.RoomID == roomId);
                //if (room == null) return 0;

                //var roomTypeId = room.RoomTypeID;
                //var defaultType = db.RoomTypes.FirstOrDefault(t => t.RoomTypeID == roomTypeId);
                //if (defaultType == null) return 0;

                decimal totalPrice = 0;

                if (rentalType == "Hour")
                {
                    double totalHours = (checkOut - checkIn).TotalHours;
                    if (totalHours <= 0) return 0;

                    int roundedHours = (int)Math.Ceiling(totalHours);

                    //var specialPrice = db.RoomTypePrices
                        //.Where(p => p.RoomTypeID == roomTypeId
                                 //&& p.StartDate <= checkIn
                                 //&& p.EndDate >= checkIn)
                       // .OrderByDescending(p => p.StartDate)
                       // .FirstOrDefault();

                   // decimal pricePerHour = specialPrice != null
                       // ? specialPrice.PricePerHour
                       // : defaultType.PricePerHour;

                    //totalPrice = pricePerHour * roundedHours;
                }
                else if (rentalType == "Day")
                {
                    for (var date = checkIn.Date; date < checkOut.Date; date = date.AddDays(1))
                    {
                        //var priceRecord = db.RoomTypePrices
                        //    .Where(p => p.RoomTypeID == roomTypeId
                        //             && p.StartDate <= date
                        //             && p.EndDate >= date)
                        //    .OrderByDescending(p => p.StartDate)
                        //    .FirstOrDefault();

                        //decimal dayPrice = priceRecord != null
                        //    ? priceRecord.PricePerDay
                        //    : defaultType.PricePerDay;

                        //totalPrice += dayPrice;
                    }
                }

                return totalPrice;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi CalculateTotalPrice: " + ex.Message);
                return 0;
            }
        }

    }
}

