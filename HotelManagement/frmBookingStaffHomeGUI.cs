using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmBookingStaffHomeGUI : Form
    {
        public frmBookingStaffHomeGUI()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBookingStaffHomeGUI_Load(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;
        // Hàm mở form con trong panel_Body
        public void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnBooking_Click(object sender, EventArgs e)
        {
            var transferForm = new frmReceptionistsRoomList();
            OpenChildForm(transferForm);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var transferForm = new frmCustomerRECPGUI();
            OpenChildForm(transferForm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var transferForm = new frmGuestCheckInRECPGUI();
            OpenChildForm(transferForm);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var transferForm = new frmListRoomPaymentManagementREPCGUI();
            OpenChildForm(transferForm);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var transferForm = new frmChangeRoomStatusRECPGUI();
            OpenChildForm(transferForm);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            var transferForm = new frmServiceAdmin();
            OpenChildForm(transferForm);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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
    }
}
