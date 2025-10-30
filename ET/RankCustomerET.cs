using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class RankCustomerET
    {
        public int RankID { get; set; }
        public string RankName { get; set; }
        public decimal DiscountPercent { get; set; }
        public decimal MinSpending { get; set; }
    }
}
