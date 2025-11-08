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
        private string staffID;
        public frmNhanVienKyThuat(string staffID)
        {
            InitializeComponent();
            this.staffID = staffID;
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

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEditThietBi_NVkyThuat());
        }

        private void btnThietBiTrongPhong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangThietBiPhong(staffID));
        }

        private void btnKhoThietBi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhoThietBi(staffID));
        }

        private void btnThayDoiTrangThai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangThaiPhong_NVkyThuat());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
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

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPersonal_Information(staffID));
        }
    }
}
