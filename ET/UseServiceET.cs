using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class UseServiceET
    {
        public UseServiceET(int usageID, int bookingID, int serviceID, int quantity, string staffID, DateTime usageDate)
        {
            UsageID = usageID;
            BookingID = bookingID;
            ServiceID = serviceID;
            Quantity = quantity;
            StaffID = staffID;
            UsageDate = usageDate;
        }
        
        public UseServiceET()
        {
           
        }
        
        public int UsageID { get; set; }
        public int BookingID { get; set; }
        public int ServiceID { get; set; }
        public int Quantity { get; set; }
        public string StaffID { get; set; }
        public DateTime UsageDate { get; set; }
        
        // Thuộc tính hiển thị
        public string ServiceName { get; set; }
        public string StaffName { get; set; }
        public string CustomerName { get; set; }
        public string RoomName { get; set; }
        public decimal ServicePrice { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
