using BUS;
using ET;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmDanhGiaPhong : Form
    {
        public string maNhanVien;
        private bool isLoading = false;

        RoomEvaluation_BUS roomEvaluation_BUS = new RoomEvaluation_BUS();

        public frmDanhGiaPhong(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
        }

        private void frmDanhGiaPhong_Load(object sender, EventArgs e)
        {
            isLoading = true;

            // Load grid
            dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();

            // Load phòng
            cbPhong.DataSource = roomEvaluation_BUS.getIDNameRoom();
            cbPhong.DisplayMember = "RoomName";
            cbPhong.ValueMember = "RoomID";

            ResetComboBoxes();
            txtTong.Text = "0";
            dtNgayDanhGia.Value = DateTime.Now;

            // ⭐ Gắn sự kiện cho tất cả combobox
            GanSuKienTinhTong();

            isLoading = false;
        }

        // RESET tất cả combo
        private void ResetComboBoxes()
        {
            cbVeSinh.SelectedIndex = -1;
            cbTienNghi.SelectedIndex = -1;
            cbThaiBo.SelectedIndex = -1;
            cbTienIchTrongPhong.SelectedIndex = -1;
            cbViTri.SelectedIndex = -1;
            cbAnToan.SelectedIndex = -1;
            cbDoSangTrong.SelectedIndex = -1;
            cbCongNghe.SelectedIndex = -1;
            cbDoiNguNhienVien.SelectedIndex = -1;
        }

        // Hàm đặt selected bằng value
        private void SetCombo(ComboBox cb, string value)
        {
            cb.SelectedItem = cb.Items.Cast<object>()
                        .FirstOrDefault(x => x.ToString() == value);
        }

        // ⭐ Hàm gắn sự kiện TextChanged cho tất cả ComboBox
        private void GanSuKienTinhTong()
        {
            cbVeSinh.TextChanged += (s, e) => TinhTongDiem();
            cbTienNghi.TextChanged += (s, e) => TinhTongDiem();
            cbThaiBo.TextChanged += (s, e) => TinhTongDiem();
            cbTienIchTrongPhong.TextChanged += (s, e) => TinhTongDiem();
            cbViTri.TextChanged += (s, e) => TinhTongDiem();
            cbAnToan.TextChanged += (s, e) => TinhTongDiem();
            cbDoSangTrong.TextChanged += (s, e) => TinhTongDiem();
            cbCongNghe.TextChanged += (s, e) => TinhTongDiem();
            cbDoiNguNhienVien.TextChanged += (s, e) => TinhTongDiem();
        }

        // ⭐ Tính tổng điểm
        private void TinhTongDiem()
        {
            if (isLoading) return;

            int tong = 0;
            int diem = 0;

            if (int.TryParse(cbVeSinh.Text, out diem)) tong += diem;
            if (int.TryParse(cbTienNghi.Text, out diem)) tong += diem;
            if (int.TryParse(cbThaiBo.Text, out diem)) tong += diem;
            if (int.TryParse(cbTienIchTrongPhong.Text, out diem)) tong += diem;
            if (int.TryParse(cbViTri.Text, out diem)) tong += diem;
            if (int.TryParse(cbAnToan.Text, out diem)) tong += diem;
            if (int.TryParse(cbDoSangTrong.Text, out diem)) tong += diem;
            if (int.TryParse(cbCongNghe.Text, out diem)) tong += diem;
            if (int.TryParse(cbDoiNguNhienVien.Text, out diem)) tong += diem;

            txtTong.Text = tong.ToString();
        }

        private bool KiemTraNhapDiem()
        {
            if (string.IsNullOrWhiteSpace(cbVeSinh.Text) ||
                string.IsNullOrWhiteSpace(cbTienNghi.Text) ||
                string.IsNullOrWhiteSpace(cbThaiBo.Text) ||
                string.IsNullOrWhiteSpace(cbTienIchTrongPhong.Text) ||
                string.IsNullOrWhiteSpace(cbViTri.Text) ||
                string.IsNullOrWhiteSpace(cbAnToan.Text) ||
                string.IsNullOrWhiteSpace(cbDoSangTrong.Text) ||
                string.IsNullOrWhiteSpace(cbCongNghe.Text) ||
                string.IsNullOrWhiteSpace(cbDoiNguNhienVien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các mục đánh giá!");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiDanhGia.Text))
            {
                MessageBox.Show("Vui lòng nhập tên người đánh giá!");
                return false;
            }

            if (cbPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return false;
            }

            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapDiem()) return;

            try
            {
                RoomEvaluation_ET et = new RoomEvaluation_ET
                {
                    RoomID = cbPhong.SelectedValue.ToString(),
                    EvaluationDate = dtNgayDanhGia.Value,
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
                    string status = roomEvaluation_BUS.UpdateOfficialRoom(et);
                    MessageBox.Show($"Đánh giá đã lưu. Trạng thái phòng: {status}");

                    dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();
                }
                else
                {
                    MessageBox.Show("Lưu thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhapDiem()) return;
            if (string.IsNullOrWhiteSpace(txtMaDanhGia.Text))
            {
                MessageBox.Show("Vui lòng chọn đánh giá cần cập nhật!");
                return;
            }

            try
            {
                RoomEvaluation_ET et = new RoomEvaluation_ET
                {
                    EvaluationID = Convert.ToInt32(txtMaDanhGia.Text),
                    RoomID = cbPhong.SelectedValue.ToString(),
                    EvaluationDate = dtNgayDanhGia.Value,
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
                    MessageBox.Show($"Cập nhật thành công. Trạng thái: {status}");

                    dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaDanhGia.Text))
            {
                MessageBox.Show("Vui lòng nhập/chọn mã đánh giá để xóa!");
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtMaDanhGia.Text);

                if (roomEvaluation_BUS.DeleteRoomEvaluation(id))
                {
                    MessageBox.Show("Xóa đánh giá thành công!");
                    dtG_RoomEvalua.DataSource = roomEvaluation_BUS.getAllRoomEvaluation();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dtG_RoomEvalua_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            isLoading = true;

            DataGridViewRow row = dtG_RoomEvalua.Rows[e.RowIndex];

            txtMaDanhGia.Text = row.Cells["EvaluationID"].Value.ToString();
            cbPhong.SelectedValue = row.Cells["RoomID"].Value.ToString();
            txtNguoiDanhGia.Text = row.Cells["Evaluator"].Value.ToString();

            SetCombo(cbVeSinh, row.Cells["CleanlinessScore"].Value.ToString());
            SetCombo(cbTienNghi, row.Cells["ComfortScore"].Value.ToString());
            SetCombo(cbThaiBo, row.Cells["ServiceScore"].Value.ToString());
            SetCombo(cbTienIchTrongPhong, row.Cells["FacilitiesScore"].Value.ToString());
            SetCombo(cbViTri, row.Cells["LocationScore"].Value.ToString());
            SetCombo(cbAnToan, row.Cells["SafetyScore"].Value.ToString());
            SetCombo(cbDoSangTrong, row.Cells["LuxuryScore"].Value.ToString());
            SetCombo(cbCongNghe, row.Cells["TechnologyScore"].Value.ToString());
            SetCombo(cbDoiNguNhienVien, row.Cells["StaffScore"].Value.ToString());

            if (DateTime.TryParse(row.Cells["EvaluationDate"].Value?.ToString(), out DateTime d))
                dtNgayDanhGia.Value = d;

            isLoading = false;

            TinhTongDiem();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            isLoading = true;

            txtMaDanhGia.Clear();
            txtNguoiDanhGia.Clear();

            cbPhong.SelectedIndex = -1;
            ResetComboBoxes();

            txtTong.Text = "0";
            dtNgayDanhGia.Value = DateTime.Now;

            isLoading = false;

            TinhTongDiem();
        }

        private void btnInPhieuDanhGia_Click(object sender, EventArgs e)
        {
            if (cbPhong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn phòng!");
                return;
            }

            new frmReportRoomEvaluation(cbPhong.SelectedValue.ToString()).Show();
        }
    }
}
