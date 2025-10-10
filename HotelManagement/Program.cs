using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    internal static class Program
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frmNhanVienKyThuat()); chạy thẳng form riêng



            bool exitApp = false;

            while (!exitApp)
            {
                frm_login loginForm = new frm_login();
                DialogResult result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Mở form theo quyền đăng nhập
                    if (loginForm.UserRole == "Admin")
                    {
                        Application.Run(new frmAdminMain());
                    }
                    else if (loginForm.UserRole == "NVKT")
                    {
                        Application.Run(new frmNhanVienKyThuat());
                    }
                    else if (loginForm.UserRole == "HR")
                    {
                        Application.Run(new frmHRManagerMainGUI());
                    }
                    else if (loginForm.UserRole == "NVDV")
                    {
                        Application.Run(new frmServiceStaffMain());
                    }
                    else if (loginForm.UserRole == "NVLT")
                    {
                        Application.Run(new frmBookingStaffHomeGUI());
                    }
                }
                else
                {
                    // Bấm X hoặc Cancel → thoát ứng dụng
                    exitApp = true;
                }
            }
        }
    }
}
