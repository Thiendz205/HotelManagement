    using ET;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace DAL
    {
        public class MaintenanceDAL
        {
        private HotelManagementDataContext db = new HotelManagementDataContext();

        // Load danh sách nhân viên kỹ thuật
        public List<Staff> GetTechnicians()
        {
            return db.Staffs.Where(s => s.Role == "Kỹ thuật").ToList();
        }

        // Load loại bảo trì
        public List<MaintenanceType> GetMaintenanceTypes()
        {
            return db.MaintenanceTypes.ToList();
        }

        // Tạo log bảo trì phòng
        public bool CreateMaintenanceLogs(MaintenanceLogET et)
        {
            db = new HotelManagementDataContext(); // luôn tạo mới để tránh connection cũ bị đóng

            db.Connection.Open(); // ⭐ MUST: mở kết nối trước

            using (var transaction = db.Connection.BeginTransaction())
            {
                db.Transaction = transaction;

                try
                {
                    foreach (var roomId in et.RoomIDs)
                    {
                        var room = db.Rooms.SingleOrDefault(r => r.RoomID == roomId);
                        if (room != null)
                        {
                            room.Status = "Bảo trì";
                        }

                        db.MaintenanceLogs.InsertOnSubmit(new MaintenanceLog
                        {
                            MaintenanceTypeID = et.MaintenanceTypeID,
                            RoomID = roomId,
                            RoomEquipment = null,
                            StaffID = et.StaffID,
                            MaintenanceDate = et.MaintenanceDate,
                            Status = et.Status,
                            Note = et.Note
                        });
                    }

                    db.SubmitChanges();
                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    db.Connection.Close();  // đóng kết nối
                }
            }
        }

    }
}
