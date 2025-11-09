using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class EquipmentStorage_BUS
    {
        EquipmentStorage_DAL equipmentStorage_DAL = new EquipmentStorage_DAL();
        public IQueryable getAllEquipment()
        {
            return equipmentStorage_DAL.getAllEquipment();
        }
        public bool addEquipment(EquipmentStorage_ET eq)
        {
            return equipmentStorage_DAL.addEquipment(eq);
        }
        public bool deleteEquipment(string equipmentID)
        {
            return equipmentStorage_DAL.deleteEquipment(equipmentID);
        }
        public bool updateEquipment(EquipmentStorage_ET eq)
        {
            return equipmentStorage_DAL.updateEquipment(eq);
        }

        public IQueryable getEquipmentByStatus(string status)
        {
            return equipmentStorage_DAL.getEquipmentByStatus(status);
        }

    }
}
