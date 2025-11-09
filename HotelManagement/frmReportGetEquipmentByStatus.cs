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
    public partial class frmReportGetEquipmentByStatus : Form
    {
        string trangThai;
        public frmReportGetEquipmentByStatus(string trangThai)
        {
            InitializeComponent();
            this.trangThai = trangThai;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@Status", trangThai }
                };

                var report = CrystalReportHelper.LoadReport("rptEquipmentByStatus.rpt", parameters);
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
