using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class Room_Type_ET
    {
        public Room_Type_ET() { }

        public Room_Type_ET(int roomTypeID, string typeName, decimal pricePerDay, decimal pricePerHour, string category, string description)
        {
            RoomTypeID = roomTypeID;
            TypeName = typeName;
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
            Category = category;
            Description = description;
        }

        public int RoomTypeID { get; set; }
        public string TypeName { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PricePerHour { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }


    }
}
