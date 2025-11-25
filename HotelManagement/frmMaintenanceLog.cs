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
    public partial class frmMaintenanceLog : Form
    {
        public frmMaintenanceLog()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.None;
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
        }
        MaintenanceLog_BUS maintenanceLog_BUS = new MaintenanceLog_BUS();
        private void frmMaintenanceLog_Load(object sender, EventArgs e)
        {
            dtGV_LichSuBaoTri.DataSource = maintenanceLog_BUS.getAllMaintenanceLogs();
            cbLoaiBaoTri.DataSource = maintenanceLog_BUS.getNameAndIDMaintenanceTypes();
            cbLoaiBaoTri.DisplayMember = "TypeName";
            cbLoaiBaoTri.ValueMember = "MaintenanceTypeID";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLichSu.Text))
            {
                MessageBox.Show("Vui lòng chọn log bảo trì để xóa!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbTrangThai.Text != "Not completed")
            {
                MessageBox.Show("Chỉ có thể xóa log với trạng thái 'Not completed'!", "Thông báo");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa log bảo trì này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr != DialogResult.Yes)
                return;

            int logID = int.Parse(txtMaLichSu.Text);
            string message;

            bool deleted = maintenanceLog_BUS.DeleteMaintenanceLog(logID, out message);

            MessageBox.Show(message);

            if (deleted)
                dtGV_LichSuBaoTri.DataSource = maintenanceLog_BUS.getAllMaintenanceLogs();
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLichSu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn log!");
                return;
            }
            int logID = int.Parse(txtMaLichSu.Text);
            frmCompleteMaintenance popup = new frmCompleteMaintenance(logID);

            if (popup.ShowDialog() == DialogResult.OK)
            {
                string result = popup.ResultStatus;
                string message;

                bool ok = maintenanceLog_BUS.UpdateMaintenanceResult(
                    int.Parse(txtMaLichSu.Text),
                    result,
                    out message
                );

                if (!ok)
                {
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                dtGV_LichSuBaoTri.DataSource = maintenanceLog_BUS.getAllMaintenanceLogs();
            }
        }

        private void dtGV_LichSuBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dtGV_LichSuBaoTri.Rows[e.RowIndex];

            txtMaLichSu.Text = row.Cells["LogID"].Value?.ToString() ?? "";
            cbLoaiBaoTri.SelectedValue = (int)row.Cells["MaintenanceTypeID"].Value;
            txtMaPhong.Text = row.Cells["RoomID"].Value?.ToString() ?? "";
            txtMaThietBi.Text = row.Cells["RoomEquipmentID"].Value?.ToString() ?? "";
            txtMaNhanVien.Text = row.Cells["StaffID"].Value?.ToString() ?? "";
            dtNgayBaoTri.Value = Convert.ToDateTime(row.Cells["MaintenanceDate"].Value);
            cbTrangThai.Text = row.Cells["Status"].Value?.ToString() ?? "";
            txtNote.Text = row.Cells["Note"].Value?.ToString() ?? "";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLichSu.Clear();
            txtMaPhong.Clear();
            txtMaThietBi.Clear();
            txtMaNhanVien.Clear();
            txtNote.Clear();
            dtNgayBaoTri.Value = DateTime.Now;

        }
    }
}
