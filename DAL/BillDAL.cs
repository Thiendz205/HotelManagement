using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;

namespace DAL
{
    public class BillDAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable<BillET> getAllBills()
        {
            var bills =
                from i in db.Invoices
                join b in db.Bookings on i.BookingID equals b.BookingID
                join c in db.Customers on b.CustomerID equals c.CustomerID
                join r in db.Rooms on b.RoomID equals r.RoomID
                join s in db.Staffs on i.StaffID equals s.StaffID
                orderby i.InvoiceDate descending
                select new BillET
                {
                    InvoiceID = i.InvoiceID,
                    BookingID = i.BookingID,
                    InvoiceDate = i.InvoiceDate,
                    TotalAmount = i.TotalAmount,
                    PaymentMethod = i.PaymentMethod,
                    PaidStatus = i.PaidStatus,
                    StaffID = i.StaffID,
                    Note = i.Note,

                    CustomerName = c.FullName,
                    RoomName = r.RoomName,
                    StaffName = s.FullName,
                    CheckIn = b.CheckIn,
                    CheckOut = b.CheckOut ?? DateTime.Now,

                    // audit
                    CreatedBy = i.CreatedBy,
                    AuditStatus = i.AuditStatus,
                    AuditNote = i.AuditNote,
                    AuditedBy = i.AuditedBy,
                    AuditedAt = i.AuditedAt
                };
            return bills;
        }

        // Giữ nguyên các hàm filter nếu bạn dùng, nhớ thêm audit nếu cần hiển thị.

        public bool addBill(BillET bill)
        {
            try
            {
                // Không tự sinh InvoiceID thủ công ở đây (để IDENTITY tự chạy)
                var newInvoice = new Invoice
                {
                    BookingID = bill.BookingID,
                    InvoiceDate = bill.InvoiceDate == default ? DateTime.Now : bill.InvoiceDate,
                    TotalAmount = bill.TotalAmount,
                    PaymentMethod = bill.PaymentMethod,
                    PaidStatus = bill.PaidStatus,
                    StaffID = bill.StaffID,
                    Note = bill.Note,

                    // audit defaults
                    CreatedBy = string.IsNullOrWhiteSpace(bill.CreatedBy) ? bill.StaffID : bill.CreatedBy,
                    AuditStatus = string.IsNullOrWhiteSpace(bill.AuditStatus) ? "OK" : bill.AuditStatus,
                    AuditNote = bill.AuditNote,
                    AuditedBy = bill.AuditedBy,
                    AuditedAt = bill.AuditedAt
                };

                db.Invoices.InsertOnSubmit(newInvoice);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Chính sách: KHÔNG xóa hóa đơn
        public bool checkBillHasForeignKey(int invoiceID) => true; // ép coi như có ràng buộc để chặn xóa

        public bool removeBill(int invoiceID)
        {
            // Không cho xóa hóa đơn theo chính sách
            return false;
        }

        public bool updateBill(BillET bill)
        {
            try
            {
                var inv = db.Invoices.SingleOrDefault(i => i.InvoiceID == bill.InvoiceID);
                if (inv == null) return false;

                inv.TotalAmount = bill.TotalAmount;
                inv.PaymentMethod = bill.PaymentMethod;
                inv.PaidStatus = bill.PaidStatus;
                inv.Note = bill.Note;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // === Mới: cập nhật đánh giá/audit ===
        public bool UpdateInvoiceAudit(int invoiceId, string newStatus, string note, string adminStaffId)
        {
            try
            {
                var inv = db.Invoices.SingleOrDefault(i => i.InvoiceID == invoiceId);
                if (inv == null) return false;

                inv.AuditStatus = newStatus;
                inv.AuditNote = note;
                inv.AuditedBy = adminStaffId;
                inv.AuditedAt = DateTime.Now;

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public IQueryable<BillET> getBillsByStatus(string status)
        {
            var bills = from i in db.Invoices
                       join b in db.Bookings on i.BookingID equals b.BookingID
                       join c in db.Customers on b.CustomerID equals c.CustomerID
                       join r in db.Rooms on b.RoomID equals r.RoomID
                       join s in db.Staffs on i.StaffID equals s.StaffID
                       where i.PaidStatus == status
                       select new BillET
                       {
                           InvoiceID = i.InvoiceID,
                           BookingID = i.BookingID,
                           InvoiceDate = i.InvoiceDate,
                           TotalAmount = i.TotalAmount,
                           PaymentMethod = i.PaymentMethod,
                           PaidStatus = i.PaidStatus,
                           StaffID = i.StaffID,
                           Note = i.Note,
                           CustomerName = c.FullName,
                           RoomName = r.RoomName,
                           StaffName = s.FullName,
                           CheckIn = b.CheckIn,
                           CheckOut = b.CheckOut ?? DateTime.Now
                       };
            return bills;
        }

        public IQueryable<BillET> getBillsByDateRange(DateTime startDate, DateTime endDate)
        {
            var bills = from i in db.Invoices
                       join b in db.Bookings on i.BookingID equals b.BookingID
                       join c in db.Customers on b.CustomerID equals c.CustomerID
                       join r in db.Rooms on b.RoomID equals r.RoomID
                       join s in db.Staffs on i.StaffID equals s.StaffID
                       where i.InvoiceDate >= startDate && i.InvoiceDate <= endDate
                       select new BillET
                       {
                           InvoiceID = i.InvoiceID,
                           BookingID = i.BookingID,
                           InvoiceDate = i.InvoiceDate,
                           TotalAmount = i.TotalAmount,
                           PaymentMethod = i.PaymentMethod,
                           PaidStatus = i.PaidStatus,
                           StaffID = i.StaffID,
                           Note = i.Note,
                           CustomerName = c.FullName,
                           RoomName = r.RoomName,
                           StaffName = s.FullName,
                           CheckIn = b.CheckIn,
                           CheckOut = b.CheckOut ?? DateTime.Now
                       };
            return bills;
        }
    }
}
