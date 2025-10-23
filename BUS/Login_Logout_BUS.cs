using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class Login_Logout_BUS
    {
        Login_Logout_DAL login_Logout_DAL = new Login_Logout_DAL();
        public bool Login(string username, string password)
        {
            return login_Logout_DAL.Login(username, password);
        }
        public string getStaffIDByAccount(string username, string password)
        {
            return login_Logout_DAL.getStaffIDByAccount(username, password);
        }
        public string checkRoleByStaffs(string staffID)
        {
            return login_Logout_DAL.checkRoleByStaffs(staffID);
        }

        public Infor_Staff_ET getInfoStaffs(string staffID)
        {
            return login_Logout_DAL.getInfoStaffs(staffID);
        }

        public string getStatusByAccount(string username, string password)
        {
            return login_Logout_DAL.getStatusByAccount(username, password);
        }

    }
}
