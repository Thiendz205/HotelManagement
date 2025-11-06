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
        private string selectedId = null;
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

            dgvFeeList.Columns["BookingFeeID"].HeaderText = "Mã phí";
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
            string bookingFeeId = txtBookingFeeID.Text.Trim();

    
            if (bus.IsBookingFeeIdExists(bookingFeeId))
            {
                MessageBox.Show($"Mã phí phát sinh '{bookingFeeId}' đã tồn tại! Vui lòng nhập mã khác.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new BookingFeeET
            {
                BookingID = cboBooking.SelectedValue.ToString(),
                FeeTypeID = cboFeeType.SelectedValue.ToString(),
                Quantity = int.Parse(txtQuantity.Text),
                Notes = txtNotes.Text
            };

            if (bus.Insert(dto))
            {
                MessageBox.Show("Thêm phí phát sinh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Không thể thêm phí phát sinh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Vui lòng chọn phí cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            var dto = new BookingFeeET
            {
                BookingFeeID = selectedId,
                BookingID = cboBooking.SelectedValue.ToString(),
                FeeTypeID = cboFeeType.SelectedValue.ToString(),
                Quantity = int.Parse(txtQuantity.Text),
                Notes = txtNotes.Text
            };

            if (bus.Update(dto))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Không thể cập nhật phí phát sinh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearForm()
        {
            selectedId = null;
            txtBookingFeeID.Clear();
            cboBooking.SelectedIndex = -1;
            cboFeeType.SelectedIndex = -1;
            txtQuantity.Clear();
            txtNotes.Clear();
            dgvFeeList.ClearSelection();
            txtBookingFeeID.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Vui lòng chọn phí cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa phí này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bus.Delete(selectedId))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Không thể xóa phí phát sinh!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvFeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvFeeList.Rows[e.RowIndex];
                selectedId = row.Cells["BookingFeeID"].Value.ToString();

                txtBookingFeeID.Text = selectedId;
                cboBooking.Text = row.Cells["RoomName"].Value.ToString();
                cboFeeType.Text = row.Cells["FeeTypeName"].Value.ToString();
                txtQuantity.Text = row.Cells["Quantity"].Value.ToString();
                txtNotes.Text = row.Cells["Notes"].Value?.ToString();
                txtBookingFeeID.Enabled = false;
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string bookingFeeId = txtBookingFeeID.Text.Trim();
            string feeTypeId = cboFeeType.SelectedValue != null ? cboFeeType.SelectedValue.ToString() : "";
            string bookingId = cboBooking.SelectedValue != null ? cboBooking.SelectedValue.ToString() : "";

            var results = bus.Search(bookingFeeId, feeTypeId, bookingId);
            dgvFeeList.DataSource = results;

            if (results.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"🔍 Tìm thấy {results.Count} kết quả phù hợp!",
                    "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }
    }
}
