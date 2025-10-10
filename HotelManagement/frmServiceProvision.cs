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
    public partial class frmServiceProvision : Form
    {
        public frmServiceProvision()
        {
            InitializeComponent();
            SetupDataGridViews();
        }

        private void SetupDataGridViews()
        {

            // Setup dgvServices columns
            dgvServices.Columns.Clear();
            dgvServices.Columns.Add("ServiceID", "Mã dịch vụ");
            dgvServices.Columns.Add("ServiceName", "Tên dịch vụ");
            dgvServices.Columns.Add("Category", "Danh mục");
            dgvServices.Columns.Add("UnitPrice", "Đơn giá");

            // Setup dgvServiceList columns
            dgvServiceList.Columns.Clear();
            dgvServiceList.Columns.Add("ServiceID", "Mã dịch vụ");
            dgvServiceList.Columns.Add("ServiceName", "Tên dịch vụ");
            dgvServiceList.Columns.Add("Quantity", "Số lượng");
            dgvServiceList.Columns.Add("UnitPrice", "Đơn giá");
            dgvServiceList.Columns.Add("TotalPrice", "Thành tiền");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
           
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvServiceList_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
          
        }

        private void btnConfirmService_Click(object sender, EventArgs e)
        {
           
        }

        private void txtSearchBooking_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtServiceName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}