using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace HotelManagement
{
    public partial class frmPersonal_Information : Form
    {
        
        private string staffID;
        public frmPersonal_Information(string staffID)
        {
            InitializeComponent();
            this.staffID = staffID;
        }
        private Login_Logout_BUS login_Logout_BUS = new Login_Logout_BUS();

        private void frmPersonal_Information_Load(object sender, EventArgs e)
        {       
            var staff = login_Logout_BUS.getInfoStaffs(staffID);
            if (staff != null)
            {
                lbName.Text = staff.FullName;
                lbCCCD.Text = staff.CitizenID;
                lbNgaySinh.Text = staff.DateOfBirth?.ToString("dd/MM/yyyy") ?? "";
                lbSDT.Text = staff.PhoneNumber;
                lbVaiTro.Text = staff.Role;
                lbNgayBatDau.Text = staff.StartDate.ToString("dd/MM/yyyy") ?? "";
                lbGioiTinh.Text = staff.Gender;
                lbMoTa.Text = staff.Note;
            }

        }
    }
}
