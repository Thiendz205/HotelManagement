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
    public partial class frmDanhGiaPhong : Form
    {
        public frmDanhGiaPhong()
        {
            InitializeComponent();
        }

        RoomEvaluation_BUS roomEvaluation_BUS = new RoomEvaluation_BUS();

        private void frmDanhGiaPhong_Load(object sender, EventArgs e)
        {
            dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();
            cbPhong.DataSource = roomEvaluation_BUS.getIDNameRoom();
            cbPhong.DisplayMember = "RoomName";
            cbPhong.ValueMember = "RoomID";
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbAnToan.Text) ||
                string.IsNullOrWhiteSpace(cbCongNghe.Text) ||
                string.IsNullOrWhiteSpace(cbDoiNguNhienVien.Text) ||
                string.IsNullOrWhiteSpace(cbDoSangTrong.Text) ||
                string.IsNullOrWhiteSpace(cbTienIchTrongPhong.Text) ||
                string.IsNullOrWhiteSpace(cbTienNghi.Text) ||
                string.IsNullOrWhiteSpace(cbThaiBo.Text) ||
                string.IsNullOrWhiteSpace(cbVeSinh.Text) ||
                string.IsNullOrWhiteSpace(cbViTri.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các mục đánh giá trước khi thêm!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if(txtNguoiDanhGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người đánh giá!", "Lỗi");
                return;
            }
            if (cbPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng cần cập nhật đánh giá!", "Lỗi");
                return;
            }
            try
            {
                RoomEvaluation_ET et = new RoomEvaluation_ET
                {

                    RoomID = cbPhong.SelectedValue.ToString(),
                    EvaluationDate = DateTime.Now,
                    CleanlinessScore = int.Parse(cbVeSinh.Text),
                    ComfortScore = int.Parse(cbTienNghi.Text),
                    ServiceScore = int.Parse(cbThaiBo.Text),
                    FacilitiesScore = int.Parse(cbTienIchTrongPhong.Text),
                    LocationScore = int.Parse(cbViTri.Text),
                    SafetyScore = int.Parse(cbAnToan.Text),
                    LuxuryScore = int.Parse(cbDoSangTrong.Text),
                    TechnologyScore = int.Parse(cbCongNghe.Text),
                    StaffScore = int.Parse(cbDoiNguNhienVien.Text),
                    Evaluator = txtNguoiDanhGia.Text
                };

                if (roomEvaluation_BUS.addRoomEvaluation(et))
                {
                    // Cập nhật chứng thực
                    string status = roomEvaluation_BUS.UpdateOfficialRoom(et);
                    MessageBox.Show($"Đánh giá đã lưu. Trạng thái phòng: {status}", "Thông báo");
                    dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();

                }
                else
                {
                    MessageBox.Show("Lưu đánh giá thất bại!", "Lỗi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                return;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaDanhGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã đánh giá để xóa đánh giá!", "Lỗi");
                return;
            }
            try
            {
                if (roomEvaluation_BUS.DeleteRoomEvaluation(int.Parse(txtMaDanhGia.Text)))
                {
                    MessageBox.Show("Xóa đánh giá thành công!", "Thông báo");
                    dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();
                }
                else
                {
                    MessageBox.Show("Xóa đánh giá thất bại!", "Lỗi");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                return;
            }
        }

        private void cbVeSinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbVeSinh.Text);
            txtTong.Text = tong.ToString();
        }

        private void cbTienNghi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbTienNghi.Text);
            txtTong.Text = tong.ToString();
        }

        private void cbThaiBo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbThaiBo.Text);
            txtTong.Text = tong.ToString();
        }

        private void cbTienIchTrongPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbTienIchTrongPhong.Text);
            txtTong.Text = tong.ToString();
        }

        private void cbViTri_SelectedIndexChanged(object sender, EventArgs e)
        {

            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbViTri.Text);
            txtTong.Text = tong.ToString();
        }

        private void cbAnToan_SelectedIndexChanged(object sender, EventArgs e)
        {

            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbAnToan.Text);
            txtTong.Text = tong.ToString();
        }

        private void cbDoSangTrong_SelectedIndexChanged(object sender, EventArgs e)
        {

            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbDoSangTrong.Text);
            txtTong.Text = tong.ToString();
        }

        private void cbCongNghe_SelectedIndexChanged(object sender, EventArgs e)
        {

            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbCongNghe.Text);
            txtTong.Text = tong.ToString();
        }

        private void cbDoiNguNhienVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            int tong = Convert.ToInt32(txtTong.Text);
            tong = tong + Convert.ToInt32(cbDoiNguNhienVien.Text);
            txtTong.Text = tong.ToString();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbAnToan.Text) ||
               string.IsNullOrWhiteSpace(cbCongNghe.Text) ||
               string.IsNullOrWhiteSpace(cbDoiNguNhienVien.Text) ||
               string.IsNullOrWhiteSpace(cbDoSangTrong.Text) ||
               string.IsNullOrWhiteSpace(cbTienIchTrongPhong.Text) ||
               string.IsNullOrWhiteSpace(cbTienNghi.Text) ||
               string.IsNullOrWhiteSpace(cbThaiBo.Text) ||
               string.IsNullOrWhiteSpace(cbVeSinh.Text) ||
               string.IsNullOrWhiteSpace(cbViTri.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các mục đánh giá trước khi thêm!",
                                "Thiếu thông tin",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (txtNguoiDanhGia.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên người đánh giá!", "Lỗi");
                return;
            }
            if(cbPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng cần cập nhật đánh giá!", "Lỗi");
                return;
            }
            try
            {
                RoomEvaluation_ET et = new RoomEvaluation_ET
                {
                    EvaluationID = Convert.ToInt32(txtMaDanhGia.Text),
                    RoomID = cbPhong.SelectedValue.ToString(),
                    EvaluationDate = DateTime.Now,
                    CleanlinessScore = int.Parse(cbVeSinh.Text),
                    ComfortScore = int.Parse(cbTienNghi.Text),
                    ServiceScore = int.Parse(cbThaiBo.Text),
                    FacilitiesScore = int.Parse(cbTienIchTrongPhong.Text),
                    LocationScore = int.Parse(cbViTri.Text),
                    SafetyScore = int.Parse(cbAnToan.Text),
                    LuxuryScore = int.Parse(cbDoSangTrong.Text),
                    TechnologyScore = int.Parse(cbCongNghe.Text),
                    StaffScore = int.Parse(cbDoiNguNhienVien.Text),
                    Evaluator = txtNguoiDanhGia.Text
                }; 

                if (roomEvaluation_BUS.UpdateRoomEvaluation(et))
                {
                    string status = roomEvaluation_BUS.UpdateOfficialRoom(et);
                    MessageBox.Show($"Đánh giá đã lưu. Trạng thái phòng: {status}", "Thông báo");
                    dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();

                }
                else
                {
                    MessageBox.Show("Lưu đánh giá thất bại!", "Lỗi");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi");
                return;
            }
        }

        private void dtG_RoomEvalua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtG_RoomEvalua.Rows[e.RowIndex];

                txtMaDanhGia.Text = row.Cells["EvaluationID"].Value.ToString(); 

                cbPhong.SelectedValue = row.Cells["RoomID"].Value.ToString();
                txtNguoiDanhGia.Text = row.Cells["Evaluator"].Value.ToString();

                cbVeSinh.Text = row.Cells["CleanlinessScore"].Value.ToString();
                cbTienNghi.Text = row.Cells["ComfortScore"].Value.ToString();
                cbThaiBo.Text = row.Cells["ServiceScore"].Value.ToString();
                cbTienIchTrongPhong.Text = row.Cells["FacilitiesScore"].Value.ToString();
                cbViTri.Text = row.Cells["LocationScore"].Value.ToString();
                cbAnToan.Text = row.Cells["SafetyScore"].Value.ToString();
                cbDoSangTrong.Text = row.Cells["LuxuryScore"].Value.ToString();
                cbCongNghe.Text = row.Cells["TechnologyScore"].Value.ToString();
                cbDoiNguNhienVien.Text = row.Cells["StaffScore"].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaDanhGia.Clear();
            txtNguoiDanhGia.Clear();
            cbPhong.SelectedIndex = -1;
            cbVeSinh.SelectedIndex = -1;
            cbTienNghi.SelectedIndex = -1;
            cbThaiBo.SelectedIndex = -1;
            cbTienIchTrongPhong.SelectedIndex = -1;
            cbViTri.SelectedIndex = -1;
            cbAnToan.SelectedIndex = -1;
            cbDoSangTrong.SelectedIndex = -1;
            cbCongNghe.SelectedIndex = -1;
            cbDoiNguNhienVien.SelectedIndex = -1;
            cbVeSinh.SelectedIndex = -1;
            txtTong.Text = "0";
            dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();
            dtNgayDanhGia.Value = DateTime.Now;
        }
    }
}
