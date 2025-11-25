using ET;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class Staff_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        /// <summary>
        /// Lấy danh sách nhân viên theo Role
        /// </summary>
        public IQueryable GetStaffByRole(string roleName)
        {
            var data =
                from s in db.Staffs
                join acc in db.Accounts on s.StaffID equals acc.StaffID
                where s.Role == roleName && acc.Status == "Active"
                select new
                {
                    s.StaffID,
                    s.FullName,
                    s.PhoneNumber,
                    s.Gender,
                    s.Role
                };

            return data;
        }

    }
}
