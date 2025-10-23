using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Infor_Staff_ET
    {
        public Infor_Staff_ET(string staffID, string fullName, string role, DateTime dateOfBirth,
            string gender, string phoneNumber, string citizenID, DateTime startDate, string note)
        {
            StaffID = staffID;
            FullName = fullName;
            Role = role;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            PhoneNumber = phoneNumber;
            CitizenID = citizenID;
            StartDate = startDate;
            Note = note;
        }
        public Infor_Staff_ET() { }

        public string StaffID { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string CitizenID { get; set; }
        public DateTime StartDate { get; set; }
        public string Note { get; set; }
    }
}
