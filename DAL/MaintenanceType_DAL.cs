using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class MaintenanceType_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();


        public IQueryable getAllMaintenanceType()
        {
            var mt = from maintenanceType in db.MaintenanceTypes
                     select new
                     {
                         maintenanceType.MaintenanceTypeID,
                         maintenanceType.TypeName,
                         maintenanceType.Description
                     };
            return mt;
        }


        public bool addMaintenanceType(MaintenanceType_ET maintenanceType_ET)
        {
            try
            {
                var typr = db.MaintenanceTypes.Where(x=>x.MaintenanceTypeID == maintenanceType_ET.MaintenanceTypeID).FirstOrDefault();
                if (typr != null)
                {
                    return false;
                }
                else
                {
                    MaintenanceType maintenanceType = new MaintenanceType()
                    {
                        MaintenanceTypeID = maintenanceType_ET.MaintenanceTypeID,
                        TypeName = maintenanceType_ET.TypeName,
                        Description = maintenanceType_ET.Description
                    };
                    db.MaintenanceTypes.InsertOnSubmit(maintenanceType);
                    db.SubmitChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
           
        
        public bool deleteMaintenanceType(int maintenanceTypeID)
        {
            try
            {
                var mt = db.MaintenanceTypes.Where(x => x.MaintenanceTypeID == maintenanceTypeID).FirstOrDefault();
                if (mt != null)
                {
                    db.MaintenanceTypes.DeleteOnSubmit(mt);
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool updateMaintenanceType(MaintenanceType_ET maintenanceType_ET)
        {
            try
            {
                var mt = db.MaintenanceTypes.Where(x => x.MaintenanceTypeID == maintenanceType_ET.MaintenanceTypeID).FirstOrDefault();
                if (mt != null)
                {
                    mt.TypeName = maintenanceType_ET.TypeName;
                    mt.Description = maintenanceType_ET.Description;
                    db.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
