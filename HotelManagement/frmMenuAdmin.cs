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

        private void frmMenuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCustomerManagementAdminGUI());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRankCustomerAdminGUI());
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
             OpenChildForm(new frmExtraChargeTypeAdminGUI());
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmExtraChargeAdminGUI());
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBookingAdminGUI());
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChinhSuaPhong());
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEditThietBi_NVkyThuat());
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangThaiPhong_NVkyThuat());
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiPhong());
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new frmDanhGiaPhong());
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGiaPhongDongTheoThoiGIan());
        }
    }
}

