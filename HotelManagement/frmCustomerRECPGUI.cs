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
    public partial class frmCustomerRECPGUI : Form
    {
        public frmCustomerRECPGUI()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmRoomTransferRECPGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }

        private void frmCustomerRECPGUI_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Họ tên khách hàng");
            dt.Columns.Add("Hạng");
            dt.Columns.Add("Phòng");
            dt.Columns.Add("Kiểu thuê");
            dt.Columns.Add("Giá phòng (VNĐ)");
            dt.Columns.Add("Check-in");
            dt.Columns.Add("Check-out");

            // ===== DỮ LIỆU DEMO NHIỀU KHÁCH HÀNG =====
            dt.Rows.Add("Nguyễn Văn A", "Gold", "A01", "Theo ngày", "550,000", "05/10/2025 14:00", "07/10/2025 12:00");
            dt.Rows.Add("Trần Thị B", "Silver", "A02", "Theo giờ", "120,000", "07/10/2025 10:00", "07/10/2025 13:30");
            dt.Rows.Add("Phạm Minh C", "Thường", "A03", "Theo ngày", "480,000", "06/10/2025 09:00", "08/10/2025 11:00");
            dt.Rows.Add("Lê Thị D", "Platinum", "A04", "Theo ngày", "800,000", "07/10/2025 15:00", "09/10/2025 10:00");
            dt.Rows.Add("Đỗ Quốc E", "Gold", "A05", "Theo giờ", "150,000", "07/10/2025 08:00", "07/10/2025 11:30");
            dt.Rows.Add("Nguyễn Hoàng F", "Silver", "A06", "Theo ngày", "520,000", "05/10/2025 13:00", "06/10/2025 11:00");
            dt.Rows.Add("Phan Văn G", "Thường", "A07", "Theo giờ", "110,000", "07/10/2025 09:30", "07/10/2025 12:00");
            dt.Rows.Add("Lâm Thị H", "Gold", "A08", "Theo ngày", "600,000", "06/10/2025 11:00", "08/10/2025 12:00");
            dt.Rows.Add("Vũ Anh I", "Silver", "A09", "Theo ngày", "500,000", "07/10/2025 10:00", "09/10/2025 11:00");

            dt.Rows.Add("Bùi Đức J", "Thường", "B01", "Theo ngày", "420,000", "06/10/2025 12:00", "08/10/2025 10:00");
            dt.Rows.Add("Hoàng Gia K", "Gold", "B02", "Theo giờ", "130,000", "07/10/2025 08:30", "07/10/2025 10:30");
            dt.Rows.Add("Đặng Mỹ L", "Silver", "B03", "Theo ngày", "550,000", "05/10/2025 15:00", "07/10/2025 12:00");
            dt.Rows.Add("Phan Minh M", "Thường", "B04", "Theo ngày", "470,000", "06/10/2025 09:00", "08/10/2025 11:00");
            dt.Rows.Add("Ngô Trọng N", "Gold", "B05", "Theo ngày", "600,000", "07/10/2025 15:30", "09/10/2025 10:00");
            dt.Rows.Add("Đoàn Thị O", "Platinum", "B06", "Theo giờ", "200,000", "07/10/2025 07:00", "07/10/2025 10:00");
            dt.Rows.Add("Huỳnh Quốc P", "Silver", "B07", "Theo ngày", "530,000", "06/10/2025 08:00", "08/10/2025 12:00");
            dt.Rows.Add("Võ Hữu Q", "Gold", "B08", "Theo ngày", "650,000", "05/10/2025 14:00", "07/10/2025 12:00");
            dt.Rows.Add("Nguyễn Huy R", "Thường", "B09", "Theo giờ", "120,000", "07/10/2025 09:00", "07/10/2025 11:00");

            dt.Rows.Add("Trịnh Thu S", "Silver", "C01", "Theo ngày", "480,000", "05/10/2025 11:00", "07/10/2025 10:00");
            dt.Rows.Add("Đặng Nhật T", "Gold", "C02", "Theo ngày", "580,000", "06/10/2025 09:30", "08/10/2025 11:30");
            dt.Rows.Add("Phan Tấn U", "Platinum", "C03", "Theo ngày", "850,000", "07/10/2025 10:00", "09/10/2025 11:00");
            dt.Rows.Add("Lê Thanh V", "Thường", "C04", "Theo giờ", "100,000", "07/10/2025 08:30", "07/10/2025 10:00");
            dt.Rows.Add("Ngô Bảo W", "Gold", "C05", "Theo ngày", "650,000", "05/10/2025 13:00", "07/10/2025 12:00");
            dt.Rows.Add("Trần Mỹ X", "Silver", "C06", "Theo ngày", "520,000", "06/10/2025 10:00", "08/10/2025 11:00");
            dt.Rows.Add("Đoàn Minh Y", "Gold", "C07", "Theo giờ", "130,000", "07/10/2025 09:00", "07/10/2025 11:30");
            dt.Rows.Add("Phạm Hữu Z", "Thường", "C08", "Theo ngày", "430,000", "06/10/2025 11:00", "08/10/2025 10:00");
            dt.Rows.Add("Nguyễn Khánh AA", "Platinum", "C09", "Theo ngày", "900,000", "07/10/2025 14:00", "09/10/2025 10:00");

            dt.Rows.Add("Trương Văn BB", "Silver", "D01", "Theo ngày", "500,000", "06/10/2025 13:00", "08/10/2025 12:00");
            dt.Rows.Add("Đặng Thị CC", "Gold", "D02", "Theo giờ", "150,000", "07/10/2025 07:00", "07/10/2025 10:30");
            dt.Rows.Add("Phan Bảo DD", "Thường", "D03", "Theo ngày", "450,000", "06/10/2025 08:00", "08/10/2025 11:00");
            dt.Rows.Add("Nguyễn Văn EE", "Gold", "D04", "Theo ngày", "600,000", "05/10/2025 15:00", "07/10/2025 11:00");
            dt.Rows.Add("Trần Thị FF", "Silver", "D05", "Theo ngày", "530,000", "06/10/2025 09:00", "08/10/2025 12:00");
            dt.Rows.Add("Đỗ Văn GG", "Thường", "D06", "Theo giờ", "120,000", "07/10/2025 10:00", "07/10/2025 12:30");
            dt.Rows.Add("Ngô Minh HH", "Gold", "D07", "Theo ngày", "670,000", "06/10/2025 11:00", "08/10/2025 10:00");
            dt.Rows.Add("Lê Mỹ II", "Platinum", "D08", "Theo ngày", "880,000", "05/10/2025 14:00", "07/10/2025 11:00");
            dt.Rows.Add("Vũ Anh JJ", "Silver", "D09", "Theo giờ", "140,000", "07/10/2025 08:00", "07/10/2025 10:30");

            dgvCustomerBooking.DataSource = dt;

            // === Style ===
            dgvCustomerBooking.DefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Regular);
            dgvCustomerBooking.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 13, FontStyle.Bold);
            dgvCustomerBooking.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvCustomerBooking.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomerBooking.EnableHeadersVisualStyles = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
