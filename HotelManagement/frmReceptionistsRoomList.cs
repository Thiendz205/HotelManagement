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
    public partial class frmReceptionistsRoomList : Form
    {
        public frmReceptionistsRoomList()
        {
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            // Lấy form cha (frmBookingStaffHomeGUI) từ danh sách OpenForms
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmBookingGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            // Lấy form cha (frmBookingStaffHomeGUI) từ danh sách OpenForms
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmBookingGUI();
                parent.OpenChildForm(bookingDetailForm);
            }
        }
    }
}
