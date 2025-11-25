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
    public partial class frmAdminMain : Form
    {
        string maNhanVien;
        public frmAdminMain(string maNhanVien)
        {
            InitializeComponent();
            this.maNhanVien = maNhanVien;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccountAdmin());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStaffAdmin());
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmServiceAdmin());
        }

        private void btnUseService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUseServiceAdmin());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBillAdmin());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCustomerManagementAdminGUI());
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRankCustomerAdminGUI());
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmExtraChargeTypeAdminGUI());
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmExtraChargeAdminGUI());
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBookingAdminGUI());
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChinhSuaPhong());
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhoThietBi(maNhanVien));
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangThietBiPhong(maNhanVien));
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiPhong());
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhGiaPhong(maNhanVien));
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGiaPhongDongTheoThoiGIan());
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Bạn có chắc muốn đăng xuất không?",
                    "Đăng xuất",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSynthesisReport());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRevenueChartGUI());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            rp_chucNangPhong.IsMainMenu = true;
            rp_chucNangKhachHang.IsMainMenu = true;
            rp_chucNangDichVu.IsMainMenu = true;
            rp_chucNangPhi.IsMainMenu = true;
            rp_chucNangKhac.IsMainMenu = true;
            rp_chucNangBaoTri.IsMainMenu = true;
        }

       


        private void ddChucNangPhong_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton10_Click_1(object sender, EventArgs e)
        {
            rp_chucNangPhong.Show(gunaButton10, gunaButton10.Width, 0);
           
          
        }

     

        private void giáPhòngĐộngTheoThờiGianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGiaPhongDongTheoThoiGIan());


        }

        private void chỉnhSửaPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChinhSuaPhong());

        }

        private void loạiPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLoaiPhong());

        }

        private void khoThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhoThietBi(maNhanVien));

        }

        private void trangThiếtBịTrongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangThietBiPhong(maNhanVien));

        }

        private void đặtPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBookingAdminGUI());

        }

        private void đánhGiáPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhGiaPhong(maNhanVien));

        }

        private void gunaButton5_Click_1(object sender, EventArgs e)
        {
            rp_chucNangKhachHang.Show(gunaButton5, gunaButton5.Width, 0);

        }

        private void kháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCustomerManagementAdminGUI());

        }

        private void hạngKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRankCustomerAdminGUI());

        }

        private void gunaButton6_Click_1(object sender, EventArgs e)
        {
            rp_chucNangDichVu.Show(gunaButton6, gunaButton6.Width, 0);

        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmServiceAdmin());

        }

        private void sửDụngDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmUseServiceAdmin());

        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
            rp_chucNangPhi.Show(gunaButton1, gunaButton1.Width, 0);

        }

        private void phíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmExtraChargeAdminGUI());

        }

        private void loạiPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmExtraChargeTypeAdminGUI());

        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            rp_chucNangKhac.Show(gunaButton2, gunaButton2.Width, 0);

        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAccountAdmin());

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmStaffAdmin());

        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBillAdmin());

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRevenueChartGUI());

        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSynthesisReport());

        }

        private void btnBaoTri_Click(object sender, EventArgs e)
        {
            rp_chucNangBaoTri.Show(btnBaoTri, btnBaoTri.Width, 0);

        }

        private void loạiBảoTrìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMaintenanceType());

        }

        private void lịchSửBảoTrìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMaintenanceLog());

        }

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmSynthesisReport());
        }
    }
}
