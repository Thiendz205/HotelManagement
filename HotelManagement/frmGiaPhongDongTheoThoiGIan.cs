using BUS;
using ET;
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
    public partial class frmGiaPhongDongTheoThoiGIan : Form
    {
        public frmGiaPhongDongTheoThoiGIan()
        {
            InitializeComponent();
        }
        RoomTypePrice_BUS roomTypePrice_BUS = new RoomTypePrice_BUS();
        private void frmGiaPhongDongTheoThoiGIan_Load(object sender, EventArgs e)
        {
            dtGiaPhongThayDoi.DataSource = roomTypePrice_BUS.getAllRoomTypePrices();
            cbBPhong.DataSource = roomTypePrice_BUS.getNameIDRoom();
            cbBPhong.DisplayMember = "TypeName";
            cbBPhong.ValueMember = "RoomTypeID";
            dtGiaPhongThayDoi.Columns["PricePerDay"].DefaultCellStyle.Format = "N0";
            dtGiaPhongThayDoi.Columns["PricePerHour"].DefaultCellStyle.Format = "N0";



        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGiaTheoGio.Text))
            {
                MessageBox.Show("Vui lòng nhập giá theo giờ!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiaTheoNgay.Text))
            {
                MessageBox.Show("Vui lòng nhập giá theo ngày!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RoomTypePrice_ET et = new RoomTypePrice_ET
                {
                    RoomTypeID = cbBPhong.SelectedValue.ToString(),
                    StartDate = dtNgayBatDau.Value.Date,
                    EndDate = dtNgayKetThuc.Value.Date,
                    PricePerDay = decimal.Parse(txtGiaTheoNgay.Text),
                    PricePerHour = decimal.Parse(txtGiaTheoGio.Text),
                    Note = txtNote.Text
                };

                if (roomTypePrice_BUS.IsOverlap(et))
                {
                    MessageBox.Show("Khoảng thời gian này đã có giá giảm cho loại phòng này rồi!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = roomTypePrice_BUS.AddRoomTypePrice(et);

                if (success)
                {
                    MessageBox.Show("Thêm giá loại phòng thành công!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dtGiaPhongThayDoi.DataSource = roomTypePrice_BUS.getAllRoomTypePrices();
                }
                else
                {
                    MessageBox.Show(" Thêm thất bại!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaGiam.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã giá để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try 
            {   

                 int priceID = Convert.ToInt32(txtMaGiam.Text);

                 DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa giá này không?",
                                                  "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                bool success = roomTypePrice_BUS.DeleteRoomTypePrice(priceID);

                if (success)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGiaPhongThayDoi.DataSource = roomTypePrice_BUS.getAllRoomTypePrices();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            catch (Exception ex)
            {
                 MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGiaPhongThayDoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGiaPhongThayDoi.Rows[e.RowIndex];
                txtMaGiam.Text = row.Cells["PriceID"].Value.ToString();
                cbBPhong.Text = row.Cells["TypeName"].Value.ToString();
                dtNgayBatDau.Value = Convert.ToDateTime(row.Cells["StartDate"].Value);
                dtNgayKetThuc.Value = Convert.ToDateTime(row.Cells["EndDate"].Value);

                if (decimal.TryParse(row.Cells["PricePerDay"].Value.ToString(), out decimal priceDay))
                    txtGiaTheoNgay.Text = priceDay.ToString("0"); 

                if (decimal.TryParse(row.Cells["PricePerHour"].Value.ToString(), out decimal priceHour))
                    txtGiaTheoGio.Text = priceHour.ToString("0");

                txtNote.Text = row.Cells["Note"].Value?.ToString();
                txtMaGiam.Enabled = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbBPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiaTheoGio.Text))
            {
                MessageBox.Show("Vui lòng nhập giá theo giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGiaTheoNgay.Text))
            {
                MessageBox.Show("Vui lòng nhập giá theo ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtNgayKetThuc.Value.Date < dtNgayBatDau.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                RoomTypePrice_ET et = new RoomTypePrice_ET()
                {
                    PriceID = int.Parse(txtMaGiam.Text),
                    RoomTypeID = cbBPhong.SelectedValue.ToString(),
                    StartDate = dtNgayBatDau.Value.Date,
                    EndDate = dtNgayKetThuc.Value.Date,
                    PricePerDay = decimal.Parse(txtGiaTheoNgay.Text),
                    PricePerHour = decimal.Parse(txtGiaTheoGio.Text),
                    Note = txtNote.Text
                };

                bool isOverlap = roomTypePrice_BUS.CheckOverlapForUpdate(et);
                if (isOverlap)
                {
                    MessageBox.Show("Khoảng thời gian giảm giá bị trùng với đợt giảm khác!",
                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                bool result = roomTypePrice_BUS.Update(et);

                if (result)
                {
                    MessageBox.Show("Cập nhật giá phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGiaPhongThayDoi.DataSource = roomTypePrice_BUS.getAllRoomTypePrices();
                }
                else
                {
                    MessageBox.Show("Lỗi khi cập nhật dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGiam.Clear();
            txtGiaTheoGio.Clear();
            txtGiaTheoNgay.Clear();
            txtNote.Clear();
            txtMaGiam.Enabled = true;
            dtGiaPhongThayDoi.DataSource = roomTypePrice_BUS.getAllRoomTypePrices();

        }

        private void btnXoaHetHan_Click(object sender, EventArgs e)
        {
            int soDongXoa = roomTypePrice_BUS.RemoveExpiredPrices();

            if (soDongXoa > 0)
            {
                MessageBox.Show($"{soDongXoa} giá phòng đã hết hạn và được xóa!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtGiaPhongThayDoi.DataSource = roomTypePrice_BUS.getAllRoomTypePrices();
            }
            else
            {
                MessageBox.Show("Không có giá nào hết hạn.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMaGiam_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGiaTheoNgay_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtGiaTheoNgay.Text, "[^0-9]"))
            {
                MessageBox.Show("Chỉ được nhập số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGiaTheoNgay.Text = System.Text.RegularExpressions.Regex.Replace(txtGiaTheoNgay.Text, "[^0-9]", "");
                txtGiaTheoNgay.SelectionStart = txtGiaTheoNgay.Text.Length;
            }
        }
    }
}
