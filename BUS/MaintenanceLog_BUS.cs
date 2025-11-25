using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class MaintenanceLog_BUS
    {
        MaintenanceLog_DAL maintenanceLog_DAL = new MaintenanceLog_DAL();
        public IQueryable getAllMaintenanceLogs()
        {
            return maintenanceLog_DAL.getAllMaintenanceLogs();
        }

        public bool AddLog(MaintenanceLog_ET log)
        {
            return maintenanceLog_DAL.AddLog(log);
        }
        public bool DeleteMaintenanceLog(int logID, out string message)
        {
            return maintenanceLog_DAL.DeleteMaintenanceLog(logID, out message);
        }
        public IQueryable getNameAndIDMaintenanceTypes()
        {
            return maintenanceLog_DAL.getNameAndIDMaintenanceTypes();
        }
        public bool UpdateMaintenanceResult(int logID, string result, out string message)
        {
            return maintenanceLog_DAL.UpdateMaintenanceResult(logID, result, out message);
        }


    }
}
