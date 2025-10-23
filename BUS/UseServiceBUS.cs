using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class UseServiceBUS
    {
        UseServiceDAL useServiceDAL = new UseServiceDAL();
        
        public IQueryable<UseServiceET> getAllServiceUsages()
        {
            return useServiceDAL.getAllServiceUsages();
        }
        
        public bool addServiceUsage(UseServiceET serviceUsage)
        {
            return useServiceDAL.addServiceUsage(serviceUsage);
        }
        
        public bool removeServiceUsage(int usageID)
        {
            return useServiceDAL.removeServiceUsage(usageID);
        }
        
        public bool updateServiceUsage(UseServiceET serviceUsage)
        {
            return useServiceDAL.updateServiceUsage(serviceUsage);
        }
        
        public IQueryable<ServiceET> getAllServices()
        {
            return useServiceDAL.getAllServices();
        }
        
        public IQueryable<BookingET> getAllBookings()
        {
            return useServiceDAL.getAllBookings();
        }
        
        public IQueryable getAllStaffs()
        {
            return useServiceDAL.getAllStaffs();
        }
        public IQueryable<StaffET> getServiceStaffs()
        {
            return useServiceDAL.getServiceStaffs();
        }

    }
}
