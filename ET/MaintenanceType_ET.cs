using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class MaintenanceType_ET
    {
        public int MaintenanceTypeID { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public MaintenanceType_ET() { }
        public MaintenanceType_ET(int maintenanceTypeID, string typeName, string description)
        {
            MaintenanceTypeID = maintenanceTypeID;
            TypeName = typeName;
            Description = description;
        }
    }
}
