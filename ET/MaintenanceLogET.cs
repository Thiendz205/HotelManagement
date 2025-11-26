using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class MaintenanceLogET
    {

        public int MaintenanceTypeID { get; set; }

        // Danh sách phòng cần bảo trì
        public List<string> RoomIDs { get; set; } = new List<string>();

        // Nếu bảo trì thiết bị (chúng ta không dùng trong trường hợp này)
        public string EquipmentID { get; set; } = null;

        // Nhân viên kỹ thuật
        public string StaffID { get; set; }

        // Ghi chú, mặc định null
        public string Note { get; set; } = null;

        // Ngày bảo trì, mặc định hôm nay
        public DateTime MaintenanceDate { get; set; } = DateTime.Now;

        // Trạng thái mặc định
        public string Status { get; set; } = "Not Completed";
    }
}
