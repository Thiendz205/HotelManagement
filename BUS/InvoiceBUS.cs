using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InvoiceBUS
    {
        private readonly InvoiceDAL dal = new InvoiceDAL();

        public List<BookingUsageET> GetUsageDetailsByRoom(string roomId)
        {
            return dal.GetUsageByRoom(roomId);
        }

        public decimal GetTotalAmount(string roomId)
        {
            string bookingId = dal.GetType()
                .GetMethod("GetActiveBookingIdByRoom", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.Invoke(dal, new object[] { roomId })?.ToString();

            if (string.IsNullOrEmpty(bookingId)) return 0m;
            return dal.CalculateBookingTotal(bookingId);
        }
        public CustomerPaymentInfoET GetCustomerInfoByRoom(string roomId)
        {
            return dal.GetCustomerInfoByRoom(roomId);
        }
        public bool AddExtraFeeToBooking(string bookingId, string feeTypeId, int quantity = 1)
        {
            return dal.AddExtraFeeToBooking(bookingId, feeTypeId, quantity);
        }
        public bool PayInvoiceByBooking(string bookingId, string staffId, string paymentMethod, string note)
        {
            return dal.CreateInvoiceByBooking(bookingId, staffId, paymentMethod, note);
        }

    }
}
