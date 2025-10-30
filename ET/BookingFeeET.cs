using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BookingFeeET
    {
        public int BookingFeeID { get; set; }
        public int BookingID { get; set; }
        public int FeeTypeID { get; set; }
        public string FeeTypeName { get; set; }
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public string RoomName { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Notes { get; set; }
        public decimal UnitPrice { get; set; }     // Đơn giá
        public decimal TotalAmount { get; set; }   // Tổng tiền

    }
}
