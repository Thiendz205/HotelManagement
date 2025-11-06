using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BookingUsageET
    {
        public string UsageID { get; set; }      // Mã sử dụng dịch vụ (ServiceUsage.UsageID)
        public string BookingID { get; set; }    // Mã đặt phòng
        public string ServiceID { get; set; }    // Mã dịch vụ (nếu là dòng dịch vụ)
        public string StaffID { get; set; }      // Nhân viên phụ trách (nếu có)

        // === Fields for display / invoice calculation ===
        public string Type { get; set; }         // "Tiền phòng", "Dịch vụ", "Phụ phí", "Tổng cộng"
        public string ItemName { get; set; }     // Tên dịch vụ / tên phụ phí / tên phòng
        public decimal Price { get; set; }       // Đơn giá
        public int Quantity { get; set; }        // Số lượng (mặc định 1 cho tiền phòng)
        public decimal Total => Price * Quantity; // Tổng cho dòng
        public DateTime UsedAt { get; set; }     // Thời điểm sử dụng (nếu có)

        public BookingUsageET()
        {
            // khởi tạo giá trị mặc định an toàn
            Quantity = 1;
            Price = 0m;
            UsedAt = DateTime.Now;
        }

        // Optional convenience constructor (dùng khi cần)
        public BookingUsageET(string type, string itemName, decimal price, int quantity, DateTime usedAt)
        {
            Type = type;
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
            UsedAt = usedAt;
        }
    }
}
