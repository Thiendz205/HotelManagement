using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class CustomerET
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalID { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int RankID { get; set; }

        // Thêm thuộc tính hiển thị
        public string RankName { get; set; }
        public decimal TotalSpending { get; set; }
    }
}
