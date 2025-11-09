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
        public frmChinhSuaPhong()
        {
            InitializeComponent();
        }

        private void frmChinhSuaPhong_Load(object sender, EventArgs e)
        {
            dtGV_Room.DataSource = room_BUS.getAllRooms();
            cbTypeRoom.DataSource = room_BUS.getAll_ID_and_Name_RoomType();
            dtGV_Room.Columns["RoomTypeID"].Visible = false;
            dtGV_Room.Columns["TypeName"].DisplayIndex = 2;

            cbTypeRoom.DisplayMember = "TypeName";
            cbTypeRoom.ValueMember = "RoomTypeID";

        }

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

            if ( status == "Đặt trước" ||
                status == "Đang hoạt động" )
            {
                MessageBox.Show("Chỉ được sửa phòng có trạng thái Mới tạo, Trống, Dọn dẹp", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbStatus.Text == "Mới tạo")
            {
                bool check = room_BUS.checkRoomHasEquipment(txtRoomID.Text);
                if (check)
                {
                    MessageBox.Show("Phòng đã có thiết bị, không thể chuyển về trạng thái Mới tạo!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if(cbStatus.Text == "Dọn dẹp")
            {
                bool check = room_BUS.checkRoomHasEquipment(txtRoomID.Text);
                if (!check)
                {
                    MessageBox.Show("Phòng không có thiết bị, không thể chuyển về trạng thái Đang dọn dẹp!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if(cbStatus.Text == "Đang bảo trì")
            {
                bool check = room_BUS.checkRoomHasEquipment(txtRoomID.Text);
                if (!check)
                {
                    MessageBox.Show("Phòng không có thiết bị, không thể chuyển về trạng thái Đang bảo trì!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if(cbStatus.Text == "Trống")
            {
                bool check = room_BUS.checkRoomHasEquipment(txtRoomID.Text);
                if (!check)
                {
                    MessageBox.Show("Phòng không có thiết bị, không thể chuyển về trạng thái Trống!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            try
            {
                
                string roomName = txtRoomName.Text;

                if (room_BUS.checkExistenceNameRoom_UPDate(roomName, txtRoomID.Text))
                {
                    MessageBox.Show("Tên phòng đã tồn tại! Vui lòng nhập tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                room_ET.RoomID = txtRoomID.Text;
                room_ET.RoomName = roomName;
                room_ET.RoomTypeID = cbTypeRoom.SelectedValue.ToString();
                room_ET.Capacity = int.Parse(txtCapacity.Text.Replace(".", "").Replace(",", ""));
                room_ET.Description = txtDescription.Text;
                room_ET.Status = cbStatus.Text;
                room_ET.Official = cbOfficial.Text;

                bool success = room_BUS.updateRoom(room_ET);
                if (success)
                {
                    MessageBox.Show("Sửa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_Room.DataSource = room_BUS.getAllRooms();
                }
                else
                {
                    MessageBox.Show("Sửa phòng thất bại! Vui lòng kiểm tra lại ID phòng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGV_Room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                DataGridViewRow row = dtGV_Room.Rows[dong];
                txtRoomID.Text = row.Cells["RoomID"].Value?.ToString();
                txtRoomName.Text = row.Cells["RoomName"].Value?.ToString();
                cbTypeRoom.Text = row.Cells["TypeName"].Value?.ToString();  
                txtCapacity.Text = row.Cells["Capacity"].Value?.ToString();
                txtDescription.Text = row.Cells["Description"].Value?.ToString();
                cbStatus.Text = row.Cells["Status"].Value?.ToString();
                cbOfficial.Text = row.Cells["Official"].Value?.ToString();       
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
