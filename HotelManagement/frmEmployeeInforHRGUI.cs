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
    public partial class frmEmployeeInforHRGUI : Form
    {
        public frmEmployeeInforHRGUI()
        {
            InitializeComponent();
        }

        private void frmEmployeeInforHRGUI_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }
    }
}
