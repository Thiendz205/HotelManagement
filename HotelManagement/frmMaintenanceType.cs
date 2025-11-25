using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET;

namespace HotelManagement
{
    public partial class frmMaintenanceType : Form
    {
        public frmMaintenanceType()
        {
            InitializeComponent();
        }

        MaintenanceType_BUS maintenanceType_BUS = new MaintenanceType_BUS();

        private void frmMaintenanceType_Load(object sender, EventArgs e)
        {
            dtGV_LoaiBaoTri.DataSource = maintenanceType_BUS.getAllMaintenanceType();
            txtMaLoaiBaoTri.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenBaoTri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }
            try
            {
                MaintenanceType_ET maintenanceType_ET = new MaintenanceType_ET(0, txtTenBaoTri.Text, txtMoTa.Text);
                if (maintenanceType_BUS.addMaintenanceType(maintenanceType_ET))
                {
                    MessageBox.Show("Thêm loại bảo trì thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_LoaiBaoTri.DataSource = maintenanceType_BUS.getAllMaintenanceType();
                }
                else
                {
                    MessageBox.Show("Thêm loại bảo trì thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi thêm {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaLoaiBaoTri.Text == "")
            {
                MessageBox.Show("Vui lòng chọn loại bảo trì cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool check = maintenanceType_BUS.deleteMaintenanceType(int.Parse(txtMaLoaiBaoTri.Text));
                if (check)
                {
                    MessageBox.Show("Xóa loại bảo trì thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_LoaiBaoTri.DataSource = maintenanceType_BUS.getAllMaintenanceType();
                }
                else
                {
                    MessageBox.Show("Xóa loại bảo trì thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenBaoTri.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                bool check = maintenanceType_BUS.updateMaintenanceType(new MaintenanceType_ET(int.Parse(txtMaLoaiBaoTri.Text), txtTenBaoTri.Text, txtMoTa.Text));
                if (check)
                {
                    MessageBox.Show("Sửa loại bảo trì thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_LoaiBaoTri.DataSource = maintenanceType_BUS.getAllMaintenanceType();
                }
                else
                {
                    MessageBox.Show("Sửa loại bảo trì thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi sửa {ex}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dtGV_LoaiBaoTri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtGV_LoaiBaoTri.Rows[e.RowIndex];
                txtMaLoaiBaoTri.Text = row.Cells[0].Value.ToString();
                txtTenBaoTri.Text = row.Cells[1].Value.ToString();
                txtMoTa.Text = row.Cells[2].Value.ToString();
                txtMaLoaiBaoTri.Enabled = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtGV_LoaiBaoTri.DataSource = maintenanceType_BUS.getAllMaintenanceType();
            txtMaLoaiBaoTri.Clear();
            txtTenBaoTri.Clear();
            txtMoTa.Clear();
        }
    }
}
