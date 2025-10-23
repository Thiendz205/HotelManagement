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
using BUS;
using ET;

namespace HotelManagement
{
    public partial class frmServiceAdmin : Form
    {
        ServiceBUS serviceBUS = new ServiceBUS();
        ServiceET serviceET = new ServiceET();

        public frmServiceAdmin()
        {
            InitializeComponent();
            SetupLayout();
        }

        private void SetupLayout()
        {
            dgvMain.AutoGenerateColumns = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Thiết lập các cột cho DataGridView
            colServiceID.DataPropertyName = "ServiceID";
            colServiceName.DataPropertyName = "ServiceName";
            colCategory.DataPropertyName = "Category";
            colPrice.DataPropertyName = "Price";
            colDescription.DataPropertyName = "Description";
        }

        private void frmServiceAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadCategoryComboBox();
            LoadCategoryFilterComboBox();
        }

        private void LoadData()
        {
            try
            {
                _cacheAllServices = serviceBUS.getAllServices().ToList();
                dgvMain.DataSource = _cacheAllServices;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategoryComboBox()
        {
            gunaComboBox1.Items.Add("Ăn uống");
            gunaComboBox1.Items.Add("Giặt ủi");
            gunaComboBox1.Items.Add("Vận chuyển");
            gunaComboBox1.Items.Add("Spa & Massage");
            gunaComboBox1.Items.Add("Giải trí");
            gunaComboBox1.Items.Add("Khác");
        }

        private void LoadCategoryFilterComboBox()
        {
            gunaComboBox2.Items.Clear();
            gunaComboBox2.Items.Add("Tất cả");
            gunaComboBox2.Items.Add("Ăn uống");
            gunaComboBox2.Items.Add("Giặt ủi");
            gunaComboBox2.Items.Add("Vận chuyển");
            gunaComboBox2.Items.Add("Spa & Massage");
            gunaComboBox2.Items.Add("Giải trí");
            gunaComboBox2.Items.Add("Khác");
            gunaComboBox2.SelectedIndex = 0; // Chọn "Tất cả" mặc định
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(gunaComboBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Validate price
                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Giá dịch vụ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check existence
                if (serviceBUS.checkExistenceServiceName(txtServiceName.Text) == false)
                {
                    MessageBox.Show("Tên dịch vụ này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                serviceET.ServiceName = txtServiceName.Text;
                serviceET.Category = gunaComboBox1.Text;
                serviceET.Price = price;
                serviceET.Description = txtDescription.Text;
                
                bool success = serviceBUS.addService(serviceET);
                if (success)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kiểm tra selection bằng nhiều cách
            if (dgvMain.SelectedRows.Count == 0 && dgvMain.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(gunaComboBox1.Text))
            {
                MessageBox.Show("Vui lòng chọn danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Vui lòng nhập giá dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy ServiceID từ selection hiện tại
                int currentServiceID = 0;
                if (dgvMain.SelectedRows.Count > 0)
                {
                    int.TryParse(dgvMain.SelectedRows[0].Cells[0].Value?.ToString(), out currentServiceID);
                }
                else if (dgvMain.CurrentRow != null)
                {
                    int.TryParse(dgvMain.CurrentRow.Cells[0].Value?.ToString(), out currentServiceID);
                }
                
                if (currentServiceID == 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate price
                if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
                {
                    MessageBox.Show("Giá dịch vụ không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check existence for update
                if (serviceBUS.checkExistenceServiceName_Update(txtServiceName.Text, currentServiceID) == false)
                {
                    MessageBox.Show("Tên dịch vụ này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                serviceET.ServiceID = currentServiceID;
                serviceET.ServiceName = txtServiceName.Text;
                serviceET.Category = gunaComboBox1.Text;
                serviceET.Price = price;
                serviceET.Description = txtDescription.Text;
                
                bool success = serviceBUS.updateService(serviceET);
                if (success)
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
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
            // Kiểm tra selection bằng nhiều cách
            if (dgvMain.SelectedRows.Count == 0 && dgvMain.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy ServiceID từ selection hiện tại
                int serviceID = 0;
                if (dgvMain.SelectedRows.Count > 0)
                {
                    int.TryParse(dgvMain.SelectedRows[0].Cells[0].Value?.ToString(), out serviceID);
                }
                else if (dgvMain.CurrentRow != null)
                {
                    int.TryParse(dgvMain.CurrentRow.Cells[0].Value?.ToString(), out serviceID);
                }
                
                if (serviceID == 0)
                {
                    MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = serviceBUS.removeService(serviceID);
                    if (success)
                    {
                        MessageBox.Show("Xóa dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
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

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Bỏ qua nếu bấm vào tiêu đề hoặc hàng trống
            if (e.RowIndex < 0) return;

            int dong = e.RowIndex;

            // Lấy hàng được click
            var row = dgvMain.Rows[dong];
            if (row.IsNewRow) return;

            try
            {
                // Dùng toán tử ? để tránh lỗi null
                txtServiceID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtServiceName.Text = row.Cells[1].Value?.ToString() ?? "";
                gunaComboBox1.Text = row.Cells[2].Value?.ToString() ?? "";
                txtPrice.Text = row.Cells[3].Value?.ToString() ?? "";
                txtDescription.Text = row.Cells[4].Value?.ToString() ?? "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi đọc dữ liệu hàng: " + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_isFillingControls) return;

            if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text != "Tìm kiếm theo tên dịch vụ...")
            {
                var allServices = serviceBUS.getAllServices().ToList();
                var filteredServices = allServices.Where(s => s.ServiceName.Contains(txtSearch.Text)).ToList();
                dgvMain.DataSource = filteredServices;
            }
            else
            {
                LoadData();
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm theo tên dịch vụ...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Tìm kiếm theo tên dịch vụ...";
                txtSearch.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void gunaComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isFillingControls) return;

            if (gunaComboBox2.SelectedItem != null &&
                gunaComboBox2.SelectedItem.ToString() != "Tất cả")
            {
                var category = gunaComboBox2.SelectedItem.ToString();
                dgvMain.DataSource = _cacheAllServices.Where(s => s.Category == category).ToList();
            }
            else
            {
                dgvMain.DataSource = _cacheAllServices;
            }
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

        private bool _isFillingControls = false;
        private List<ServiceET> _cacheAllServices = new List<ServiceET>();
        
        private void ClearForm()
        {
            txtServiceID.Text = "";
            txtServiceName.Text = "";
            gunaComboBox1.SelectedIndex = -1;
            txtPrice.Text = "";
            txtDescription.Text = "";
        }

        private void editorPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

