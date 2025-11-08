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
    public partial class frmReportRoomEvaluation : Form
    {
        string maPhong;
        public frmReportRoomEvaluation(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
        }

        private void frmReportRoomEvaluation_Load(object sender, EventArgs e)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@RoomID", maPhong }
                };

                var report = CrystalReportHelper.LoadReport("rptRoomEvaluation.rpt", parameters);
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
