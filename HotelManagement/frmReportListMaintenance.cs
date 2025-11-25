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
    public partial class frmReportListMaintenance : Form
    {
        public frmReportListMaintenance()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                int thang = int.Parse(cbThang.Text);
                int nam = (int)dtNam.Value.Year;
                string mode = cbLoai.Text.Trim();

                var parameters = new Dictionary<string, object>
        {
            { "@Mode", mode },
            { "@Month", thang },
            { "@Year", nam }
        };

                var report = CrystalReportHelper.LoadReport("rptListMaintenance.rpt", parameters);
                crystalReportViewer1.ReportSource = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải báo cáo: " + ex.Message);
            }
        }

    }
}
