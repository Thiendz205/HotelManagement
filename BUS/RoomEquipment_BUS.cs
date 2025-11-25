using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoomEquipment_BUS
    {
        RoomEquipment_DAL roomEquipment_DAL = new DAL.RoomEquipment_DAL();
        public IQueryable getAllRoomEquipment()
        {
            return roomEquipment_DAL.getAllRoomEquipment();
        }

        public IQueryable<EquipmentStorage_ET> getEquipmentNameAndID()
        {
            return roomEquipment_DAL.getEquipmentNameAndID();
        }

        public bool AddRoomEquipment(RoomEquipment_ET roomEquipment)
        {
            return roomEquipment_DAL.AddRoomEquipment(roomEquipment);
        }
        public IQueryable<Room_ET> getIDNameRoom()
        {
            return roomEquipment_DAL.getIDNameRoom();
        }
        public bool RemoveRoomEquipment(string roomEquipmentID)
        {
            return roomEquipment_DAL.RemoveRoomEquipment(roomEquipmentID);
        }
        public bool UpdateRoomEquipment(RoomEquipment_ET roomEquipment)
        {
            bool result = roomEquipment_DAL.UpdateRoomEquipment(roomEquipment);

            // 🔥 NẾU thiết bị chuyển sang bảo trì → phòng cũng phải chuyển
            if (result && roomEquipment.Condition == "Maintenance")
            {
                roomEquipment_DAL.SetRoomMaintenanceByEquipment(roomEquipment.RoomEquipmentID);
            }

            return result;
        }

        public bool UpdateStatusRoom(string roomID)
        {
            return roomEquipment_DAL.UpdateStatusRoom(roomID);
        }

     
    }
}
