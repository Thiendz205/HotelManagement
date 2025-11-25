using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class MaintenanceLog_ET
    {
        public MaintenanceLog_ET() { }

        public MaintenanceLog_ET(int logID, int maintenanceTypeID, string roomID, string roomEquipmentID, string staffID, DateTime maintenanceDate, string status, string note)
        {
            LogID = logID;
            MaintenanceTypeID = maintenanceTypeID;
            RoomID = roomID;
            RoomEquipmentID = roomEquipmentID;
            StaffID = staffID;
            MaintenanceDate = maintenanceDate;
            Status = status;
            Note = note;
        }

        public int LogID { get; set; }
        public int MaintenanceTypeID { get; set; }
        public string RoomID { get; set; }
        public string RoomEquipmentID { get; set; }   // NEW ✔
        public string StaffID { get; set; }
        public DateTime MaintenanceDate { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }


    }
}
