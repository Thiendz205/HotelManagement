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
    public partial class frmChooseStatusReportEquipmentByStatus : Form
    {
        public frmChooseStatusReportEquipmentByStatus()
        {
            InitializeComponent();
        }
        EquipmentStorage_BUS equipmentStorage_BUS = new EquipmentStorage_BUS();
        private void frmChooseStatusReportEquipmentByStatus_Load(object sender, EventArgs e)
        {
            dtDSEquipmentByStatus.DataSource = equipmentStorage_BUS.getAllEquipment();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmChooseStatusReportEquipmentByStatus frm = new frmChooseStatusReportEquipmentByStatus();
            string trangThai = cbTrangThai.Text;
            frmReportGetEquipmentByStatus report = new frmReportGetEquipmentByStatus(trangThai);
            report.Show();
        }

        private void cbTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTrangThai.SelectedIndex == 0)
            {
                dtDSEquipmentByStatus.DataSource = equipmentStorage_BUS.getEquipmentByStatus("Available");
            }
            else if (cbTrangThai.SelectedIndex == 1)
            {
                dtDSEquipmentByStatus.DataSource = equipmentStorage_BUS.getEquipmentByStatus("Maintenance");
            }
            else if (cbTrangThai.SelectedIndex == 2)
            {
                dtDSEquipmentByStatus.DataSource = equipmentStorage_BUS.getEquipmentByStatus("In Use");
            }
        }

       
    }
}
