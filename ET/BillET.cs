using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BillET
    {
        public BillET() { }

        public int InvoiceID { get; set; }
        public int BookingID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaidStatus { get; set; }
        public string StaffID { get; set; }
        public string Note { get; set; }

        // Hiển thị
        public string CustomerName { get; set; }
        public string RoomName { get; set; }
        public string StaffName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        // === Audit fields (mới) ===
        public string CreatedBy { get; set; }   // NV tạo hóa đơn
        public string AuditStatus { get; set; } // OK | REVIEW | WARNING | FAIL
        public string AuditNote { get; set; }   // ghi chú của admin
        public string AuditedBy { get; set; }   // admin đánh dấu
        public DateTime? AuditedAt { get; set; } // thời điểm đánh dấu
    }
}
