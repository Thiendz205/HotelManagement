using System;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmAccountAdmin : Form
    {
        public frmAccountAdmin()
        {
            InitializeComponent();
            SetupLayout();
        }

        private void SetupLayout()
        {
            dgvMain.AutoGenerateColumns = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    
    }
}

