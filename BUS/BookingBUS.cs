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

        // Tìm kiếm Booking theo tên khách hoặc tên phòng
        public List<BookingET> Search(string customerName, string roomName)
        {
            return bookingDAL.Search(customerName, roomName);
        }

        // Kiểm tra đã lập hóa đơn chưa
        public bool HasInvoice(int bookingId)
        {
            return bookingDAL.HasInvoice(bookingId);
        }

        // Cập nhật Booking
        public UpdateResult UpdateBookingInfoOnly(BookingET booking)
        {
            return bookingDAL.UpdateBookingInfoOnly(booking);
        }

        public List<BookingET> GetAllCustomers() => bookingDAL.GetAllCustomers();
        public List<BookingET> GetRoomsForBookingCombo() => bookingDAL.GetRoomsForBookingCombo();

        // Hủy lịch Booking (chỉ cập nhật trạng thái, không xóa, không thông báo)
        public bool CancelBooking(int bookingId)=> bookingDAL.CancelBooking(bookingId);

        public List<Room> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            return bookingDAL.GetAvailableRooms(checkIn, checkOut);
        }
        public decimal CalculateTotalPrice(int roomId, string rentalType, DateTime checkIn, DateTime checkOut)
            => bookingDAL.CalculateTotalPrice(roomId, rentalType, checkIn, checkOut);
        public List<BookingET> GetRoomTypes()
        {
            return bookingDAL.GetRoomTypes();
        }

        // 🔹 Lấy danh sách phòng theo loại
        public List<BookingET> GetRoomsByType(int roomTypeId)
        {
            return bookingDAL.GetRoomsByType(roomTypeId);
        }

        // 🔹 Cập nhật trạng thái phòng
        public bool UpdateRoomStatus(BookingET dto)
        {
            return bookingDAL.UpdateRoomStatus(dto);
        }

        // 🔹 Lấy trạng thái hiện tại của phòng
        public string GetRoomStatus(int roomId)
        {
            return bookingDAL.GetRoomStatus(roomId);
        }
    }
}
