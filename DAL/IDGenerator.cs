using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IDGenerator
    {
        private readonly HotelManagementDataContext db;
        public IDGenerator(HotelManagementDataContext ctx) { db = ctx; }

        // Tạo mã cho ServiceUsage: SU001, SU002...
        public string GenerateUseServiceID()
        {
            var last = db.ServiceUsages
                         .OrderByDescending(x => x.UsageID)
                         .Select(x => x.UsageID)
                         .FirstOrDefault();
            if (string.IsNullOrEmpty(last)) return "SU001";

            // lấy phần số sau "SU"
            int num = int.Parse(last.Substring(2)) + 1;
            return "SU" + num.ToString("D3");
        }
    }
}
