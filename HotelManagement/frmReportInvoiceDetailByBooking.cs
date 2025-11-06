using GUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmReportInvoiceDetailByBooking : Form
    {
        private string bookingId;
        public frmReportInvoiceDetailByBooking(string bookingId )
        {
            InitializeComponent();
            this.bookingId = bookingId;
        }

        private void frmReportInvoiceDetailByBooking_Load(object sender, EventArgs e)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "@BookingID", bookingId }
                };

                var report = CrystalReportHelper.LoadReport("rptInvoiceDetailByBooking.rpt", parameters);
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
