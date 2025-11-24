using GUI.Helpers;
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
    public partial class frmReportCustomerHistory : Form
    {
        public frmReportCustomerHistory(string customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }
        private readonly string _customerId;
        private void frmReportCustomerHistory_Load(object sender, EventArgs e)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@CustomerID", _customerId }
                };

                var report = CrystalReportHelper.LoadReport("rptCustomerFullHistory.rpt", parameters);
                if (report != null)
                    crystalReportViewer1.ReportSource = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
