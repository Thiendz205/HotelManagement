using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class Login_Logout_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();
        Infor_Staff_ET infor_Staff_ET = new Infor_Staff_ET();
        public bool Login(string username, string password)
        {
            var acc = db.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);

            if (acc == null)
            {
                return false;
            }

            if (acc.Status == "Inactive")
            {
                return false;
            }

            return true; 
        }

        public string getStaffIDByAccount(string username, string password)
        {
            var staff = from a in db.Accounts
                        where a.Username == username && a.Password == password
                        select a.StaffID;
            return staff.FirstOrDefault();
        }
        public string checkRoleByStaffs(string staffID)
        {
            var roles = from r in db.Staffs
                        where r.StaffID == staffID
                        select r.Role;
            return roles.FirstOrDefault();

        }

        public Infor_Staff_ET getInfoStaffs(string staffID)
        {
            var info = db.Staffs.FirstOrDefault(s => s.StaffID == staffID);
            if(info != null)
            {
                return new Infor_Staff_ET
                {
                    StaffID = info.StaffID,
                    FullName = info.FullName,
                    Role = info.Role,
                    DateOfBirth = info.DateOfBirth,
                    Gender = info.Gender,
                    PhoneNumber = info.PhoneNumber,
                    CitizenID = info.CitizenID,
                    StartDate = info.StartDate,
                    Note = info.Notes,
                };
            }
            return null;
        }

        public string getStatusByAccount(string username, string password)
        {
            var status = from a in db.Accounts
                         where a.Username == username && a.Password == password
                         select a.Status;
            return status.FirstOrDefault();
        }
    }
}
