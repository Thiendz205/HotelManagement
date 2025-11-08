using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class ServiceBUS
    {
        ServiceDAL serviceDAL = new ServiceDAL();

        public IQueryable<ServiceET> getAllServices()
        {
            return serviceDAL.getAllServices();
        }

        public bool addService(ServiceET service)
        {
            return serviceDAL.addService(service);
        }

        public bool checkServiceHasForeignKey(string serviceID)
        {
            return serviceDAL.checkServiceHasForeignKey(serviceID);
        }

        public bool removeService(string serviceID)
        {
            return serviceDAL.removeService(serviceID);
        }

        public bool updateService(ServiceET service)
        {
            return serviceDAL.updateService(service);
        }

        public bool checkExistenceServiceName(string serviceName)
        {
            return serviceDAL.checkExistenceServiceName(serviceName);
        }

        public bool checkExistenceServiceName_Update(string serviceName, string currentServiceID)
        {
            return serviceDAL.checkExistenceServiceName_Update(serviceName, currentServiceID);
        }

        public string generateServiceID()
        {
            return serviceDAL.generateServiceID();
        }
    }
}
