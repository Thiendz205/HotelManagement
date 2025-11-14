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
    public partial class frmSynthesisReport : Form
    {
        public frmSynthesisReport()
        {
            InitializeComponent();
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            frmChooseStatusReportEquipmentByStatus frm = new frmChooseStatusReportEquipmentByStatus();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            var parentPanel = this.Parent; 
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(frm);
            frm.Show();                 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmReportServiceUsage_Detail frm = new frmReportServiceUsage_Detail();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            var parentPanel = this.Parent;
            parentPanel.Controls.Clear();
            parentPanel.Controls.Add(frm);
            frm.Show();
        }
    }
}
