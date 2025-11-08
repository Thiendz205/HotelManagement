using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EquipmentStorage_DAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();
        public IQueryable getAllEquipment()
        {
            var equipment = from eq in db.EquipmentStorages
                            join st in db.Staffs on eq.StaffID equals st.StaffID
                            where eq.Status == "Available"
                            select new
                            {
                                eq.EquipmentID,
                                eq.EquipmentName,
                                eq.EquipmentCategory,
                                eq.Quantity,
                                eq.PurchaseDate,
                                eq.Status,
                                eq.Description,
                                eq.StaffID,
                                st.FullName
                            };
            return equipment;
        }

        public string GenerateNewEquipmentID()
        {
            // Nếu bảng trống thì trả về EQ001
            if (!db.EquipmentStorages.Any())
                return "EQ001";

            // Lấy ID lớn nhất hiện có (vd: EQ005)
            string maxID = db.EquipmentStorages
                             .OrderByDescending(x => x.EquipmentID)
                             .Select(x => x.EquipmentID)
                             .FirstOrDefault();

            // Cắt phần số ra
            int numberPart = int.Parse(maxID.Substring(2)); // bỏ "EQ"

            // +1 rồi định dạng lại đủ 3 chữ số
            string newID = "EQ" + (numberPart + 1).ToString("D3");
            return newID;
        }

        public bool addEquipment(EquipmentStorage_ET et)
        {
            try
            {
                string newID = GenerateNewEquipmentID(); // Gọi hàm sinh ID

                EquipmentStorage newItem = new EquipmentStorage
                {
                    EquipmentID = newID,
                    EquipmentName = et.EquipmentName,
                    EquipmentCategory = et.EquipmentCategory,
                    Quantity = et.Quantity,
                    PurchaseDate = et.PurchaseDate,
                    Status = et.Status,
                    Description = et.Description,
                    StaffID = et.staffID
                };  

                db.EquipmentStorages.InsertOnSubmit(newItem);
                db.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateEquipment(EquipmentStorage_ET et)
        {
            try
            {
                var existing = db.EquipmentStorages
                    .FirstOrDefault(x => x.EquipmentID == et.EquipmentID);

                if (existing == null)
                    return false;

                existing.EquipmentName = et.EquipmentName;
                existing.EquipmentCategory = et.EquipmentCategory;
                existing.Quantity = et.Quantity;
                existing.PurchaseDate = et.PurchaseDate;
                existing.Status = et.Status;
                existing.Description = et.Description;
                existing.StaffID = et.staffID;

                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        public bool deleteEquipment(string equipmentID)
        {
            try
            {
                var eq = db.EquipmentStorages.SingleOrDefault(e => e.EquipmentID == equipmentID);
                if (eq == null)
                    return false;

                db.EquipmentStorages.DeleteOnSubmit(eq);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi xóa thiết bị (DAO): " + ex.Message);
                return false;
            }
        }

    }
}
