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
    public partial class frmChangeRoomStatusRECPGUI : Form
    {
        public frmChangeRoomStatusRECPGUI()
        {
            InitializeComponent();
        }

        private void frmChangeRoomStatusRECPGUI_Load(object sender, EventArgs e)
        {
            LoadComboboxes();
        }
        private readonly BookingBUS bus = new BookingBUS();
        private void LoadComboboxes()
        {
            // 🔹 Load tất cả phòng
            var rooms = new List<BookingET>();
            var roomTypes = bus.GetRoomTypes();

            foreach (var type in roomTypes)
            {
                var typeRooms = bus.GetRoomsByType(type.BookingID);
                rooms.AddRange(typeRooms);
            }

            // ✅ Gán vào cboRoom (KHÔNG phải cboStatus)
            cboRoom.DataSource = rooms;
            cboRoom.DisplayMember = "RoomName";
            cboRoom.ValueMember = "RoomID";
            cboRoom.SelectedIndex = -1;
            cboRoom.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboRoom.AutoCompleteSource = AutoCompleteSource.ListItems;

            // 🔹 Danh sách trạng thái phòng
            var statuses = new List<string>
    {
        "Trống",
        "Bảo trì",
        "Dọn dẹp"
    };

            // ✅ Gán riêng cho cboStatus
            cboStatus.DataSource = statuses;
            cboStatus.SelectedIndex = -1;
        }


        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (cboRoom.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new BookingET
            {
                RoomID = cboRoom.SelectedValue.ToString(), // ✅ đổi int → string
                RoomStatus = cboStatus.SelectedItem.ToString()
            };

            bool result = bus.UpdateRoomStatus(dto);

            if (result)
            {
                MessageBox.Show("Cập nhật trạng thái phòng thành công!", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblCurrentStatus.Text = $"Trạng thái hiện tại: {dto.RoomStatus}";
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboRoom.SelectedValue == null) return;
            string roomId = cboRoom.SelectedValue.ToString();

            string currentStatus = bus.GetRoomStatus(roomId);
            lblCurrentStatus.Text = $"Trạng thái hiện tại: {currentStatus}";
        }
    }
}
