using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BookingHistoryET
    {
        public string BookingID { get; set; }
        public string RoomName { get; set; }
        public string RoomTypeName { get; set; }
        public string Type { get; set; }        // Loại: "Tiền phòng", "Dịch vụ", "Phụ phí"
        public string ItemName { get; set; }    // Tên dịch vụ hoặc phí
        public decimal Price { get; set; }      // Giá đơn vị
        public int Quantity { get; set; }       // Số lượng
        public decimal Total => Price * Quantity;  // Tổng cộng
        public DateTime? UsedAt { get; set; }   // Ngày sử dụng (hoặc CheckIn nếu là tiền phòng)
    }
}
