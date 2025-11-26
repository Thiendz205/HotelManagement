using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class MaintenanceBUS
    {
        private readonly MaintenanceDAL dal = new MaintenanceDAL();

        public List<KeyValuePair<int, string>> GetMaintenanceTypes()
        {
            return dal.GetMaintenanceTypes()
                      .Select(m => new KeyValuePair<int, string>(m.MaintenanceTypeID, m.TypeName))
                      .ToList();
        }

        public List<KeyValuePair<string, string>> GetTechnicians()
        {
            return dal.GetTechnicians()
                      .Select(s => new KeyValuePair<string, string>(s.StaffID, s.FullName))
                      .ToList();
        }

        public bool CreateMaintenanceLogs(MaintenanceLogET et)
        {
            return dal.CreateMaintenanceLogs(et);
        }
    }
}
