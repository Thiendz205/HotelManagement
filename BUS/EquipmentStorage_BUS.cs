using DAL;
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

    }
}
