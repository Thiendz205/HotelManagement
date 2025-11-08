using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BUS;
using ET;

namespace HotelManagement
{
    public partial class frmAccountAdmin : Form
    {
        private string _selectedAccountId;
        AccountBUS accountBUS = new AccountBUS();
        AccountET accountET = new AccountET();

        public frmAccountAdmin()
        {
            InitializeComponent();
            SetupLayout();
        }

        private void SetupLayout()
        {
            dgvMain.AutoGenerateColumns = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Thiết lập các cột cho DataGridView
            colAccountID.DataPropertyName = "AccountID";
            colUsername.DataPropertyName = "Username";
            colStartDate.DataPropertyName = "StartDate";
            colStaffID.DataPropertyName = "StaffID";
            colStatus.DataPropertyName = "Status";
        }

        private void frmAccountAdmin_Load(object sender, EventArgs e)
        {
            LoadStaffComboBox();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var accounts = accountBUS.getAllAccounts().ToList();
                dgvMain.DataSource = null;
                dgvMain.DataSource = accounts;
                dgvMain.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStaffComboBox()
        {
            try
            {
                var staffs = accountBUS.getAll_ID_and_Name_Staff();
                gunaTextBox1.DataSource = staffs;
                gunaTextBox1.DisplayMember = "FullName";
                gunaTextBox1.ValueMember = "StaffID";
                gunaTextBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            { MessageBox.Show("Vui lòng nhập username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            { MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!IsStaffSelected())
            { MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (string.IsNullOrWhiteSpace(cboStatus.Text))
            { MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var staffId = GetSelectedStaffId();

                // 1) StaffID phải tồn tại trong bảng Staffs
                if (!accountBUS.StaffExists(staffId))
                {
                    MessageBox.Show("Mã nhân viên không hợp lệ. Vui lòng chọn lại từ danh sách.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2) Chặn nếu username đã tồn tại hoặc nhân viên đã có tài khoản
                if (accountBUS.UsernameExists(txtUsername.Text.Trim()) ||
                    accountBUS.StaffHasAccount(staffId))
                {
                    MessageBox.Show("Username đã tồn tại hoặc nhân viên này đã có tài khoản! Vui lòng nhập lại.",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Nếu có rule mật khẩu riêng thì kiểm tra ở đây
                if (!ValidatePassword(txtPassword.Text)) return;

                // Generate AccountID tự động
                accountET.AccountID = accountBUS.generateAccountID();
                accountET.Username = txtUsername.Text.Trim();
                accountET.Password = HashPassword(txtPassword.Text);
                accountET.StaffID = staffId;
                accountET.Status = cboStatus.Text.Trim();
                accountET.StartDate = DateTime.Now; // hoặc dtpStartDate.Value

                bool success = accountBUS.addAccount(accountET);
                MessageBox.Show(success ? "Thêm tài khoản thành công!" : "Thêm tài khoản thất bại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                success ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (success)
                {
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập username!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!IsStaffSelected())
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboStatus.Text))
            {
                MessageBox.Show("Vui lòng chọn trạng thái!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy AccountID ưu tiên từ _selectedAccountId, nếu không có thì dùng CurrentRow
                string accountID;
                if (!string.IsNullOrEmpty(_selectedAccountId))
                {
                    accountID = _selectedAccountId;
                }
                else
                {
                    if (dgvMain.CurrentRow == null)
                    {
                        MessageBox.Show("Vui lòng chọn tài khoản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Đổi "colAccountID" cho khớp với Name cột ID của bạn
                    object cellVal = dgvMain.CurrentRow.Cells["colAccountID"].Value;
                    // Nếu bạn không đặt Name cho cột, có thể dùng index 0:
                    // object cellVal = dgvMain.CurrentRow.Cells[0].Value;

                    if (cellVal == null || cellVal == DBNull.Value)
                    {
                        MessageBox.Show("Không đọc được AccountID từ dòng đã chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    accountID = cellVal.ToString();
                }

                // Không cho trùng username với account khác
                if (!accountBUS.IsUsernameAvailableForUpdate(txtUsername.Text.Trim(), accountID))
                {
                    MessageBox.Show("Username đã tồn tại, vui lòng nhập username khác!",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                // Gán dữ liệu
                accountET.AccountID = accountID;
                accountET.Username = txtUsername.Text.Trim();

                // Nếu nhập mật khẩu mới -> hash; nếu không -> giữ mật khẩu cũ
                if (!string.IsNullOrWhiteSpace(txtPassword.Text) &&
                    txtPassword.Text != "Nhập mật khẩu mới để thay đổi (để trống nếu không đổi)")
                {
                    if (!ValidatePassword(txtPassword.Text))
                        return;

                    accountET.Password = HashPassword(txtPassword.Text);
                }
                else
                {
                    var currentAccount = accountBUS.getAllAccounts().FirstOrDefault(a => a.AccountID == accountID);
                    if (currentAccount != null)
                        accountET.Password = currentAccount.Password;
                }

                accountET.StaffID = GetSelectedStaffId();
                accountET.Status = cboStatus.Text.Trim();

                bool success = accountBUS.updateAccount(accountET);
                if (success)
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMain.Rows[e.RowIndex];

            // Lưu AccountID để Edit không phụ thuộc SelectedRows
            // Đổi "colAccountID" cho khớp Name cột ID trong Designer (hoặc dùng index [0] nếu chắc chắn)
            object idVal = row.Cells["colAccountID"].Value;
            if (idVal == null || idVal == DBNull.Value) return;
            
            _selectedAccountId = idVal.ToString();

            // Fill UI
            txtUsername.Text = row.Cells["colUsername"]?.Value?.ToString() ?? string.Empty;

            // Đặt placeholder cho password khi sửa (không đổi thì để nguyên)
            txtPassword.ForeColor = System.Drawing.Color.Gray;
            txtPassword.Text = "Nhập mật khẩu mới để thay đổi (để trống nếu không đổi)";

            // StaffID -> set SelectedValue cho ComboBox nhân viên
            var staffId = row.Cells["colStaffID"]?.Value?.ToString();
            if (!string.IsNullOrEmpty(staffId) && gunaTextBox1.DataSource != null)
                gunaTextBox1.SelectedValue = staffId;
            else
                gunaTextBox1.SelectedIndex = -1;

            cboStatus.Text = row.Cells["colStatus"]?.Value?.ToString() ?? string.Empty;

            var startDateStr = row.Cells["colStartDate"]?.Value?.ToString();
            if (DateTime.TryParse(startDateStr, out var startDt))
                dtpStartDate.Value = startDt;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 50)
            {
                MessageBox.Show("Username không được vượt quá 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = txtUsername.Text.Substring(0, 50);
                txtUsername.SelectionStart = txtUsername.Text.Length;
                txtUsername.SelectionLength = 0;
            }
            if (txtUsername.Text.StartsWith(" "))
            {
                MessageBox.Show("Username không được bắt đầu bằng khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Text = txtUsername.Text.TrimStart();
                txtUsername.SelectionStart = txtUsername.Text.Length;
                txtUsername.SelectionLength = 0;
            }
        }

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    // Lọc theo username
        //    if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text != "Tìm kiếm theo username...")
        //    {
        //        var allAccounts = accountBUS.getAllAccounts().ToList();
        //        var filteredAccounts = allAccounts.Where(a => a.Username.Contains(txtSearch.Text)).ToList();
        //        dgvMain.DataSource = filteredAccounts;
        //    }
        //    else
        //    {
        //        LoadData();
        //    }
        //}

        //private void txtSearch_Enter(object sender, EventArgs e)
        //{
        //    if (txtSearch.Text == "Tìm kiếm theo username...")
        //    {
        //        txtSearch.Text = "";
        //        txtSearch.ForeColor = System.Drawing.Color.Black;
        //    }
        //}

        //private void txtSearch_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtSearch.Text))
        //    {
        //        txtSearch.Text = "Tìm kiếm theo username...";
        //        txtSearch.ForeColor = System.Drawing.Color.Gray;
        //    }
        //}

        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lọc theo trạng thái
            if (cboFilterStatus.SelectedItem != null && cboFilterStatus.SelectedItem.ToString() != "Tất cả")
            {
                var allAccounts = accountBUS.getAllAccounts().ToList();
                var filteredAccounts = allAccounts.Where(a => a.Status == cboFilterStatus.SelectedItem.ToString()).ToList();
                dgvMain.DataSource = filteredAccounts;
            }
            else
            {
                LoadData();
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                {
                    result.Append(b.ToString("x2"));
                }
                return result.ToString();
            }
        }

        private bool ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            bool hasUpperCase = password.Any(char.IsUpper);
            bool hasLowerCase = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(c => !char.IsLetterOrDigit(c));

            if (!hasUpperCase)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 1 chữ hoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!hasLowerCase)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 1 chữ thường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!hasDigit)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 1 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!hasSpecialChar)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 1 ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Nhập mật khẩu mới để thay đổi (để trống nếu không đổi)")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.Text = "Nhập mật khẩu mới để thay đổi (để trống nếu không đổi)";
                txtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }
        private bool IsStaffSelected()
        {
            // Nếu control là ComboBox chứa danh sách nhân viên
            return gunaTextBox1 != null
                   && gunaTextBox1.SelectedValue != null
                   && gunaTextBox1.SelectedIndex >= 0;
        }

        private string GetSelectedStaffId()
        {
            return IsStaffSelected() ? gunaTextBox1.SelectedValue.ToString() : null;
        }
        private void ClearForm()
        {
            //txtAccountID.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtPassword.ForeColor = System.Drawing.Color.Black;
            gunaTextBox1.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;
            dtpStartDate.Value = DateTime.Now;
        }

        private void headerPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void editorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

