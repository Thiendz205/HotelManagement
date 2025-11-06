using BUS;
using ET;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmReceptionistsRoomList : Form
    {
        private readonly string staffId;
        public frmReceptionistsRoomList(string staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            
        }
        BookingBUS bookingBus = new BookingBUS();
        private void LoadRoomButtons(List<BookingET> rooms = null)
        {
            flowLayoutPanelRooms.Controls.Clear();

            if (rooms == null)
                rooms = bookingBus.GetRoomsForBookingList();

            foreach (var room in rooms)
            {
                var btn = new Guna2Button();
                btn.Text = $"{room.RoomName}\n({room.RoomTypeName})\n[{(room.RoomStatus == "Available" ? "Trống" : room.RoomStatus)}]";
                btn.Tag = room.RoomID;
                btn.Width = 230;
                btn.Height = 110;
                btn.Font = new Font("Times New Roman", 11, FontStyle.Bold);
                btn.ForeColor = Color.Black;
                btn.Margin = new Padding(12);
                btn.BorderRadius = 25;
                btn.TextAlign = HorizontalAlignment.Center;

                if (room.RoomStatus.Trim().Equals("Đặt trước", StringComparison.OrdinalIgnoreCase))
                    btn.FillColor = Color.FromArgb(255, 192, 192);
                else
                    btn.FillColor = Color.LightGreen;

                btn.HoverState.FillColor = ControlPaint.Light(btn.FillColor, 0.8f);

                btn.Click += (s, e) =>
                {
                    string roomId = (string)((Guna2Button)s).Tag;
                    var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
                    if (parent != null)
                    {
                        var bookingDetailForm = new frmBookingGUI(staffId, roomId, room.RoomName, room.RoomStatus);
                        parent.OpenChildForm(bookingDetailForm);
                    }
                };

                flowLayoutPanelRooms.Controls.Add(btn);
            }
        }

        private void LoadRoomTypeCombo()
        {
            var types = bookingBus.GetAllRoomTypes(); // bạn sẽ thêm hàm này ở dưới
            cboRoomType.Items.Clear();
            cboRoomType.Items.Add("Tất cả");
            foreach (var t in types)
                cboRoomType.Items.Add(t);
            cboRoomType.SelectedIndex = 0;
        }

        private void frmReceptionistsRoomList_Load(object sender, EventArgs e)
        {
            LoadRoomButtons();
            LoadRoomTypeCombo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text.Trim();
            string roomType = cboRoomType.SelectedItem?.ToString() ?? "Tất cả";

            var rooms = bookingBus.SearchRooms(roomName, roomType) ?? new List<BookingET>();

            if (rooms.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoomButtons();
                return;
            }

            LoadRoomButtons(rooms);
        }
    }
}
