using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmRoomMonitoring : Form
    {
        public frmRoomMonitoring()
        {
            InitializeComponent();
            SetupDataGridViews();
        }

        private void SetupDataGridViews()
        {
            // Setup dgvRooms columns
            dgvRooms.Columns.Clear();
            dgvRooms.Columns.Add("RoomNumber", "Số phòng");
            dgvRooms.Columns.Add("RoomType", "Loại phòng");
            dgvRooms.Columns.Add("Status", "Trạng thái");
            dgvRooms.Columns.Add("Customer", "Khách hàng");
            dgvRooms.Columns.Add("CheckInTime", "Thời gian Check-in");

            // Setup dgvRoomServices columns
            dgvRoomServices.Columns.Clear();
            dgvRoomServices.Columns.Add("ServiceName", "Tên dịch vụ");
            dgvRoomServices.Columns.Add("Quantity", "Số lượng");
            dgvRoomServices.Columns.Add("Price", "Giá");

            // Setup dgvRoomEquipment columns
            dgvRoomEquipment.Columns.Clear();
            dgvRoomEquipment.Columns.Add("EquipmentName", "Tên thiết bị");
            dgvRoomEquipment.Columns.Add("Condition", "Tình trạng");
            dgvRoomEquipment.Columns.Add("LastMaintenance", "Bảo trì cuối");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Implement search functionality
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // TODO: Implement refresh functionality
        }

        private void dgvRooms_SelectionChanged(object sender, EventArgs e)
        {
            // TODO: Implement room selection functionality
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmServiceStaffMain"] as frmServiceStaffMain;
            if (parent != null)
            {
                var bookingDetailForm = new frmServiceProvision();
                parent.OpenChildForm(bookingDetailForm);
            }
        }
    }
}
