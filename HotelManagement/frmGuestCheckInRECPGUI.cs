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
    public partial class frmGuestCheckInRECPGUI : Form
    {
        private string staffId;
        public frmGuestCheckInRECPGUI(string staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }
        BookingBUS bookingBus = new BookingBUS();
        private void frmGuestCheckInRECPGUI_Load(object sender, EventArgs e)
        {
            LoadRoomTypeCombo();
            LoadReservedRoomButtons();
        }
        private void LoadReservedRoomButtons(List<BookingET> rooms = null)
        {
            flowLayoutPanelRooms.Controls.Clear();

            if (rooms == null)
                rooms = bookingBus.GetPreBookedRooms(); // 🔹 chỉ lấy phòng "Đặt trước"

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
                    FillColor = Color.FromArgb(255, 192, 192),
                    HoverState = { FillColor = ControlPaint.Light(Color.FromArgb(255, 192, 192), 0.8f) }
                };

                btn.Click += (s, e) =>
                {
                    string roomId = (string)((Guna2Button)s).Tag;
                    var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
                    if (parent != null)
                    {
                        var checkinForm = new frmCheckInFromReservationRECPGUI(roomId, room.RoomName, room.RoomStatus,staffId);
                        parent.OpenChildForm(checkinForm);
                    }
                };

                flowLayoutPanelRooms.Controls.Add(btn);
            }
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text.Trim();
            string roomType = cboRoomType.SelectedItem?.ToString() ?? "Tất cả";

            var rooms = bookingBus.SearchPreBookedRooms(roomName, roomType) ?? new List<BookingET>();

            if (rooms.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng phù hợp!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadReservedRoomButtons(); // hiện lại toàn bộ phòng "Đặt trước"
                return;
            }

            LoadReservedRoomButtons(rooms);
        }
    }
}
