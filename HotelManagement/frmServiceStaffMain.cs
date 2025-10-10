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
    public partial class frmServiceStaffMain : Form
    {
        private Form activeChildForm;
        public frmServiceStaffMain()
        {
            InitializeComponent();
        }

        public void OpenChildForm(Form childForm)
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

        private void btnServiceManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmServiceManagement());
        }

        private void btnServiceCRUD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmServiceCRUD());
        }

        private void btnServiceProvision_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmServiceProvision());
        }

        private void btnRoomMonitoring_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRoomMonitoring());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc muốn đăng xuất không?",
            "Đăng xuất",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmServiceStaffMain_Load(object sender, EventArgs e)
        {

        }
    }
}