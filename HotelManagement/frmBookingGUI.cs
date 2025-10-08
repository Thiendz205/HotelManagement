using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelManagement
{
    public partial class frmBookingGUI : Form
    {
        public frmBookingGUI()
        {
            InitializeComponent();
        }

        private void frmBookingGUI_Load(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
                guna2CheckBox2.Enabled = false;
            else
                guna2CheckBox2.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox2.Checked)
                guna2CheckBox1.Enabled = false;
            else
                guna2CheckBox1.Enabled = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmReceptionistsRoomList();
                parent.OpenChildForm(bookingDetailForm);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmReceptionistsRoomList();
                parent.OpenChildForm(bookingDetailForm);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmReceptionistsRoomList();
                parent.OpenChildForm(bookingDetailForm);
            }
        }
    }
}
