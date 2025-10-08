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
    public partial class frmBookingAdminGUI : Form
    {
        public frmBookingAdminGUI()
        {
            InitializeComponent();
        }

        private void frmBookingAdminGUI_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Khách hàng");
            dt.Columns.Add("Phòng");
            dt.Columns.Add("Kiểu thuê");
            dt.Columns.Add("Giờ vào");
            dt.Columns.Add("Giờ ra");
            dt.Columns.Add("Giá (VNĐ)");
            dt.Columns.Add("Trạng thái");
            dt.Columns.Add("Nhân viên");

            // --- Dữ liệu mẫu (tên thay cho ID) ---
            dt.Rows.Add("Nguyễn Văn A", "A01", "Day", "2025-10-07 12:00", "2025-10-08 11:00", "1,200,000", "CheckOut", "Lê Thị Hoa");
            dt.Rows.Add("Trần Thị B", "A02", "Hour", "2025-10-07 10:30", "2025-10-07 13:30", "450,000", "CheckOut", "Phạm Minh Khang");
            dt.Rows.Add("John Smith", "B01", "Day", "2025-10-06 14:00", "2025-10-07 10:00", "1,500,000", "CheckOut", "Lê Thị Hoa");
            dt.Rows.Add("Maria Lopez", "C02", "Day", "2025-10-07 09:00", "", "1,300,000", "CheckIn", "Nguyễn Quốc Dũng");
            dt.Rows.Add("Lê Minh C", "C03", "Hour", "2025-10-07 08:00", "2025-10-07 10:00", "400,000", "CheckOut", "Nguyễn Quốc Dũng");
            dt.Rows.Add("Nguyễn Văn A", "D01", "Day", "2025-10-08 07:30", "", "1,250,000", "Reserved", "Phạm Minh Khang");

            dgvBooking.DataSource = dt;
            dgvBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- Làm đẹp phần tiêu đề ---
            dgvBooking.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204);
            dgvBooking.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBooking.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dgvBooking.EnableHeadersVisualStyles = false;

            // --- Căn giữa các cột thời gian, kiểu thuê, trạng thái ---
            dgvBooking.Columns["Kiểu thuê"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooking.Columns["Giờ vào"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooking.Columns["Giờ ra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBooking.Columns["Trạng thái"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // --- Căn phải cột giá ---
            dgvBooking.Columns["Giá (VNĐ)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // --- Định dạng cột giá ---
            dgvBooking.Columns["Giá (VNĐ)"].DefaultCellStyle.Format = "N0";
        }
    }
}
