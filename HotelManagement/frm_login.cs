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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        string usernameAd = "admin";
        string passwordAd = "admin123";

        string usernameNV = "nvkt";
        string passwordNV = "nvkt123";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == usernameAd && txtPassword.Text == passwordAd)
            {
                //this.Hide();
                frmAdminMain adminForm = new frmAdminMain();
                adminForm.ShowDialog();
                this.Close();
            }
            else if (txtUsername.Text == usernameNV && txtPassword.Text == passwordNV)
            {
                this.Hide();
                frmNhanVienKyThuat nvktForm = new frmNhanVienKyThuat();
                nvktForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cB_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cB_ShowPass.Checked;
        }
    }
}
