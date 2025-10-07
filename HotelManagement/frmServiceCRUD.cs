using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace HotelManagement
{
    public partial class frmServiceCRUD : Form
    {
        public frmServiceCRUD()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (ValidateInput())
            //{
            //    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    ClearForm();
            //    LoadServices();
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (ValidateInput())
            //{
            //    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    ClearForm();
            //    LoadServices();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvServices.SelectedRows.Count > 0)
            //{
            //    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận", 
            //        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (result == DialogResult.Yes)
            //    {
            //        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadServices();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                LoadSelectedService();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadServices();
        }

        private bool ValidateInput()
        {
            //if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            //{
            //    MessageBox.Show("Vui lòng nhập tên dịch vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtServiceName.Focus();
            //    return false;
            //}

            //if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            //{
            //    MessageBox.Show("Vui lòng chọn danh mục dịch vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    cmbCategory.Focus();
            //    return false;
            //}

            //if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            //{
            //    MessageBox.Show("Vui lòng nhập giá dịch vụ hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    txtPrice.Focus();
            //    return false;
            //}

            return true;
        }

        private void ClearForm()
        {
            //txtServiceID.Clear();
            //txtServiceName.Clear();
            //cmbCategory.SelectedIndex = -1;
            //txtPrice.Clear();
            //txtDescription.Clear();
            //dgvServices.ClearSelection();
        }

        private void LoadServices()
        {
            //dgvServices.Rows.Clear();
            //dgvServices.Rows.Add("1", "Ăn sáng", "Ăn uống", "50000", "Dịch vụ ăn sáng buffet");
            //dgvServices.Rows.Add("2", "Giặt ủi", "Chăm sóc", "30000", "Dịch vụ giặt ủi quần áo");
            //dgvServices.Rows.Add("3", "Massage", "Chăm sóc", "200000", "Dịch vụ massage thư giãn");
            //dgvServices.Rows.Add("4", "Đưa đón sân bay", "Vận chuyển", "150000", "Dịch vụ đưa đón sân bay");
        }

        private void LoadSelectedService()
        {
            //if (dgvServices.SelectedRows.Count > 0)
            //{
            //    DataGridViewRow row = dgvServices.SelectedRows[0];
            //    txtServiceID.Text = row.Cells[0].Value.ToString();
            //    txtServiceName.Text = row.Cells[1].Value.ToString();
            //    cmbCategory.Text = row.Cells[2].Value.ToString();
            //    txtPrice.Text = row.Cells[3].Value.ToString();
            //    txtDescription.Text = row.Cells[4].Value.ToString();
            //}
        }

        private void frmServiceCRUD_Load(object sender, EventArgs e)
        {
            //LoadServices();
            //LoadCategories();
        }

        private void LoadCategories()
        {
            //cmbCategory.Items.Clear();
            //cmbCategory.Items.Add("Ăn uống");
            //cmbCategory.Items.Add("Chăm sóc");
            //cmbCategory.Items.Add("Vận chuyển");
            //cmbCategory.Items.Add("Giải trí");
            //cmbCategory.Items.Add("Khác");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
