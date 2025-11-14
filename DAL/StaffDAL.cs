using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class StaffDAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable<StaffET> getAllStaffs()
        {
            var staffs = from s in db.Staffs
                        select new StaffET
                        {
                            StaffID = s.StaffID,
                            FullName = s.FullName,
                            Role = s.Role,
                            DateOfBirth = s.DateOfBirth,
                            Gender = s.Gender,
                            PhoneNumber = s.PhoneNumber,
                            CitizenID = s.CitizenID,
                            StartDate = s.StartDate,
                            Notes = s.Notes
                        };
            return staffs;
        }

        public bool checkExistenceStaffID(string staffID)
        {
            var staff = db.Staffs.Where(x => x.StaffID == staffID).FirstOrDefault();
            return staff == null;
        }

        public bool checkExistencePhoneNumber(string phoneNumber)
        {
            var staff = db.Staffs.Where(x => x.PhoneNumber == phoneNumber).FirstOrDefault();
            return staff == null;
        }

        public bool checkExistenceCitizenID(string citizenID)
        {
            var staff = db.Staffs.Where(x => x.CitizenID == citizenID).FirstOrDefault();
            return staff == null;
        }

        public bool checkExistencePhoneNumber_Update(string phoneNumber, string currentStaffID)
        {
            var staff = db.Staffs.FirstOrDefault(x => x.PhoneNumber == phoneNumber && x.StaffID != currentStaffID);
            return staff == null;
        }

        public bool checkExistenceCitizenID_Update(string citizenID, string currentStaffID)
        {
            var staff = db.Staffs.FirstOrDefault(x => x.CitizenID == citizenID && x.StaffID != currentStaffID);
            return staff == null;
        }

        public bool addStaff(StaffET staff)
        {
            try
            {
                var existingStaff = db.Staffs.Where(x => x.StaffID == staff.StaffID).FirstOrDefault();
                if (existingStaff == null)
                {
                    Staff newStaff = new Staff
                    {
                        StaffID = staff.StaffID,
                        FullName = staff.FullName,
                        Role = staff.Role,
                        DateOfBirth = staff.DateOfBirth,
                        Gender = staff.Gender,
                        PhoneNumber = staff.PhoneNumber,
                        CitizenID = staff.CitizenID,
                        StartDate = staff.StartDate,
                        Notes = staff.Notes
                    };
                    db.Staffs.InsertOnSubmit(newStaff);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool checkStaffHasForeignKey(string staffID)
        {
            try
            {
                // Kiểm tra xem nhân viên có được sử dụng trong bảng Account không
                var accountExists = db.Accounts.Any(a => a.StaffID == staffID);
                if (accountExists) return true;

                // Kiểm tra xem nhân viên có được sử dụng trong bảng UseService không
                var useServiceExists = db.ServiceUsages.Any(u => u.StaffID == staffID);
                if (useServiceExists) return true;

                // Có thể thêm các bảng khác nếu cần
                return false;
            }
            catch (Exception)
            {
                return true; // Nếu có lỗi, giả sử có khóa ngoại để an toàn
            }
        }

        public bool removeStaff(string staffID)
        {
            try
            {
                // Kiểm tra khóa ngoại trước khi xóa
                if (checkStaffHasForeignKey(staffID))
                {
                    return false; // Không thể xóa vì có khóa ngoại
                }

                Staff staffToDelete = db.Staffs.SingleOrDefault(s => s.StaffID == staffID);
                if (staffToDelete != null)
                {
                    db.Staffs.DeleteOnSubmit(staffToDelete);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateStaff(StaffET staff)
        {
            try
            {
                Staff staffToUpdate = db.Staffs.SingleOrDefault(s => s.StaffID == staff.StaffID);
                if (staffToUpdate != null)
                {
                    staffToUpdate.FullName = staff.FullName;
                    staffToUpdate.Role = staff.Role;
                    staffToUpdate.DateOfBirth = staff.DateOfBirth;
                    staffToUpdate.Gender = staff.Gender;
                    staffToUpdate.PhoneNumber = staff.PhoneNumber;
                    staffToUpdate.CitizenID = staff.CitizenID;
                    staffToUpdate.StartDate = staff.StartDate;
                    staffToUpdate.Notes = staff.Notes;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string generateStaffID()
        {
            try
            {
                var lastStaff = db.Staffs.OrderByDescending(s => s.StaffID).FirstOrDefault();
                if (lastStaff == null)
                {
                    return "ST001";
                }
                else
                {
                    string lastID = lastStaff.StaffID;
                    int number = int.Parse(lastID.Substring(2)) + 1;
                    return "ST" + number.ToString("D3");
                }
            }
            catch (Exception)
            {
                return "ST001";
            }
        }
        public IQueryable<StaffET> getStaffsWithStatus()
        {
            var staffs = from s in db.Staffs
                         join a in db.Accounts on s.StaffID equals a.StaffID into acc
                         from a in acc.DefaultIfEmpty()
                         select new StaffET
                         {
                             StaffID = s.StaffID,
                             FullName = s.FullName,
                             Role = s.Role,
                             DateOfBirth = s.DateOfBirth,
                             Gender = s.Gender,
                             PhoneNumber = s.PhoneNumber,
                             CitizenID = s.CitizenID,
                             StartDate = s.StartDate,
                             Notes = s.Notes,
                             Status = (a != null && (a.Status == "1" || a.Status == "Active" || a.Status == "Đang làm việc"))
                                        ? "Active"
                                        : "Inactive"
                         };
            return staffs;
        }
    }
}
