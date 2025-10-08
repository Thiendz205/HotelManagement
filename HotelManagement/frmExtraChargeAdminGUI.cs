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
    public partial class frmExtraChargeAdminGUI : Form
    {
        public frmExtraChargeAdminGUI()
        {
            InitializeComponent();
        }

        private void frmExtraChargeAdminGUI_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Phòng");
            dt.Columns.Add("Loại phí");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Ngày ghi nhận");
            dt.Columns.Add("Ghi chú");

            dt.Rows.Add("A01", "Mất khăn tắm", "2", "2025-10-07", "Khách làm mất 2 khăn tắm");
            dt.Rows.Add("A01", "Check-out muộn", "1", "2025-10-07", "Trả phòng lúc 15h30");
            dt.Rows.Add("B02", "Thêm giường phụ", "1", "2025-10-06", "Yêu cầu thêm 1 giường");
            dt.Rows.Add("C03", "Hỏng máy lạnh", "1", "2025-10-05", "Máy lạnh không hoạt động sau khi khách sử dụng");
            dt.Rows.Add("C03", "Mini bar (đồ uống)", "3", "2025-10-05", "Uống 3 lon nước ngọt");
            dt.Rows.Add("D04", "Check-in sớm", "1", "2025-10-04", "Nhận phòng lúc 8h sáng");
            dt.Rows.Add("D04", "Thêm chăn", "2", "2025-10-04", "Yêu cầu thêm 2 chăn phụ");

            dgvBookingFee.DataSource = dt;
            dgvBookingFee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Làm đẹp phần tiêu đề
            dgvBookingFee.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 102, 204);
            dgvBookingFee.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBookingFee.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dgvBookingFee.EnableHeadersVisualStyles = false;

            // Canh giữa + phải
            dgvBookingFee.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBookingFee.Columns["Ngày ghi nhận"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
