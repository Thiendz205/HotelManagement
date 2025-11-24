using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class InvoiceET
    {
        public string InvoiceID { get; set; }
        public string BookingID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentMethod { get; set; }
        public string PaidStatus { get; set; }
        public string StaffID { get; set; }
        public string Note { get; set; }
        public string RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomType { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public decimal Revenue { get; set; }
    }
}
