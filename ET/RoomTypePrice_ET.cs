using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class RoomTypePrice_ET
    {
        public RoomTypePrice_ET(int priceID, string roomTypeID, DateTime startDate, DateTime endDate, decimal pricePerDay, decimal pricePerHour, string note)
        {
            PriceID = priceID;
            RoomTypeID = roomTypeID;
            StartDate = startDate;
            EndDate = endDate;
            PricePerDay = pricePerDay;
            PricePerHour = pricePerHour;
            Note = note;
        }

        public RoomTypePrice_ET()
        {
        }

        public int PriceID { get; set; }
        public string RoomTypeID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PricePerHour { get; set; }
        public string Note { get; set; }



    }
}
