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
        private string staffId;
        public frmChangeRoomStatusRECPGUI(string staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }

        private void frmChangeRoomStatusRECPGUI_Load(object sender, EventArgs e)
        {
            LoadCleaningRooms();
            cboRoomType.DataSource = bus.GetAllRoomTypess();
        }

        private readonly BookingBUS bus = new BookingBUS();
        private void LoadCleaningRooms()
        {
         
            var rooms = bus.GetCleaningRooms();
            dgvRooms.DataSource = rooms;

            // Thêm checkbox cột Select
            if (!dgvRooms.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "Select";
                chk.Width = 60;
                dgvRooms.Columns.Insert(0, chk);
            }

            AddSelectAllCheckBox(); // <-- thêm dòng này

            HideUnusedColumns();
            RenameHeaders();
            dgvRooms.Columns["Select"].ReadOnly = false;
        }
        private void HideUnusedColumns()
        {
            string[] showColumns =
            {
                "Select", "RoomID", "RoomName", "RoomTypeName", "RoomStatus"
            };

            foreach (DataGridViewColumn col in dgvRooms.Columns)
            {
                if (!showColumns.Contains(col.Name))
                    col.Visible = false;
            }
        }

        // Đổi header sang tiếng Việt
        private void RenameHeaders()
        {
            dgvRooms.Columns["RoomID"].HeaderText = "Mã phòng";
            dgvRooms.Columns["RoomName"].HeaderText = "Tên phòng";
            dgvRooms.Columns["RoomTypeName"].HeaderText = "Loại phòng";
            dgvRooms.Columns["RoomStatus"].HeaderText = "Trạng thái";
        }

        private List<string> GetSelectedRooms()
        {
            List<string> selected = new List<string>();

            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value);

                if (isChecked)
                {
                    string roomId = row.Cells["RoomID"].Value.ToString();
                    selected.Add(roomId);
                }
            }

            return selected;
        }
        private void AddSelectAllCheckBox()
        {
            // Nếu chưa có cột Select
            if (!dgvRooms.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                chk.HeaderText = "";
                chk.Name = "Select";
                chk.Width = 60;
                dgvRooms.Columns.Insert(0, chk);
            }

            // Thêm checkbox vào header
            Rectangle rect = dgvRooms.GetCellDisplayRectangle(0, -1, true);
            CheckBox chkHeader = new CheckBox();
            chkHeader.Name = "chkHeader";
            chkHeader.Size = new Size(18, 18);
            chkHeader.Location = new Point(rect.Location.X + (rect.Width - 18) / 2, rect.Location.Y + (rect.Height - 18) / 2);
            chkHeader.CheckedChanged += ChkHeader_CheckedChanged;
            dgvRooms.Controls.Add(chkHeader);
        }
        private void ChkHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox headerChk = sender as CheckBox;

            foreach (DataGridViewRow row in dgvRooms.Rows)
            {
                row.Cells["Select"].Value = headerChk.Checked;
            }
        }

        private void btnSetAvailable_Click(object sender, EventArgs e)
        {
            var selectedRooms = GetSelectedRooms();

            if (!selectedRooms.Any())
            {
                MessageBox.Show("Vui lòng chọn ít nhất một phòng!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            // Hộp thoại xác nhận
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn chuyển các phòng đã chọn sang TRỐNG không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            bool result = bus.UpdateRoomStatusBulk(selectedRooms, "Trống");

            if (result)
            {
                MessageBox.Show("Cập nhật trạng thái thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCleaningRooms();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSetMaintenance_Click(object sender, EventArgs e)
        {

            var selectedRooms = GetSelectedRooms();
            if (!selectedRooms.Any() || string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("Vui lòng chọn phòng và nhập ghi chú!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn gửi yêu cầu bảo trì cho các phòng này?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            // ❗Không update phòng ở đây
            using (frmMaintenanceCreateGUI f = new frmMaintenanceCreateGUI(selectedRooms))
            {
                f.Note = txtNote.Text.Trim(); // gửi note qua

                var result = f.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Lúc này Save thành công → Update phòng lúc này!
                    bus.UpdateRoomStatusBulk(selectedRooms, "Bảo trì", txtNote.Text.Trim());

                    LoadCleaningRooms();
                    MessageBox.Show("Đã chuyển sang Bảo trì!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Cancel → không làm gì, giữ nguyên trạng thái phòng
                    MessageBox.Show("Đã hủy bảo trì, trạng thái phòng giữ nguyên.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            txtNote.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string roomName = txtRoomName.Text.Trim();
            string roomType = cboRoomType.SelectedItem?.ToString() ?? "Tất cả";

            // Lấy danh sách phòng tìm được
            var rooms = bus.SearchCleaningRooms(roomName, roomType) ?? new List<BookingET>();

            if (rooms.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phòng phù hợp!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                LoadCleaningRooms();
                return;
            }
            dgvRooms.DataSource = rooms;
            HideUnusedColumns();

            // Đổi header sang tiếng Việt
            RenameHeaders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var listForm = new frmReceptionistsRoomList(staffId); // truyền staffId nếu cần
                parent.OpenChildForm(listForm);
            }
        }
    }
}
