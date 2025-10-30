using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BookinggET
    {
        public BookinggET()
        {
           
        }
        
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public string RentalType { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string StaffID { get; set; }
        
        // Thuộc tính hiển thị
        public string CustomerName { get; set; }
        public string RoomName { get; set; }
        public string StaffName { get; set; }
    }
}
