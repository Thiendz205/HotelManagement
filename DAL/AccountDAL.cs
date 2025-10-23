using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class AccountDAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();
        AccountET accountET = new AccountET();

        public IQueryable<AccountET> getAllAccounts()
        {
            var accounts = from a in db.Accounts
                          join s in db.Staffs on a.StaffID equals s.StaffID into staffGroup
                          from s in staffGroup.DefaultIfEmpty()
                          select new AccountET
                          {
                              AccountID = a.AccountID,
                              Username = a.Username,
                              Password = a.Password,
                              StartDate = a.StartDate,
                              StaffID = a.StaffID,
                              Status = a.Status,
                              StaffName = s != null ? s.FullName : "Không xác định"
                          };
            return accounts;
        }

        // true nếu Username đã tồn tại
        public bool UsernameExists(string username)
        {
            if (string.IsNullOrWhiteSpace(username)) return false;
            string u = username.Trim();
            return db.Accounts.Any(x => x.Username == u);
        }

        // true nếu nhân viên đã có tài khoản
        public bool StaffHasAccount(string staffID)
        {
            if (string.IsNullOrWhiteSpace(staffID)) return false;
            string s = staffID.Trim();
            return db.Accounts.Any(x => x.StaffID == s);
        }

        // true nếu username có thể dùng khi update (không đụng ai khác)
        public bool IsUsernameAvailableForUpdate(string username, int accountId)
        {
            string u = (username ?? "").Trim();
            return !db.Accounts.Any(x => x.Username == u && x.AccountID != accountId);
        }

        // (MỚI) true nếu StaffID tồn tại trong bảng Staff
        public bool StaffExists(string staffID)
        {
            if (string.IsNullOrWhiteSpace(staffID)) return false;
            string s = staffID.Trim();
            return db.Staffs.Any(x => x.StaffID == s);
        }

        public bool addAccount(AccountET account)
        {
            // ĐỪNG nuốt lỗi mù mờ – nếu có vấn đề, ném ra cho GUI hiển thị
            if (account == null) return false;

            string username = (account.Username ?? "").Trim();
            string staffId = (account.StaffID ?? "").Trim();
            string status = (account.Status ?? "").Trim();

            // 1) Validate cơ bản
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(staffId))
                return false;

            // 2) Username đã tồn tại? -> chặn
            if (UsernameExists(username))
                return false;

            // 3) Staff có tồn tại? -> chặn nếu không
            if (!StaffExists(staffId))
                return false;

            // 4) Staff đã có account? -> chặn
            if (StaffHasAccount(staffId))
                return false;

            // 5) Thêm
            var newAccount = new Account
            {
                Username = username,
                Password = account.Password,
                StartDate = account.StartDate == default ? DateTime.Now : account.StartDate,
                StaffID = staffId,
                Status = string.IsNullOrWhiteSpace(status) ? "Active" : status
            };

            try
            {
                db.Accounts.InsertOnSubmit(newAccount);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                // Trong giai đoạn debug, trả lỗi ra ngoài để biết chính xác nguyên nhân
                throw new Exception("DAL.addAccount failed: " + ex.Message, ex);
            }
        }

        public bool updateAccount(AccountET account)
        {
            if (account == null) return false;

            string username = (account.Username ?? "").Trim();
            string staffId = (account.StaffID ?? "").Trim();
            string status = (account.Status ?? "").Trim();

            var acc = db.Accounts.SingleOrDefault(a => a.AccountID == account.AccountID);
            if (acc == null) return false;

            // Không cho trùng username với account khác
            if (db.Accounts.Any(a => a.Username == username && a.AccountID != account.AccountID))
                return false;

            // Staff phải tồn tại
            if (!StaffExists(staffId))
                return false;

            // Không cho 2 account dùng chung 1 Staff
            if (db.Accounts.Any(a => a.StaffID == staffId && a.AccountID != account.AccountID))
                return false;

            acc.Username = username;
            acc.Password = account.Password;
            acc.StaffID = staffId;
            acc.Status = string.IsNullOrWhiteSpace(status) ? "Active" : status;

            try
            {
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("DAL.updateAccount failed: " + ex.Message, ex);
            }
        }


        public IQueryable getAll_ID_and_Name_Staff()
        {
            var staffs = from s in db.Staffs
                        select new
                        {
                            s.StaffID,
                            s.FullName
                        };
            return staffs;
        }
    }
}
