﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class Room_Type_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable getAllRoomTypes()
        {
            var roomTypes = from rt in db.RoomTypes
                            select new
                            {
                                rt.RoomTypeID,
                                rt.TypeName,
                                rt.PricePerDay,
                                rt.PricePerHour,
                                rt.Category,
                                rt.Description
                            };
            return roomTypes;
        }

        public bool addRoomType(Room_Type_ET room_Type_ET)
        {
            try
            {
                RoomType newRoomType = new RoomType
                {
                    TypeName = room_Type_ET.TypeName,
                    PricePerDay = room_Type_ET.PricePerDay,
                    PricePerHour = room_Type_ET.PricePerHour,
                    Category = room_Type_ET.Category,
                    Description = room_Type_ET.Description
                };
                db.RoomTypes.InsertOnSubmit(newRoomType);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool removeRoomType(int roomTypeID)
        {
            try
            {
                using (var dbs = new HotelManagementDataContext()) {
                    // tạo context mới cho mỗi thao tác
                    var roomType = dbs.RoomTypes.FirstOrDefault(rt => rt.RoomTypeID == roomTypeID);
                    if (roomType != null)
                    {
                        dbs.RoomTypes.DeleteOnSubmit(roomType);
                        dbs.SubmitChanges();
                        return true;
                    }
                    return false;

                } 
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateRoomType(Room_Type_ET room_Type_ET)
        {
            try
            {
                var roomType = db.RoomTypes.SingleOrDefault(rt => rt.RoomTypeID == room_Type_ET.RoomTypeID);
                if (roomType != null)
                {
                    roomType.TypeName = room_Type_ET.TypeName;
                    roomType.PricePerDay = room_Type_ET.PricePerDay;
                    roomType.PricePerHour = room_Type_ET.PricePerHour;
                    roomType.Category = room_Type_ET.Category;
                    roomType.Description = room_Type_ET.Description;
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

        public bool checkExistenceNameRoomType(string name, string category)
        {
            var typeName = db.RoomTypes.Where(x => x.TypeName == name && x.Category == category).FirstOrDefault(); 
            if (typeName == null)
            {
                return true;
            }
            return false;
        }

        public bool checkExistenceNameRoomType_UPDate(string name, int currentRoomID)
        {
            var typeName = db.RoomTypes.FirstOrDefault(x => x.TypeName == name && x.RoomTypeID != currentRoomID);
            return typeName != null;
        }
    }
}
