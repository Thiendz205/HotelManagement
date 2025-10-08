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
    public partial class frmCustomerManagementAdminGUI : Form
    {
        public frmCustomerManagementAdminGUI()
        {
            InitializeComponent();
        }

        private void frmCustomerManagementAdminGUI_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã KH");          // Cột này vẫn tồn tại để lưu dữ liệu nội bộ
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Số điện thoại");
            dt.Columns.Add("CCCD");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Quốc gia");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Hạng");

            // --- Dữ liệu mẫu ---
            dt.Rows.Add("1", "Nguyễn Văn A", "0905123456", "079123456789", "123 Lê Lợi, Q.1, TP.HCM", "Việt Nam", "Nam", "1995-05-12", "Thường");
            dt.Rows.Add("2", "Trần Thị B", "0912123456", "079223456789", "56 Nguyễn Trãi, Q.5, TP.HCM", "Việt Nam", "Nữ", "1998-03-21", "Bạc");
            dt.Rows.Add("3", "John Smith", "0989123456", "A1234567", "221B Baker Street, London", "Anh", "Nam", "1987-11-30", "Vàng");
            dt.Rows.Add("4", "Lê Minh C", "0978123123", "079323456789", "12 Nguyễn Văn Cừ, Cần Thơ", "Việt Nam", "Nam", "2000-02-18", "Thường");
            dt.Rows.Add("5", "Maria Lopez", "0968234567", "X9843123", "Av. de España, Madrid", "Tây Ban Nha", "Nữ", "1992-08-05", "Kim cương");

            // Gán nguồn dữ liệu cho DataGridView
            dgvCustomer.DataSource = dt;
            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // --- Ẩn cột "Mã KH" ---
            dgvCustomer.Columns["Mã KH"].Visible = false;

            // --- Tùy chỉnh tiêu đề ---
            dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204);
            dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dgvCustomer.EnableHeadersVisualStyles = false;

            // --- Căn giữa một số cột ---
            dgvCustomer.Columns["Giới tính"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomer.Columns["Ngày sinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCustomer.Columns["Hạng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // --- Định dạng ngày sinh ---
            dgvCustomer.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
    }
}
