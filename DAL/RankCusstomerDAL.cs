using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RankCusstomerDAL
    {
        HotelManagementDataContext db = new HotelManagementDataContext();

        // Lấy danh sách tất cả rank
        public List<RankCustomerET> GetAll()
        {
            return db.CustomerRanks
                     .Select(r => new RankCustomerET
                     {
                         RankID = r.RankID,
                         RankName = r.RankName,
                         DiscountPercent = r.DiscountPercent,
                         MinSpending = r.MinSpending ?? 0
                     }).ToList();
        }

        // Thêm mới
        public bool Insert(RankCustomerET rank)
        {
            try
            {
                if (CheckRankNameExists(rank.RankName))
                    return false; // Trùng tên

                var newRank = new CustomerRank
                {
                    RankName = rank.RankName,
                    DiscountPercent = rank.DiscountPercent,
                    MinSpending = rank.MinSpending
                };

                db.CustomerRanks.InsertOnSubmit(newRank);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Cập nhật
        public bool Update(RankCustomerET rank)
        {
            try
            {
                var existing = db.CustomerRanks.FirstOrDefault(r => r.RankID == rank.RankID);
                if (existing == null)
                    return false;

                // Nếu đổi tên, kiểm tra trùng tên với rank khác
                bool duplicateName = db.CustomerRanks
                    .Any(r => r.RankName == rank.RankName && r.RankID != rank.RankID);
                if (duplicateName)
                    return false;

                existing.RankName = rank.RankName;
                existing.DiscountPercent = rank.DiscountPercent;
                existing.MinSpending = rank.MinSpending;
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Xóa (chỉ cho phép nếu không có khách hàng)
        public bool Delete(int rankID)
        {
            try
            {
                var rank = db.CustomerRanks.FirstOrDefault(r => r.RankID == rankID);
                if (rank == null)
                    return false;

                if (CheckRankHasCustomers(rankID))
                    return false; // Có khách hàng đang dùng => không xóa

                db.CustomerRanks.DeleteOnSubmit(rank);
                db.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Kiểm tra RankName trùng
        public bool CheckRankNameExists(string rankName)
        {
            try
            {
                return db.CustomerRanks.Any(r => r.RankName == rankName);
            }
            catch
            {
                return false;
            }
        }

        // Kiểm tra RankID tồn tại
        public bool CheckRankIDExists(int rankID)
        {
            try
            {
                return db.CustomerRanks.Any(r => r.RankID == rankID);
            }
            catch
            {
                return false;
            }
        }

        // Kiểm tra Rank có khách hàng không
        public bool CheckRankHasCustomers(int rankID)
        {
            try
            {
                return db.Customers.Any(c => c.RankID == rankID);
            }
            catch
            {
                return false;
            }
        }
        // Kiểm tra khoảng cách tối thiểu giữa các mốc chi tiêu
        public bool CheckMinSpendingDifference(decimal newMinSpending, int? excludeRankId = null)
        {
            try
            {
                // Lấy danh sách tất cả MinSpending (bỏ qua chính nó nếu đang update)
                var spendingList = db.CustomerRanks
                                     .Where(r => excludeRankId == null || r.RankID != excludeRankId)
                                     .Select(r => r.MinSpending ?? 0)
                                     .OrderBy(x => x)
                                     .ToList();

                if (!spendingList.Any())
                    return true; // Nếu chưa có rank nào, thì hợp lệ

                // Duyệt qua từng mức chi tiêu hiện có
                foreach (var existing in spendingList)
                {
                    // Nếu khoảng cách tuyệt đối < 1 triệu => không hợp lệ
                    if (Math.Abs(existing - newMinSpending) < 1000000)
                        return false;
                }

                // Nếu không vi phạm khoảng cách tối thiểu => hợp lệ
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
