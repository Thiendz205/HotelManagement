using CrystalDecisions.CrystalReports.Engine;
using GUI.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class frmReportServiceUsage_Detail : Form
    {
        private ReportDocument _report;

        public frmReportServiceUsage_Detail()
        {
            InitializeComponent();
            InitUiDefaults();
            LoadAllCombos();
        }

        #region UI init & combos

        private void InitUiDefaults()
        {
            // mặc định 7 ngày gần nhất
            dtpTo.Value = DateTime.Today;
            dtpFrom.Value = DateTime.Today.AddDays(-7);

            // viewer gọn gàng
            crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            crystalReportViewer1.ShowLogo = false;
            crystalReportViewer1.ShowExportButton = true;
            crystalReportViewer1.ShowPrintButton = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void LoadAllCombos()
        {
            try
            {
                // Các combo đều thêm dòng “(Tất cả)” = null
                LoadComboServiceCat();
                LoadComboStaff();
                LoadComboRoom();
                LoadComboCustomer();
                //TestSqlConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SqlConnection CreateConn()
        {
            // Dùng connection từ App.config: HotelManagementConnection
            var cs = ConfigurationManager.ConnectionStrings["HotelManagementConnection"]?.ConnectionString
                     ?? @"Data Source=.;Initial Catalog=HotelManagement;Integrated Security=True";
            return new SqlConnection(cs);
        }

        private void LoadComboServiceCat()
        {
            using (var conn = CreateConn())
            using (var cmd = new SqlCommand(
                @"SELECT DISTINCT Category AS Value, Category AS Text 
                  FROM Service 
                  WHERE ISNULL(Category,'') <> '' 
                  ORDER BY Category", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);

                // thêm dòng (Tất cả)
                var row = dt.NewRow();
                row["Value"] = DBNull.Value; row["Text"] = "(Tất cả)";
                dt.Rows.InsertAt(row, 0);

                //cboServiceCat.DataSource = dt;
                //cboServiceCat.ValueMember = "Value";
                //cboServiceCat.DisplayMember = "Text";
            }
        }

        private void LoadComboStaff()
        {
            using (var conn = CreateConn())
            using (var cmd = new SqlCommand(
                @"SELECT StaffID AS Value, FullName AS Text 
                  FROM Staff 
                  ORDER BY FullName", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);

                var row = dt.NewRow();
                row["Value"] = DBNull.Value; row["Text"] = "(Tất cả)";
                dt.Rows.InsertAt(row, 0);

                //cboStaff.DataSource = dt;
                //cboStaff.ValueMember = "Value";
                //cboStaff.DisplayMember = "Text";
            }
        }

        private void LoadComboRoom()
        {
            using (var conn = CreateConn())
            using (var cmd = new SqlCommand(
                @"SELECT RoomID AS Value, RoomName AS Text 
                  FROM Room 
                  ORDER BY RoomName", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);

                var row = dt.NewRow();
                row["Value"] = DBNull.Value; row["Text"] = "(Tất cả)";
                dt.Rows.InsertAt(row, 0);

                cboRoom.DataSource = dt;
                cboRoom.ValueMember = "Value";
                cboRoom.DisplayMember = "Text";
            }
        }

        #endregion

        #region Preview / Export

        private object DbNullIfEmpty(object value)
        {
            if (value == null) return DBNull.Value;
            if (value is string s && string.IsNullOrWhiteSpace(s)) return DBNull.Value;
            return value;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                var parameters = new Dictionary<string, object>
                {
                    { "FromDate",  dtpFrom.Value.Date },
                    { "ToDate",    dtpTo.Value.Date },
                    //{ "CustomerText", cboCustomer.SelectedValue ?? (object)DBNull.Value },
                    //{ "ServiceCat",   cboServiceCat.SelectedValue ?? (object)DBNull.Value },
                    //{ "StaffID",      cboStaff.SelectedValue ?? (object)DBNull.Value },
                    { "RoomID",       cboRoom.SelectedValue ?? (object)DBNull.Value },
                    //{ "OnlyPaid",     chkOnlyPaid.Checked ? (object)1 : (object)DBNull.Value }
                };

                try
                {
                    using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["HotelManagementConnection"].ConnectionString))
                    using (var cmd = new SqlCommand("sp_ServiceUsage_Detail", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                        cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);
                        //cmd.Parameters.AddWithValue("@CustomerText", cboCustomer.SelectedValue ?? (object)DBNull.Value);
                       // cmd.Parameters.AddWithValue("@ServiceCat", cboServiceCat.SelectedValue ?? (object)DBNull.Value);
                       // cmd.Parameters.AddWithValue("@StaffID", cboStaff.SelectedValue ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@RoomID", cboRoom.SelectedValue ?? (object)DBNull.Value);
//cmd.Parameters.AddWithValue("@OnlyPaid", chkOnlyPaid.Checked ? 1 : (object)DBNull.Value);

                        var da = new SqlDataAdapter(cmd);
                        var dt = new DataTable();
                        da.Fill(dt);

                        MessageBox.Show("Số dòng dữ liệu: " + dt.Rows.Count);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi test dữ liệu: " + ex.Message);
                }

                _report = ReportFileLoader.LoadReportWithData("rptServiceUsage_Detail.rpt", parameters);


                if (_report == null)
                {
                    MessageBox.Show("Report bị null – có thể không tìm thấy file hoặc lỗi kết nối CSDL.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                crystalReportViewer1.ReportSource = _report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo:\n" + ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #endregion

        #region Dispose

        private void frmServiceUsageReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisposeReport();
        }

        private void DisposeReport()
        {
            try
            {
                if (_report != null)
                {
                    crystalReportViewer1.ReportSource = null;
                    _report.Close();
                    _report.Dispose();
                    _report = null;
                }
            }
            catch { /* ignore */ }
        }

        private void LoadComboCustomer()
        {
            using (var conn = CreateConn())
            using (var cmd = new SqlCommand(@"
            SELECT CAST(NULL AS varchar(20)) AS Value, N'(Tất cả khách hàng)' AS Text
            UNION ALL
            SELECT PhoneNumber AS Value,
                   (FullName + N' - ' + PhoneNumber) AS Text
            FROM   Customer
            ORDER BY Text", conn))
            using (var da = new SqlDataAdapter(cmd))
            {
                var dt = new DataTable();
                da.Fill(dt);

                //cboCustomer.DataSource = dt;
                //cboCustomer.ValueMember = "Value";   // PhoneNumber hoặc NULL cho “Tất cả”
                //cboCustomer.DisplayMember = "Text";
                //cboCustomer.SelectedIndex = 0;
            }
        }

        private void frmReportServiceUsage_Detail_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }
        //// ======== HÀM TEST KẾT NỐI SQL ========
        //private void TestSqlConnection()
        //{
        //    try
        //    {
        //        var cs = ConfigurationManager.ConnectionStrings["HotelManagementConnection"]?.ConnectionString;
        //        using (var conn = new SqlConnection(cs))
        //        {
        //            conn.Open();
        //            MessageBox.Show("Kết nối thành công tới: " + conn.DataSource + " / DB: " + conn.Database);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi khi mở kết nối SQL:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        #endregion

        //private void btnXemBaoCao_Click(object sender, EventArgs e)
        //{

        //}
    }
}

