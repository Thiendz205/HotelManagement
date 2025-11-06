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
using System.Xml.Linq;

namespace HotelManagement
{
    public partial class frmExtraChargeTypeAdminGUI : Form
    {
        public frmExtraChargeTypeAdminGUI()
        {
            InitializeComponent();
        }

        private void frmExtraChargeTypeAdminGUI_Load(object sender, EventArgs e)
        {
            LoadFeeTypes();
        }
        private readonly FeeTypeBUS bus = new FeeTypeBUS();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            if (bus.IsFeeTypeNameExists(txtFeeTypeName.Text.Trim()))
            {
                MessageBox.Show("Tên loại phí đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var et = new FeeTypeET
            {
                FeeTypeName = txtFeeTypeName.Text.Trim(),
                Category = cboCategory.Text.Trim(),
                DefaultPrice = decimal.Parse(txtDefaultPrice.Text.Trim()),
                Notes = txtNotes.Text.Trim()
            };

            string newId = bus.AddFeeType(et);
            if (!string.IsNullOrEmpty(newId))
            {
                MessageBox.Show($"Thêm loại phí thành công! Mã mới: {newId}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFeeTypes();
                ClearInput();
                txtFeeType.Text = newId;
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInput()
        {
            txtFeeType.Clear();
            txtFeeTypeName.Clear();
            txtDefaultPrice.Clear();
            txtNotes.Clear();
            cboCategory.SelectedIndex = -1;
            selectedFeeTypeId = null;
            oldFeeTypeName = "";
            txtFeeType.Enabled = true;
        }

        private string selectedFeeTypeId = null;
        private string oldFeeTypeName = "";
        private bool ValidateInput()
        {
            // Kiểm tra tên loại phí
            if (string.IsNullOrWhiteSpace(txtFeeTypeName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phí!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtFeeTypeName.Text.Length > 100)
            {
                MessageBox.Show("Tên loại phí không được vượt quá 100 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra loại danh mục (phụ phí, bồi thường,...)
            if (cboCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại danh mục (Phụ phí dịch vụ, Bồi thường hư hỏng,...)", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra giá mặc định
            if (string.IsNullOrWhiteSpace(txtDefaultPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập giá mặc định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtDefaultPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Giá mặc định phải là số hợp lệ và không âm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Ghi chú (tùy chọn nhưng không nên quá dài)
            if (txtNotes.Text.Length > 500)
            {
                MessageBox.Show("Ghi chú không được vượt quá 500 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void dgvExtraCharge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFeeTypes.Rows[e.RowIndex];
                selectedFeeTypeId = row.Cells["FeeTypeID"].Value?.ToString();

                txtFeeType.Text = selectedFeeTypeId;

                txtFeeTypeName.Text = row.Cells["FeeTypeName"].Value?.ToString();
                cboCategory.Text = row.Cells["Category"].Value?.ToString();
                txtDefaultPrice.Text = row.Cells["DefaultPrice"].Value?.ToString();
                txtNotes.Text = row.Cells["Notes"].Value?.ToString();

                oldFeeTypeName = txtFeeTypeName.Text.Trim();
                txtFeeType.Enabled = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFeeTypeId))
            {
                MessageBox.Show("Vui lòng chọn loại phí cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            string newName = txtFeeTypeName.Text.Trim();
            if (!newName.Equals(oldFeeTypeName, StringComparison.OrdinalIgnoreCase))
            {
                if (bus.IsFeeTypeNameExists(newName))
                {
                    MessageBox.Show("Tên loại phí đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            var et = new FeeTypeET
            {
                FeeTypeID = selectedFeeTypeId,
                FeeTypeName = newName,
                Category = cboCategory.Text.Trim(),
                DefaultPrice = decimal.Parse(txtDefaultPrice.Text),
                Notes = txtNotes.Text.Trim()
            };

            if (bus.Update(et))
            {
                MessageBox.Show("Cập nhật loại phí thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadFeeTypes();
                ClearInput();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFeeTypeId))
            {
                MessageBox.Show("Vui lòng chọn loại phí cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!bus.CanDeleteFeeType(selectedFeeTypeId))
            {
                MessageBox.Show("Không thể xóa vì loại phí đã được sử dụng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa loại phí này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                if (bus.DeleteFeeType(selectedFeeTypeId))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFeeTypes();
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadFeeTypes()
        {
            var list = bus.GetAllFeeTypes();
            dgvFeeTypes.DataSource = list;

            if (dgvFeeTypes.Columns.Count == 0) return;

            dgvFeeTypes.Columns["FeeTypeID"].HeaderText = "Mã loại phí";
            dgvFeeTypes.Columns["FeeTypeName"].HeaderText = "Tên loại phí";
            dgvFeeTypes.Columns["Category"].HeaderText = "Nhóm loại phí";
            dgvFeeTypes.Columns["DefaultPrice"].HeaderText = "Giá mặc định (VNĐ)";
            dgvFeeTypes.Columns["Notes"].HeaderText = "Ghi chú";

            dgvFeeTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeeTypes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadFeeTypes();
            ClearInput();
        }
    }
}
