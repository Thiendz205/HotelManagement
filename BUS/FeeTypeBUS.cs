using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FeeTypeBUS
    {
        private readonly FeeTypeDAL dal = new FeeTypeDAL();

        public List<FeeTypeET> GetAll()
        {
            return dal.GetAllFeeTypes();
        }

        public bool Add(FeeTypeET et)
        {
            return dal.AddFeeType(et) > 0;
        }

        public bool Update(FeeTypeET et)
        {
            return dal.UpdateFeeType(et);
        }

        public bool Delete(int feeTypeId)
        {
            return dal.DeleteFeeType(feeTypeId);
        }

        public bool IsFeeTypeNameExists(string name, int? excludeId = null)
        {
            return dal.IsFeeTypeNameExists(name, excludeId);
        }

        public bool CanDeleteFeeType(int id)
        {
            return dal.CanDeleteFeeType(id);
        }
        public List<FeeTypeET> GetAllFeeTypes()
        {
            return dal.GetAllFeeTypes();
        }

    }
}
