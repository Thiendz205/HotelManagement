using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
                            Status = r.Status,
                            Official = r.Official,
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
        
        public bool checkExistenceNameRoom_UPDate(string name, string currentRoomID)
        {
            // var roomName = db.Rooms.FirstOrDefault(x => x.RoomName == name && x.RoomID != currentRoomID);
            // return roomName != null;
            return false; //tem
        }

        public bool addRoom(Room_ET room)
        {
            try
            {
                // Kiểm tra trùng tên phòng
                var roomName = db.Rooms.FirstOrDefault(x => x.RoomName == room.RoomName);
                if (roomName != null)
                    return false;

                // 🔹 Lấy ID phòng lớn nhất hiện có
                var lastRoom = db.Rooms
                                 .OrderByDescending(x => x.RoomID)
                                 .Select(x => x.RoomID)
                                 .FirstOrDefault();

                string newRoomID = "R001";

                if (!string.IsNullOrEmpty(lastRoom))
                {
                    int num = int.Parse(lastRoom.Substring(1)) + 1;
                    newRoomID = "R" + num.ToString("D3");
                }

                Room newRoom = new Room
                {
                    RoomID = newRoomID,
                    RoomName = room.RoomName,
                    RoomTypeID = room.RoomTypeID,
                    Capacity = room.Capacity,
                    Description = room.Description,
                    Status = room.Status,
                    Official = room.Official
                };

                db.Rooms.InsertOnSubmit(newRoom);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi thêm phòng: " + ex.Message);
                return false;
            }
        }


        public bool removeRoom(string roomID)
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
                    roomToUpdate.Official = room.Official;
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
