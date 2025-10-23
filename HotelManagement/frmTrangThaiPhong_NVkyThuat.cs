using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace HotelManagement
{
    public partial class frmTrangThaiPhong_NVkyThuat : Form
    {
        public frmTrangThaiPhong_NVkyThuat()
        {
            InitializeComponent();
        }
        RoomStatus_StaffTech_BUS roomStatus_StaffTech_BUS = new RoomStatus_StaffTech_BUS();
        private void frmTrangThaiPhong_NVkyThuat_Load(object sender, EventArgs e)
        {
            dtGV_TrangThai.DataSource = roomStatus_StaffTech_BUS.getAllRoomStatus();
        }

        private void dtGV_TrangThai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dong = e.RowIndex;
                txtMaPhong.Text = dtGV_TrangThai.Rows[dong].Cells["RoomID"].Value.ToString();
                txtRoomName.Text = dtGV_TrangThai.Rows[dong].Cells["RoomName"].Value.ToString();
                cbStatus.SelectedItem = dtGV_TrangThai.Rows[dong].Cells["Status"].Value.ToString();
            }

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string currentStatus = dtGV_TrangThai.Rows[dtGV_TrangThai.CurrentCell.RowIndex]
                .Cells["Status"].Value.ToString();

            string selectedStatus = cbStatus.SelectedItem?.ToString(); 

            if (selectedStatus == currentStatus)
            {
                MessageBox.Show("Trạng thái phòng không thay đổi!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int roomID = Convert.ToInt32(txtMaPhong.Text);
            string status = cbStatus.SelectedItem.ToString();
            try
            {
                bool result = roomStatus_StaffTech_BUS.updateStatusRooms_StaffTech(roomID, status);
                if (result)
                {
                    MessageBox.Show("Cập nhật trạng thái phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_TrangThai.DataSource = roomStatus_StaffTech_BUS.getAllRoomStatus();
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
    }
}
