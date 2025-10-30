using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BookingFeeBUS
    {
        private BookingFeeDAL dal = new BookingFeeDAL();

        public List<BookingFeeET> GetAll()
        {
            return dal.GetAll();
        }

        public bool CheckDuplicate(int bookingId, int feeTypeId, int? excludeId = null)
        {
            return dal.CheckDuplicate(bookingId, feeTypeId, excludeId);
        }

        public bool Insert(BookingFeeET dto)
        { 
            return dal.Insert(dto);
        }
        public bool Update(BookingFeeET dto)
        {
            return dal.Update(dto);
        }

        public bool Delete(int id)
        {
            return dal.Delete(id);
        }
        // BookingBUS.cs
        public List<BookingFeeET> GetBookingsWithActiveRooms()
        {
            return dal.GetBookingsWithActiveRooms();
        }
    }
}
