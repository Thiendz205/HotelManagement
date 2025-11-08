using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class RoomEquipment_ET
    {
        public RoomEquipment_ET() { }

        public RoomEquipment_ET(string roomEquipmentID, string roomID, string equipmentStorage, int quantity, DateTime installedDate, string condition, string note, string staffID)
        {
            RoomEquipmentID = roomEquipmentID;
            RoomID = roomID;
            EquipmentStorage = equipmentStorage;
            Quantity = quantity;
            InstalledDate = installedDate;
            Condition = condition;
            Note = note;
            StaffID = staffID;
        }

        public string RoomEquipmentID { get; set; }
        public string RoomID { get; set; }
        public string EquipmentStorage { get; set; }
        public int Quantity { get; set; }
        public DateTime InstalledDate { get; set; }
        public string Condition { get; set; }
        public string Note { get; set; }
        public string StaffID { get; set; }
    }
}
