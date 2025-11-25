using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class MaintenanceType_BUS
    {
        MaintenanceType_DAL maintenanceType_DAL = new MaintenanceType_DAL();
        public IQueryable getAllMaintenanceType()
        {
            return maintenanceType_DAL.getAllMaintenanceType();
        }
        public bool addMaintenanceType(MaintenanceType_ET maintenanceType_ET)
        {
            return maintenanceType_DAL.addMaintenanceType(maintenanceType_ET);
        }

        public bool deleteMaintenanceType(int maintenanceTypeID)
        {
            return maintenanceType_DAL.deleteMaintenanceType(maintenanceTypeID);
        }
        public bool updateMaintenanceType(MaintenanceType_ET maintenanceType_ET)
        {
            return maintenanceType_DAL.updateMaintenanceType(maintenanceType_ET);
        }
       

    }
}
