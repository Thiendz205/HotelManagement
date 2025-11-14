using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace GUI.Helpers
{
    /// <summary>
    /// Loader chuẩn cho Crystal Reports.
    /// - Tự tìm file .rpt (bin\Reports hoặc ..\..\Reports) và copy sang Output nếu cần
    /// - Đọc chuỗi kết nối HotelManagementConnection trong App.config (nếu có)
    /// - Fallback về DESKTOP-UUT1B4I hoặc DESKTOP-UUT1B4I\SQLEXPRESS (tuỳ bạn chỉnh)
    /// - Gán connection cho tất cả tables & subreports
    /// - Set tham số cho main & subreports (tự bỏ ký tự '@' nếu có)
    /// </summary>
    public static class ReportFileLoader
    {
        public static ReportDocument LoadReportWithData(string reportFileName, Dictionary<string, object> parameters)
        {
            try
            {
                string reportPath = Path.Combine(Application.StartupPath, "Reports", reportFileName);
                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file report: " + reportPath);
                    return null;
                }

                string connStr = ConfigurationManager.ConnectionStrings["HotelManagementConnection"]?.ConnectionString
                                 ?? @"Data Source=.\SQLEXPRESS;Initial Catalog=HotelManagement;Integrated Security=True";

                DataTable dt = new DataTable();
                using (var conn = new SqlConnection(connStr))
                using (var cmd = new SqlCommand("sp_ServiceUsage_Detail", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    foreach (var p in parameters)
                        cmd.Parameters.AddWithValue("@" + p.Key, p.Value ?? DBNull.Value);

                    new SqlDataAdapter(cmd).Fill(dt);
                }

                var report = new ReportDocument();
                report.Load(reportPath);

                // ✅ Gán DataTable cho report
                report.SetDataSource(dt);
                // ✅ 7. Set parameters cho Crystal Report
                foreach (var p in parameters)
                {
                    // Crystal không dùng @ nên cần bỏ nếu có
                    string paramName = p.Key.StartsWith("@") ? p.Key.Substring(1) : p.Key;

                    // Nếu report có parameter này thì set giá trị
                    if (report.ParameterFields[paramName] != null)
                        report.SetParameterValue(paramName, p.Value ?? DBNull.Value);
                }

                // ✅ Gán Tham Số cho Crystal Report
                foreach (var p in parameters)
                {
                    string name = p.Key.StartsWith("@") ? p.Key.Substring(1) : p.Key;
                    if (report.ParameterFields[name] != null)
                        report.SetParameterValue(name, p.Value ?? DBNull.Value);
                }

                return report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load report:\n" + ex);
                return null;
            }
        }

    }
}
