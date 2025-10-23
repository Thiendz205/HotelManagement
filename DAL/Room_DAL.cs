using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class Room_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();
        Room_ET room_ET = new Room_ET();

        public IQueryable<Room_ET>  getAllRooms()
        {
            var rooms = from r in db.Rooms
                        join rt in db.RoomTypes on r.RoomTypeID equals rt.RoomTypeID
                        select new Room_ET
                        {
                            RoomID = r.RoomID,
                            RoomName = r.RoomName,
                            TypeName = rt.TypeName,
                            Capacity = r.Capacity,
                            Description = r.Description,
                            Status = r.Status
                        };
            return rooms;
        }

        public bool checkExistenceNameRoom(string name)
        {
            var roomName = db.Rooms.Where(x => x.RoomName == name).FirstOrDefault(); if (roomName == null)
            {
                return true;
            }
            return false;
        }
        
        public bool checkExistenceNameRoom_UPDate(string name, int currentRoomID)
        {
            var roomName = db.Rooms.FirstOrDefault(x => x.RoomName == name && x.RoomID != currentRoomID);
            return roomName != null;
        }

        public bool addRoom(Room_ET room)
        {
            try
            {
                var roomID = db.Rooms.Where(x=>x.RoomID == room.RoomID).FirstOrDefault();
                var roomName = db.Rooms.Where(x => x.RoomName == room.RoomName).FirstOrDefault();
                if (roomID == null && roomName == null) 
                {
                    Room newRoom = new Room
                    {

                        RoomName = room.RoomName,
                        RoomTypeID = room.RoomTypeID,
                        Capacity = room.Capacity,
                        Description = room.Description,
                        Status = room.Status
                    };
                    db.Rooms.InsertOnSubmit(newRoom);
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

        public bool removeRoom(int roomID)
        {
            try
            {
                Room roomToDelete = db.Rooms.SingleOrDefault(r => r.RoomID == roomID);
                if (roomToDelete != null)
                {
                    db.Rooms.DeleteOnSubmit(roomToDelete);
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

        public bool updateRoom(Room_ET room)
       {
            try
            {
                Room roomToUpdate = db.Rooms.SingleOrDefault(r => r.RoomID == room.RoomID);
                if (roomToUpdate != null)
                {
                    roomToUpdate.RoomName = room.RoomName;
                    roomToUpdate.RoomTypeID = room.RoomTypeID;
                    roomToUpdate.Capacity = room.Capacity;
                    roomToUpdate.Description = room.Description;
                    roomToUpdate.Status = room.Status;
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

        public IQueryable getAll_ID_and_Name_RoomType()
        {
            var roomTypes = from rt in db.RoomTypes
                            where rt.Category == "Standard"
                            select new
                            {
                                rt.RoomTypeID,
                                rt.TypeName
                            };
            return roomTypes;
        }


    }
}
