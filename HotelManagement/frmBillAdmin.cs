using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using ET;

namespace HotelManagement
{
    public partial class frmBillAdmin : Form
    {
        //private readonly string _currentAdminStaffId;
        private readonly BillBUS billBUS = new BillBUS();

        private List<BillET> _cacheAllBills = new List<BillET>();


        private string CurrentAdminStaffId => "ST001";
        //private string CurrentAdminStaffId => _currentAdminStaffId;
        public frmBillAdmin()
        {
            InitializeComponent();
            //_currentAdminStaffId = staffId;
            ConfigureLayout();
        }

        private void ConfigureLayout()
        {
            // DataGridView
            dgvMain.AutoGenerateColumns = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Map các cột đã có trong Designer
            colInvoiceID.DataPropertyName = "InvoiceID";
            colBookingID.DataPropertyName = "BookingID";
            colInvoiceDate.DataPropertyName = "InvoiceDate";
            colTotalAmount.DataPropertyName = "TotalAmount";
            colPaymentMethod.DataPropertyName = "PaymentMethod";
            colPaidStatus.DataPropertyName = "PaidStatus";
            colStaffID.DataPropertyName = "StaffID";

            // Map cột audit NẾU bạn đã thêm trong Designer (không bắt buộc)
            if (dgvMain.Columns.Contains("colCreatedBy"))
                dgvMain.Columns["colCreatedBy"].DataPropertyName = "CreatedBy";
            if (dgvMain.Columns.Contains("colAuditStatus"))
                dgvMain.Columns["colAuditStatus"].DataPropertyName = "AuditStatus";
            if (dgvMain.Columns.Contains("colAuditNote"))
                dgvMain.Columns["colAuditNote"].DataPropertyName = "AuditNote";
            if (dgvMain.Columns.Contains("colAuditedBy"))
                dgvMain.Columns["colAuditedBy"].DataPropertyName = "AuditedBy";
            if (dgvMain.Columns.Contains("colAuditedAt"))
                dgvMain.Columns["colAuditedAt"].DataPropertyName = "AuditedAt";

            // Combobox lọc Audit (đúng “Lọc theo đánh giá”)
            if (cboFilterAudit != null)
            {
                cboFilterAudit.Items.Clear();
                cboFilterAudit.Items.AddRange(new[] { "Tất cả", "OK", "REVIEW", "WARNING", "FAIL" });
                cboFilterAudit.SelectedIndex = 0;
                cboFilterAudit.SelectedIndexChanged += (s, e) => ApplyFilters();
            }
            // Lọc trạng thái thanh toán (gunaComboBox1)
            if (gunaComboBox1 != null)
            {
                gunaComboBox1.Items.Clear();
                gunaComboBox1.Items.AddRange(new[] { "Tất cả", "Paid", "Unpaid" });
                gunaComboBox1.SelectedIndex = 0;
                gunaComboBox1.SelectedIndexChanged += gunaComboBox1_SelectedIndexChanged;
            }

            // Combobox đánh giá (cboAuditStatus) – control này cần tồn tại trong Designer
            if (cboAuditStatus != null)
            {
                cboAuditStatus.Items.Clear();
                cboAuditStatus.Items.AddRange(new[] { "OK", "REVIEW", "WARNING", "FAIL" });
                cboAuditStatus.SelectedIndex = 0;
            }

            // Search
            if (txtSearch != null)
            {
                txtSearch.ForeColor = Color.Gray;
                if (string.IsNullOrEmpty(txtSearch.Text))
                    txtSearch.Text = "Tìm kiếm theo mã hóa đơn...";
                txtSearch.TextChanged += txtSearch_TextChanged;
                txtSearch.Enter += txtSearch_Enter;
                txtSearch.Leave += txtSearch_Leave;
            }
            EnsureAuditColumns();
        }
        private void EnsureAuditColumns()
        {
            void AddTextCol(string name, string header, string prop, int width = 100)
            {
                if (!dgvMain.Columns.Contains(name))
                {
                    var col = new DataGridViewTextBoxColumn
                    {
                        Name = name,
                        HeaderText = header,
                        DataPropertyName = prop,
                        Width = width,
                        ReadOnly = true
                    };
                    dgvMain.Columns.Add(col);
                }
                else
                {
                    dgvMain.Columns[name].DataPropertyName = prop;
                }
            }

            AddTextCol("colCreatedBy", "CreatedBy", "CreatedBy", 90);
            AddTextCol("colAuditStatus", "AuditStatus", "AuditStatus", 100);
            AddTextCol("colAuditNote", "AuditNote", "AuditNote", 220);
            AddTextCol("colAuditedBy", "AuditedBy", "AuditedBy", 90);
            AddTextCol("colAuditedAt", "AuditedAt", "AuditedAt", 140);

            // format ngày giờ cho AuditedAt
            dgvMain.Columns["colAuditedAt"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }
        private void frmBillAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _cacheAllBills = billBUS.getAllBills().ToList();
                dgvMain.DataSource = _cacheAllBills;
                ColorizeRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorizeRows()
        {
            if (!dgvMain.Columns.Contains("colAuditStatus")) return;

            foreach (DataGridViewRow r in dgvMain.Rows)
            {
                var st = r.Cells["colAuditStatus"]?.Value?.ToString();
                if (st == "FAIL") r.DefaultCellStyle.BackColor = Color.MistyRose;
                else if (st == "WARNING") r.DefaultCellStyle.BackColor = Color.LemonChiffon;
                else if (st == "REVIEW") r.DefaultCellStyle.BackColor = Color.LightCyan;
                else r.DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void ApplyFilters()
        {
            var list = _cacheAllBills;

            // filter Paid (gunaComboBox1)
            if (gunaComboBox1 != null &&
                gunaComboBox1.SelectedItem != null &&
                gunaComboBox1.SelectedItem.ToString() != "Tất cả")
            {
                string paid = gunaComboBox1.SelectedItem.ToString();
                list = list.Where(x => (x.PaidStatus ?? "") == paid).ToList();
            }
            // filter AuditStatus
            if (cboFilterAudit != null &&
                cboFilterAudit.SelectedItem != null &&
                cboFilterAudit.SelectedItem.ToString() != "Tất cả")
            {
                string audit = cboFilterAudit.SelectedItem.ToString();
                list = list.Where(x => (x.AuditStatus ?? "OK") == audit).ToList();
            }
            // filter keyword
            if (txtSearch != null)
            {
                string kw = txtSearch.Text?.Trim();
                if (!string.IsNullOrEmpty(kw) && kw != "Tìm kiếm theo mã hóa đơn...")
                {
                    list = list.Where(b =>
                        b.InvoiceID.ToString().Contains(kw) ||
                        b.BookingID.ToString().Contains(kw) ||
                        (b.StaffID ?? "").Contains(kw) ||
                        (b.CustomerName ?? "").Contains(kw) ||
                        (b.CreatedBy ?? "").Contains(kw)
                    ).ToList();
                }
            }

            dgvMain.DataSource = list;
            ColorizeRows();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // GIỮ NGUYÊN theo yêu cầu
            if (dgvMain.SelectedRows.Count == 0 && dgvMain.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xem!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int invoiceID = 0;
                if (dgvMain.SelectedRows.Count > 0)
                    int.TryParse(dgvMain.SelectedRows[0].Cells[0].Value?.ToString(), out invoiceID);
                else if (dgvMain.CurrentRow != null)
                    int.TryParse(dgvMain.CurrentRow.Cells[0].Value?.ToString(), out invoiceID);

                if (invoiceID == 0)
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần xem!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var bill = _cacheAllBills.FirstOrDefault(b => b.InvoiceID == invoiceID);
                if (bill != null)
                {
                    string details = $"Thông tin hóa đơn:\n\n" +
                                     $"Mã hóa đơn: {bill.InvoiceID}\n" +
                                     $"Mã booking: {bill.BookingID}\n" +
                                     $"Ngày lập: {bill.InvoiceDate:dd/MM/yyyy HH:mm}\n" +
                                     $"Tổng tiền: {bill.TotalAmount:N0} VNĐ\n" +
                                     $"Phương thức thanh toán: {bill.PaymentMethod}\n" +
                                     $"Trạng thái: {bill.PaidStatus}\n" +
                                     $"Khách hàng: {bill.CustomerName}\n" +
                                     $"Phòng: {bill.RoomName}\n" +
                                     $"Nhân viên: {bill.StaffName}\n" +
                                     $"Check-in: {bill.CheckIn:dd/MM/yyyy HH:mm}\n" +
                                     $"Check-out: {bill.CheckOut:dd/MM/yyyy HH:mm}";
                    MessageBox.Show(details, "Chi tiết hóa đơn",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Cập nhật đánh giá/audit
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(dgvMain.CurrentRow.Cells["colInvoiceID"].Value?.ToString(), out int invoiceId))
            {
                MessageBox.Show("Không đọc được InvoiceID!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string status = (cboAuditStatus?.SelectedItem?.ToString()) ?? "REVIEW";
            string note = (txtAuditNote?.Text?.Trim()) ?? "";

            bool ok = billBUS.UpdateInvoiceAudit(invoiceId, status, note, CurrentAdminStaffId);
            MessageBox.Show(ok ? "Đã cập nhật đánh giá." : "Cập nhật thất bại.",
                "Thông báo", MessageBoxButtons.OK,
                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

            if (ok) LoadData();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Đổ audit controls (nếu có cột)
            if (dgvMain.Columns.Contains("colAuditStatus"))
                cboAuditStatus.Text = dgvMain.Rows[e.RowIndex].Cells["colAuditStatus"].Value?.ToString() ?? "OK";
            if (dgvMain.Columns.Contains("colAuditNote"))
                txtAuditNote.Text = dgvMain.Rows[e.RowIndex].Cells["colAuditNote"].Value?.ToString() ?? "";
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilters();

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm theo mã hóa đơn...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Tìm kiếm theo mã hóa đơn...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

        private void btnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất hóa đơn sẽ được phát triển trong phiên bản tiếp theo!",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Không cho phép xóa hóa đơn. Vui lòng dùng 'Cập nhật đánh giá'.",
                "Chính sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editorPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
