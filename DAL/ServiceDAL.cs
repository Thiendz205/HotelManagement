using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class ServiceDAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable<ServiceET> getAllServices()
        {
            var services = from s in db.Services
                          select new ServiceET
                          {
                             // ServiceID = s.ServiceID,
                              ServiceName = s.ServiceName,
                              Category = s.Category,
                              Price = s.Price,
                              Description = s.Description
                          };
            return services;
        }

        public bool checkExistenceServiceName(string serviceName)
        {
            var service = db.Services.Where(x => x.ServiceName == serviceName).FirstOrDefault();
            return service == null;
        }

        public bool checkExistenceServiceName_Update(string serviceName, int currentServiceID)
        {
            //var service = db.Services.FirstOrDefault(x => x.ServiceName == serviceName && x.ServiceID != currentServiceID);
            // return service == null;
            return false; //tam
        }

        public bool addService(ServiceET service)
        {
            try
            {
                var existingService = db.Services.Where(x => x.ServiceName == service.ServiceName).FirstOrDefault();
                if (existingService == null)
                {
                    Service newService = new Service
                    {
                        ServiceName = service.ServiceName,
                        Category = service.Category,
                        Price = service.Price,
                        Description = service.Description
                    };
                    db.Services.InsertOnSubmit(newService);
                    db.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool checkServiceHasForeignKey(int serviceID)
        {
            try
            {
                // Kiểm tra xem dịch vụ có được sử dụng trong bảng ServiceUsage không
                //var serviceUsageExists = db.ServiceUsages.Any(su => su.ServiceID == serviceID);
                //if (serviceUsageExists) return true;

                return false;
            }
            catch (Exception)
            {
                return true; // Nếu có lỗi, giả sử có khóa ngoại để an toàn
            }
        }

        public bool removeService(int serviceID)
        {
            try
            {
                // Kiểm tra khóa ngoại trước khi xóa
                //if (checkServiceHasForeignKey(serviceID))
                //{
                //    return false; // Không thể xóa vì có khóa ngoại
                //}

                //Service serviceToDelete = db.Services.SingleOrDefault(s => s.ServiceID == serviceID);
                //if (serviceToDelete != null)
                //{
                //    db.Services.DeleteOnSubmit(serviceToDelete);
                //    db.SubmitChanges();
                //    return true;
                //}
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateService(ServiceET service)
        {
            try
            {
                //Service serviceToUpdate = db.Services.SingleOrDefault(s => s.ServiceID == service.ServiceID);
                //if (serviceToUpdate != null)
                //{
                //    serviceToUpdate.ServiceName = service.ServiceName;
                //    serviceToUpdate.Category = service.Category;
                //    serviceToUpdate.Price = service.Price;
                //    serviceToUpdate.Description = service.Description;
                //    db.SubmitChanges();
                //    return true;
                //}
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int generateServiceID()
        {
            try
            {
                var lastService = db.Services.OrderByDescending(s => s.ServiceID).FirstOrDefault();
                if (lastService == null)
                {
                    return 1;
                }
                else
                {
                    //return lastService.ServiceID + 1;
                    return 0;
                }
            }
            catch (Exception)
            {
                return 1;
            }
        }
    }
}
