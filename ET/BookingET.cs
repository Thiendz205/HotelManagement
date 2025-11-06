using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class BookingET
    {
        public string BookingID { get; set; }      
        public string CustomerID { get; set; }   
        public string CustomerName { get; set; }
        public string RoomID { get; set; }
        public string CitizenID { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string RoomName { get; set; }
        public string RentalType { get; set; }
        public string RoomStatus { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string StaffID { get; set; }
        public string StaffName { get; set; }
        public string RoomTypeName { get; set; }
        public int Capacity { get; set; }           
        public string Description { get; set; }      
        public decimal PricePerDay { get; set; }     
        public decimal PricePerHour { get; set; }  
        public string Category { get; set; }
    }
}
