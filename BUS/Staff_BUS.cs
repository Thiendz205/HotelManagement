using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Staff_BUS
    {
        Staff_DAL dal = new Staff_DAL();

        public IQueryable GetStaffByRole(string roleName)
        {
            return dal.GetStaffByRole(roleName);
        }
    }

}
