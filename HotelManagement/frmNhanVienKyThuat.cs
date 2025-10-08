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
    public partial class frmNhanVienKyThuat : Form
    {
        public frmNhanVienKyThuat()
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
            panelBody.Controls.Add(childForm);
            panelBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnThemThietBi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEditThietBi_NVkyThuat());
          
        }


        private void btnThietBiPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangThietBiPhong());
        }

        private void btnTrangThaiPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangThaiPhong_NVkyThuat());
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dx =  MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dx == DialogResult.Yes)
            {
                frm_login loginForm = new frm_login();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
           
        }
    }
}
