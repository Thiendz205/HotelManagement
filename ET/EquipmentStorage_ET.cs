using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class EquipmentStorage_ET
    {        
            public EquipmentStorage_ET(string equipmentID, string equipmentName, string equipmentCategory, int quantity, DateTime purchaseDate, string status, string description, string staffID)
            {
                EquipmentID = equipmentID;
                EquipmentName = equipmentName;
                EquipmentCategory = equipmentCategory;
                Quantity = quantity;
                PurchaseDate = purchaseDate;
                Status = status;
                Description = description;
                this.staffID = staffID;
            }
            public EquipmentStorage_ET() { }

            public string EquipmentID { get; set; }
            public string EquipmentName { get; set; }
            public string EquipmentCategory { get; set; }
            public int Quantity { get; set; }
            public DateTime PurchaseDate { get; set; }
            public string Status { get; set; }
            public string Description { get; set; }
            public string staffID { get; set; }
        }

    }

