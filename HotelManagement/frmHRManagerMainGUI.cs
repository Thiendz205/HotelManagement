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
    public partial class frmHRManagerMainGUI : Form
    {
        public frmHRManagerMainGUI()
        {
            InitializeComponent();
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

        private void btnAccCount_Click(object sender, EventArgs e)
        {
            var transferForm = new frmAccCountHRGUI();
            OpenChildForm(transferForm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Chức năng đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void guna2Button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();

                //frmLogin loginForm = new frmLogin();
                //loginForm.Show();

                this.Close();
            }
        }


        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var transferForm = new frmEmployeeInforHRGUI();
            OpenChildForm(transferForm);
        }
    }
}
