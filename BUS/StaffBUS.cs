using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class StaffBUS
    {
        StaffDAL staffDAL = new StaffDAL();
        
        public IQueryable<StaffET> getAllStaffs()
        {
            return staffDAL.getAllStaffs();
        }
        
        public bool addStaff(StaffET staff)
        {
            return staffDAL.addStaff(staff);
        }
        
        public bool checkStaffHasForeignKey(string staffID)
        {
            return staffDAL.checkStaffHasForeignKey(staffID);
        }

        public bool removeStaff(string staffID)
        {
            return staffDAL.removeStaff(staffID);
        }
        
        public bool updateStaff(StaffET staff)
        {
            return staffDAL.updateStaff(staff);
        }
        
        public bool checkExistenceStaffID(string staffID)
        {
            return staffDAL.checkExistenceStaffID(staffID);
        }

        public bool checkExistencePhoneNumber(string phoneNumber)
        {
            return staffDAL.checkExistencePhoneNumber(phoneNumber);
        }

        public bool checkExistenceCitizenID(string citizenID)
        {
            return staffDAL.checkExistenceCitizenID(citizenID);
        }

        public bool checkExistencePhoneNumber_Update(string phoneNumber, string currentStaffID)
        {
            return staffDAL.checkExistencePhoneNumber_Update(phoneNumber, currentStaffID);
        }

        public bool checkExistenceCitizenID_Update(string citizenID, string currentStaffID)
        {
            return staffDAL.checkExistenceCitizenID_Update(citizenID, currentStaffID);
        }

        public string generateStaffID()
        {
            return staffDAL.generateStaffID();
        }
        public IQueryable<StaffET> getStaffsWithStatus()
        {
            return staffDAL.getStaffsWithStatus();
        }


    }
}
