using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class CustomerPaymentInfoET
    {
        public string BookingID { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string RentalType { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string RoomName { get; set; }
    }
}
