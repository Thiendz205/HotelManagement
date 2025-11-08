using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class Room_Type_BUS
    {
        Room_Type_DAL roomTypeDAL = new Room_Type_DAL();
        public IQueryable getAllRoomTypes()
        {
            return roomTypeDAL.getAllRoomTypes();
        }
        public bool addRoomType(ET.Room_Type_ET roomType)
        {
            return roomTypeDAL.addRoomType(roomType);
        }
        public bool removeRoomType(string roomTypeID)
        {
            return roomTypeDAL.removeRoomType(roomTypeID);
        }
        public bool updateRoomType(ET.Room_Type_ET roomType)
        {
            return roomTypeDAL.updateRoomType(roomType);
        }
        public bool checkExistenceNameRoom(string name, string category)
        {
            return roomTypeDAL.checkExistenceNameRoomType(name, category);
        }
        public bool checkExistenceNameRoomType_UPDate(string name, string currentRoomID)
        {
            return roomTypeDAL.checkExistenceNameRoomType_UPDate(name, currentRoomID);
        }

        public bool IsRoomTypeInUse(string roomTypeID)
        {
            return roomTypeDAL.IsRoomTypeInUse(roomTypeID);
        }


    }
}
