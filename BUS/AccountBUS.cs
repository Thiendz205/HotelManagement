using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class AccountBUS
    {
        AccountDAL accountDAL = new AccountDAL();
        
        public IQueryable<AccountET> getAllAccounts()
        {
            return accountDAL.getAllAccounts();
        }
        
        public bool addAccount(AccountET account)
        {
            return accountDAL.addAccount(account);
        }
        
        public bool updateAccount(AccountET account)
        {
            return accountDAL.updateAccount(account);
        }
        public bool UsernameExists(string username) => accountDAL.UsernameExists(username);
        public bool StaffHasAccount(string staffID) => accountDAL.StaffHasAccount(staffID);
        public bool IsUsernameAvailableForUpdate(string username, int accountID)
            => accountDAL.IsUsernameAvailableForUpdate(username, accountID);
        public bool StaffExists(string staffID) => accountDAL.StaffExists(staffID);
        public IQueryable getAll_ID_and_Name_Staff()
        {
            return accountDAL.getAll_ID_and_Name_Staff();
        }

    }
}
