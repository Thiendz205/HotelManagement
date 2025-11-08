using ET;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        // FeeTypeID = ft.FeeTypeID,
                         FeeTypeName = ft.FeeTypeName,
                         Category = ft.Category,
                         DefaultPrice = ft.DefaultPrice,
                         Notes = ft.Notes
                     }).ToList();
        }
        public bool IsFeeTypeNameExists(string name, int? excludeId = null)
        {
            //var q = db.FeeTypes.Where(f => f.FeeTypeName == name);
            //if (excludeId.HasValue)
            //    q = q.Where(f => f.FeeTypeID != excludeId.Value);
            //return q.Any();
            return true; //tam
        }

        public int AddFeeType(FeeTypeET et)
        {
            var ft = new FeeType
            {
                FeeTypeName = et.FeeTypeName,
                Category = et.Category,
                DefaultPrice = et.DefaultPrice,
                Notes = et.Notes
            };
            db.FeeTypes.InsertOnSubmit(ft);
            db.SubmitChanges();
            // return ft.FeeTypeID;
            return 0;
        }

        public bool UpdateFeeType(FeeTypeET et)
        {
            //var ft = db.FeeTypes.FirstOrDefault(f => f.FeeTypeID == et.FeeTypeID);
            //if (ft == null) return false;
            //ft.FeeTypeName = et.FeeTypeName;
            //ft.Category = et.Category;
            //ft.DefaultPrice = et.DefaultPrice;
            //ft.Notes = et.Notes;
            //db.SubmitChanges();
            return true;
        }
        
        public bool CanDeleteFeeType(int feeTypeId)
        {
           // return !db.BookingFees.Any(bf => bf.FeeTypeID == feeTypeId);
           return false;
        }

        public bool DeleteFeeType(int feeTypeId)
        {
            //var ft = db.FeeTypes.FirstOrDefault(f => f.FeeTypeID == feeTypeId);
            //if (ft == null) return false;
            //if (!CanDeleteFeeType(feeTypeId))
            //    return false; 
            //db.FeeTypes.DeleteOnSubmit(ft);
            //db.SubmitChanges();
            return true;
        }
    }
}
