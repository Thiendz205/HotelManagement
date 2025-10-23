using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomStatus_StaffTech_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();
        public IQueryable getAllRoomStatus()
        {
            var roomStatus = from r in db.Rooms
                             join rt in db.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                             where r.Status == "Trống" || r.Status == "Đang bảo trì"
                             select new
                             {
                                 r.RoomID,
                                 r.RoomName,
                                 r.RoomTypeID,
                                 RoomTypeName = rt.TypeName,
                                 r.Capacity,
                                 r.Description,
                                 r.Status
                             };
            return roomStatus;
        }

        public bool updateStatusRooms_StaffTech(int roomID, string status)
        {
            try
            {
                var room = db.Rooms.SingleOrDefault(r => r.RoomID == roomID);
                if (room != null && room.Status != status )
                {
                    room.Status = status;
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
