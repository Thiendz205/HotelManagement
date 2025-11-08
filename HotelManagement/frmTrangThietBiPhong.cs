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
    public partial class frmTrangThietBiPhong : Form
    {
        private string maNhanVien;
        public frmTrangThietBiPhong(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
        }
        RoomEquipment_BUS roomEquipment_BUS = new RoomEquipment_BUS();
        string RoomEquipmentID = "";

        private void frmTrangThietBiPhong_Load(object sender, EventArgs e)
        {
            dtGV_RoomEquipment.DataSource = roomEquipment_BUS.getAllRoomEquipment();
            cbThietBi.DataSource = roomEquipment_BUS.getEquipmentNameAndID();
            cbThietBi.DisplayMember = "EquipmentName";
            cbThietBi.ValueMember = "EquipmentID";
            cbPhong.DataSource = roomEquipment_BUS.getIDNameRoom();
            cbPhong.DisplayMember = "RoomName";
            cbPhong.ValueMember = "RoomID";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (cbThietBi.SelectedIndex == -1 || cbPhong.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn phòng và thiết bị!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtQTY.Text, out int soLuong) || soLuong <= 0)
                {
                    MessageBox.Show("Số lượng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RoomEquipment_ET item = new RoomEquipment_ET
                {
                    RoomEquipmentID = "",
                    RoomID = cbPhong.SelectedValue.ToString(),
                    EquipmentStorage = cbThietBi.SelectedValue.ToString(),
                    Quantity = soLuong,
                    InstalledDate = dtNgayLapDat.Value,
                    Condition = cbTinhTrang.Text,
                    Note = txtNote.Text.Trim(),
                    StaffID = maNhanVien
                };

                bool result = roomEquipment_BUS.AddRoomEquipment(item);

                if (result)
                {
                    MessageBox.Show("Thêm thiết bị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_RoomEquipment.DataSource = roomEquipment_BUS.getAllRoomEquipment();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            if (cbThietBi.SelectedIndex == -1 || cbPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng và thiết bị!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQTY.Text, out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                RoomEquipment_ET et = new RoomEquipment_ET
                {

                    RoomEquipmentID = this.RoomEquipmentID,
                    RoomID = cbPhong.SelectedValue.ToString(),
                    EquipmentStorage = cbThietBi.SelectedValue.ToString(),
                    Quantity = int.Parse(txtQTY.Text),
                    InstalledDate = dtNgayLapDat.Value,
                    Condition = cbTinhTrang.Text,
                    Note = txtNote.Text,
                    StaffID = maNhanVien
                };

                bool success = roomEquipment_BUS.UpdateRoomEquipment(et);

                if (success)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    dtGV_RoomEquipment.DataSource = roomEquipment_BUS.getAllRoomEquipment();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại! Kiểm tra lại số lượng hoặc dữ liệu.", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(cbPhong.SelectedIndex == -1 )
            {
                MessageBox.Show("Vui lòng chọn phòng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbThietBi.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thiết bị!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa thiết bị này và trả về kho không?",
                                              "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bool success = roomEquipment_BUS.RemoveRoomEquipment(RoomEquipmentID);

                if (success)
                {
                    MessageBox.Show("Đã xóa và cập nhật lại kho thành công!", "Thông báo");
                    dtGV_RoomEquipment.DataSource = roomEquipment_BUS.getAllRoomEquipment();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi");
                }
            }
        }

        private void dtGV_RoomEquipment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGV_RoomEquipment.Rows[e.RowIndex];
                RoomEquipmentID = row.Cells["RoomEquipmentID"].Value.ToString();
                cbPhong.SelectedValue = row.Cells["RoomID"].Value.ToString();
                cbThietBi.SelectedValue = row.Cells["EquipmentStorage"].Value.ToString();
                txtQTY.Text = row.Cells["Quantity"].Value.ToString();
                dtNgayLapDat.Value = Convert.ToDateTime(row.Cells["InstalledDate"].Value);
                cbTinhTrang.Text = row.Cells["Condition"].Value.ToString();
                txtNote.Text = row.Cells["Note"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtNote.Clear();
            txtQTY.Clear();
            dtNgayLapDat.Value = DateTime.Now;
            cbPhong.SelectedIndex = -1;
            cbThietBi.SelectedIndex = -1;
            cbTinhTrang.SelectedIndex = -1;
            dtGV_RoomEquipment.DataSource = roomEquipment_BUS.getAllRoomEquipment();
        }
    }
}
