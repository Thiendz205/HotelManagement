using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmMenuAdmin : Form
    {
        private Form activeChildForm;

        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
                activeChildForm.Dispose();
            }

            activeChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.pnlMainContent.Controls.Clear();
            this.pnlMainContent.Controls.Add(childForm);
            this.pnlMainContent.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccountAdmin());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStaffAdmin());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmServiceAdmin());
        }

        private void btnUseService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUseServiceAdmin());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBillAdmin());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}

