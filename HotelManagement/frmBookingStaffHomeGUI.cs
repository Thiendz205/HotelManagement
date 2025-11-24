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
        private readonly string staffId;
        public frmBookingStaffHomeGUI(string staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
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
            var transferForm = new frmReceptionistsRoomList(staffId);
            OpenChildForm(transferForm);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var transferForm = new frmCustomerRECPGUI();
            OpenChildForm(transferForm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var transferForm = new frmGuestCheckInRECPGUI(staffId);
            OpenChildForm(transferForm);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Xác nhận người dùng có muốn đăng xuất không
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //// Ẩn form hiện tại
                //this.Hide();

                //// Mở lại form đăng nhập
                //frmLogin loginForm = new frmLogin();
                //loginForm.Show();

                // Đóng form hiện tại hoàn toàn sau khi mở form đăng nhập
                this.Close();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var transferForm = new frmListRoomPaymentManagementREPCGUI(staffId);
            OpenChildForm(transferForm);
        }


        private void guna2Button6_Click_1(object sender, EventArgs e)
        {
            var transferForm = new frmUpdateBookingRECPGUI(staffId);
            OpenChildForm(transferForm);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var transferForm = new frmServiceProvision(staffId);
            OpenChildForm(transferForm);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            var transferForm = new frmServiceManagement();
            OpenChildForm(transferForm);
        }
    }
}
