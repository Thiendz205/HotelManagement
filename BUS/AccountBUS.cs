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
        public bool IsUsernameAvailableForUpdate(string username, string accountID)
            => accountDAL.IsUsernameAvailableForUpdate(username, accountID);
        public bool StaffExists(string staffID) => accountDAL.StaffExists(staffID);
        public IQueryable getAll_ID_and_Name_Staff()
        {
            return accountDAL.getAll_ID_and_Name_Staff();
        }

        public string generateAccountID()
        {
            return accountDAL.generateAccountID();
        }
        public IQueryable<StaffShortET> getAllStaffShort()
        {
            return accountDAL.getAllStaffShort();
        }
        public string generateAccountID_Safe()
        {
            return accountDAL.generateAccountID_Safe();
        }
        public string generateAccountID_New()
        {
            return accountDAL.generateAccountID_New();
        }
        public bool CheckDuplicateAccountID(string accountID)
        {
            return accountDAL.CheckDuplicateAccountID(accountID);
        }

    }
}
