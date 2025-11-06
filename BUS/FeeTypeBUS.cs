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

        public string AddFeeType(FeeTypeET et)
        {
            return dal.AddFeeType(et);
        }

        public bool Update(FeeTypeET et)
        {
            return dal.UpdateFeeType(et);
        }

        public bool DeleteFeeType(string feeTypeId)
        {
            return dal.DeleteFeeType(feeTypeId);
        }

        public bool IsFeeTypeNameExists(string name, string excludeId = null)
        {
            return dal.IsFeeTypeNameExists(name, excludeId);
        }

        public bool CanDeleteFeeType(string feeTypeId)
        {
            return dal.CanDeleteFeeType(feeTypeId);
        }
        public List<FeeTypeET> GetAllFeeTypes()
        {
            return dal.GetAllFeeTypes();
        }
        public bool IsFeeTypeIdExists(string feeTypeId)
        {
            return dal.IsFeeTypeIdExists(feeTypeId);
        }

    }
}
