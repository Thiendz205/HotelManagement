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
    public partial class frmRankCustomerAdminGUI : Form
    {
        public frmRankCustomerAdminGUI()
        {
            InitializeComponent();
        }

        private void frmRankCustomerAdminGUI_Load(object sender, EventArgs e)
        {
            // ======== FONT + CHỦ ĐỀ ========
            dgvRankCustomer.BackgroundColor = Color.White;
            dgvRankCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 76, 153);
            dgvRankCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRankCustomer.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dgvRankCustomer.EnableHeadersVisualStyles = false;
            dgvRankCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ======== TẠO BẢNG DỮ LIỆU ========
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hạng");
            dt.Columns.Add("Tên hạng");
            dt.Columns.Add("Giảm giá (%)");
            dt.Columns.Add("Tổng chi tiêu tối thiểu (VNĐ)");

            // ======== DỮ LIỆU TĨNH ========
            dt.Rows.Add(1, "Thường", 0, "0");
            dt.Rows.Add(2, "Silver", 5, "5,000,000");
            dt.Rows.Add(3, "Gold", 10, "15,000,000");
            dt.Rows.Add(4, "Platinum", 15, "30,000,000");
            dt.Rows.Add(5, "Diamond", 20, "50,000,000");
            dt.Rows.Add(6, "Royal", 25, "100,000,000");

            // ======== GÁN DỮ LIỆU VÀO DGV ========
            dgvRankCustomer.DataSource = dt;

            // ======== CANH CHỮ ========
            dgvRankCustomer.Columns["Giảm giá (%)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRankCustomer.Columns["Mã hạng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvRankCustomer.Columns["Tổng chi tiêu tối thiểu (VNĐ)"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
    }
}
