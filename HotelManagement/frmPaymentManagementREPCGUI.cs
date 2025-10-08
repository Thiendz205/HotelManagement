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
    public partial class frmPaymentManagementREPCGUI : Form
    {
        public frmPaymentManagementREPCGUI()
        {
            InitializeComponent();
        }

        private void frmPaymentManagementREPCGUI_Load(object sender, EventArgs e)
        {
            // Thêm 2 lựa chọn
            cboPaymentMethod.Items.Add("Tiền mặt");
            cboPaymentMethod.Items.Add("Quét mã QR");

            // Mặc định là Tiền mặt
            cboPaymentMethod.SelectedIndex = 0;

            // Ẩn hình QR ban đầu
            picQRCode.Visible = false;
            // ======== FONT + CHỦ ĐỀ ========
            dgvPaymentDetail.BackgroundColor = Color.FromArgb(0, 102, 204); // xanh dương
            dgvPaymentDetail.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 76, 153);
            dgvPaymentDetail.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvPaymentDetail.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dgvPaymentDetail.EnableHeadersVisualStyles = false;

            // ======== TẠO BẢNG DỮ LIỆU ========
            DataTable dt = new DataTable();
            dt.Columns.Add("Mục");
            dt.Columns.Add("Mục chi tiết");
            dt.Columns.Add("Đơn giá (VNĐ)");
            dt.Columns.Add("Số lượng");

            // ======== PHÒNG ========
            string[,] phongData = {
        { "A01", "Day", "3", "500000" }
    };

            for (int i = 0; i < phongData.GetLength(0); i++)
            {
                string soPhong = phongData[i, 0];
                string kieuThue = phongData[i, 1];
                int soLuongThue = int.Parse(phongData[i, 2]);
                decimal giaPhong = decimal.Parse(phongData[i, 3]);
                string donVi = (kieuThue == "Day") ? "ngày" : "giờ";
                string chiTietPhong = $"Phòng {soPhong} ({soLuongThue} {donVi} × {giaPhong.ToString("N0")} VNĐ/{donVi})";
                dt.Rows.Add("Phòng", chiTietPhong, giaPhong.ToString("N0"), soLuongThue.ToString());
            }

            // ======== DỊCH VỤ ========
            dt.Rows.Add("Dịch vụ", "Ăn sáng buffet", "100,000", "4");
            dt.Rows.Add("Dịch vụ", "Giặt ủi quần áo", "80,000", "2");
            dt.Rows.Add("Dịch vụ", "Đưa đón sân bay", "200,000", "1");
            dt.Rows.Add("Dịch vụ", "Sử dụng hồ bơi VIP", "150,000", "3");
            dt.Rows.Add("Dịch vụ", "Mini bar (đồ uống)", "50,000", "5");

            // ======== PHỤ PHÍ ========
            dt.Rows.Add("Phụ phí", "Thêm giường phụ", "150,000", "2");
            dt.Rows.Add("Phụ phí", "Check-in sớm", "200,000", "1");
            dt.Rows.Add("Phụ phí", "Check-out muộn", "250,000", "1");

            // ======== BỒI THƯỜNG ========
            dt.Rows.Add("Bồi thường", "Hỏng điều hòa", "300,000", "1");
            dt.Rows.Add("Bồi thường", "Mất khăn tắm", "50,000", "2");

            // ======== GÁN DỮ LIỆU VÀO DATAGRIDVIEW ========
            dgvPaymentDetail.DataSource = dt;
            dgvPaymentDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPaymentDetail.Columns["Đơn giá (VNĐ)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPaymentDetail.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // ======== TÍNH TỔNG TIỀN ========
            decimal tongTien = 0;
            foreach (DataRow row in dt.Rows)
            {
                decimal donGia = decimal.Parse(row["Đơn giá (VNĐ)"].ToString().Replace(",", ""));
                int soLuong = int.Parse(row["Số lượng"].ToString());
                tongTien += donGia * soLuong;
            }
            lblTongTien.Text = "Tổng cộng: " + tongTien.ToString("N0") + " VNĐ";
        }

        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaymentMethod.SelectedItem.ToString() == "Quét mã QR")
            {
                picQRCode.Visible = true;  // Hiện hình QR
            }
            else
            {
                picQRCode.Visible = false; // Ẩn hình QR
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmListRoomPaymentManagementREPCGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmListRoomPaymentManagementREPCGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }
    }
}
