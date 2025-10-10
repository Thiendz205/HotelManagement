using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        // 🔹 Thuộc tính giúp truyền thông tin đăng nhập sang Program.cs
        public string UserRole { get; private set; }

        // 🔹 Tài khoản mẫu
        private readonly string usernameAd = "admin";
        private readonly string passwordAd = "admin123";

        private readonly string usernameNV_KT = "nvkt";
        private readonly string passwordNV_KT = "nvkt123";

        private readonly string usernameNV_HR = "hr";
        private readonly string passwordNV_HR = "hr123";

        private readonly string usernameNV_DV = "nvdv";
        private readonly string passwordNV_DV = "nvdv123";

        private readonly string usernameNV_LT = "nvlt";
        private readonly string passwordNV_LT = "nvlt123";


        // 🔹 Xử lý nút đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == usernameAd && password == passwordAd)
            {
                UserRole = "Admin";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (username == usernameNV_KT && password == passwordNV_KT)
            {
                UserRole = "NVKT";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (username == usernameNV_HR && password == passwordNV_HR)
            {
                UserRole = "HR";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (username == usernameNV_DV && password == passwordNV_DV)
            {
                UserRole = "NVDV";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (username == usernameNV_LT && password == passwordNV_LT)
            {
                UserRole = "NVLT";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Ẩn/hiện mật khẩu
        private void cB_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cB_ShowPass.Checked;
        }

        // 🔹 Nếu bấm nút Thoát thì đóng login (thoát chương trình)
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
