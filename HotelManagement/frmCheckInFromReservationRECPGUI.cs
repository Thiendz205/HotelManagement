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
    public partial class frmCheckInFromReservationRECPGUI : Form
    {
        public frmCheckInFromReservationRECPGUI()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmGuestCheckInRECPGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmGuestCheckInRECPGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmGuestCheckInRECPGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }
    }
}
