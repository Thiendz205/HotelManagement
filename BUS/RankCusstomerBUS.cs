using DAL;
using ET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RankCusstomerBUS
    {
        RankCusstomerDAL dal = new RankCusstomerDAL();
        // Lấy toàn bộ danh sách rank
        public List<RankCustomerET> GetAll()
        {
            return dal.GetAll();
        }

        // Thêm mới
        public bool Insert(RankCustomerET rank)
        {
            // Kiểm tra dữ liệu đầu vào
            if (rank == null)
                return false;

            if (string.IsNullOrWhiteSpace(rank.RankName))
                return false;

            // Gọi DAL
            return dal.Insert(rank);
        }

        // Cập nhật
        public bool Update(RankCustomerET rank)
        {
            if (rank == null)
                return false;

            if (string.IsNullOrWhiteSpace(rank.RankName))
                return false;

            // Kiểm tra RankID tồn tại trước khi update
            if (!dal.CheckRankIDExists(rank.RankID))
                return false;

            return dal.Update(rank);
        }

        // Xóa
        public bool Delete(int rankID)
        {
            // Kiểm tra RankID tồn tại
            if (!dal.CheckRankIDExists(rankID))
                return false;

            return dal.Delete(rankID);
        }


        // Kiểm tra trùng tên
        public bool CheckRankNameExists(string rankName)
        {
            return dal.CheckRankNameExists(rankName);
        }

        // Kiểm tra Rank có khách hàng hay chưa
        public bool CheckRankHasCustomers(int rankID)
        {
            return dal.CheckRankHasCustomers(rankID);
        }

        // Kiểm tra RankID có tồn tại
        public bool CheckRankIDExists(int rankID)
        {
            return dal.CheckRankIDExists(rankID);
        }
        public bool CheckMinSpendingDifference(decimal newMinSpending, int? excludeRankId = null) => dal.CheckMinSpendingDifference(newMinSpending, excludeRankId);
    }
}
