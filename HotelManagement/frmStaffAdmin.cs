using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmStaffAdmin : Form
    {
        public frmStaffAdmin()
        {
            InitializeComponent();
            ConfigureLayout();
        }

        private void ConfigureLayout()
        {
            dgvMain.AutoGenerateColumns = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}


