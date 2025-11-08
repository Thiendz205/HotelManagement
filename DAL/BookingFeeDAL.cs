using ET;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookingFeeDAL
    {
        private HotelManagementDataContext db = new HotelManagementDataContext();

        // ✅ Lấy tất cả phí phát sinh, kèm tên khách hàng và tên phòng
        public List<BookingFeeET> GetAll()
        {
            return (from f in db.BookingFees
                    join t in db.FeeTypes on f.FeeTypeID equals t.FeeTypeID
                    join b in db.Bookings on f.BookingID equals b.BookingID
                    join c in db.Customers on b.CustomerID equals c.CustomerID
                    join r in db.Rooms on b.RoomID equals r.RoomID
                    select new BookingFeeET
                    {
                        //BookingFeeID = f.BookingFeeID,
                        //BookingID = f.BookingID,
                        //FeeTypeID = f.FeeTypeID,
                        FeeTypeName = t.FeeTypeName,
                        UnitPrice = t.DefaultPrice,                             // ✅ Lấy đơn giá
                        Quantity = f.Quantity,
                        TotalAmount = f.Quantity * t.DefaultPrice,              // ✅ Tính tổng tiền
                        CustomerName = c.FullName,
                        RoomName = r.RoomName,
                        CreatedAt = f.CreatedAt ?? new DateTime(1753, 1, 1),
                        Notes = f.Notes
                    }).ToList();
        }

        public bool CheckDuplicate(int bookingId, int feeTypeId, int? excludeId = null)
        {
           // return db.BookingFees.Any(x =>
                //x.BookingID == bookingId &&
                //x.FeeTypeID == feeTypeId &&
                //(excludeId == null || x.BookingFeeID != excludeId));
                return false; //tam
        }
        // BookingDAL.cs
        public List<BookingFeeET> GetBookingsWithActiveRooms()
        {
            return (from b in db.Bookings
                    join c in db.Customers on b.CustomerID equals c.CustomerID
                    join r in db.Rooms on b.RoomID equals r.RoomID
                    where r.Status == "Đang hoạt động"
                    select new BookingFeeET
                    {
                        //BookingID = b.BookingID,
                        CustomerName = c.FullName,
                        RoomName = r.RoomName
                    }).ToList();
        }
        public bool Insert(BookingFeeET dto)
        {
            var entity = new BookingFee
            {
                //BookingID = dto.BookingID,
                //FeeTypeID = dto.FeeTypeID,
                Quantity = dto.Quantity,
                Notes = dto.Notes,
                CreatedAt = DateTime.Now
            };

            db.BookingFees.InsertOnSubmit(entity);
            db.SubmitChanges();
            return true;
        }

        public bool Update(BookingFeeET dto)
        {
            //var fee = db.BookingFees.FirstOrDefault(f => f.BookingFeeID == dto.BookingFeeID);
            //if (fee == null) return false;

            //fee.BookingID = dto.BookingID;
            //fee.FeeTypeID = dto.FeeTypeID;
            //fee.Quantity = dto.Quantity;
            //fee.Notes = dto.Notes;

            //db.SubmitChanges();
            return true;
        }

        public bool Delete(int id)
        {
           // var fee = db.BookingFees.FirstOrDefault(f => f.BookingFeeID == id);
            //if (fee == null) return false;

            //db.BookingFees.DeleteOnSubmit(fee);
            //db.SubmitChanges();
            return true;
        }
    }
}
