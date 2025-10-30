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
    public partial class frmExtraChargeAdminGUI : Form
    {
        public frmExtraChargeAdminGUI()
        {
            InitializeComponent();
        }

        private void frmExtraChargeAdminGUI_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
            LoadData();
        }

        private readonly BookingFeeBUS bus = new BookingFeeBUS();
        public readonly FeeTypeBUS feebus = new FeeTypeBUS();
        private void LoadComboboxes()
        {
          
            var activeBookings = bus.GetBookingsWithActiveRooms();

            cboBooking.DataSource = activeBookings;
            cboBooking.DisplayMember = "RoomName";  
            cboBooking.ValueMember = "BookingID";    
            cboBooking.SelectedIndex = -1;
            cboBooking.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboBooking.AutoCompleteSource = AutoCompleteSource.ListItems;
            var feeTypes = feebus.GetAllFeeTypes();
            cboFeeType.DataSource = feeTypes;
            cboFeeType.DisplayMember = "FeeTypeName";
            cboFeeType.ValueMember = "FeeTypeID";
            cboFeeType.SelectedIndex = -1;
            cboFeeType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboFeeType.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private bool ValidateInput()
        {
            if (cboBooking.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đặt phòng hoặc phòng này đang không hoạt động!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboFeeType.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phí!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                !int.TryParse(txtQuantity.Text, out int q) || q <= 0)
            {
                MessageBox.Show("Số lượng phải là số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtNotes.Text.Length > 500)
            {
                MessageBox.Show("Ghi chú không được vượt quá 500 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void LoadData()
        {
            dgvFeeList.DataSource = bus.GetAll();
            dgvFeeList.ClearSelection();

            dgvFeeList.Columns["BookingFeeID"].Visible = false;
            dgvFeeList.Columns["BookingID"].Visible = false;
            dgvFeeList.Columns["FeeTypeID"].Visible = false;
            dgvFeeList.Columns["FeeTypeName"].HeaderText = "Loại phí";
            dgvFeeList.Columns["Quantity"].HeaderText = "Số lượng";
            dgvFeeList.Columns["CustomerName"].HeaderText = "Khách hàng";
            dgvFeeList.Columns["RoomName"].HeaderText = "Phòng";
            dgvFeeList.Columns["CreatedAt"].HeaderText = "Ngày tạo";
            dgvFeeList.Columns["Notes"].HeaderText = "Ghi chú";
            dgvFeeList.Columns["CreatedAt"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvFeeList.Columns["UnitPrice"].HeaderText = "Đơn giá (VNĐ)";
            dgvFeeList.Columns["TotalAmount"].HeaderText = "Tổng tiền (VNĐ)";

            dgvFeeList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFeeList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var dto = new BookingFeeET
            {
                BookingID = (int)cboBooking.SelectedValue,
                FeeTypeID = (int)cboFeeType.SelectedValue,
                Quantity = int.Parse(txtQuantity.Text),
                Notes = txtNotes.Text
            };
            MessageBox.Show("Thêm thành công!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bus.Insert(dto);
            LoadData();
            ClearForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn phí cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            var dto = new BookingFeeET
            {
                BookingFeeID = selectedId,
                BookingID = (int)cboBooking.SelectedValue,
                FeeTypeID = (int)cboFeeType.SelectedValue,
                Quantity = int.Parse(txtQuantity.Text),
                Notes = txtNotes.Text
            };
            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bus.Update(dto);
            LoadData();
            ClearForm();
        }
        private int selectedId = -1;
        private void ClearForm()
        {
            selectedId = -1;
            cboBooking.SelectedIndex = -1;
            cboFeeType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtNotes.Clear();
            dgvFeeList.ClearSelection();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn phí cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phí này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus.Delete(selectedId);
                LoadData();
                ClearForm();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvFeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFeeList.Rows[e.RowIndex];
                selectedId = Convert.ToInt32(row.Cells["BookingFeeID"].Value);

                cboBooking.Text = row.Cells["RoomName"].Value.ToString();
                cboFeeType.Text = row.Cells["FeeTypeName"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtNotes.Text = row.Cells["Notes"].Value?.ToString();
            }
        }
    }
}
