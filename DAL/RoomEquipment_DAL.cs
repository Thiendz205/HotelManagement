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
                var equipment = db.EquipmentStorages
                                  .FirstOrDefault(e => e.EquipmentID == roomEquipment.EquipmentStorage);
                if (equipment == null)
                    throw new Exception("Thiết bị không tồn tại trong kho!");

                if (equipment.Quantity < roomEquipment.Quantity)
                    throw new Exception("Số lượng trong kho không đủ!");

                equipment.Quantity -= roomEquipment.Quantity;

                string newID = GenerateNewID();

                RoomEquipment newItem = new RoomEquipment
                {
                    RoomEquipmentID = newID,
                    RoomID = roomEquipment.RoomID,
                    EquipmentStorage = roomEquipment.EquipmentStorage,
                    Quantity = roomEquipment.Quantity,
                    InstalledDate = roomEquipment.InstalledDate,
                    Condition = roomEquipment.Condition,
                    Note = roomEquipment.Note,
                    StaffID = roomEquipment.StaffID
                };

                db.RoomEquipments.InsertOnSubmit(newItem);
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
            var last = db.RoomEquipments
                         .OrderByDescending(x => x.RoomEquipmentID)
                         .FirstOrDefault();

            if (last == null)
                return "REQ001";

            int num = int.Parse(last.RoomEquipmentID.Substring(3)) + 1;
            return "REQ" + num.ToString("D3");
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
                    eqStorage.Quantity += roomEq.Quantity; 
                }

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
                var oldData = db.RoomEquipments.FirstOrDefault(x => x.RoomEquipmentID == et.RoomEquipmentID);
                if (oldData == null)
                    return false;

                if (oldData.EquipmentStorage != et.EquipmentStorage)
                {
                    var oldStorage = db.EquipmentStorages.FirstOrDefault(x => x.EquipmentID == oldData.EquipmentStorage);
                    if (oldStorage != null)
                        oldStorage.Quantity += oldData.Quantity;

                    var newStorage = db.EquipmentStorages.FirstOrDefault(x => x.EquipmentID == et.EquipmentStorage);
                    if (newStorage == null || newStorage.Quantity < et.Quantity)
                        return false; 
                    newStorage.Quantity -= et.Quantity;

                    oldData.EquipmentStorage = et.EquipmentStorage;
                    oldData.Quantity = et.Quantity;
                }
                else
                {
                    int diff = et.Quantity - oldData.Quantity;
                    var storage = db.EquipmentStorages.FirstOrDefault(x => x.EquipmentID == oldData.EquipmentStorage);

                    if (storage == null)
                        return false;

                    if (diff > 0)
                    {
                        if (storage.Quantity < diff)
                            return false; 
                        storage.Quantity -= diff;
                    }
                    else if (diff < 0)
                    {
                        storage.Quantity += Math.Abs(diff);
                    }

                    oldData.Quantity = et.Quantity;
                }

                oldData.RoomID = et.RoomID;
                oldData.InstalledDate = et.InstalledDate;
                oldData.Condition = et.Condition;
                oldData.Note = et.Note;
                oldData.StaffID = et.StaffID;

                db.SubmitChanges();
                return true;
            }
            catch
            {
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

    }
}
