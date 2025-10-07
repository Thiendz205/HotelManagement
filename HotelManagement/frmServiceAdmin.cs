using System;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmServiceAdmin : Form
    {
        public frmServiceAdmin()
        {
            InitializeComponent();
            InitializeLayoutHelpers();
        }

        private void InitializeLayoutHelpers()
        {
            if (dgvMain != null)
            {
                dgvMain.AutoGenerateColumns = false;
                dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

    }
}

