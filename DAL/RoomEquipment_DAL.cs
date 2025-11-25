using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomEquipment_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        public IQueryable getAllRoomEquipment()
        {
            var roomEquipments = from re in db.RoomEquipments
                                 join st in db.Staffs on re.StaffID equals st.StaffID
                                 select new
                                 {
                                     re.RoomEquipmentID,
                                     re.RoomID,
                                     re.EquipmentStorage,
                                     re.Quantity,
                                     re.InstalledDate,
                                     re.Condition,
                                     re.Note,
                                     st.StaffID
                                 };
            return roomEquipments;
        }

        public IQueryable<EquipmentStorage_ET> getEquipmentNameAndID()
        {
            var Equipment = db.EquipmentStorages
                 .GroupBy(eq => eq.EquipmentName)
                 .Select(g => new EquipmentStorage_ET
                 {
                      EquipmentID = g.FirstOrDefault().EquipmentID,
                      EquipmentName = g.Key
                 });

            return Equipment;

        }

        public bool AddRoomEquipment(RoomEquipment_ET roomEquipment)
        {
            try
            {
                var storage = db.EquipmentStorages
                                .FirstOrDefault(x => x.EquipmentID == roomEquipment.EquipmentStorage);

                if (storage == null)
                    throw new Exception("Thiết bị không tồn tại!");

                if (storage.Quantity < roomEquipment.Quantity)
                    throw new Exception("Số lượng trong kho không đủ!");

                // ✔ Lấy ID lớn nhất ngoài database chỉ 1 lần
                string lastID = db.RoomEquipments
                                  .OrderByDescending(x => x.RoomEquipmentID)
                                  .Select(x => x.RoomEquipmentID)
                                  .FirstOrDefault() ?? "REQ000";

                int lastNum = int.Parse(lastID.Substring(3));

                // ✔ Tạo list để giữ ID đã tạo trong batch
                HashSet<string> usedIDs = new HashSet<string>();

                for (int i = 0; i < roomEquipment.Quantity; i++)
                {
                    lastNum++;
                    string newID = "REQ" + lastNum.ToString("D3");

                    // Dự phòng trường hợp cực hiếm bị trùng
                    while (db.RoomEquipments.Any(x => x.RoomEquipmentID == newID) || usedIDs.Contains(newID))
                    {
                        lastNum++;
                        newID = "REQ" + lastNum.ToString("D3");
                    }

                    usedIDs.Add(newID);

                    RoomEquipment item = new RoomEquipment
                    {
                        RoomEquipmentID = newID,
                        RoomID = roomEquipment.RoomID,
                        EquipmentStorage = roomEquipment.EquipmentStorage,
                        Quantity = 1,
                        InstalledDate = roomEquipment.InstalledDate,
                        Condition = "Good",
                        Note = roomEquipment.Note,
                        StaffID = roomEquipment.StaffID
                    };

                    db.RoomEquipments.InsertOnSubmit(item);

                    storage.Quantity -= 1;
                }

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private string GenerateNewID()
        {
            // Lấy ID cao nhất hiện tại
            var lastID = db.RoomEquipments
                           .OrderByDescending(x => x.RoomEquipmentID)
                           .Select(x => x.RoomEquipmentID)
                           .FirstOrDefault();

            if (lastID == null)
                return "REQ001";

            int number = int.Parse(lastID.Substring(3));
            number++;

            return "REQ" + number.ToString("D3");
        }


        public IQueryable<Room_ET> getIDNameRoom()
        {
            var room = from r in db.Rooms
                       select new Room_ET
                       {
                           RoomID = r.RoomID,
                           RoomName = r.RoomName
                       };
            return room;
        }

        public bool RemoveRoomEquipment(string roomEquipmentID)
        {
            try
            {
                var roomEq = db.RoomEquipments.FirstOrDefault(x => x.RoomEquipmentID == roomEquipmentID);
                if (roomEq == null)
                    return false;

                var eqStorage = db.EquipmentStorages.FirstOrDefault(x => x.EquipmentID == roomEq.EquipmentStorage);
                if (eqStorage != null)
                {
                    // Trả số lượng về kho
                    eqStorage.Quantity += roomEq.Quantity;

                    if (eqStorage.Quantity > 0)
                    {
                        eqStorage.Status = "Available"; 
                    }
                }

                // Xóa bản ghi thiết bị gắn với phòng
                db.RoomEquipments.DeleteOnSubmit(roomEq);

                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateRoomEquipment(RoomEquipment_ET et)
        {
            try
            {
                var oldData = db.RoomEquipments
                    .FirstOrDefault(x => x.RoomEquipmentID == et.RoomEquipmentID);

                if (oldData == null)
                    return false;

                string oldCondition = oldData.Condition;

                // =====================================================
                // 1) Xử lý đổi thiết bị (EquipmentStorage)
                // =====================================================
                if (oldData.EquipmentStorage != et.EquipmentStorage)
                {
                    var oldStorage = db.EquipmentStorages
                        .FirstOrDefault(x => x.EquipmentID == oldData.EquipmentStorage);

                    if (oldStorage != null)
                        oldStorage.Quantity += oldData.Quantity;

                    var newStorage = db.EquipmentStorages
                        .FirstOrDefault(x => x.EquipmentID == et.EquipmentStorage);

                    if (newStorage == null || newStorage.Quantity < et.Quantity)
                        return false;

                    newStorage.Quantity -= et.Quantity;

                    oldData.EquipmentStorage = et.EquipmentStorage;
                    oldData.Quantity = et.Quantity;
                }
                else
                {
                    // ========== xử lý quantity ==========
                    int diff = et.Quantity - oldData.Quantity;

                    var storage = db.EquipmentStorages
                        .FirstOrDefault(x => x.EquipmentID == oldData.EquipmentStorage);

                    if (storage == null) return false;

                    if (diff > 0)
                    {
                        if (storage.Quantity < diff) return false;
                        storage.Quantity -= diff;
                    }
                    else if (diff < 0)
                    {
                        storage.Quantity += Math.Abs(diff);
                    }

                    oldData.Quantity = et.Quantity;
                }

                // =====================================================
                // 2) Update dữ liệu chung
                // =====================================================
                oldData.RoomID = et.RoomID;
                oldData.InstalledDate = et.InstalledDate;
                oldData.Note = et.Note;
                oldData.StaffID = et.StaffID;

                // =====================================================
                // ⭐ 3) CHUYỂN SANG GOOD
                // =====================================================
                if (et.Condition == "Good")
                {
                    // ❗ kiểm tra log theo ROOMEQUIPMENTID, không phải EquipmentID
                    bool hasDeviceLog = db.MaintenanceLogs.Any(x =>
                        x.RoomEquipmentID == et.RoomEquipmentID &&
                        x.MaintenanceTypeID == 2 &&
                        x.Status == "Not completed"
                    );

                    if (hasDeviceLog)
                        return false;

                    oldData.Condition = "Good";

                    // Kiểm tra còn thiết bị nào Maintenance không
                    bool stillHasMaintenance = db.RoomEquipments.Any(x =>
                        x.RoomID == et.RoomID &&
                        x.Condition == "Maintenance"
                    );

                    // Nếu không → phòng về Trống
                    if (!stillHasMaintenance)
                    {
                        var room = db.Rooms.FirstOrDefault(r => r.RoomID == et.RoomID);
                        if (room != null)
                            room.Status = "Trống";

                        // Các log phòng chưa hoàn thành → Completed
                        var roomLogs = db.MaintenanceLogs.Where(x =>
                            x.RoomID == et.RoomID &&
                            x.MaintenanceTypeID == 1 &&
                            x.Status == "Not completed"
                        );

                        foreach (var log in roomLogs)
                            log.Status = "Completed";
                    }
                }

                // =====================================================
                // ⭐ 4) CHUYỂN SANG MAINTENANCE
                // =====================================================
                else if (et.Condition == "Maintenance")
                {
                    if (oldCondition != "Maintenance")
                    {
                        // Phòng chuyển sang bảo trì
                        var room = db.Rooms.FirstOrDefault(r => r.RoomID == et.RoomID);
                        if (room != null)
                            room.Status = "Maintenance";

                        // 1) Log thiết bị riêng theo RoomEquipmentID
                        db.MaintenanceLogs.InsertOnSubmit(new MaintenanceLog
                        {
                            MaintenanceTypeID = 2,
                            RoomID = null,
                            RoomEquipmentID = et.RoomEquipmentID,
                            StaffID = et.StaffID,
                            MaintenanceDate = DateTime.Now,
                            Status = "Not completed",
                            Note = "Thiết bị chuyển sang bảo trì"
                        });

                        // 2) Log phòng
                        db.MaintenanceLogs.InsertOnSubmit(new MaintenanceLog
                        {
                            MaintenanceTypeID = 1,
                            RoomID = et.RoomID,
                            RoomEquipmentID = null,
                            StaffID = et.StaffID,
                            MaintenanceDate = DateTime.Now,
                            Status = "Not completed",
                            Note = "Phòng chuyển sang bảo trì do thiết bị " + et.RoomEquipmentID
                        });
                    }

                    oldData.Condition = "Maintenance";
                }

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi UpdateRoomEquipment: " + ex.Message);
                return false;
            }
        }

        public bool UpdateStatusRoom(string roomID)
        {
            try
            {
                var room = db.Rooms.FirstOrDefault(x => x.RoomID == roomID);

                if (room != null)
                {
                    if (room.Status == "Mới tạo")
                    {
                        room.Status = "Trống";
                        db.SubmitChanges();
                        return true;
                    }
                }

                return false; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi cập nhật trạng thái phòng: " + ex.Message);
                return false;
            }
        }
        public bool SetRoomMaintenanceByEquipment(string roomEquipmentID)
        {
            try
            {
                var re = db.RoomEquipments.FirstOrDefault(x => x.RoomEquipmentID == roomEquipmentID);
                if (re == null) return false;

                var room = db.Rooms.FirstOrDefault(x => x.RoomID == re.RoomID);
                if (room == null) return false;

                room.Status = "Maintenance"; 
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
