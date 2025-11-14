using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class StaffET
    {
        public StaffET()
        {
           
        }
        
        public string StaffID { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string CitizenID { get; set; }
        public DateTime StartDate { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }

    }
}
