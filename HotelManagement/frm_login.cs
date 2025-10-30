using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BUS;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace HotelManagement
{
    public partial class frm_login : Form
    {
        Login_Logout_BUS login_Logout_BUS = new Login_Logout_BUS();
        public string StaffID { get; private set; } // Lưu StaffID sau khi đăng nhập thành công
        public string UserRole { get; private set; }

        public frm_login()
        {
            InitializeComponent();
        }

        private string HashPassword(string password) 
        {
            using (SHA256 sha256 = SHA256.Create()) 
            {   byte[] bytes = Encoding.UTF8.GetBytes(password); 
                byte[] hash = sha256.ComputeHash(bytes); 
                StringBuilder result = new StringBuilder(); 
                foreach (byte b in hash) 
                {
                    result.Append(b.ToString("x2")); 
                }
                return result.ToString(); 
            } 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username không được bỏ trống. Vui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password không được bỏ trống. Vui lòng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 8)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 8 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(ch => !char.IsLetterOrDigit(ch));

            if (!hasUpper || !hasLower || !hasDigit || !hasSpecial)
            {
                MessageBox.Show("Mật khẩu phải có chữ hoa, chữ thường, số và ký tự đặc biệt!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (login_Logout_BUS.getStatusByAccount(username, password) == "Inactive")
            {
                MessageBox.Show("Tài khoản của bạn đã bị vô hiệu hóa. Vui lòng liên hệ quản trị viên.", "Tài khoản vô hiệu hóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string hashedInput = HashPassword(txtPassword.Text);
                string staffID = login_Logout_BUS.getStaffIDByAccount(username, hashedInput);

                if (string.IsNullOrEmpty(staffID))
                {
                    string staffID2 = login_Logout_BUS.getStaffIDByAccount(username, txtPassword.Text);
                    if (string.IsNullOrEmpty(staffID2))
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        staffID = staffID2;
                    }
                }

                StaffID = staffID;

                string role = login_Logout_BUS.checkRoleByStaffs(staffID);
                if (string.IsNullOrEmpty(role))
                {
                    MessageBox.Show("Không tìm thấy vai trò của nhân viên!", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                UserRole = role.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng nhập: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cB_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cB_ShowPass.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
           

            if (txtUsername.Text.Length > 50)
            {
                MessageBox.Show("Username không được vượt quá 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUsername.Text = txtUsername.Text.Substring(0, 50);
                txtUsername.SelectionStart = txtUsername.Text.Length;
                txtUsername.SelectionLength = 0;
                txtUsername.Focus();
                return;


            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text.Length > 64)
            {
                MessageBox.Show("Password không được vượt quá 64 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtPassword.Text = txtPassword.Text.Substring(0, 64);
                txtPassword.SelectionStart = txtPassword.Text.Length;
                txtPassword.SelectionLength = 0;
                txtPassword.Focus();
                return;


            }
        }
    }
}
