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
    public partial class frmBookingAdminGUI : Form
    {
        public frmBookingAdminGUI()
        {
            InitializeComponent();
        }
        private void frmBookingAdminGUI_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
            LoadData();
        }
        private void LoadComboboxes()
        {
            // customers
            var customers = bookingBUS.GetAllCustomers();
            cboCustomer.DataSource = customers;
            cboCustomer.DisplayMember = "CustomerName";
            cboCustomer.ValueMember = "CustomerID";
            cboCustomer.SelectedIndex = -1;

            cboCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCustomer.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var custAuto = new AutoCompleteStringCollection();
            foreach (var c in customers) custAuto.Add(c.CustomerName);
            cboCustomer.AutoCompleteCustomSource = custAuto;

            // rooms
            var rooms = bookingBUS.GetRoomsForBookingCombo();
            cboRoom.DataSource = rooms;
            cboRoom.DisplayMember = "RoomName";
            cboRoom.ValueMember = "RoomID";
            cboRoom.SelectedIndex = -1;

            cboRoom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboRoom.AutoCompleteSource = AutoCompleteSource.CustomSource;
            var roomAuto = new AutoCompleteStringCollection();
            foreach (var r in rooms) roomAuto.Add(r.RoomName);
            cboRoom.AutoCompleteCustomSource = roomAuto;
        }

        private bool ValidateBookingInput()
        {
            if (cboRoom.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboCustomer.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!rdoDay.Checked && !rdoHour.Checked)
            {
                MessageBox.Show("Vui lòng chọn kiểu thuê (theo ngày hoặc theo giờ)!",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                MessageBox.Show("Ngày trả phòng phải sau ngày nhận phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lblPrice.Tag == null || Convert.ToDecimal(lblPrice.Tag) <= 0)
            {
                MessageBox.Show("Giá phòng chưa được thiết lập hoặc không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void ResetForm()
        {
            cboRoom.SelectedIndex = -1;
            cboCustomer.SelectedIndex = -1;
            rdoDay.Checked = false;
            rdoHour.Checked = false;
            lblPrice.Text = "0 VND";
            lblPrice.Tag = 0;
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
        }
        private void rdoDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDay.Checked)
            {
                rdoHour.Checked = false;
                if (isLoadingBooking) return;
                UpdateRoomPrice();
            }
        }
        private void rdoHour_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHour.Checked)
            {
                rdoDay.Checked = false;
                if (isLoadingBooking) return;
                UpdateRoomPrice();
            }
        }
        private BookingBUS bookingBUS = new BookingBUS();
        private int selectedBookingId = -1;
        private void UpdateRoomPrice()
        {
            if (cboRoom.SelectedValue == null) return;
            if (!rdoDay.Checked && !rdoHour.Checked) return;

            int roomId = (int)cboRoom.SelectedValue;
            string rentalType = rdoDay.Checked ? "Day" : "Hour";
            DateTime checkIn = dtpCheckIn.Value;
            DateTime checkOut = dtpCheckOut.Value;

            decimal price = bookingBUS.CalculateTotalPrice(roomId, rentalType, checkIn, checkOut);

            if (price > 0)
            {
                lblPrice.Text = price.ToString("N0") + " VNĐ";
                lblPrice.Tag = price; // ✅ Cập nhật lại Tag
            }
            else
            {
                lblPrice.Text = "Chưa có giá áp dụng";
                lblPrice.Tag = 0; // ✅ Gán giá trị 0 cho an toàn
            }
        }

        private void CancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lịch để hủy.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookingId = Convert.ToInt32(dgvBooking.SelectedRows[0].Cells["BookingID"].Value);

            bool result = bookingBUS.CancelBooking(bookingId);

            if (result)
            {
                MessageBox.Show("Hủy lịch thành công.", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Chỉ có thể hủy các lịch có trạng thái 'Đặt trước'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateRoomPrice();
        }
        private bool isLoadingBooking = false; // thêm biến toàn cục ở đầu form
        private void dgvBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                isLoadingBooking = true; // ✅ chặn ValueChanged trong lúc load

                DataGridViewRow row = dgvBooking.Rows[e.RowIndex];
                selectedBookingId = Convert.ToInt32(row.Cells["BookingID"].Value);

                // Phòng & khách hàng
                cboRoom.SelectedValue = row.Cells["RoomID"].Value ?? -1;
                cboCustomer.SelectedValue = row.Cells["CustomerID"].Value ?? -1;

                // Kiểu thuê
                string rentalType = row.Cells["RentalType"].Value?.ToString();
                rdoDay.Checked = rentalType == "Day";
                rdoHour.Checked = rentalType == "Hour";

                // Thời gian
                dtpCheckIn.Value = row.Cells["CheckIn"].Value is DateTime checkIn ? checkIn : DateTime.Now;
                dtpCheckOut.Value = row.Cells["CheckOut"].Value is DateTime checkOut ? checkOut : DateTime.Now.AddDays(1);

                // Giá
                if (row.Cells["Price"].Value != null && row.Cells["Price"].Value != DBNull.Value)
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    lblPrice.Text = $"{price:N0} VNĐ";
                    lblPrice.Tag = price;
                }
                else
                {
                    lblPrice.Text = "0 VNĐ";
                    lblPrice.Tag = 0;
                }
                string roomStatus = row.Cells["RoomStatus"].Value?.ToString();
                if (!string.IsNullOrEmpty(roomStatus))
                {
                    cboRoomStatus.SelectedItem = roomStatus;
                }
                else
                {
                    cboRoomStatus.SelectedIndex = -1; // nếu null thì clear chọn
                }
                cboCustomer.Enabled = false;
                isLoadingBooking = false; // ✅ bật lại
                UpdateRoomPrice(); // ✅ gọi lại sau khi load xong để tính chính xác giá hiện tại
            }
        }
        private void LoadData()
        {
            // Gọi BLL để lấy danh sách booking
            var list = bookingBUS.GetAll();

            dgvBooking.DataSource = list;

            // Ẩn các cột ID
            dgvBooking.Columns["BookingID"].Visible = false;
            dgvBooking.Columns["CustomerID"].Visible = false;
            dgvBooking.Columns["RoomID"].Visible = false;
            dgvBooking.Columns["StaffID"].Visible = false;

            // Đặt tiêu đề tiếng Việt
            dgvBooking.Columns["CustomerName"].HeaderText = "Khách hàng";
            dgvBooking.Columns["RoomName"].HeaderText = "Phòng";
            dgvBooking.Columns["RentalType"].HeaderText = "Kiểu thuê";
            dgvBooking.Columns["CheckIn"].HeaderText = "Ngày nhận phòng";
            dgvBooking.Columns["CheckOut"].HeaderText = "Ngày trả phòng";
            dgvBooking.Columns["Price"].HeaderText = "Giá";
            dgvBooking.Columns["Status"].HeaderText = "Trạng thái";
            dgvBooking.Columns["RoomStatus"].HeaderText = "Trạng thái phòng";
            dgvBooking.Columns["StaffName"].HeaderText = "Tên nhân viên";

            // Format hiển thị
            dgvBooking.Columns["Price"].DefaultCellStyle.Format = "N0";
            dgvBooking.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBooking.Columns["CheckIn"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvBooking.Columns["CheckOut"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooking.MultiSelect = false;
            dgvBooking.ReadOnly = true;
            dgvBooking.AllowUserToAddRows = false;
            dgvBooking.AllowUserToDeleteRows = false;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateBookingInput())
                return;

            if (selectedBookingId <= 0)
            {
                MessageBox.Show("Vui lòng chọn booking cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BookingET booking = new BookingET
            {
                BookingID = selectedBookingId,
                RoomID = (int)cboRoom.SelectedValue,
                CustomerID = (int)cboCustomer.SelectedValue,
                RentalType = rdoDay.Checked ? "Day" : "Hour",
                CheckIn = dtpCheckIn.Value,
                CheckOut = dtpCheckOut.Value,
                Price = Convert.ToDecimal(lblPrice.Tag)
            };
            var result = bookingBUS.UpdateBookingInfoOnly(booking);

            switch (result)
            {
                case UpdateResult.Success:
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetForm();
                    break;

                case UpdateResult.InvalidStatus:
                    MessageBox.Show("Chỉ được cập nhật booking đang Check-in", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case UpdateResult.RoomNotAvailable:
                    MessageBox.Show("Phòng này hiện không trống hoặc không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case UpdateResult.RoomConflict:
                    MessageBox.Show("Phòng đã được đặt trong khoảng thời gian này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

                case UpdateResult.NotFound:
                default:
                    MessageBox.Show("Không tìm thấy booking để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoomPrice();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoomPrice();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ResetForm();

            selectedBookingId = -1;
            cboCustomer.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string customerName = cboCustomer.Text?.Trim();
            string roomName = cboRoom.Text?.Trim();

           
            var result = bookingBUS.Search(customerName, roomName);

            dgvBooking.DataSource = result;

            dgvBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooking.ReadOnly = true;

            // Thông báo số kết quả
            if (result.Count > 0)
            {
                MessageBox.Show($"Tìm thấy {result.Count} kết quả phù hợp.",
                                "Kết quả tìm kiếm",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả nào phù hợp.",
                                "Kết quả tìm kiếm",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
