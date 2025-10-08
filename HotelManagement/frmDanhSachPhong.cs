using Guna.UI2.WinForms;
using HotelManagement.CustomControl;
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
    public partial class frmDanhSachPhong : Form
    {
        public frmDanhSachPhong()
        {
            InitializeComponent();
        }

        

      


        private void btnTang1_Click(object sender, EventArgs e)
        {
            btnTang1.FillColor = Color.FromArgb(255, 255, 243);
            btnTang2.FillColor = Color.Transparent;
            btnTang3.FillColor = Color.Transparent;
            btnTang4.FillColor = Color.Transparent;
            btnTang5.FillColor = Color.Transparent;
            btnTang6.FillColor = Color.Transparent;
            btnTang7.FillColor = Color.Transparent;
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            btnTang2.FillColor = Color.FromArgb(255, 255, 243);
            btnTang1.FillColor = Color.Transparent;
            btnTang3.FillColor = Color.Transparent;
            btnTang4.FillColor = Color.Transparent;
            btnTang5.FillColor = Color.Transparent;
            btnTang6.FillColor = Color.Transparent;
            btnTang7.FillColor = Color.Transparent;
        }

        private void btnTang3_Click(object sender, EventArgs e)
        {
            btnTang3.FillColor = Color.FromArgb(255, 255, 243);
            btnTang1.FillColor = Color.Transparent;
            btnTang2.FillColor = Color.Transparent;
            btnTang4.FillColor = Color.Transparent;
            btnTang5.FillColor = Color.Transparent;
            btnTang6.FillColor = Color.Transparent;
            btnTang7.FillColor = Color.Transparent;
        }

        private void btnTang4_Click(object sender, EventArgs e)
        {
            btnTang4.FillColor = Color.FromArgb(255, 255, 243);
            btnTang2.FillColor = Color.Transparent;
            btnTang3.FillColor = Color.Transparent;
            btnTang1.FillColor = Color.Transparent;
            btnTang5.FillColor = Color.Transparent;
            btnTang6.FillColor = Color.Transparent;
            btnTang7.FillColor = Color.Transparent;
        }

        private void btnTang5_Click(object sender, EventArgs e)
        {
            btnTang5.FillColor = Color.FromArgb(255, 255, 243);
            btnTang2.FillColor = Color.Transparent;
            btnTang3.FillColor = Color.Transparent;
            btnTang1.FillColor = Color.Transparent;
            btnTang4.FillColor = Color.Transparent;
            btnTang6.FillColor = Color.Transparent;
            btnTang7.FillColor = Color.Transparent;
        }

        private void btnTang6_Click(object sender, EventArgs e)
        {
            btnTang6.FillColor = Color.FromArgb(255, 255, 243);
            btnTang2.FillColor = Color.Transparent;
            btnTang3.FillColor = Color.Transparent;
            btnTang1.FillColor = Color.Transparent;
            btnTang5.FillColor = Color.Transparent;
            btnTang4.FillColor = Color.Transparent;
            btnTang7.FillColor = Color.Transparent;
        }

        private void btnTang7_Click(object sender, EventArgs e)
        {
            btnTang7.FillColor = Color.FromArgb(255, 255, 243);
            btnTang2.FillColor = Color.Transparent;
            btnTang3.FillColor = Color.Transparent;
            btnTang1.FillColor = Color.Transparent;
            btnTang5.FillColor = Color.Transparent;
            btnTang6.FillColor = Color.Transparent;
            btnTang4.FillColor = Color.Transparent;
        }

        private void btnRooms1_Click(object sender, EventArgs e)
        {
            txtTest.Text = "ok";

        }

        private void btnRooms2_Click(object sender, EventArgs e)
        {
            txtTest.Text = "  ";
        }



        private void cbTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTatCa.Checked)
            {
                cbTrong.Checked = false;
                cbDaDat.Checked = false;
                cbDangHoatDong.Checked = false;
                cbBaoTri.Checked = false;
            }
            FilterRooms();
        }

        private void cbTrong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTrong.Checked)
            {
                cbTatCa.Checked = false;
                cbDaDat.Checked = false;
                cbDangHoatDong.Checked = false;
                cbBaoTri.Checked = false;
            }
            FilterRooms();
        }

        private void cbDaDat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDaDat.Checked)
            {
                cbTatCa.Checked = false;
                cbTrong.Checked = false;
                cbDangHoatDong.Checked = false;
                cbBaoTri.Checked = false;
            }
            FilterRooms();
        }

        private void cbDangHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDangHoatDong.Checked)
            {
                cbTatCa.Checked = false;
                cbTrong.Checked = false;
                cbDaDat.Checked = false;
                cbBaoTri.Checked = false;
            }
            FilterRooms();
        }

        private void cbBaoTri_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBaoTri.Checked)
            {
                cbTatCa.Checked = false;
                cbTrong.Checked = false;
                cbDaDat.Checked = false;
                cbDangHoatDong.Checked = false;
            }
            FilterRooms();
        }

        private void FilterRooms()
        {
            bool anyStatusChecked = cbTatCa.Checked || cbTrong.Checked || cbDaDat.Checked || cbDangHoatDong.Checked || cbBaoTri.Checked;
            bool anyTypeChecked = cbVIP.Checked || cbNormal.Checked;

            foreach (btnRooms room in flLPn_danhSachPhong.Controls)
            {
                bool matchStatus = false;
                bool matchType = false;

                if (!anyStatusChecked)
                {
                    matchStatus = true;
                }
                else
                {
                    if (cbTatCa.Checked) matchStatus = true;
                    else if (cbTrong.Checked && room.RoomColor == Color.White) matchStatus = true;
                    else if (cbDaDat.Checked && room.RoomColor == Color.Gainsboro) matchStatus = true;
                    else if (cbDangHoatDong.Checked && room.RoomColor == Color.Aquamarine) matchStatus = true;
                    else if (cbBaoTri.Checked && room.RoomColor == Color.Red) matchStatus = true;
                }

                if (!anyTypeChecked)
                {
                    matchType = true;
                }
                else
                {
                    if (cbVIP.Checked && room.TypeRoom == "VIP") matchType = true;
                    if (cbNormal.Checked && room.TypeRoom == "Normal") matchType = true;
                }

                room.Visible = matchStatus && matchType;
            }
        }



        private void cbVIP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVIP.Checked) cbNormal.Checked = false;
            FilterRooms();
        }

        private void cbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNormal.Checked) cbVIP.Checked = false;
            FilterRooms();
        }

        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            lblDateNow.Text = DateTime.Now.ToString();
          

        }


        bool isThongTinChungExpanded = false;
        bool isDichVuExpanded = false;
        bool isThietBiExpanded = false;

        // Chiều cao DataGridView
        int dgvCollapsedHeight = 0;
        int dgvExpandedHeight = 200;

        private void ToggleDataGridView(DataGridView dgv, ref bool isExpanded, int expandedHeight)
        {
            if (isExpanded)
            {
                dgv.Height = dgvCollapsedHeight; // thu nhỏ
                isExpanded = false;
            }
            else
            {
                dgv.Height = expandedHeight;     // mở rộng
                isExpanded = true;
            }
        }

        

        private void pn_DanhSachDichVu_Click_1(object sender, EventArgs e)
        {
            ToggleDataGridView(dtGV_DanhSachDichVu, ref isDichVuExpanded, dgvExpandedHeight);

        }

        private void pn_DanhSachThietBi_Click_1(object sender, EventArgs e)
        {
            ToggleDataGridView(dtGV_DanhSachThietBi, ref isThietBiExpanded, dgvExpandedHeight);

        }

        private void pn_ThongTinChung_Click_1(object sender, EventArgs e)
        {
            ToggleDataGridView(dtGV_ThongTinChung, ref isThongTinChungExpanded, dgvExpandedHeight);

        }
    }
    
}
