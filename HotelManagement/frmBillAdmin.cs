using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmBillAdmin : Form
    {
        public frmBillAdmin()
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


