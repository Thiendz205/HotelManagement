using BUS;
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
    public partial class frmKhoThietBi : Form
    {   
        public frmKhoThietBi()
        {
            InitializeComponent();
        }
        EquipmentStorage_BUS equipmentStorage_BUS = new EquipmentStorage_BUS();
        private void frmKhoThietBi_Load(object sender, EventArgs e)
        {
            dtGV_KhoThietBi.DataSource = equipmentStorage_BUS.getAllEquipment();
        }
    }
}
