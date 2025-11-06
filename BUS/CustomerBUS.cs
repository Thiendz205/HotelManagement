using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CustomerBUS
    {
        private CustomerDAL dal = new CustomerDAL();
        public decimal GetTotalSpending(string customerId) => dal.GetTotalSpending(customerId);
        public List<CustomerET> GetAllCustomers() => dal.GetAllCustomers();
        public bool AddCustomer(CustomerET customer) => dal.InsertCustomer(customer);
        public bool UpdateCustomer(CustomerET customer) => dal.UpdateCustomer(customer);
        public string AutoUpgradeRank(string customerId)=> dal.AutoUpgradeRank(customerId);
        public List<CustomerET> SearchCustomers(string name, string phone, string nationalId) => dal.SearchCustomers(name, phone, nationalId);
        public bool IsPhoneExists(string phone) => dal.IsPhoneExists(phone);
        public bool IsNationalIDExists(string nationalId) => dal.IsNationalIDExists(nationalId);
        public CustomerET GetCustomerByPhoneOrId(string phone, string nationalId)
        {
            return dal.GetCustomerByPhoneOrId(phone, nationalId);
        }

        public int GetDefaultRankId()
        {
            return dal.GetDefaultRankId();
        }

        public string GetRankNameById(int rankId)
        {
            return dal.GetRankNameById(rankId);
        }
    }
}
