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
    public partial class frmUseServiceAdmin : Form
    {
        public frmUseServiceAdmin()
        {
            InitializeComponent();
            ConfigureLayout();
        }

        private void ConfigureLayout()
        {
            if (dgvMain != null)
            {
                dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvMain.AutoGenerateColumns = false;
            }
        }
    }
}
