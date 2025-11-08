using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
namespace GUI.Helpers
{
    public static class CrystalReportHelper
    {
        private static readonly string ServerName = GetServerName();
        private static readonly string DatabaseName = "HotelManagement";

        private static string GetServerName()
        {
            try
            {
                var connStr = ConfigurationManager.ConnectionStrings["HotelManagementConnection"]?.ConnectionString;
                if (!string.IsNullOrEmpty(connStr))
                {
                    var builder = new SqlConnectionStringBuilder(connStr);
                    if (!string.IsNullOrEmpty(builder.DataSource))
                        return builder.DataSource;
                }
            }
            catch
            {
            }

            return Environment.MachineName + "\\SQLEXPRESS";
        }

        public static ReportDocument LoadReport(string reportFileName, Dictionary<string, object> parameters = null)
        {
            string reportPath = Path.Combine(Application.StartupPath, "Reports", reportFileName);

            if (!File.Exists(reportPath))
            {
                MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            ReportDocument report = new ReportDocument();
            report.Load(reportPath);

            // Thiết lập kết nối Windows Authentication
            ConnectionInfo connectionInfo = new ConnectionInfo
            {
                ServerName = ServerName,
                DatabaseName = DatabaseName,
                IntegratedSecurity = true
            };

            // Apply kết nối cho tất cả bảng chính
            foreach (Table table in report.Database.Tables)
            {
                TableLogOnInfo logonInfo = table.LogOnInfo;
                logonInfo.ConnectionInfo = connectionInfo;
                table.ApplyLogOnInfo(logonInfo);
            }

            // Apply cho các subreport (nếu có)
            foreach (ReportDocument subreport in report.Subreports)
            {
                foreach (Table table in subreport.Database.Tables)
                {
                    TableLogOnInfo logonInfo = table.LogOnInfo;
                    logonInfo.ConnectionInfo = connectionInfo;
                    table.ApplyLogOnInfo(logonInfo);
                }
            }

            // Gán tham số
            if (parameters != null)
            {
                foreach (var param in parameters)
                {
                    report.SetParameterValue(param.Key, param.Value);
                }
            }

            return report;
        }
    }
}

