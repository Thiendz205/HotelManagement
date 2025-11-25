using BUS;
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
    public partial class frmCompleteMaintenance : Form
    {
        private int _logID;
        private MaintenanceLog_BUS maintenanceLog_BUS = new MaintenanceLog_BUS();

        public frmCompleteMaintenance(int logID)
        {
            InitializeComponent();
            _logID = logID;

        }
        public string ResultStatus { get; private set; } = null;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResultStatus = null;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFailed_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
          "Bạn có chắc chắn muốn đánh dấu bảo trì thất bại?\n\n"
          + "• Thiết bị FAILED → sẽ bị loại khỏi phòng\n"
          + "• Phòng FAILED → sẽ chuyển sang trạng thái OutOfOrder",
          "Xác nhận",
          MessageBoxButtons.YesNo,
          MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                ResultStatus = "Failed";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            ResultStatus = "Completed";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
