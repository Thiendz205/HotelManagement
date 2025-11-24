using BUS;
using Guna.UI2.HtmlRenderer.Adapters;
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
    public partial class frmCustomerDetailRECPGUI : Form
    {
        public frmCustomerDetailRECPGUI(string customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }
        private readonly string _customerId;
        private readonly CustomerBUS customerBus = new CustomerBUS();
        private readonly BookingBUS bookingBus = new BookingBUS();
        private void frmCustomerDetailRECPGUI_Load(object sender, EventArgs e)
        {
            LoadCustomerInfo();
            LoadBookingHistory();
        }
        private void LoadCustomerInfo()
        {
            var customer = customerBus.GetAllCustomers().FirstOrDefault(c => c.CustomerID == _customerId);
            if (customer != null)
            {
                lblFullName.Text = string.IsNullOrWhiteSpace(customer.FullName) ? "-" : customer.FullName;
                lblPhone.Text = string.IsNullOrWhiteSpace(customer.PhoneNumber) ? "-" : customer.PhoneNumber;
                lblCCCD.Text = string.IsNullOrWhiteSpace(customer.NationalID) ? "-" : customer.NationalID;
                lblAddress.Text = string.IsNullOrWhiteSpace(customer.Address) ? "-" : customer.Address;
                lblCountry.Text = string.IsNullOrWhiteSpace(customer.Country) ? "-" : customer.Country;

                // Hiển thị giới tính chuẩn (fallback nếu rỗng)
                var gender = (customer.Gender ?? "").Trim();
                if (string.Equals(gender, "Nam", StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(gender, "Male", StringComparison.OrdinalIgnoreCase))
                    lblGender.Text = "Nam";
                else if (string.Equals(gender, "Nữ", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(gender, "Female", StringComparison.OrdinalIgnoreCase) ||
                         string.Equals(gender, "Nu", StringComparison.OrdinalIgnoreCase))
                    lblGender.Text = "Nữ";
                else
                    lblGender.Text = "-";

                // Ngày sinh — format hoặc hiển thị "-" nếu null
                lblDOB.Text = customer.DateOfBirth.HasValue
                    ? customer.DateOfBirth.Value.ToString("dd/MM/yyyy")
                    : "-";

                lblRank.Text = string.IsNullOrWhiteSpace(customer.RankName) ? "-" : customer.RankName;
            }
            else
            {
                // Nếu không tìm thấy, clear tất cả label
                lblFullName.Text = lblPhone.Text = lblCCCD.Text = lblAddress.Text =
                lblCountry.Text = lblGender.Text = lblDOB.Text = lblRank.Text = "-";
            }
        }
        private void LoadBookingHistory()
        {
            var history = bookingBus.GetBookingHistoryByCustomerID(_customerId);
            dgvBookingHistory.DataSource = history;

            dgvBookingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookingHistory.ReadOnly = true;
            dgvBookingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn col in dgvBookingHistory.Columns)
                col.Visible = false;

            // Hiển thị các cột cần thiết
            dgvBookingHistory.Columns["BookingID"].Visible = true;
            dgvBookingHistory.Columns["RoomName"].Visible = true;
            dgvBookingHistory.Columns["RoomTypeName"].Visible = true;
            dgvBookingHistory.Columns["Type"].Visible = true;
            dgvBookingHistory.Columns["ItemName"].Visible = true;
            dgvBookingHistory.Columns["Quantity"].Visible = true;
            dgvBookingHistory.Columns["Price"].Visible = true;
            dgvBookingHistory.Columns["Total"].Visible = true;
            dgvBookingHistory.Columns["UsedAt"].Visible = true;

            // Header tiếng Việt
            dgvBookingHistory.Columns["BookingID"].HeaderText = "Mã đặt phòng";
            dgvBookingHistory.Columns["RoomName"].HeaderText = "Phòng";
            dgvBookingHistory.Columns["RoomTypeName"].HeaderText = "Loại phòng";
            dgvBookingHistory.Columns["Type"].HeaderText = "Loại phí";
            dgvBookingHistory.Columns["ItemName"].HeaderText = "Chi tiết";
            dgvBookingHistory.Columns["Quantity"].HeaderText = "SL";
            dgvBookingHistory.Columns["Price"].HeaderText = "Đơn giá (VNĐ)";
            dgvBookingHistory.Columns["Total"].HeaderText = "Thành tiền (VNĐ)";
            dgvBookingHistory.Columns["UsedAt"].HeaderText = "Ngày phát sinh";

            // Format hiển thị
            dgvBookingHistory.Columns["Price"].DefaultCellStyle.Format = "N0";
            dgvBookingHistory.Columns["Total"].DefaultCellStyle.Format = "N0";
            dgvBookingHistory.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBookingHistory.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvBookingHistory.Columns["UsedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(_customerId))
                {
                    MessageBox.Show("Không xác định được khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Mở form báo cáo, truyền ID khách hàng
                frmReportCustomerHistory frm = new frmReportCustomerHistory(_customerId);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
