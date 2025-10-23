using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class AccountET
    {
        public AccountET(int accountID, string username, string password, DateTime startDate, string staffID, string status)
        {
            AccountID = accountID;
            Username = username;
            Password = password;
            StartDate = startDate;
            StaffID = staffID;
            Status = status;
        }
        
        public AccountET()
        {
           
        }
        
        public int AccountID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime StartDate { get; set; }
        public string StaffID { get; set; }
        public string Status { get; set; }
        public string StaffName { get; set; }
    }
}
