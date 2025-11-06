using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomTypePrice_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable getAllRoomTypePrices()
        {
            var roomTypePrices = from rtp in db.RoomTypePrices
                                 join rt in db.RoomTypes on rtp.RoomTypeID equals rt.RoomTypeID
                                 select new
                                 {
                                     rtp.PriceID,
                                     rt.RoomTypeID,
                                     rt.TypeName,
                                     rtp.StartDate,
                                     rtp.EndDate,
                                     rtp.PricePerDay,
                                     rtp.PricePerHour,
                                     rtp.Note
                                 };
            return roomTypePrices;
        }

        public bool IsOverlap(RoomTypePrice_ET et)
        {
            return db.RoomTypePrices.Any(p =>
                p.RoomTypeID == et.RoomTypeID &&
                (
                    (et.StartDate >= p.StartDate && et.StartDate <= p.EndDate) ||
                    (et.EndDate >= p.StartDate && et.EndDate <= p.EndDate) ||
                    (et.StartDate <= p.StartDate && et.EndDate >= p.EndDate)
                )
            );
        }


        public bool AddRoomTypePrice(RoomTypePrice_ET et)
        {
            try
            {
                RoomTypePrice newItem = new RoomTypePrice
                {
                    RoomTypeID = et.RoomTypeID,
                    StartDate = et.StartDate,
                    EndDate = et.EndDate,
                    PricePerDay = et.PricePerDay,
                    PricePerHour = et.PricePerHour,
                    Note = et.Note
                };

                db.RoomTypePrices.InsertOnSubmit(newItem);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IQueryable<Room_Type_ET> getNameIDRoom()
        {
            var rooms = from r in db.RoomTypes
                        select new Room_Type_ET
                        {
                            RoomTypeID = r.RoomTypeID,
                             TypeName= r.TypeName
                        };
            return rooms;
        }

        public bool DeleteRoomTypePrice(int priceID)
        {
            try
            {
                var item = db.RoomTypePrices.FirstOrDefault(p => p.PriceID == priceID);
                if (item != null)
                {
                    db.RoomTypePrices.DeleteOnSubmit(item);
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

        public bool CheckOverlapForUpdate(RoomTypePrice_ET et)
        {
            
            return db.RoomTypePrices.Any(p =>
                p.RoomTypeID == et.RoomTypeID &&
                p.PriceID != et.PriceID && 
                (
                    (et.StartDate >= p.StartDate && et.StartDate <= p.EndDate) ||
                    (et.EndDate >= p.StartDate && et.EndDate <= p.EndDate) ||
                    (et.StartDate <= p.StartDate && et.EndDate >= p.EndDate)
                )
            );
        }


        public bool Update(RoomTypePrice_ET et)
        {
            var existing = db.RoomTypePrices.FirstOrDefault(p => p.PriceID == et.PriceID);
            if (existing == null)
                return false;

            existing.RoomTypeID = et.RoomTypeID;
            existing.StartDate = et.StartDate;
            existing.EndDate = et.EndDate;
            existing.PricePerDay = et.PricePerDay;
            existing.PricePerHour = et.PricePerHour;
            existing.Note = et.Note;

            db.SubmitChanges();
            return true;
        }


        public int RemoveExpiredPrices()
        {
            var allList = db.RoomTypePrices.ToList();
            DateTime today = DateTime.Today; 

            var expiredList = allList
                .Where(p => p.EndDate < today)
                .ToList();

            if (expiredList.Count == 0)
                return 0;

            db.RoomTypePrices.DeleteAllOnSubmit(expiredList);
            db.SubmitChanges();

            return expiredList.Count;
        }
    }

}
