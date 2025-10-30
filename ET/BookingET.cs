using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BookingET
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public string RentalType { get; set; }
        public string RoomStatus { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string StaffID { get; set; }
        public string StaffName { get; set; }

    }
}
