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
    public partial class frmServiceManagement : Form
    {
        public frmServiceManagement()
        {
            InitializeComponent();
            SetupDataGridViews();
        }

        private void SetupDataGridViews()
        {
            // Setup dgvServiceUsage columns
            dgvServiceUsage.Columns.Clear();
            dgvServiceUsage.Columns.Add("UsageID", "Mã sử dụng");
            dgvServiceUsage.Columns.Add("CustomerName", "Tên khách hàng");
            dgvServiceUsage.Columns.Add("RoomNumber", "Số phòng");
            dgvServiceUsage.Columns.Add("ServiceName", "Tên dịch vụ");
            dgvServiceUsage.Columns.Add("Quantity", "Số lượng");
            dgvServiceUsage.Columns.Add("TotalPrice", "Tổng tiền");
            dgvServiceUsage.Columns.Add("Status", "Trạng thái");
            dgvServiceUsage.Columns.Add("DateTime", "Thời gian");
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

        private void dgvServiceUsage_SelectionChanged(object sender, EventArgs e)
        {
            // TODO: Implement service usage selection functionality
        }
    }
}