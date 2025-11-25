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
using System.Text.RegularExpressions;


namespace HotelManagement
{
    public partial class frmChinhSuaPhong : Form
    {
        Room_ET room_ET = new Room_ET();
        Room_BUS room_BUS = new Room_BUS();
        MaintenanceLog_BUS maintenanceLog_BUS = new MaintenanceLog_BUS();
        public frmChinhSuaPhong()
        {
            InitializeComponent();
        }

        private void frmChinhSuaPhong_Load(object sender, EventArgs e)
        {
            dtGV_Room.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtGV_Room.MultiSelect = false;
            dtGV_Room.DataSource = room_BUS.getAllRooms();
            cbTypeRoom.DataSource = room_BUS.getAll_ID_and_Name_RoomType();
            dtGV_Room.Columns["RoomTypeID"].Visible = false;
            dtGV_Room.Columns["TypeName"].DisplayIndex = 2;

            cbTypeRoom.DisplayMember = "TypeName";
            cbTypeRoom.ValueMember = "RoomTypeID";

        }
        private string selectedTechStaffID = null;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string message;
            if (string.IsNullOrWhiteSpace(cbTypeRoom.Text))
            {
                MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (string.IsNullOrWhiteSpace(txtRoomName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCapacity.Text))
            {
                MessageBox.Show("Vui lòng nhập sức chứa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                MessageBox.Show("Vui lòng chọn trạng thái phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string status = cbStatus.Text.Trim();

            if (status == "Đang sử dụng" || status == "Dọn dẹp" ||
                status == "Đặt trước" || status == "Đang bảo trì"||
                status == "Đang hoạt động" || status == "Trống")
            {
                MessageBox.Show("Trạng thái phòng mới phải là 'Mới tạo'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (room_BUS.checkExistenceNameRoom(txtRoomName.Text))
                {
                    room_ET.RoomName = txtRoomName.Text;
                    room_ET.RoomTypeID = cbTypeRoom.SelectedValue.ToString();
                    room_ET.Capacity = int.Parse(txtCapacity.Text.Replace(".", "").Replace(",", ""));
                    room_ET.Description = txtDescription.Text;
                    room_ET.Status = cbStatus.Text;
                    room_ET.Official = "Chưa chứng thực";
                   
                    bool success = room_BUS.addRoom(room_ET);
                    if (success)
                    {
                        MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtGV_Room.DataSource = room_BUS.getAllRooms();
                    }
                    else
                    {
                        MessageBox.Show("Thêm phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Tên phòng không thể trùng! Vui lòng nhập lại tên phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtRoomID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbStatus.Text == "Đang hoạt động" || cbStatus.Text == "Đặt trước" || cbStatus.Text == "Dọn dẹp")
            {
                MessageBox.Show("Không thể xóa phòng đang hoạt động, đặt trước hoặc đang dọn dẹp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; 
                }
                bool success = room_BUS.removeRoom(txtRoomID.Text);
               
                    if (success)
                    {
                        MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtGV_Room.DataSource = room_BUS.getAllRooms();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phòng thất bại! Vui lòng kiểm tra lại ID phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // ============================
            // 0. KIỂM TRA HÀNG ĐƯỢC CHỌN
            // ============================
            if (dtGV_Room.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ============================
            // 1. KIỂM TRA DỮ LIỆU NHẬP
            // ============================
            if (string.IsNullOrWhiteSpace(cbTypeRoom.Text) ||
                string.IsNullOrWhiteSpace(txtRoomName.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                string.IsNullOrWhiteSpace(cbStatus.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newStatus = cbStatus.Text.Trim();
            string oldStatus = dtGV_Room.SelectedRows[0].Cells["Status"].Value.ToString();
            bool hasEquipment = room_BUS.checkRoomHasEquipment(txtRoomID.Text);

            // --- RULE: Mới tạo nhưng có thiết bị → không cho phép
            if (newStatus == "Mới tạo" && hasEquipment)
            {
                MessageBox.Show("Phòng đã có thiết bị, không thể chuyển về Mới tạo!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- RULE: Dọn dẹp / Trống / Bảo trì nhưng không có thiết bị
            if ((newStatus == "Dọn dẹp" || newStatus == "Trống" || newStatus == "Bảo trì") && !hasEquipment)
            {
                MessageBox.Show("Phòng không có thiết bị, không thể chuyển về trạng thái này!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- RULE: Không cho chuyển về Trống khi phòng đang bảo trì
            if (newStatus == "Trống" && oldStatus == "Bảo trì")
            {
                MessageBox.Show("Không thể chuyển lại thành trống khi phòng đang bảo trì.\nVui lòng sang mục Bảo trì để hoàn tất!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ============================
                // 2. KIỂM TRA TÊN PHÒNG TRÙNG
                // ============================
                string roomName = txtRoomName.Text.Trim();

                if (room_BUS.checkExistenceNameRoom_UPDate(roomName, txtRoomID.Text))
                {
                    MessageBox.Show("Tên phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ============================
                // 3. GÁN GIÁ TRỊ VÀO ET
                // ============================
                room_ET.RoomID = txtRoomID.Text;
                room_ET.RoomName = roomName;
                room_ET.RoomTypeID = cbTypeRoom.SelectedValue.ToString();
                room_ET.Capacity = int.Parse(txtCapacity.Text.Replace(".", "").Replace(",", ""));
                room_ET.Description = txtDescription.Text;
                room_ET.Status = newStatus;
                room_ET.Official = cbOfficial.Text;

                // ============================
                // 4. MỞ POPUP CHỌN NHÂN VIÊN KỸ THUẬT (nếu chuyển sang bảo trì)
                // ============================
                string techStaffID = null;

                if (newStatus == "Bảo trì" && oldStatus != "Bảo trì")
                {
                    frmChooseStaffTech frm = new frmChooseStaffTech();
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        techStaffID = frm.SelectedStaffID;
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn nhân viên kỹ thuật!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // ============================
                // 5. CẬP NHẬT PHÒNG
                // ============================
                bool success = room_BUS.updateRoom(room_ET);

                if (!success)
                {
                    MessageBox.Show("Sửa phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ============================
                // 6. TẠO LOG PHÒNG (MaintenanceTypeID = 1)
                // ============================
                if (newStatus == "Bảo trì" && oldStatus != "Bảo trì")
                {
                    MaintenanceLog_ET log = new MaintenanceLog_ET
                    {
                        MaintenanceTypeID = 1,
                        RoomID = txtRoomID.Text,
                        RoomEquipmentID = null,   // ❗ Không có thiết bị → để null
                        StaffID = techStaffID,
                        MaintenanceDate = DateTime.Now,
                        Status = "Not completed",
                        Note = "Phòng chuyển sang bảo trì từ màn hình sửa phòng"
                    };

                    maintenanceLog_BUS.AddLog(log);
                }

                // ============================
                // 7. THÔNG BÁO + LOAD LẠI
                // ============================
                MessageBox.Show("Sửa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGV_Room.DataSource = room_BUS.getAllRooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGV_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dtGV_Room.Rows[e.RowIndex];

            txtRoomID.Text = row.Cells["RoomID"]?.Value?.ToString();
            txtRoomName.Text = row.Cells["RoomName"]?.Value?.ToString();
            cbTypeRoom.Text = row.Cells["TypeName"]?.Value?.ToString();
            txtCapacity.Text = row.Cells["Capacity"]?.Value?.ToString();
            txtDescription.Text = row.Cells["Description"]?.Value?.ToString();
            cbStatus.Text = row.Cells["Status"]?.Value?.ToString();

            // 🔥 KIỂM TRA CỘT TỒN TẠI TRƯỚC KHI GÁN
            if (dtGV_Room.Columns.Contains("Official"))
            {
                cbOfficial.Text = row.Cells["Official"]?.Value?.ToString();
            }
            else
            {
                cbOfficial.Text = "Chưa chứng thực"; // fallback
            }
        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtCapacity.Text = "";
            txtDescription.Text = "";
            txtRoomID.Text = "";
            txtRoomName.Text = "";
            cbTypeRoom.Text = "";
            cbStatus.Text = "";
            dtGV_Room.DataSource = room_BUS.getAllRooms();
            cbTypeRoom.Enabled = true;
            cbOfficial.Text = "Chưa chứng thực";


        }

        private void txtRoomName_TextChanged(object sender, EventArgs e)
        {
           if(txtRoomName.Text.Length > 50 )
           {
                MessageBox.Show("Tên phòng không được vượt quá 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomName.Text = txtRoomName.Text.Substring(0, 50);
                txtRoomName.SelectionStart = txtRoomName.Text.Length;
                txtRoomName.SelectionLength = 0;
           }
           if(txtRoomName.Text.StartsWith(" "))
           {
                MessageBox.Show("Tên phòng không được bắt đầu bằng khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRoomName.Text = txtRoomName.Text.TrimStart();
                txtRoomName.SelectionStart = txtRoomName.Text.Length;
                txtRoomName.SelectionLength = 0;
           }
           //if (Regex.IsMatch(txtRoomName.Text, @"[^a-zA-Z0-9\s\u00C0-\u1EF9]"))
           //{
           //     MessageBox.Show("Tên phòng không được chứa ký tự đặc biệt!",
           //                     "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           //     txtRoomName.Clear();
           //     txtRoomName.Focus();
           //}

        }
        bool isHandlingTextChanged = false;
        private void txtCapacity_TextChanged(object sender, EventArgs e)
        {
            if (isHandlingTextChanged)
                return;

            if (string.IsNullOrWhiteSpace(txtCapacity.Text))
                return;

            if (!int.TryParse(txtCapacity.Text, out int capacity))
            {
                isHandlingTextChanged = true; // đánh dấu đang xử lý
                MessageBox.Show("Vui lòng chỉ nhập số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapacity.Clear();
                txtCapacity.Focus();
                isHandlingTextChanged = false; // reset lại
                return;
            }
            
            if (capacity <= 0)
            {
                isHandlingTextChanged = true;
                MessageBox.Show("Sức chứa phải là số nguyên dương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapacity.Clear();
                txtCapacity.Focus();
                isHandlingTextChanged = false;
                return;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
