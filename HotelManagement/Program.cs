using System;
using System.Windows.Forms;

namespace HotelManagement
{
    internal static class Program
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        /// <summary> /// The main entry point for the application. /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDanhGiaPhong());

            //bool exitApp = false;

            //while (!exitApp)
            //{
            //    frm_login loginForm = new frm_login();
            //    DialogResult result = loginForm.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {
            //        // 🔹 Mở form tương ứng theo vai trò
            //        switch (loginForm.UserRole)
            //        {
            //            case "Admin":
            //                Application.Run(new frmAdminMain(loginForm.StaffID));
            //                break;
            //            case "Kỹ thuật":
            //                Application.Run(new frmNhanVienKyThuat(loginForm.StaffID));
            //                break;
            //            case "Nhân sự":
            //                Application.Run(new frmHRManagerMainGUI());
            //                break;
            //            case "Dịch vụ":
            //                Application.Run(new frmServiceStaffMain());
            //                break;
            //            case "Lễ tân":
            //                Application.Run(new frmBookingStaffHomeGUI());
            //                break;
            //            default:
            //                MessageBox.Show("Vai trò không hợp lệ: " + loginForm.UserRole, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        exitApp = true;
            //    }
            //}
        }
    }
}
