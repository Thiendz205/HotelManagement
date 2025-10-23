using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class Room_BUS
    {
        Room_DAL roomDAL = new Room_DAL();
        public IQueryable<Room_ET> getAllRooms()
        {
            return roomDAL.getAllRooms();
        }
        public bool addRoom(Room_ET room)
        {
            return roomDAL.addRoom(room);
        }
        public bool removeRoom(int roomID)
        {
            return roomDAL.removeRoom(roomID);
        }
        public bool updateRoom(Room_ET room)
        {
            return roomDAL.updateRoom(room);
        }
        public bool checkExistenceNameRoom(string name)
        {
            return roomDAL.checkExistenceNameRoom(name);
        }

        public bool checkExistenceNameRoom_UPDate(string name, int currentRoomID)
        {
            return roomDAL.checkExistenceNameRoom_UPDate(name, currentRoomID);
        }
        public IQueryable getAll_ID_and_Name_RoomType()
        {
            return roomDAL.getAll_ID_and_Name_RoomType();
        }

    }

}
