using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EquipmentStorage_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();
        public IQueryable getAllEquipment()
        {
            var equipment = from eq in db.EquipmentStorages
                            select new
                            {
                                eq.EquipmentID,
                                eq.EquipmentName,
                                eq.EquipmentCategory,
                                eq.Quantity,
                                eq.PurchaseDate,
                                eq.Status,
                                eq.Description,
                                eq.Staff
                            };
            return equipment;
        }
    }
}
