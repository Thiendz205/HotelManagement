using BUS;
using ET;
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
    public partial class frmKhoThietBi : Form
    {
        public string maNhanVien;
        public frmKhoThietBi(string maNhanVien)
        {
            this.maNhanVien = maNhanVien;
            InitializeComponent();
        }
        EquipmentStorage_BUS equipmentStorage_BUS = new EquipmentStorage_BUS();
        private void frmKhoThietBi_Load(object sender, EventArgs e)
        {
            dtGV_KhoThietBi.DataSource = equipmentStorage_BUS.getAllEquipment();
            txtMaNhanVien.Text = maNhanVien;
        }
        EquipmentStorage_ET equipmentStorage_ET = new EquipmentStorage_ET();
        

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenThietBi.Text == "" )
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbNhomThietBi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trạng thái thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dtNgayNhapKho.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày nhập kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbTrangThai.Text == "Maintenance")
            {
                MessageBox.Show("Trạng thái khi thêm mới chỉ được phép là 'Available'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtQTY.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                equipmentStorage_ET.EquipmentName = txtTenThietBi.Text.Trim();
                equipmentStorage_ET.EquipmentCategory = cbNhomThietBi.Text;
                equipmentStorage_ET.Quantity = Convert.ToInt32(txtQTY.Text);
                equipmentStorage_ET.PurchaseDate = dtNgayNhapKho.Value;
                equipmentStorage_ET.Status = "Available";
                equipmentStorage_ET.Description = txtMoTa.Text.Trim();
                equipmentStorage_ET.staffID = txtMaNhanVien.Text;
                bool result = equipmentStorage_BUS.addEquipment(equipmentStorage_ET);
                if (result)
                {
                    MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_KhoThietBi.DataSource = equipmentStorage_BUS.getAllEquipment();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtIDthietBi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn xóa thiết bị này không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = equipmentStorage_BUS.deleteEquipment(txtIDthietBi.Text);
                if (success)
                {
                    MessageBox.Show("Xóa thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_KhoThietBi.DataSource = equipmentStorage_BUS.getAllEquipment(); 
                }
                else
                {
                    MessageBox.Show("Xóa thiết bị thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dtGV_KhoThietBi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtGV_KhoThietBi.Rows.Count)
            {
                DataGridViewRow row = dtGV_KhoThietBi.Rows[e.RowIndex];

                txtIDthietBi.Text = row.Cells["EquipmentID"].Value?.ToString();
                txtTenThietBi.Text = row.Cells["EquipmentName"].Value?.ToString();
                cbNhomThietBi.Text = row.Cells["EquipmentCategory"].Value?.ToString();
                txtQTY.Text = row.Cells["Quantity"].Value?.ToString();
                cbTrangThai.Text = row.Cells["Status"].Value?.ToString();
                txtMoTa.Text = row.Cells["Description"].Value?.ToString();
                txtMaNhanVien.Text = row.Cells["StaffID"].Value?.ToString();
                txtMaNhanVien.Enabled = false;

                if (row.Cells["PurchaseDate"].Value != null)
                {
                    DateTime purchaseDate;
                    if (DateTime.TryParse(row.Cells["PurchaseDate"].Value.ToString(), out purchaseDate))
                    {
                        dtNgayNhapKho.Value = purchaseDate;
                    }
                }
            }
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenThietBi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbNhomThietBi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbTrangThai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập trạng thái thiết bị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtNgayNhapKho.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ngày nhập kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                EquipmentStorage_ET et = new EquipmentStorage_ET
                {
                    EquipmentID = txtIDthietBi.Text.Trim(),
                    EquipmentName = txtTenThietBi.Text.Trim(),
                    EquipmentCategory = cbNhomThietBi.Text.Trim(),
                    Quantity = int.Parse(txtQTY.Text.Trim()),
                    PurchaseDate = dtNgayNhapKho.Value,
                    Status = cbTrangThai.Text.Trim(),
                    Description = txtMoTa.Text.Trim(),
                    staffID = txtMaNhanVien.Text.Trim()
                };

                bool result = equipmentStorage_BUS.updateEquipment(et);

                if (result)
                {
                    MessageBox.Show("Cập nhật thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_KhoThietBi.DataSource = equipmentStorage_BUS.getAllEquipment();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thiết bị cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = maNhanVien;
            txtIDthietBi.Clear();
            txtTenThietBi.Clear();
            cbNhomThietBi.SelectedIndex = -1;
            txtQTY.Clear();
            cbTrangThai.SelectedIndex = -1;
            txtMoTa.Clear();
            dtNgayNhapKho.Value = DateTime.Now;
            dtGV_KhoThietBi.DataSource = equipmentStorage_BUS.getAllEquipment();
        }

        private void txtQTY_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQTY.Text))
                return;

            if (!System.Text.RegularExpressions.Regex.IsMatch(txtQTY.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQTY.Text = string.Empty;
            }
        }

        private void txtTenThietBi_TextChanged(object sender, EventArgs e)
        {
            string oldText = txtTenThietBi.Text;
            string newText = System.Text.RegularExpressions.Regex.Replace(oldText, @"[^a-zA-Z0-9\sÀ-ỹ]", "");

            if (oldText != newText)
            {
                int pos = txtTenThietBi.SelectionStart - 1;
                txtTenThietBi.Text = newText;
                if (pos < 0) pos = 0;
                txtTenThietBi.SelectionStart = pos;
            }
        }
    }
}
