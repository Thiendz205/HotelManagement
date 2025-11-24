using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GUI.Helpers
{
    public static class CrystalReportHelper
    {
        // 🔥 Gán cứng server máy anh ở đây
        private static readonly string ServerName = @"LAPTOP-EKLM582L";
        private static readonly string DatabaseName = "HotelManagement";

        public static ReportDocument LoadReport(string reportFileName, Dictionary<string, object> parameters = null)
        {
            try
            {
                string reportPath = Path.Combine(Application.StartupPath, "Reports", reportFileName);

                if (!File.Exists(reportPath))
                {
                    MessageBox.Show("Không tìm thấy file báo cáo: " + reportPath,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                ReportDocument report = new ReportDocument();
                report.Load(reportPath);

                // Thiết lập connection
                ConnectionInfo connectionInfo = new ConnectionInfo
                {
                    ServerName = ServerName,
                    DatabaseName = DatabaseName,
                    IntegratedSecurity = true
                };

                ApplyConnection(report, connectionInfo);

                // Gán tham số
                if (parameters != null)
                {
                    foreach (var p in parameters)
                    {
                        try { report.SetParameterValue(p.Key, p.Value); } catch { }
                    }

                    // Subreport
                    foreach (ReportDocument sub in report.Subreports)
                    {
                        foreach (var p in parameters)
                        {
                            try { sub.SetParameterValue(p.Key, p.Value); } catch { }
                        }
                    }
                }

                return report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải báo cáo:\n" + ex.Message,
                    "Crystal Report", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private static void ApplyConnection(ReportDocument report, ConnectionInfo connInfo)
        {
            // Main tables
            foreach (Table table in report.Database.Tables)
            {
                TableLogOnInfo logonInfo = table.LogOnInfo;
                logonInfo.ConnectionInfo = connInfo;
                table.ApplyLogOnInfo(logonInfo);
            }

            // Subreports
            foreach (ReportDocument sub in report.Subreports)
            {
                foreach (Table table in sub.Database.Tables)
                {
                    TableLogOnInfo logonInfo = table.LogOnInfo;
                    logonInfo.ConnectionInfo = connInfo;
                    table.ApplyLogOnInfo(logonInfo);
                }
            }
        }
    }
}
