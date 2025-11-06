using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Room_ET
    {
        public Room_ET(string roomID, string roomName, string roomTypeID, int capacity, string description, string status, string official)
        {
            RoomID = roomID;
            RoomName = roomName;
            RoomTypeID = roomTypeID;
            Capacity = capacity;
            Description = description;
            Status = status;
            Official = official;

        }
        public Room_ET()
        {
           
        }
        public string RoomID { get; set; }
        public string RoomName { get; set; }
        public string RoomTypeID { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string TypeName { get; set; } 
        public string Official { get; set; }



    }
}
