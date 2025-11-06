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
    public partial class frmCheckInFromReservationRECPGUI : Form
    {
        public frmCheckInFromReservationRECPGUI(string roomId, string roomName, string roomStatus,string staffId)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.roomName = roomName;
            this.roomStatus = roomStatus;
            this.staffId = staffId;
        }
        private string roomId;
        private string roomName;
        private string roomStatus;
        private string staffId;
        BookingBUS bookingBUS = new BookingBUS();
  

        private void frmCheckInFromReservationRECPGUI_Load(object sender, EventArgs e)
        {
            lblRoomInfo.Text = $"{roomName} ({roomStatus})";
            var bookings = bookingBUS.GetPendingBookingsByRoom(roomId);
            dgvBookings.DataSource = bookings;
            // 🟨 Ẩn các cột không cần thiết
            foreach (DataGridViewColumn col in dgvBookings.Columns)
            {
                col.Visible = false;
            }

            // 🟩 Chỉ hiện các cột cần thiết
            dgvBookings.Columns["BookingID"].Visible = true;
            dgvBookings.Columns["CustomerName"].Visible = true;
            dgvBookings.Columns["PhoneNumber"].Visible = true;
            dgvBookings.Columns["CheckIn"].Visible = true;
            dgvBookings.Columns["CheckOut"].Visible = true;
            dgvBookings.Columns["RentalType"].Visible = true;
            dgvBookings.Columns["Price"].Visible = true;
            dgvBookings.Columns["Status"].Visible = true;
            dgvBookings.Columns["BookingID"].HeaderText = "Mã đặt phòng";
            dgvBookings.Columns["CustomerName"].HeaderText = "Khách hàng";
            dgvBookings.Columns["PhoneNumber"].HeaderText = "SĐT";
            dgvBookings.Columns["CheckIn"].HeaderText = "Ngày nhận";
            dgvBookings.Columns["CheckOut"].HeaderText = "Ngày trả";
            dgvBookings.Columns["RentalType"].HeaderText = "Loại thuê";
            dgvBookings.Columns["Price"].HeaderText = "Giá";
            dgvBookings.Columns["Status"].HeaderText = "Trạng thái";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Lấy BookingID từ dòng đang chọn
                if (dgvBookings.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một đặt phòng để nhận!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string bookingId = dgvBookings.CurrentRow.Cells["BookingID"].Value.ToString();

                // ✅ Tiến hành CheckIn qua BUS
                bool success = bookingBUS.CheckIn(bookingId, staffId);
                if (success)
                {
                    MessageBox.Show("✅ Nhận phòng thành công! Trạng thái đã chuyển sang CheckIn.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ✅ Làm mới lại danh sách Booking
                    dgvBookings.DataSource = bookingBUS.GetPendingBookingsByRoom(roomId);
                }
                else
                {
                    MessageBox.Show("❌ Nhận phòng thất bại! Kiểm tra lại trạng thái đặt phòng.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Lấy BookingID từ dòng đang chọn
                if (dgvBookings.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn một đặt phòng để hủy!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string bookingId = dgvBookings.CurrentRow.Cells["BookingID"].Value.ToString();

                // ✅ Xác nhận
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn hủy lịch đặt phòng này không?",
                    "Xác nhận hủy",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                // ✅ Tiến hành hủy lịch qua BUS
                bool success = bookingBUS.CancelBookingByStaff(bookingId, staffId);
                if (success)
                {
                    MessageBox.Show("✅ Hủy lịch thành công! Đã ghi nhận nhân viên xử lý.",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ✅ Làm mới danh sách Booking
                    dgvBookings.DataSource = bookingBUS.GetPendingBookingsByRoom(roomId);
                }
                else
                {
                    MessageBox.Show("❌ Hủy lịch thất bại! Chỉ có thể hủy các lịch 'Đặt trước'.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi hủy lịch: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var roomListForm = new frmGuestCheckInRECPGUI(staffId);
                parent.OpenChildForm(roomListForm);
            }

            this.Close(); // đóng form hiện tại
        }

        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookings.Rows[e.RowIndex];

                lblBookingId.Text = row.Cells["BookingID"].Value?.ToString();
                lblCustomerName.Text = row.Cells["CustomerName"].Value?.ToString();
                lblPhone.Text = row.Cells["PhoneNumber"].Value?.ToString();
                lblCheckIn.Text = Convert.ToDateTime(row.Cells["CheckIn"].Value).ToString("dd/MM/yyyy HH:mm");
                lblCheckOut.Text = Convert.ToDateTime(row.Cells["CheckOut"].Value).ToString("dd/MM/yyyy HH:mm");
                lblRentalType.Text = row.Cells["RentalType"].Value?.ToString();
                lblPrice.Text = string.Format("{0:N0} VND", row.Cells["Price"].Value);
            }
        }
    }
}
