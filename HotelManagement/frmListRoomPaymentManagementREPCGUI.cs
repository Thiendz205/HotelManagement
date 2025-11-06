using BUS;
using ET;
using Guna.UI2.WinForms;
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
    public partial class frmListRoomPaymentManagementREPCGUI : Form
    {
        private readonly string staffId;
        private readonly BookingBUS bookingBus = new BookingBUS();
        public frmListRoomPaymentManagementREPCGUI(string staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
        }

        private void frmListRoomPaymentManagementREPCGUI_Load(object sender, EventArgs e)
        {
            LoadRoomTypeCombo();
            LoadActiveRoomButtons();
        }
        private void LoadRoomTypeCombo()
        {
            var types = bookingBus.GetAllRoomTypes();
            cboRoomType.Items.Clear();
            cboRoomType.Items.Add("Tất cả");
            foreach (var t in types)
                cboRoomType.Items.Add(t);
            cboRoomType.SelectedIndex = 0;
        }
        private void LoadActiveRoomButtons(List<BookingET> rooms = null)
        {
            flowLayoutPanelRooms.Controls.Clear();

            if (rooms == null)
                rooms = bookingBus.GetActiveRooms();

            foreach (var room in rooms)
            {
                var btn = new Guna2Button
                {
                    Text = $"{room.RoomName}\n({room.RoomTypeName})\n[{room.RoomStatus}]",
                    Tag = room.RoomID,
                    Width = 230,
                    Height = 110,
                    Font = new Font("Times New Roman", 11, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Margin = new Padding(12),
                    BorderRadius = 25,
                    TextAlign = HorizontalAlignment.Center,
                    FillColor = Color.LightSkyBlue,
                };

                // 🔹 Màu khác nếu phòng có trạng thái đặc biệt
                if (room.RoomStatus.Trim().Equals("Đang hoạt động", StringComparison.OrdinalIgnoreCase))
                    btn.FillColor = Color.LightSkyBlue;
                else
                    btn.FillColor = Color.LightGray;

                btn.HoverState.FillColor = ControlPaint.Light(btn.FillColor, 0.8f);

                btn.Click += (s, e) =>
                {
                    string roomId = (string)((Guna2Button)s).Tag;
                    var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
                    if (parent != null)
                    {
                        // 🔹 Mở form quản lý thanh toán
                        var paymentForm = new frmPaymentManagementREPCGUI(staffId, roomId, room.RoomName, room.RoomStatus);
                        parent.OpenChildForm(paymentForm);
                    }
                };

                flowLayoutPanelRooms.Controls.Add(btn);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text.Trim();
            string roomType = cboRoomType.SelectedItem?.ToString() ?? "Tất cả";

            var rooms = bookingBus.FindActiveRooms(roomName, roomType);

            if (rooms == null || rooms.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng đang hoạt động phù hợp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadActiveRoomButtons();
                return;
            }

            LoadActiveRoomButtons(rooms);
        }
    }
}
