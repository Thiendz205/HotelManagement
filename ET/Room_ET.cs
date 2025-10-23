using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Room_ET
    {
        public Room_ET(int roomID, string roomName, int roomTypeID, int capacity, string description, string status)
        {
            RoomID = roomID;
            RoomName = roomName;
            RoomTypeID = roomTypeID;
            Capacity = capacity;
            Description = description;
            Status = status;
        }
        public Room_ET()
        {
           
        }
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public int RoomTypeID { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string TypeName { get; set; } 



    }
}
