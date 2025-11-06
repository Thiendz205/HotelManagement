using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoomTypePrice_BUS
    {
        RoomTypePrice_DAL roomTypePrice_DAL = new RoomTypePrice_DAL();
        public IQueryable getAllRoomTypePrices()
        {
            return roomTypePrice_DAL.getAllRoomTypePrices();
        }
        public bool IsOverlap(RoomTypePrice_ET et)
        {
            return roomTypePrice_DAL.IsOverlap(et);
        }

        public bool AddRoomTypePrice(RoomTypePrice_ET et)
        {
            return roomTypePrice_DAL.AddRoomTypePrice(et);
        }
        public IQueryable<Room_Type_ET> getNameIDRoom()
        {
            return roomTypePrice_DAL.getNameIDRoom();
        }
        public bool DeleteRoomTypePrice(int priceID)
        {
            return roomTypePrice_DAL.DeleteRoomTypePrice(priceID);  
        }

        public bool Update(RoomTypePrice_ET et)
        {
            return roomTypePrice_DAL.Update(et);
        }
        public int RemoveExpiredPrices()
        {
            return roomTypePrice_DAL.RemoveExpiredPrices();
        }
        public bool CheckOverlapForUpdate(RoomTypePrice_ET et)
        {
            return roomTypePrice_DAL.CheckOverlapForUpdate(et);
        }
    }
}
