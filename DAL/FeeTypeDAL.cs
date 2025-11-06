using ET;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace DAL
{
    public class FeeTypeDAL
    {
        private readonly HotelManagementDataContext db = new HotelManagementDataContext();

        public List<FeeTypeET> GetAllFeeTypes()
        {
            return db.FeeTypes
                     .Select(ft => new FeeTypeET
                     {
                         FeeTypeID = ft.FeeTypeID,
                         FeeTypeName = ft.FeeTypeName,
                         Category = ft.Category,
                         DefaultPrice = ft.DefaultPrice,
                         Notes = ft.Notes
                     }).ToList();
        }

        public bool IsFeeTypeNameExists(string name, string excludeId = null)
        {
            var q = db.FeeTypes.Where(f => f.FeeTypeName == name);
            if (!string.IsNullOrEmpty(excludeId))
                q = q.Where(f => f.FeeTypeID != excludeId);
            return q.Any();
        }

        // 🔹 Hàm sinh mã tự động: F001, F002, ...
        private string GenerateNewFeeTypeID()
        {
            // Lấy ID cuối cùng theo thứ tự giảm dần
            var lastId = db.FeeTypes
                           .OrderByDescending(f => f.FeeTypeID)
                           .Select(f => f.FeeTypeID)
                           .FirstOrDefault();

            if (string.IsNullOrEmpty(lastId))
                return "F001"; // nếu chưa có dữ liệu
            string numericPart = lastId.Substring(1); // bỏ ký tự 'F'
            if (int.TryParse(numericPart, out int num))
            {
                num++;
                return "F" + num.ToString("D3"); 
            }

            // Trường hợp bất thường → fallback
            return "F001";
        }

        public string AddFeeType(FeeTypeET et)
        {
            // Nếu chưa có ID thì tự sinh
            if (string.IsNullOrEmpty(et.FeeTypeID))
                et.FeeTypeID = GenerateNewFeeTypeID();

            var ft = new FeeType
            {
                FeeTypeID = et.FeeTypeID,
                FeeTypeName = et.FeeTypeName,
                Category = et.Category,
                DefaultPrice = et.DefaultPrice,
                Notes = et.Notes
            };
            db.FeeTypes.InsertOnSubmit(ft);
            db.SubmitChanges();
            return ft.FeeTypeID;
        }
        public bool IsFeeTypeIdExists(string feeTypeId)
        {
            return db.FeeTypes.Any(f => f.FeeTypeID == feeTypeId);
        }

        public bool UpdateFeeType(FeeTypeET et)
        {
            var ft = db.FeeTypes.FirstOrDefault(f => f.FeeTypeID == et.FeeTypeID);
            if (ft == null) return false;
            ft.FeeTypeName = et.FeeTypeName;
            ft.Category = et.Category;
            ft.DefaultPrice = et.DefaultPrice;
            ft.Notes = et.Notes;
            db.SubmitChanges();
            return true;
        }

        public bool CanDeleteFeeType(string feeTypeId)
        {
            return !db.BookingFees.Any(bf => bf.FeeTypeID == feeTypeId);
        }

        public bool DeleteFeeType(string feeTypeId)
        {
            var ft = db.FeeTypes.FirstOrDefault(f => f.FeeTypeID == feeTypeId);
            if (ft == null) return false;
            if (!CanDeleteFeeType(feeTypeId))
                return false;
            db.FeeTypes.DeleteOnSubmit(ft);
            db.SubmitChanges();
            return true;
        }
    }
}
