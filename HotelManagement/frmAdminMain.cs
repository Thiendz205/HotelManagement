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
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
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
            OpenChildForm(new frmTrangThietBiPhong());
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiPhong());
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhGiaPhong());
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGiaPhongDongTheoThoiGIan());
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton17_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Tạo một luồng (thread) mới để mở form đăng nhập
                System.Threading.Thread t = new System.Threading.Thread(() =>
                {
                    Application.Run(new frm_login());
                });
                t.SetApartmentState(System.Threading.ApartmentState.STA);
                t.Start();

                // Đóng form hiện tại
                this.Close();
            }
        }

    }
}
