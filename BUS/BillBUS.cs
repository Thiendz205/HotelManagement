using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ET;

namespace BUS
{
    public class BillBUS
    {
        BillDAL billDAL = new BillDAL();

        public IQueryable<BillET> getAllBills() => billDAL.getAllBills();
        public bool addBill(BillET bill) => billDAL.addBill(bill);

        public bool checkBillHasForeignKey(int invoiceID) => billDAL.checkBillHasForeignKey(invoiceID);
        public bool removeBill(int invoiceID) => billDAL.removeBill(invoiceID);
        public bool updateBill(BillET bill) => billDAL.updateBill(bill);

        public IQueryable<BillET> getBillsByStatus(string status) => billDAL.getBillsByStatus(status);
        public IQueryable<BillET> getBillsByDateRange(DateTime start, DateTime end) => billDAL.getBillsByDateRange(start, end);

        // === Mới: cập nhật đánh giá/audit ===
        public bool UpdateInvoiceAudit(int invoiceId, string newStatus, string note, string adminStaffId)
            => billDAL.UpdateInvoiceAudit(invoiceId, newStatus, note, adminStaffId);

        //public IQueryable<BillET> getBillsByStatus(string status)
        //{
        //    return billDAL.getBillsByStatus(status);
        //}

        //public IQueryable<BillET> getBillsByDateRange(DateTime startDate, DateTime endDate)
        //{
        //    return billDAL.getBillsByDateRange(startDate, endDate);
        //}
    }
}
