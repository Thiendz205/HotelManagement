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
    }
}
