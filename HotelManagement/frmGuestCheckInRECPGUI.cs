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
    public partial class frmGuestCheckInRECPGUI : Form
    {
        public frmGuestCheckInRECPGUI()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmCheckInFromReservationRECPGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }
    }
}
