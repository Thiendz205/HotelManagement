using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class RoomStatus_StaffTech_BUS
    {
        RoomStatus_StaffTech_DAL roomStatus_StaffTech = new RoomStatus_StaffTech_DAL();
        public IQueryable getAllRoomStatus()
        {
            return roomStatus_StaffTech.getAllRoomStatus();
        }
        public bool updateStatusRooms_StaffTech(int roomID, string status)
        {
            return roomStatus_StaffTech.updateStatusRooms_StaffTech(roomID, status);
        }

    }
}
