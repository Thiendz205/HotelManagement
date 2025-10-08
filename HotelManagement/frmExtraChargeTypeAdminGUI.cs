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
    public partial class frmExtraChargeTypeAdminGUI : Form
    {
        public frmExtraChargeTypeAdminGUI()
        {
            InitializeComponent();
        }

        private void frmExtraChargeTypeAdminGUI_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Loại phí");
            dt.Columns.Add("Tên phí");
            dt.Columns.Add("Giá mặc định (VNĐ)");
            dt.Columns.Add("Ghi chú");

            dt.Rows.Add("Early Check-in", "Phụ phí dịch vụ", "200,000", "Nhận phòng trước 12h trưa");
            dt.Rows.Add("Late Check-out", "Phụ phí dịch vụ", "250,000", "Trả phòng sau 14h");
            dt.Rows.Add("Extra Bed", "Phụ phí dịch vụ", "150,000", "Thêm giường phụ trong phòng");
            dt.Rows.Add("Damaged Air Conditioner", "Bồi thường hư hỏng", "300,000", "Sửa điều hòa bị hư");
            dt.Rows.Add("Lost Towel", "Bồi thường hư hỏng", "50,000", "Khách làm mất khăn tắm");
            dt.Rows.Add("Mini Bar Consumption", "Phụ phí dịch vụ", "100,000", "Dùng đồ uống trong minibar");

            dgvExtraCharge.DataSource = dt;
            dgvExtraCharge.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Giao diện đẹp hơn
            dgvExtraCharge.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204);
            dgvExtraCharge.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvExtraCharge.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dgvExtraCharge.EnableHeadersVisualStyles = false;
        }
    }
}
