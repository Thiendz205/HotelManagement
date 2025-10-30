using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class FeeTypeET
    {
        public int FeeTypeID { get; set; }
        public string FeeTypeName { get; set; }
        public string Category { get; set; }
        public decimal DefaultPrice { get; set; }
        public string Notes { get; set; }
    }
}
