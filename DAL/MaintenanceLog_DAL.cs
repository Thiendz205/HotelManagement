using ET;
using System;
using System.Linq;

namespace DAL
{
    public class MaintenanceLog_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable getAllMaintenanceLogs()
        {
            var logs =
        from log in db.MaintenanceLogs
        join re in db.RoomEquipments
            on log.RoomEquipmentID equals re.RoomEquipmentID into reJoin
        from re in reJoin.DefaultIfEmpty()   // LEFT JOIN
        join eq in db.EquipmentStorages
            on re.EquipmentStorage equals eq.EquipmentID into eqJoin
        from eq in eqJoin.DefaultIfEmpty()
        select new
        {
            log.LogID,
            log.MaintenanceTypeID,
            log.RoomID,
            log.RoomEquipmentID,

            // ⭐ CỘT BẠN MUỐN HIỂN THỊ
            EquipmentID = eq != null ? eq.EquipmentID : null,
            EquipmentName = eq != null ? eq.EquipmentName : null,

            log.StaffID,
            log.MaintenanceDate,
            log.Status,
            log.Note
        };

            return logs;
        }

        public bool AddLog(MaintenanceLog_ET et)
        {
            try
            {
                MaintenanceLog log = new MaintenanceLog
                {
                    MaintenanceTypeID = et.MaintenanceTypeID,
                    RoomID = et.RoomID,
                    RoomEquipmentID = et.RoomEquipmentID, // NEW ✔
                    StaffID = et.StaffID,
                    MaintenanceDate = et.MaintenanceDate,
                    Status = et.Status,
                    Note = et.Note
                };

                db.MaintenanceLogs.InsertOnSubmit(log);
                db.SubmitChanges();
                return true;
            }
            catch { return false; }
        }



        public bool DeleteMaintenanceLog(int logID, out string message)
        {
            message = "";

            try
            {
                var log = db.MaintenanceLogs.FirstOrDefault(x => x.LogID == logID);
                if (log == null)
                {
                    message = "Log không tồn tại!";
                    return false;
                }

                // ❌ Không được xóa log đã hoàn tất
                if (log.Status != "Not completed")
                {
                    message = "Chỉ được xóa log có trạng thái 'Not completed'!";
                    return false;
                }

                string roomID = log.RoomID;
                string roomEquipID = log.RoomEquipmentID;

                // ============================================================
                // 1) XỬ LÝ LOG PHÒNG
                // ============================================================
                if (log.MaintenanceTypeID == 1 && roomID != null)
                {
                    // check phòng còn thiết bị đang bảo trì không
                    bool hasDeviceMaintenance = db.RoomEquipments.Any(x =>
                        x.RoomID == roomID && x.Condition == "Maintenance");

                    if (hasDeviceMaintenance)
                    {
                        message = "Không thể xóa log phòng vì trong phòng vẫn còn thiết bị đang bảo trì!";
                        return false;
                    }
                }

                // ============================================================
                // 2) XỬ LÝ LOG THIẾT BỊ
                // ============================================================
                if (log.MaintenanceTypeID == 2 && roomEquipID != null)
                {
                    // Trả thiết bị về Good
                    var re = db.RoomEquipments.FirstOrDefault(x => x.RoomEquipmentID == roomEquipID);
                    if (re != null)
                    {
                        re.Condition = "Good";
                    }
                }

                // ============================================================
                // 3) TIẾN HÀNH XÓA LOG
                // ============================================================
                db.MaintenanceLogs.DeleteOnSubmit(log);
                db.SubmitChanges();

                // ============================================================
                // 4) CẬP NHẬT TRẠNG THÁI PHÒNG
                // ============================================================
                if (roomID != null)
                {
                    bool stillDeviceMaintenance = db.RoomEquipments.Any(x =>
                        x.RoomID == roomID && x.Condition == "Maintenance");

                    bool stillRoomLogs = db.MaintenanceLogs.Any(x =>
                        x.RoomID == roomID &&
                        x.MaintenanceTypeID == 1 &&
                        x.Status == "Not completed");

                    // nếu không còn gì pending → chuyển về Trống
                    if (!stillDeviceMaintenance && !stillRoomLogs)
                    {
                        var room = db.Rooms.FirstOrDefault(r => r.RoomID == roomID);
                        if (room != null)
                            room.Status = "Trống";

                        db.SubmitChanges();
                    }
                }

                message = "Xóa thành công!";
                return true;
            }
            catch (Exception ex)
            {
                message = "Lỗi DeleteMaintenanceLog: " + ex.Message;
                return false;
            }
        }


        public void CheckAndUpdateRoomStatus(string roomID)
        {
            var room = db.Rooms.FirstOrDefault(x => x.RoomID == roomID);
            if (room == null) return;

            // 🚫 Nếu phòng đã OutOfOrder thì KHÔNG được sửa trạng thái nữa
            if (room.Status == "Ngừng hoạt động")
                return;

            bool hasMaintenanceEquip = db.RoomEquipments
                .Any(x => x.RoomID == roomID && x.Condition == "Maintenance");

            bool hasBrokenEquip = db.RoomEquipments
                .Any(x => x.RoomID == roomID && x.Condition == "Broken");

            bool hasPendingRoomLogs = db.MaintenanceLogs
                .Any(x => x.RoomID == roomID &&
                          x.MaintenanceTypeID == 1 &&
                          x.Status == "Not completed");

            // ⭐ Nếu có thiết bị hỏng → chuyển sang Ngưng hoạt động
            if (hasBrokenEquip)
            {
                room.Status = "Ngừng hoạt động";
                db.SubmitChanges();
                return;
            }

            // ⭐ Nếu còn thiết bị bảo trì hoặc còn log → giữ Maintenance
            if (hasMaintenanceEquip || hasPendingRoomLogs)
            {
                room.Status = "Bảo trì";
                db.SubmitChanges();
                return;
            }

            // ⭐ Ngược lại → Trống
            room.Status = "Trống";
            db.SubmitChanges();
        }



        public IQueryable getNameAndIDMaintenanceTypes()
        {
            var types = from type in db.MaintenanceTypes
                        select new
                        {
                            type.MaintenanceTypeID,
                            type.TypeName
                        };
            return types;
        }


        public bool UpdateMaintenanceResult(int logID, string result, out string message)
        {
            message = "";

            try
            {
                var log = db.MaintenanceLogs.FirstOrDefault(x => x.LogID == logID);
                if (log == null)
                {
                    message = "Không tìm thấy log!";
                    return false;
                }

                if (log.Status == "Completed" || log.Status == "Failed")
                {
                    message = "Log đã hoàn tất, không thể cập nhật!";
                    return false;
                }

                log.Status = result;

                // ===============================
                // 1) BẢO TRÌ THIẾT BỊ
                // ===============================
                if (log.MaintenanceTypeID == 2 && log.RoomEquipmentID != null)
                {
                    var req = db.RoomEquipments
                                .FirstOrDefault(x => x.RoomEquipmentID == log.RoomEquipmentID);

                    if (req != null)
                    {
                        if (result == "Completed")
                        {
                            req.Condition = "Good";
                        }
                        else if (result == "Failed")
                        {
                            req.Condition = "Broken"; // KHÔNG XOÁ
                        }
                    }
                }

                // ===============================
                // 2) BẢO TRÌ PHÒNG
                // ===============================
                if (log.MaintenanceTypeID == 1 && log.RoomID != null)
                {
                    var room = db.Rooms.FirstOrDefault(r => r.RoomID == log.RoomID);

                    if (room != null)
                    {
                        if (result == "Completed")
                        {
                            bool stillDeviceMaintenance =
                                db.RoomEquipments.Any(x =>
                                    x.RoomID == room.RoomID &&
                                    x.Condition == "Maintenance");

                            if (stillDeviceMaintenance)
                            {
                                message = "Phòng vẫn còn thiết bị đang bảo trì — không thể hoàn tất!";
                                return false;
                            }

                            bool stillRoomLogs =
                                db.MaintenanceLogs.Any(x =>
                                    x.RoomID == room.RoomID &&
                                    x.MaintenanceTypeID == 1 &&
                                    x.Status == "Not completed" &&
                                    x.LogID != logID);

                            if (stillRoomLogs)
                            {
                                message = "Phòng vẫn còn bảo trì chưa hoàn tất — không thể hoàn tất!";
                                return false;
                            }

                            room.Status = "Trống";
                        }
                        else if (result == "Failed")
                        {
                            room.Status = "Ngừng hoạt động";
                        }
                    }
                }

                db.SubmitChanges();

                if (log.RoomID != null)
                    CheckAndUpdateRoomStatus(log.RoomID);

                return true;
            }
            catch (Exception ex)
            {
                message = "Lỗi hệ thống: " + ex.Message;
                return false;
            }
        }

    }
}
