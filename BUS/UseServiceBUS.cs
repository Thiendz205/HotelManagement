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

        public bool removeServiceUsage(string usageID)
        {
            return useServiceDAL.removeServiceUsage(usageID);
        }

        public string generateUsageID()
        {
            return useServiceDAL.generateUsageID();
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
    //    public IQueryable<UseServiceET> Search(string bookingId = null, DateTime? from = null, DateTime? to = null)
    //        => useServiceDAL.GetAll(bookingId, from, to);

    //    public string Add(UseServiceET et)
    //    {
    //        if (string.IsNullOrWhiteSpace(et.BookingID)) throw new Exception("Chọn Booking.");
    //        if (string.IsNullOrWhiteSpace(et.ServiceID)) throw new Exception("Chọn Dịch vụ.");
    //        if (string.IsNullOrWhiteSpace(et.StaffID)) throw new Exception("Thiếu StaffID.");
    //        if (et.Quantity <= 0) throw new Exception("Số lượng > 0.");

    //        if (et.UsageDate == default) et.UsageDate = DateTime.Now;
    //        return useServiceDAL.Insert(et);
    //    }

    //    public void Update(UseServiceET et)
    //    {
    //        if (et.Quantity <= 0) throw new Exception("Số lượng > 0.");
    //        useServiceDAL.Update(et);
    //    }

    //    public void Delete(string usageId) => useServiceDAL.Delete(usageId);

    //    // Nguồn cho combobox
    //    public IQueryable<(string Id, string Display)> GetBookingOptions() => useServiceDAL.GetActiveBookingsForSelect();
    //    public IQueryable<(string Id, string Name, decimal Price)> GetServiceOptions() => useServiceDAL.GetServicesForSelect();
    }
}
