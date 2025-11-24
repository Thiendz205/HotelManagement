using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.BookingDAL;

namespace BUS
{
    public class BookingBUS
    {
        private BookingDAL bookingDAL = new BookingDAL();

        // Lấy danh sách Booking
        public List<BookingET> GetAll()
        {
            return bookingDAL.GetAll();
        }

        // 🔹 Tìm kiếm Booking theo tên khách hoặc tên phòng
        public List<BookingET> Search(string customerName, string roomName)
        {
            return bookingDAL.Search(customerName, roomName);
        }

        // 🔹 Kiểm tra đã lập hóa đơn chưa
        public bool HasInvoice(string bookingId)
        {
            return bookingDAL.HasInvoice(bookingId);
        }

        // 🔹 Cập nhật thông tin Booking
        public UpdateResult UpdateBookingInfoOnly(BookingET booking)
        {
            return bookingDAL.UpdateBookingInfoOnly(booking);
        }

        // 🔹 Lấy danh sách khách hàng
        public List<BookingET> GetAllCustomers()
        {
            return bookingDAL.GetAllCustomers();
        }

        // 🔹 Lấy danh sách phòng còn trống/đặt trước
        public List<BookingET> GetRoomsForBookingCombo()
        {
            return bookingDAL.GetRoomsForBookingCombo();
        }

        // 🔹 Hủy đặt phòng
        public bool CancelBooking(string bookingId)
        {
            return bookingDAL.CancelBooking(bookingId);
        }

        // 🔹 Lấy phòng khả dụng trong khoảng thời gian
        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            return bookingDAL.GetAvailableRooms(checkIn, checkOut);
        }

        // 🔹 Tính tổng tiền thuê
        public decimal CalculateTotalPrice(string roomId, string rentalType, DateTime checkIn, DateTime checkOut)
        {
            return bookingDAL.CalculateTotalPrice(roomId, rentalType, checkIn, checkOut);
        }

        // 🔹 Lấy danh sách loại phòng
        public List<BookingET> GetRoomTypes()
        {
            return bookingDAL.GetRoomTypes();
        }

        // 🔹 Lấy danh sách phòng theo loại
        public List<BookingET> GetRoomsByType(string roomTypeId)
        {
            return bookingDAL.GetRoomsByType(roomTypeId);
        }

        // 🔹 Cập nhật trạng thái phòng
        public bool UpdateRoomStatus(BookingET dto)
        {
            return bookingDAL.UpdateRoomStatus(dto);
        }

        // 🔹 Lấy trạng thái hiện tại của phòng
        public string GetRoomStatus(string roomId)
        {
            return bookingDAL.GetRoomStatus(roomId);
        }

        // 🔹 (Tùy chọn) Lấy đơn giá phòng tại thời điểm check-in
        public decimal GetRoomPrice(string roomId, string rentalType, DateTime checkIn)
        {
            return bookingDAL.GetRoomPrice(roomId, rentalType, checkIn);
        }
        public List<BookingET> GetRoomsForBookingList()
        {
            return bookingDAL.GetRoomsForBookingList();
        }
        public List<BookingET> SearchRooms(string roomName, string roomTypeName)
        {
            return bookingDAL.SearchRooms(roomName, roomTypeName);
        }
        public List<string> GetAllRoomTypes()
        {
            return bookingDAL.GetAllRoomTypes();
        }
        public List<BookingET> GetPreBookedRooms()
        {
            return bookingDAL.GetPreBookedRooms();
        }
        public List<BookingET> SearchPreBookedRooms(string roomName, string roomTypeName)
        {
            return bookingDAL.SearchPreBookedRooms(roomName, roomTypeName);
        }
        public AddBookingResult AddBookingWithCustomer(BookingET booking, CustomerET customer)
        {
            return bookingDAL.AddBookingWithCustomer(booking, customer);
        }
        public BookingET GetRoomInfo(string roomId)
        {
            return bookingDAL.GetRoomInfoById(roomId);
        }
        public CustomerET GetCustomerByPhoneOrId(string phone, string nationalId)
        {
            return bookingDAL.GetCustomerByPhoneOrId(phone, nationalId);
        }
        public List<BookingHistoryET> GetBookingHistoryByCustomerID(string customerId)
        {
            return bookingDAL.GetCustomerFullHistory(customerId);
        }
        public bool CheckIn(string bookingId, string staffId)
        {
            return bookingDAL.CheckInBooking(bookingId, staffId);
        }
        public bool CancelBookingByStaff(string bookingId, string staffId)
        {
            return bookingDAL.CancelBookingByStaff(bookingId, staffId);
        }

        public string GetBookingIdByRoom(string roomId)
        {
            return bookingDAL.GetBookingIdByRoom(roomId);
        }

        public List<BookingET> GetPendingBookingsByRoom(string roomId)
        {
            return bookingDAL.GetPendingBookingsByRoomId(roomId);
        }
        public List<BookingET> GetActiveRooms()
        {
            return bookingDAL.GetActiveRooms();
        }

        public List<BookingET> FindActiveRooms(string roomName, string roomTypeName)
        {
            return bookingDAL.FindActiveRooms(roomName, roomTypeName);
        }
        public UpdateResult UpdateBookingInfoByStaff(BookingET booking, string staffId)
        {
            return bookingDAL.UpdateBookingInfoByStaff(booking, staffId);
        }
        public List<BookingET> GetCleaningRooms()
        {
            return bookingDAL.GetCleaningRooms();
        }

        public List<BookingET> SearchCleaningRooms(string roomName, string roomTypeName)
        {
            return bookingDAL.SearchCleaningRooms(roomName, roomTypeName);
        }
        public bool UpdateRoomStatusBulk(List<string> roomIds, string newStatus, string note = null)
        {
            return bookingDAL.UpdateRoomStatusBulk(roomIds, newStatus, note);
        }
        public List<string> GetAllRoomTypess()
        {
            return bookingDAL.GetAllRoomTypess();
        }
    }
}
