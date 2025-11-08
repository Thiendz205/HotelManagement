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
                           BookingID = b.BookingID,
                           CustomerID = b.CustomerID,
                           CustomerName = c.FullName,
                           RoomID = b.RoomID,
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
                BookingID = x.b.BookingID,
                CustomerID = x.b.CustomerID,
                CustomerName = x.c.FullName,
                RoomID = x.b.RoomID,
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


        public bool HasInvoice(string bookingId)
        {
            return db.Invoices.Any(i => i.BookingID == bookingId);
        }

            public UpdateResult UpdateBookingInfoOnly(BookingET booking)
            {
                var existing = db.Bookings.SingleOrDefault(b => b.BookingID == booking.BookingID);
                if (existing == null)
                    return UpdateResult.NotFound;

                // Chỉ cho phép cập nhật khi trạng thái booking là Check-in
                if (existing.Status.Trim() != "CheckIn" && existing.Status.Trim() != "Đặt trước")
                    return UpdateResult.InvalidStatus;

                // Lưu lại phòng cũ để xử lý sau
                string oldRoomId = existing.RoomID;

                // Kiểm tra phòng mục tiêu
                var targetRoom = db.Rooms.SingleOrDefault(r => r.RoomID == booking.RoomID);
                if (targetRoom == null)
                    return UpdateResult.RoomNotAvailable;

                // Giới hạn loại phòng được cập nhật
                if (targetRoom.Status.Trim() != "CheckIn" && targetRoom.Status != "Đặt trước" && targetRoom.Status != "Available")
                    return UpdateResult.RoomNotAvailable;

                DateTime sqlMinDate = new DateTime(1753, 1, 1);
                DateTime sqlMaxDate = new DateTime(9999, 12, 31);

                // Nếu phòng là "Đặt trước", kiểm tra trùng giờ cách ít nhất 1 tiếng
                if (targetRoom.Status == "Đặt trước")
                {
                    bool isConflict = db.Bookings.Any(b =>
                        b.RoomID == booking.RoomID &&
                        b.BookingID != booking.BookingID &&
                        b.Status == "Đặt trước" &&
                        b.CheckIn < (booking.CheckOut ?? sqlMaxDate).AddHours(1) &&
                        (b.CheckOut ?? sqlMinDate) > booking.CheckIn.AddHours(-1)
                    );

                    if (isConflict)
                        return UpdateResult.RoomConflict;
                }

                // Cập nhật thông tin đặt phòng
                existing.RoomID = booking.RoomID;
                existing.RentalType = booking.RentalType;
                existing.CheckIn = booking.CheckIn;
                existing.CheckOut = booking.CheckOut;
                existing.Price = booking.Price;

                // Cập nhật trạng thái phòng mới theo ComboBox (RoomStatus)
                if (!string.IsNullOrEmpty(booking.RoomStatus))
                {
                    targetRoom.Status = booking.RoomStatus.Trim();
                }

                // ✅ Nếu chuyển phòng → xử lý phòng cũ
                if (oldRoomId != booking.RoomID)
                {
                    var oldRoom = db.Rooms.SingleOrDefault(r => r.RoomID == oldRoomId);
                    if (oldRoom != null)
                    {
                        // Kiểm tra còn booking nào đặt/ở trong phòng cũ không
                        bool hasActiveBooking = db.Bookings.Any(b =>
                            b.RoomID == oldRoomId &&
                            (b.Status == "CheckIn" || b.Status == "Đặt trước") &&
                            b.BookingID != existing.BookingID
                        );

                        if (!hasActiveBooking)
                        {
                            // Nếu phòng vừa CheckIn trước đó → chuyển sang Đang dọn dẹp
                            if (oldRoom.Status.Trim() == "CheckIn")
                                oldRoom.Status = "Đang dọn dẹp";
                            else
                                oldRoom.Status = "Available"; // nếu không có booking nào → set trống
                        }
                    }
                }

                db.SubmitChanges();
                return UpdateResult.Success;
            }
        public UpdateResult UpdateBookingInfoByStaff(BookingET booking, string staffId)
        {
            // Gọi lại hàm sửa gốc
            var result = UpdateBookingInfoOnly(booking);

            // Nếu sửa thất bại → trả kết quả luôn
            if (result != UpdateResult.Success)
                return result;

            // Lấy thông tin booking vừa sửa
            var existing = db.Bookings.SingleOrDefault(b => b.BookingID == booking.BookingID);
            if (existing == null)
                return UpdateResult.NotFound;

            // ✅ Gán nhân viên thực hiện chỉnh sửa
            existing.StaffID = staffId;

            db.SubmitChanges();
            return UpdateResult.Success;
        }

        public List<BookingET> GetAllCustomers()
        {
            return db.Customers
                     .OrderBy(c => c.FullName)
                     .Select(c => new BookingET
                     {
                         CustomerID = c.CustomerID,
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
                         RoomID = r.RoomID,
                         RoomName = r.RoomName
                     })
                     .ToList();
        }

        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            // 🔹 Lấy danh sách RoomID bị trùng lịch
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
                    (r.Status == "Available" || r.Status == "Trống") // thêm điều kiện phòng trống
                    && !conflictRoomIds.Contains(r.RoomID)            // không bị trùng lịch
                )
                .ToList();

            return availableRooms;
        }
        public bool CancelBooking(string bookingId)
        {
            var booking = db.Bookings.SingleOrDefault(b => b.BookingID == bookingId);
            if (booking == null)
                return false;

            var room = db.Rooms.SingleOrDefault(r => r.RoomID == booking.RoomID);
            if (room == null)
                return false;

            if (room.Status.Trim() != "Đặt trước")
                return false;

            booking.Status = "Hủy lịch";
            room.Status = "Trống"; 

            db.SubmitChanges();
            return true;
        }

        public decimal GetRoomPrice(string roomId, string rentalType, DateTime checkIn)
        {
            try
            {
                var room = db.Rooms.FirstOrDefault(r => r.RoomID == roomId);
                if (room == null) return 0;

                string roomTypeId = room.RoomTypeID; // ✅ giả sử RoomTypeID cũng là string

                // 🔹 Ưu tiên lấy giá trong bảng RoomTypePrice nếu có hiệu lực tại thời điểm checkIn
                var priceRecord = db.RoomTypePrices
                    .Where(p => p.RoomTypeID == roomTypeId
                             && p.StartDate <= checkIn
                             && p.EndDate >= checkIn)
                    .OrderByDescending(p => p.StartDate)
                    .FirstOrDefault();

                decimal price = 0;

                if (priceRecord != null)
                {
                    // ✅ Lấy giá theo loại thuê
                    price = rentalType == "Day"
                        ? priceRecord.PricePerDay
                        : priceRecord.PricePerHour;
                }
                else
                {
                    // 🔹 Nếu không có giá đặc biệt, lấy giá mặc định từ RoomType
                    var defaultPrice = db.RoomTypes.FirstOrDefault(t => t.RoomTypeID == roomTypeId);
                    if (defaultPrice != null)
                    {
                        price = rentalType == "Day"
                            ? defaultPrice.PricePerDay
                            : defaultPrice.PricePerHour;
                    }
                }

                return price;
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
                         RoomID = null,           
                         RoomName = null,
                         RoomStatus = null,
                         RentalType = rt.TypeName,    // lấy tên loại phòng
                         Price = rt.PricePerDay,      // giá mặc định theo ngày
                         BookingID = rt.RoomTypeID    // giả sử RoomTypeID là string
                     })
                     .ToList();
        }

        public List<BookingET> GetRoomsByType(string roomTypeId)
        {
            return db.Rooms
                     .Where(r => r.RoomTypeID.ToString() == roomTypeId)
                     .Select(r => new BookingET
                     {
                         RoomID = r.RoomID.ToString(),  
                         RoomName = r.RoomName,
                         RoomStatus = r.Status
                     })
                     .ToList();
        }

        public bool UpdateRoomStatus(BookingET dto)
        {
            var room = db.Rooms.FirstOrDefault(r => r.RoomID == dto.RoomID);
            if (room == null) return false;

            room.Status = dto.RoomStatus;
            db.SubmitChanges();
            return true;
        }

        public string GetRoomStatus(string roomId)
        {
            return db.Rooms
                     .Where(r => r.RoomID.ToString() == roomId)
                     .Select(r => r.Status)
                     .FirstOrDefault();
        }

        public decimal CalculateTotalPrice(string roomId, string rentalType, DateTime checkIn, DateTime checkOut)
        {
            try
            {
                var room = db.Rooms.FirstOrDefault(r => r.RoomID.ToString() == roomId);
                if (room == null) return 0;

                var roomTypeId = room.RoomTypeID;
                var defaultType = db.RoomTypes.FirstOrDefault(t => t.RoomTypeID == roomTypeId);
                if (defaultType == null) return 0;

                decimal totalPrice = 0;

                if (rentalType == "Hour")
                {
                    double totalHours = (checkOut - checkIn).TotalHours;
                    if (totalHours <= 0) return 0;

                    int roundedHours = (int)Math.Ceiling(totalHours);

                    var specialPrice = db.RoomTypePrices
                        .Where(p => p.RoomTypeID == roomTypeId
                                 && p.StartDate <= checkIn
                                 && p.EndDate >= checkIn)
                        .OrderByDescending(p => p.StartDate)
                        .FirstOrDefault();

                    decimal pricePerHour = specialPrice != null
                        ? specialPrice.PricePerHour
                        : defaultType.PricePerHour;

                    totalPrice = pricePerHour * roundedHours;
                }
                else if (rentalType == "Day")
                {
                    for (var date = checkIn.Date; date < checkOut.Date; date = date.AddDays(1))
                    {
                        var priceRecord = db.RoomTypePrices
                            .Where(p => p.RoomTypeID == roomTypeId
                                     && p.StartDate <= date
                                     && p.EndDate >= date)
                            .OrderByDescending(p => p.StartDate)
                            .FirstOrDefault();

                        decimal dayPrice = priceRecord != null
                            ? priceRecord.PricePerDay
                            : defaultType.PricePerDay;

                        totalPrice += dayPrice;
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
        public List<BookingET> GetRoomsForBookingList()
        {
            return db.Rooms
                     .Where(r => r.Status == "Available" || r.Status == "Đặt trước" || r.Status == "Trống")
                     .Join(db.RoomTypes,
                           r => r.RoomTypeID,
                           rt => rt.RoomTypeID,
                           (r, rt) => new BookingET
                           {
                               RoomID = r.RoomID,
                               RoomName = r.RoomName,
                               RoomStatus = r.Status,
                               RoomTypeName = rt.TypeName
                           })
                     .OrderBy(r => r.RoomName)
                     .ToList();
        }
        public List<BookingET> SearchRooms(string roomName, string roomTypeName)
        {
            try
            {
                db.CommandTimeout = 120;

                // Chuẩn hóa input
                roomName = (roomName ?? "").Trim();
                roomTypeName = (roomTypeName ?? "").Trim();

                // Lấy danh sách cơ bản (chỉ phòng còn hoạt động)
                var query = from r in db.Rooms
                            join rt in db.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                            where r.Status == "Available" || r.Status == "Đặt trước" || r.Status == "Trống"
                            select new
                            {
                                r.RoomID,
                                r.RoomName,
                                r.Status,
                                RoomTypeName = rt.TypeName
                            };

                // 🔹 Nếu chọn loại phòng (không phải "Tất cả")
                if (!string.IsNullOrEmpty(roomTypeName) && !roomTypeName.Equals("Tất cả", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(x => x.RoomTypeName.Contains(roomTypeName));
                }

                // 🔹 Nếu nhập tên phòng → tìm gần đúng (case-insensitive)
                if (!string.IsNullOrEmpty(roomName))
                {
                    string lowerName = roomName.ToLower();
                    query = query.Where(x => x.RoomName.ToLower().Contains(lowerName));
                }

                // ✅ Thực thi truy vấn (an toàn, không timeout)
                var result = query
                    .OrderBy(x => x.RoomName)
                    .Select(x => new BookingET
                    {
                        RoomID = x.RoomID,
                        RoomName = x.RoomName,
                        RoomStatus = x.Status,
                        RoomTypeName = x.RoomTypeName
                    })
                    .ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi SearchRooms: " + ex.Message);
                return new List<BookingET>(); // tránh crash form
            }
        }

        public List<BookingET> GetPreBookedRooms()
        {
            try
            {
                db.CommandTimeout = 120;

                var result = db.Rooms
                               .Where(r => r.Status == "Đặt trước")
                               .Join(db.RoomTypes,
                                     r => r.RoomTypeID,
                                     rt => rt.RoomTypeID,
                                     (r, rt) => new BookingET
                                     {
                                         RoomID = r.RoomID,
                                         RoomName = r.RoomName,
                                         RoomStatus = r.Status,
                                         RoomTypeName = rt.TypeName
                                     })
                               .OrderBy(r => r.RoomName)
                               .ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetPreBookedRooms: " + ex.Message);
                return new List<BookingET>();
            }
        }
        public List<BookingET> SearchPreBookedRooms(string roomName, string roomTypeName)
        {
            try
            {
                db.CommandTimeout = 120;

                roomName = (roomName ?? "").Trim();
                roomTypeName = (roomTypeName ?? "").Trim();

                var query = from r in db.Rooms
                            join rt in db.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                            where r.Status == "Đặt trước"
                            select new
                            {
                                r.RoomID,
                                r.RoomName,
                                r.Status,
                                RoomTypeName = rt.TypeName
                            };

                // 🔹 Lọc theo loại phòng (nếu không chọn "Tất cả")
                if (!string.IsNullOrEmpty(roomTypeName) && !roomTypeName.Equals("Tất cả", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(x => x.RoomTypeName.Contains(roomTypeName));
                }

                // 🔹 Lọc theo tên phòng (tìm gần đúng, không phân biệt hoa thường)
                if (!string.IsNullOrEmpty(roomName))
                {
                    string lowerName = roomName.ToLower();
                    query = query.Where(x => x.RoomName.ToLower().Contains(lowerName));
                }

                // ✅ Kết quả cuối cùng
                var result = query
                    .OrderBy(x => x.RoomName)
                    .Select(x => new BookingET
                    {
                        RoomID = x.RoomID,
                        RoomName = x.RoomName,
                        RoomStatus = x.Status,
                        RoomTypeName = x.RoomTypeName
                    })
                    .ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi SearchPreBookedRooms: " + ex.Message);
                return new List<BookingET>();
            }
        }

        public List<string> GetAllRoomTypes()
        {
            return db.RoomTypes
                     .OrderBy(rt => rt.TypeName)
                     .Select(rt => rt.TypeName)
                     .ToList();
        }
        // 🟩 Thêm Booking + Customer
        public AddBookingResult AddBookingWithCustomer(BookingET booking, CustomerET customer)
        {
            try
            {
                if (booking.CheckOut <= booking.CheckIn)
                    return AddBookingResult.Error;

                var existingCustomer = FindExistingCustomer(customer);

                if (IsRoomConflict(booking))
                    return AddBookingResult.RoomConflict;

                booking.Price = GetEffectiveRoomPrice(booking.RoomID, booking.RentalType, booking.CheckIn);

                if (existingCustomer != null)
                {
                    if (IsCustomerInfoDifferent(existingCustomer, customer))
                        return AddBookingResult.DuplicateCustomerConflict;

                    return InsertBookingOnly(existingCustomer, booking);
                }
                else
                {
                    return InsertCustomerAndBooking(customer, booking);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi AddBookingWithCustomer: " + ex.Message);
                return AddBookingResult.Error;
            }
        }

        private decimal GetEffectiveRoomPrice(string roomId, string rentalType, DateTime checkIn)
        {
            var room = db.Rooms.FirstOrDefault(r => r.RoomID == roomId);
            if (room == null) return 0;

            var roomType = db.RoomTypes.FirstOrDefault(rt => rt.RoomTypeID == room.RoomTypeID);
            if (roomType == null) return 0;

            // 🔹 Tìm giá động (nếu có)
            var dynamicPrice = db.RoomTypePrices
                .Where(p => p.RoomTypeID == roomType.RoomTypeID &&
                            checkIn.Date >= p.StartDate &&
                            checkIn.Date <= p.EndDate)
                .OrderByDescending(p => p.StartDate)
                .FirstOrDefault();

            if (dynamicPrice != null)
            {
                return rentalType == "Day" ? dynamicPrice.PricePerDay : dynamicPrice.PricePerHour;
            }

            // 🔹 Ngược lại lấy giá mặc định
            return rentalType == "Day" ? roomType.PricePerDay : roomType.PricePerHour;
        }

        private bool IsRoomConflict(BookingET booking)
        {
            DateTime sqlMin = new DateTime(1753, 1, 1);
            DateTime sqlMax = new DateTime(9999, 12, 31);

            return db.Bookings.Any(b =>
                b.RoomID == booking.RoomID &&
                (b.Status == "Đặt trước" || b.Status == "CheckIn") &&
                b.CheckIn < (booking.CheckOut ?? sqlMax).AddHours(1) &&
                (b.CheckOut ?? sqlMin) > booking.CheckIn.AddHours(-1)
            );
        }

        // 🟩 Tìm khách hàng đã có
        private Customer FindExistingCustomer(CustomerET customer)
        {
            string phone = (customer.PhoneNumber ?? "").Trim();
            string idCard = (customer.NationalID ?? "").Trim();

            if (string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(idCard))
                return null;

            return db.Customers.FirstOrDefault(c =>
                (!string.IsNullOrEmpty(phone) && c.PhoneNumber == phone) ||
                (!string.IsNullOrEmpty(idCard) && c.NationalID == idCard)
            );
        }


        // 🟩 So sánh khác biệt thông tin khách
        private bool IsCustomerInfoDifferent(Customer existing, CustomerET input)
        {
            // Danh sách log khác biệt
            var diffs = new List<string>();

            // Chuẩn hóa dữ liệu so sánh
            string Normalize(string s)
            {
                if (string.IsNullOrWhiteSpace(s)) return "";
                s = s.Trim().ToLower();

                // Chuẩn hóa giới tính
                if (s == "male") s = "nam";
                if (s == "female" || s == "nu") s = "nữ";

                // Chuẩn hóa quốc gia
                if (s == "vietnam" || s == "viet nam") s = "việt nam";

                return s;
            }

            string existingName = Normalize(existing.FullName);
            string inputName = Normalize(input.FullName);
            if (existingName != inputName)
                diffs.Add($"Tên khác: '{existing.FullName}' ≠ '{input.FullName}'");

            string existingAddress = Normalize(existing.Address);
            string inputAddress = Normalize(input.Address);
            if (existingAddress != inputAddress)
                diffs.Add($"Địa chỉ khác: '{existing.Address}' ≠ '{input.Address}'");

            string existingGender = Normalize(existing.Gender);
            string inputGender = Normalize(input.Gender);
            if (existingGender != inputGender)
                diffs.Add($"Giới tính khác: '{existing.Gender}' ≠ '{input.Gender}'");

            string existingCountry = Normalize(existing.Country);
            string inputCountry = Normalize(input.Country);
            if (existingCountry != inputCountry)
                diffs.Add($"Quốc gia khác: '{existing.Country}' ≠ '{input.Country}'");

            DateTime? existingDob = existing.DateOfBirth?.Date;
            DateTime? inputDob = input.DateOfBirth?.Date;
            if (existingDob != inputDob)
                diffs.Add($"Ngày sinh khác: '{existing.DateOfBirth:dd/MM/yyyy}' ≠ '{input.DateOfBirth:dd/MM/yyyy}'");

            // 🟨 In ra log để bạn dễ theo dõi trong Output console
            if (diffs.Any())
            {
                Console.WriteLine("⚠️ Phát hiện khác dữ liệu khách hàng:");
                foreach (var d in diffs)
                    Console.WriteLine("  - " + d);

                return true;
            }

            return false;
        }

        // 🟩 Thêm Booking cho khách hàng đã tồn tại
        private AddBookingResult InsertBookingOnly(Customer existingCustomer, BookingET booking)
        {
            try
            {
                var room = db.Rooms.SingleOrDefault(r => r.RoomID == booking.RoomID);
                if (room == null) return AddBookingResult.Error;

                // ✅ Mặc định đặt là "CheckIn"
                string bookingStatus = "CheckIn";

                var newBooking = new Booking
                {
                    BookingID = GenerateBookingID(),
                    CustomerID = existingCustomer.CustomerID,
                    RoomID = booking.RoomID,
                    StaffID = booking.StaffID,
                    RentalType = booking.RentalType,
                    CheckIn = booking.CheckIn,
                    CheckOut = booking.CheckOut,
                    Price = booking.Price,
                    Status = bookingStatus
                };

                db.Bookings.InsertOnSubmit(newBooking);

                // ✅ Phòng chuyển sang "Đang hoạt động"
                room.Status = "Đang hoạt động";

                db.SubmitChanges();
                return AddBookingResult.Success;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi InsertBookingOnly: " + ex.Message);
                return AddBookingResult.Error;
            }
        }

        private AddBookingResult InsertCustomerAndBooking(CustomerET customer, BookingET booking)
        {
            try
            {
                var room = db.Rooms.SingleOrDefault(r => r.RoomID == booking.RoomID);
                if (room == null) return AddBookingResult.Error;

                // ✅ Lấy rank đầu tiên làm mặc định
                int defaultRankId = db.CustomerRanks.OrderBy(r => r.RankID).Select(r => r.RankID).FirstOrDefault();

                var newCustomer = new Customer
                {
                    CustomerID = GenerateCustomerID(),
                    FullName = customer.FullName,
                    PhoneNumber = customer.PhoneNumber,
                    NationalID = customer.NationalID,
                    Address = customer.Address,
                    Country = customer.Country,
                    Gender = customer.Gender,
                    DateOfBirth = customer.DateOfBirth,
                    RankID = defaultRankId
                };

                db.Customers.InsertOnSubmit(newCustomer);
                db.SubmitChanges();

                // ✅ Tính khoảng cách thời gian (tính theo giờ)
                TimeSpan diff = booking.CheckIn - DateTime.Now;
                string bookingStatus = diff.TotalHours >= 4 ? "Đặt trước" : "CheckIn";

                var newBooking = new Booking
                {
                    BookingID = GenerateBookingID(),
                    CustomerID = newCustomer.CustomerID,
                    RoomID = booking.RoomID,
                    StaffID = booking.StaffID,
                    RentalType = booking.RentalType,
                    CheckIn = booking.CheckIn,
                    CheckOut = booking.CheckOut,
                    Price = booking.Price,
                    Status = bookingStatus
                };

                db.Bookings.InsertOnSubmit(newBooking);

                // ✅ Cập nhật phòng theo trạng thái booking
                room.Status = (bookingStatus == "CheckIn") ? "Đang hoạt động" : "Đặt trước";

                db.SubmitChanges();

                return AddBookingResult.CustomerAddedBookingAdded;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi InsertCustomerAndBooking: " + ex.Message);
                return AddBookingResult.Error;
            }
        }

        private string GenerateCustomerID() => "CUST" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        private string GenerateBookingID() => "BK" + Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper();
        public BookingET GetRoomInfoById(string roomId)
        {
            var query = from r in db.Rooms
                        join rt in db.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                        where r.RoomID == roomId
                        select new BookingET
                        {
                            RoomID = r.RoomID,
                            RoomName = r.RoomName,
                            RoomStatus = r.Status,
                            RoomTypeName = rt.TypeName,
                            Category = rt.Category,
                            Capacity = r.Capacity,
                            Description = r.Description,
                            PricePerDay = rt.PricePerDay,
                            PricePerHour = rt.PricePerHour
                        };

            return query.FirstOrDefault();
        }
        public CustomerET GetCustomerByPhoneOrId(string phone, string nationalId)
        {
            try
            {
                using (var db = new HotelManagementDataContext())
                {
                    var customer = db.Customers.FirstOrDefault(c =>
                        (!string.IsNullOrEmpty(phone) && c.PhoneNumber == phone) ||
                        (!string.IsNullOrEmpty(nationalId) && c.NationalID == nationalId));

                    if (customer == null) return null;

                    return new CustomerET
                    {
                        CustomerID = customer.CustomerID,
                        FullName = customer.FullName,
                        PhoneNumber = customer.PhoneNumber,
                        NationalID = customer.NationalID,
                        Address = customer.Address,
                        Gender = customer.Gender
                    };
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetCustomerByPhoneOrId: " + ex.Message);
                return null;
            }
        }
        public List<BookingHistoryET> GetCustomerFullHistory(string customerId)
        {
            try
            {
                // 🔹 Lấy danh sách booking có hóa đơn đã thanh toán
                var paidBookings = (from b in db.Bookings
                                    join i in db.Invoices on b.BookingID equals i.BookingID
                                    where b.CustomerID == customerId && i.PaidStatus == "Paid"
                                    select b).ToList(); // ép ToList() để chuyển sang xử lý trong C#

                var result = new List<BookingHistoryET>();

                foreach (var b in paidBookings)
                {
                    var room = db.Rooms.FirstOrDefault(r => r.RoomID == b.RoomID);
                    var roomType = (room != null)
                        ? db.RoomTypes.FirstOrDefault(rt => rt.RoomTypeID == room.RoomTypeID)
                        : null;
                    decimal roomPrice = 0;
                    if (roomType != null)
                    {
                        var dynamicPrice = db.RoomTypePrices
                            .Where(p => p.RoomTypeID == roomType.RoomTypeID &&
                                        b.CheckIn.Date >= p.StartDate &&
                                        b.CheckIn.Date <= p.EndDate)
                            .OrderByDescending(p => p.StartDate)
                            .FirstOrDefault();

                        if (dynamicPrice != null)
                            roomPrice = (b.RentalType == "Day") ? dynamicPrice.PricePerDay : dynamicPrice.PricePerHour;
                        else
                            roomPrice = (b.RentalType == "Day") ? roomType.PricePerDay : roomType.PricePerHour;
                    }

                    // 🔹 Tính số giờ / ngày thuê
                    double totalHours = b.CheckOut != null
                        ? (b.CheckOut.Value - b.CheckIn).TotalHours
                        : 24;

                    int quantity = (b.RentalType == "Day")
                        ? (int)Math.Ceiling(totalHours / 24)
                        : (int)Math.Ceiling(totalHours);

                    result.Add(new BookingHistoryET
                    {
                        BookingID = b.BookingID,
                        RoomName = room?.RoomName ?? "",
                        RoomTypeName = roomType?.TypeName ?? "",
                        Type = "Tiền phòng",
                        ItemName = b.RentalType == "Day" ? "Thuê theo ngày" : "Thuê theo giờ",
                        Price = roomPrice,
                        Quantity = quantity,
                        UsedAt = b.CheckIn
                    });

                    // ========== 🔸 DỊCH VỤ ==========
                    var serviceUsages = (from su in db.ServiceUsages
                                         join s in db.Services on su.ServiceID equals s.ServiceID
                                         where su.BookingID == b.BookingID
                                         select new
                                         {
                                             s.ServiceName,
                                             s.Price,
                                             su.Quantity
                                         }).ToList();

                    foreach (var su in serviceUsages)
                    {
                        result.Add(new BookingHistoryET
                        {
                            BookingID = b.BookingID,
                            RoomName = room?.RoomName ?? "",
                            RoomTypeName = roomType?.TypeName ?? "",
                            Type = "Dịch vụ",
                            ItemName = su.ServiceName,
                            Price = su.Price,
                            Quantity = su.Quantity,
                            UsedAt = b.CheckIn
                        });
                    }
                    var fees = (from bf in db.BookingFees
                                join ft in db.FeeTypes on bf.FeeTypeID equals ft.FeeTypeID
                                where bf.BookingID == b.BookingID
                                select new
                                {
                                    ft.FeeTypeName,
                                    ft.DefaultPrice,
                                    ft.Category,
                                    bf.Quantity,
                                    bf.CreatedAt
                                }).ToList();

                    foreach (var f in fees)
                    {
                        result.Add(new BookingHistoryET
                        {
                            BookingID = b.BookingID,
                            RoomName = room?.RoomName ?? "",
                            RoomTypeName = roomType?.TypeName ?? "",
                            Type = f.Category ?? "Phụ phí",
                            ItemName = f.FeeTypeName,
                            Price = f.DefaultPrice,
                            Quantity = f.Quantity,
                            UsedAt = f.CreatedAt
                        });
                    }
                    decimal totalBooking =
                        (roomPrice * quantity) +
                        serviceUsages.Sum(x => x.Price * x.Quantity) +
                        fees.Sum(x => x.DefaultPrice * x.Quantity);

                    result.Add(new BookingHistoryET
                    {
                        BookingID = b.BookingID,
                        RoomName = "",
                        RoomTypeName = "",
                        Type = "Tổng cộng",
                        ItemName = "",
                        Price = totalBooking,
                        Quantity = 1,
                        UsedAt = b.CheckOut ?? DateTime.Now
                    });
                }
                return result.OrderByDescending(x => x.UsedAt).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Lỗi GetCustomerFullHistory: " + ex.Message);
                return new List<BookingHistoryET>();
            }
        }
        public string GetBookingIdByRoom(string roomId)
        {
            try
            {
                var booking = db.Bookings
                    .Where(b => b.RoomID == roomId && b.Status == "Đặt trước")
                    .OrderByDescending(b => b.CheckIn)
                    .FirstOrDefault();

                return booking?.BookingID;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetBookingIdByRoom: " + ex.Message);
                return null;
            }
        }

        public bool CheckInBooking(string bookingId, string staffId)
        {
            try
            {
                var booking = db.Bookings.SingleOrDefault(b => b.BookingID == bookingId);
                if (booking == null)
                    return false;

                var room = db.Rooms.SingleOrDefault(r => r.RoomID == booking.RoomID);
                if (room == null)
                    return false;

                if (booking.Status.Trim() != "Đặt trước")
                    return false;

                booking.Status = "CheckIn";
                booking.CheckIn = DateTime.Now;
                booking.StaffID = staffId;  // ✅ Ghi nhận nhân viên thực hiện CheckIn
                room.Status = "Đang hoạt động";

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi CheckInBooking: " + ex.Message);
                return false;
            }
        }

        public List<BookingET> GetPendingBookingsByRoomId(string roomId)
        {
            try
            {
                var query = from b in db.Bookings
                            join c in db.Customers on b.CustomerID equals c.CustomerID
                            where b.RoomID == roomId && b.Status == "Đặt trước"
                            orderby b.CheckIn ascending
                            select new BookingET
                            {
                                BookingID = b.BookingID,
                                CustomerName = c.FullName,
                                PhoneNumber = c.PhoneNumber,
                                CheckIn = b.CheckIn,
                                CheckOut = b.CheckOut,
                                RentalType = b.RentalType,
                                Price = b.Price,
                                Status = b.Status
                            };

                return query.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetPendingBookingsByRoomId: " + ex.Message);
                return new List<BookingET>();
            }
        }
        public bool CancelBookingByStaff(string bookingId, string staffId)
        {
            try
            {
                var booking = db.Bookings.SingleOrDefault(b => b.BookingID == bookingId);
                if (booking == null)
                    return false;

                var room = db.Rooms.SingleOrDefault(r => r.RoomID == booking.RoomID);
                if (room == null)
                    return false;

                if (booking.Status.Trim() != "Đặt trước")
                    return false;

                booking.Status = "Hủy lịch";
                room.Status = "Trống";

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi CancelBookingByStaff: " + ex.Message);
                return false;
            }
        }
        public List<BookingET> GetActiveRooms()
        {
            try
            {
                db.CommandTimeout = 120;

                var result = db.Rooms
                               .Where(r => r.Status == "Đang hoạt động")
                               .Join(db.RoomTypes,
                                     r => r.RoomTypeID,
                                     rt => rt.RoomTypeID,
                                     (r, rt) => new BookingET
                                     {
                                         RoomID = r.RoomID,
                                         RoomName = r.RoomName,
                                         RoomStatus = r.Status,
                                         RoomTypeName = rt.TypeName
                                     })
                               .OrderBy(r => r.RoomName)
                               .ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi GetActiveRooms: " + ex.Message);
                return new List<BookingET>();
            }
        }
        public List<BookingET> FindActiveRooms(string roomName, string roomTypeName)
        {
            try
            {
                db.CommandTimeout = 120;

                roomName = (roomName ?? "").Trim();
                roomTypeName = (roomTypeName ?? "").Trim();

                var query = from r in db.Rooms
                            join rt in db.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                            where r.Status == "Đang hoạt động"
                            select new
                            {
                                r.RoomID,
                                r.RoomName,
                                r.Status,
                                RoomTypeName = rt.TypeName
                            };

                // 🔹 Lọc theo loại phòng
                if (!string.IsNullOrEmpty(roomTypeName) &&
                    !roomTypeName.Equals("Tất cả", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(x => x.RoomTypeName.Contains(roomTypeName));
                }

                // 🔹 Lọc theo tên phòng (tìm gần đúng)
                if (!string.IsNullOrEmpty(roomName))
                {
                    string lowerName = roomName.ToLower();
                    query = query.Where(x => x.RoomName.ToLower().Contains(lowerName));
                }

                var result = query
                    .OrderBy(x => x.RoomName)
                    .Select(x => new BookingET
                    {
                        RoomID = x.RoomID,
                        RoomName = x.RoomName,
                        RoomStatus = x.Status,
                        RoomTypeName = x.RoomTypeName
                    })
                    .ToList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi FindActiveRooms: " + ex.Message);
                return new List<BookingET>();
            }
        }

    }
}


