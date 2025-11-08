using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using BUS;
using ET;

namespace HotelManagement
{
    public partial class frmServiceCRUD : Form
    {
        private ServiceBUS serviceBUS = new ServiceBUS();
        private ServiceET serviceET = new ServiceET();
        private List<ServiceET> _cacheAllServices = new List<ServiceET>();

        public frmServiceCRUD()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvServices.AutoGenerateColumns = false;
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Xóa các cột cũ nếu có
            dgvServices.Columns.Clear();

            // Thêm các cột
            dgvServices.Columns.Add("colServiceID", "Mã dịch vụ");
            dgvServices.Columns["colServiceID"].DataPropertyName = "ServiceID";
            dgvServices.Columns["colServiceID"].ReadOnly = true;

            dgvServices.Columns.Add("colServiceName", "Tên dịch vụ");
            dgvServices.Columns["colServiceName"].DataPropertyName = "ServiceName";
            dgvServices.Columns["colServiceName"].ReadOnly = true;

            dgvServices.Columns.Add("colCategory", "Danh mục");
            dgvServices.Columns["colCategory"].DataPropertyName = "Category";
            dgvServices.Columns["colCategory"].ReadOnly = true;

            dgvServices.Columns.Add("colPrice", "Giá");
            dgvServices.Columns["colPrice"].DataPropertyName = "Price";
            dgvServices.Columns["colPrice"].ReadOnly = true;
            dgvServices.Columns["colPrice"].DefaultCellStyle.Format = "N0";

            dgvServices.Columns.Add("colDescription", "Mô tả");
            dgvServices.Columns["colDescription"].DataPropertyName = "Description";
            dgvServices.Columns["colDescription"].ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            try
            {
                // Validate price
                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Giá dịch vụ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }

                // Check existence
                if (!serviceBUS.checkExistenceServiceName(txtServiceName.Text.Trim()))
                {
                    MessageBox.Show("Tên dịch vụ này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtServiceName.Focus();
                    return;
                }

                // Generate ServiceID tự động
                serviceET.ServiceID = serviceBUS.generateServiceID();
                serviceET.ServiceName = txtServiceName.Text.Trim();
                serviceET.Category = cmbCategory.Text.Trim();
                serviceET.Price = price;
                serviceET.Description = txtDescription.Text.Trim();

                bool success = serviceBUS.addService(serviceET);
                if (success)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadServices();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            try
            {
                // Lấy ServiceID từ dòng được chọn
                string currentServiceID = txtServiceID.Text.Trim();
                if (string.IsNullOrEmpty(currentServiceID))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate price
                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Giá dịch vụ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPrice.Focus();
                    return;
                }

                // Check existence for update
                if (!serviceBUS.checkExistenceServiceName_Update(txtServiceName.Text.Trim(), currentServiceID))
                {
                    MessageBox.Show("Tên dịch vụ này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtServiceName.Focus();
                    return;
                }

                serviceET.ServiceID = currentServiceID;
                serviceET.ServiceName = txtServiceName.Text.Trim();
                serviceET.Category = cmbCategory.Text.Trim();
                serviceET.Price = price;
                serviceET.Description = txtDescription.Text.Trim();

                bool success = serviceBUS.updateService(serviceET);
                if (success)
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadServices();
                }
                else
                {
                    MessageBox.Show("Cập nhật dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string serviceID = txtServiceID.Text.Trim();
                if (string.IsNullOrEmpty(serviceID))
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra khóa ngoại trước khi xóa
                if (serviceBUS.checkServiceHasForeignKey(serviceID))
                {
                    MessageBox.Show("Không thể xóa dịch vụ này vì đang được sử dụng trong hệ thống!\n" +
                                    "Vui lòng xóa các bản ghi liên quan trước.", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = serviceBUS.removeService(serviceID);
                    if (success)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadServices();
                    }
                    else
                    {
                        MessageBox.Show("Xóa dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                string searchText = txtSearch.Text?.Trim() ?? "";
                
                if (string.IsNullOrEmpty(searchText))
                {
                    LoadServices();
                    return;
                }

                var filteredServices = _cacheAllServices.Where(s =>
                (!string.IsNullOrEmpty(s.ServiceName) &&
                    s.ServiceName.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrEmpty(s.ServiceID) &&
                    s.ServiceID.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrEmpty(s.Category) &&
                    s.Category.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (!string.IsNullOrEmpty(s.Description) &&
                    s.Description.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                ).ToList();


                dgvServices.DataSource = filteredServices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServiceName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục dịch vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCategory.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ hợp lệ (số dương)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtServiceID.Clear();
            txtServiceName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtPrice.Clear();
            txtDescription.Clear();
            dgvServices.ClearSelection();
        }

        private void LoadServices()
        {
            try
            {
                _cacheAllServices = serviceBUS.getAllServices().ToList();
                dgvServices.DataSource = _cacheAllServices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSelectedService()
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                var row = dgvServices.SelectedRows[0];
                var service = row.DataBoundItem as ServiceET;
                
                if (service != null)
                {
                    txtServiceID.Text = service.ServiceID ?? "";
                    txtServiceName.Text = service.ServiceName ?? "";
                    cmbCategory.Text = service.Category ?? "";
                    txtPrice.Text = service.Price.ToString("N0");
                    txtDescription.Text = service.Description ?? "";
                }
                else
                {
                    // Fallback nếu DataBoundItem không có
                    txtServiceID.Text = row.Cells["colServiceID"]?.Value?.ToString() ?? "";
                    txtServiceName.Text = row.Cells["colServiceName"]?.Value?.ToString() ?? "";
                    cmbCategory.Text = row.Cells["colCategory"]?.Value?.ToString() ?? "";
                    var priceValue = row.Cells["colPrice"]?.Value;
                    if (priceValue != null)
                    {
                        if (decimal.TryParse(priceValue.ToString(), out decimal price))
                            txtPrice.Text = price.ToString("N0");
                    }
                    txtDescription.Text = row.Cells["colDescription"]?.Value?.ToString() ?? "";
                }
            }
        }

        private void frmServiceCRUD_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadServices();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("Ăn uống");
            cmbCategory.Items.Add("Giặt ủi");
            cmbCategory.Items.Add("Vận chuyển");
            cmbCategory.Items.Add("Spa & Massage");
            cmbCategory.Items.Add("Giải trí");
            cmbCategory.Items.Add("Khác");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            // Chỉ cho phép nhập số và dấu chấm
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                string filteredText = Regex.Replace(txtPrice.Text, @"[^\d.]", "");
                if (filteredText != txtPrice.Text)
                {
                    txtPrice.Text = filteredText;
                    txtPrice.SelectionStart = txtPrice.Text.Length;
                    txtPrice.SelectionLength = 0;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
            }
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
