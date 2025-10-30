using BUS;
using ET;
using Guna.UI2.HtmlRenderer.Adapters;
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

namespace HotelManagement
{
    public partial class frmCustomerManagementAdminGUI : Form
    {
        public frmCustomerManagementAdminGUI()
        {
            InitializeComponent();
        }
        private int? selectedCustomerId = null;
        private string oldPhone = "";
        private string oldCCCD = "";
        private void frmCustomerManagementAdminGUI_Load(object sender, EventArgs e)
        {
            LoadCustomersAndUpgrade();
            cboCountry.DropDownStyle = ComboBoxStyle.DropDown;
            cboCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private CustomerBUS bus = new CustomerBUS();
        private void LoadCustomersAndUpgrade()
        {
            var customers = bus.GetAllCustomers();

            // 🔹 Tự động nâng hạng (không hiện thông báo)
            foreach (var c in customers)
            {
                bus.AutoUpgradeRank(c.CustomerID);
            }

            // 🔹 Sau khi nâng hạng xong, load lại dữ liệu mới nhất
            customers = bus.GetAllCustomers();

            dgvCustomers.DataSource = customers;
            dgvCustomers.AutoGenerateColumns = true;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ClearSelection();
            ClearInput();
            CustomizeCustomerGridView();
        }

        private void CustomizeCustomerGridView()
        {
            if (dgvCustomers.Columns.Count == 0) return;

            if (dgvCustomers.Columns.Contains("RankID"))
                dgvCustomers.Columns["RankID"].Visible = false;

            dgvCustomers.Columns["CustomerID"].HeaderText = "Mã khách hàng";
            dgvCustomers.Columns["FullName"].HeaderText = "Họ và tên";
            dgvCustomers.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            dgvCustomers.Columns["NationalID"].HeaderText = "CMND/CCCD";
            dgvCustomers.Columns["Address"].HeaderText = "Địa chỉ";
            dgvCustomers.Columns["Country"].HeaderText = "Quốc tịch";
            dgvCustomers.Columns["Gender"].HeaderText = "Giới tính";
            dgvCustomers.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            dgvCustomers.Columns["RankName"].HeaderText = "Hạng thành viên";
            dgvCustomers.Columns["TotalSpending"].HeaderText = "Tổng chi tiêu (VNĐ)";
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^\d{9,15}$"))
            {
                MessageBox.Show("Số điện thoại phải là số và từ 9–15 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtCCCD.Text, @"^\d{9,20}$"))
            {
                MessageBox.Show("CCCD phải là số và từ 9–20 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtFullName.Text.Length > 100)
            {
                MessageBox.Show("Họ tên không được vượt quá 100 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtAddress.Text.Length > 200)
            {
                MessageBox.Show("Địa chỉ không được vượt quá 200 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboCountry.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cboCountry.Text))
            {
                MessageBox.Show("Vui lòng chọn quốc gia hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!rdoNam.Checked && !rdoNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính (Nam hoặc Nữ)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Kiểm tra tuổi >= 18
            DateTime dob = dtpDOB.Value.Date;
            int age = DateTime.Today.Year - dob.Year;
            if (dob > DateTime.Today.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("Khách hàng phải từ 18 tuổi trở lên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void ClearInput()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtCCCD.Clear();
            txtAddress.Clear();
            cboCountry.SelectedIndex = -1;
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            dtpDOB.Value = DateTime.Today;

            selectedCustomerId = null;
            oldPhone = "";
            oldCCCD = "";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtFullName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string id = txtCCCD.Text.Trim();

            var result = bus.SearchCustomers(name, phone, id);

            if (result.Any())
            {
                dgvCustomers.DataSource = result;
                MessageBox.Show($"Tìm thấy {result.Count} khách hàng.", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvCustomers.DataSource = null;
                MessageBox.Show("Vui lòng nhập thông tin khách hàng (Họ tên, CCCD, SDT) hoặc không tìm thấy khách hàng dựa trên thông tin nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvCustomers.Rows[e.RowIndex];

                selectedCustomerId = Convert.ToInt32(row.Cells["CustomerID"].Value);
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtCCCD.Text = row.Cells["NationalID"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                string country = row.Cells["Country"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(country))
                {
                    int index = cboCountry.Items.IndexOf(country);
                    if (index >= 0)
                        cboCountry.SelectedIndex = index;
                    else
                        cboCountry.Text = country; 
                }
                else
                {
                    cboCountry.SelectedIndex = -1;
                }

                oldPhone = txtPhone.Text.Trim();
                oldCCCD = txtCCCD.Text.Trim();

                string gender = row.Cells["Gender"].Value?.ToString();
                if (gender == "Nam")
                    rdoNam.Checked = true;
                else if (gender == "Nữ")
                    rdoNu.Checked = true;
                else
                {
                    rdoNam.Checked = false;
                    rdoNu.Checked = false;
                }

                if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                    dtpDOB.Value = dob;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerId == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần cập nhật!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
                return;

            string newPhone = txtPhone.Text.Trim();
            string newCCCD = txtCCCD.Text.Trim();

            // 🔹 Kiểm tra trùng SĐT (nếu thay đổi)
            if (!newPhone.Equals(oldPhone, StringComparison.OrdinalIgnoreCase))
            {
                if (bus.IsPhoneExists(newPhone))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // 🔹 Kiểm tra trùng CCCD (nếu thay đổi)
            if (!newCCCD.Equals(oldCCCD, StringComparison.OrdinalIgnoreCase))
            {
                if (bus.IsNationalIDExists(newCCCD))
                {
                    MessageBox.Show("CCCD đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string gender = rdoNam.Checked ? "Nam" : (rdoNu.Checked ? "Nữ" : "");
            string country = cboCountry.SelectedItem != null ? cboCountry.SelectedItem.ToString() : string.Empty;
            var customer = new CustomerET
            {
                CustomerID = selectedCustomerId.Value,
                FullName = txtFullName.Text.Trim(),
                PhoneNumber = newPhone,
                NationalID = newCCCD,
                Address = txtAddress.Text.Trim(),
                Country = country,
                Gender = gender,
                DateOfBirth = dtpDOB.Value
            };

            bool result = bus.UpdateCustomer(customer);

            if (result)
            {
                MessageBox.Show("Cập nhật thông tin khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomersAndUpgrade();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCustomersAndUpgrade();
        }
    }
}
