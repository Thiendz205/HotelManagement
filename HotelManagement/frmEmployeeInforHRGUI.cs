using BUS;
using ET;
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
    public partial class frmEmployeeInforHRGUI : Form
    {
        public frmEmployeeInforHRGUI()
        {
            InitializeComponent();
        }
        StaffBUS staffBUS = new StaffBUS();
        private void frmEmployeeInforHRGUI_Load(object sender, EventArgs e)
        {
            var genders = new List<KeyValuePair<string, string>>
    {
        new KeyValuePair<string, string>("Male", "Nam"),
        new KeyValuePair<string, string>("Female", "Nữ")
    };
            cboGender.DataSource = genders;
            cboGender.DisplayMember = "Value";
            cboGender.ValueMember = "Key";

            cboRole.Items.Clear();
            cboRole.Items.AddRange(new string[]
            {
        "Lễ tân",
        "Dịch vụ",
        "Kỹ thuật",
        "Nhân sự"
            });

            cboStatus.Items.Add(new KeyValuePair<string, string>("All", "Tất cả"));
            cboStatus.Items.Add(new KeyValuePair<string, string>("Active", "Đang làm việc"));
            cboStatus.Items.Add(new KeyValuePair<string, string>("Inactive", "Đã nghỉ việc"));
            cboStatus.DisplayMember = "Value";
            cboStatus.ValueMember = "Key";
            cboStatus.SelectedIndex = 0;

            // ✅ THÊM DÒNG NÀY
            LoadStaffList();
            LoadStaffListHeaderText();
        }
        private bool ValidateInput()
        {
            // 🔹 Họ tên
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!Regex.IsMatch(txtFullName.Text.Trim(), @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Họ tên chỉ được chứa chữ cái và khoảng trắng!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Số điện thoại (9–15 số)
            if (!Regex.IsMatch(txtPhoneNumber.Text.Trim(), @"^\d{9,15}$"))
            {
                MessageBox.Show("Số điện thoại phải là số và từ 9–15 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 CCCD (9–12 số)
            if (!Regex.IsMatch(txtCitizenID.Text.Trim(), @"^\d{9,12}$"))
            {
                MessageBox.Show("CCCD phải là số và từ 9–12 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 🔹 Kiểm tra tuổi >= 18
            DateTime dob = dtpDateOfBirth.Value.Date;
            int age = DateTime.Today.Year - dob.Year;
            if (dob > DateTime.Today.AddYears(-age)) age--;

            if (age < 18)
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LoadStaffList()
        {
            dgvStaff.DataSource = staffBUS.getStaffsWithStatus().ToList();
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }

        private void GenerateStaffID()
        {
            txtStaffID.Text = staffBUS.generateStaffID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            txtStaffID.Text = staffBUS.generateStaffID();

            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!staffBUS.checkExistencePhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Số điện thoại đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!staffBUS.checkExistenceCitizenID(txtCitizenID.Text))
            {
                MessageBox.Show("CCCD đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StaffET newStaff = new StaffET
            {
                StaffID = txtStaffID.Text,
                FullName = txtFullName.Text,
                Role = cboRole.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Gender = ((KeyValuePair<string, string>)cboGender.SelectedItem).Key, // ✅ Lưu đúng Male/Female
                PhoneNumber = txtPhoneNumber.Text,
                CitizenID = txtCitizenID.Text,
                StartDate = dtpStartDate.Value,
                Notes = txtNotes.Text,
                Status = "Active" // ✅ Thêm mới luôn là đang làm việc
            };

            if (staffBUS.addStaff(newStaff))
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffList();
                ClearFields();
                GenerateStaffID(); // ✅ chuẩn bị cho thêm tiếp
            }
            else
            {
                MessageBox.Show("Không thể thêm nhân viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];

                txtStaffID.Text = row.Cells["StaffID"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                cboRole.Text = row.Cells["Role"].Value?.ToString();

                // ===== Giới tính: chuyển về hiển thị tiếng Việt =====
                string genderValue = row.Cells["Gender"].Value?.ToString();
                if (!string.IsNullOrEmpty(genderValue))
                {
                    if (genderValue.Equals("Male", StringComparison.OrdinalIgnoreCase))
                        cboGender.Text = "Nam";
                    else if (genderValue.Equals("Female", StringComparison.OrdinalIgnoreCase))
                        cboGender.Text = "Nữ";
                    else
                        cboGender.Text = genderValue; // Trường hợp DB đã lưu tiếng Việt
                }
                else
                {
                    cboGender.SelectedIndex = -1;
                }

                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtCitizenID.Text = row.Cells["CitizenID"].Value?.ToString();

                // ===== Ngày sinh =====
                if (row.Cells["DateOfBirth"].Value != null && DateTime.TryParse(row.Cells["DateOfBirth"].Value.ToString(), out DateTime dob))
                    dtpDateOfBirth.Value = dob;
                else
                    dtpDateOfBirth.Value = DateTime.Today;

                // ===== Ngày bắt đầu =====
                if (row.Cells["StartDate"].Value != null && DateTime.TryParse(row.Cells["StartDate"].Value.ToString(), out DateTime start))
                    dtpStartDate.Value = start;
                else
                    dtpStartDate.Value = DateTime.Today;

                txtNotes.Text = row.Cells["Notes"].Value?.ToString();
            }
        }
        private void ClearFields()
        {
            txtStaffID.Clear();
            txtFullName.Clear();
            txtPhoneNumber.Clear();
            txtCitizenID.Clear();
            txtNotes.Clear();
            cboRole.SelectedIndex = -1;
            cboGender.SelectedIndex = -1;
            dtpDateOfBirth.Value = DateTime.Today;
            dtpStartDate.Value = DateTime.Today;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string staffId = txtStaffID.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string citizenId = txtCitizenID.Text.Trim();
            string statusFilter = ((KeyValuePair<string, string>)cboStatus.SelectedItem).Key;

            var list = staffBUS.getStaffsWithStatus();

            var result = list.Where(s =>
                (string.IsNullOrEmpty(staffId) || s.StaffID.ToLower().Contains(staffId.ToLower())) &&
                (string.IsNullOrEmpty(fullName) || s.FullName.ToLower().Contains(fullName.ToLower())) &&
                (string.IsNullOrEmpty(phone) || s.PhoneNumber.ToLower().Contains(phone.ToLower())) &&
                (string.IsNullOrEmpty(citizenId) || s.CitizenID.ToLower().Contains(citizenId.ToLower())) &&
                (statusFilter == "All" || string.IsNullOrEmpty(statusFilter) || s.Status == statusFilter)
            ).ToList();

            if (result.Count == 0)
            {
                MessageBox.Show("Không tìm thấy nhân viên phù hợp với điều kiện tìm kiếm.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvStaff.DataSource = null;
            }
            else
            {
                dgvStaff.DataSource = result;
            }

            // Reset headerText sau khi gán DataSource
            if (dgvStaff.Columns.Count > 0) LoadStaffListHeaderText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStaffID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Kiểm tra dữ liệu cơ bản
            if (!ValidateInput())
                return;

            string staffID = txtStaffID.Text.Trim();
            string phone = txtPhoneNumber.Text.Trim();
            string citizenID = txtCitizenID.Text.Trim();

            // ✅ Kiểm tra trùng số điện thoại (ngoại trừ chính nó)
            if (!staffBUS.checkExistencePhoneNumber_Update(phone, staffID))
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng bởi nhân viên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Kiểm tra trùng CCCD (ngoại trừ chính nó)
            if (!staffBUS.checkExistenceCitizenID_Update(citizenID, staffID))
            {
                MessageBox.Show("CCCD này đã được sử dụng bởi nhân viên khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Tạo đối tượng nhân viên để update
            StaffET staff = new StaffET
            {
                StaffID = staffID,
                FullName = txtFullName.Text.Trim(),
                Role = cboRole.Text,
                DateOfBirth = dtpDateOfBirth.Value,
                Gender = ((KeyValuePair<string, string>)cboGender.SelectedItem).Key, // Lưu Male/Female
                PhoneNumber = phone,
                CitizenID = citizenID,
                StartDate = dtpStartDate.Value,
                Notes = txtNotes.Text
            };

            // ✅ Cập nhật
            bool result = staffBUS.updateStaff(staff);

            if (result)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadStaffList();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Kiểm tra dữ liệu hoặc trùng số điện thoại/CCCD.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadStaffListHeaderText()
        {
            if (dgvStaff.Columns["StaffID"] != null) dgvStaff.Columns["StaffID"].HeaderText = "Mã nhân viên";
            if (dgvStaff.Columns["FullName"] != null) dgvStaff.Columns["FullName"].HeaderText = "Họ và tên";
            if (dgvStaff.Columns["Role"] != null) dgvStaff.Columns["Role"].HeaderText = "Vai trò";
            if (dgvStaff.Columns["DateOfBirth"] != null) dgvStaff.Columns["DateOfBirth"].HeaderText = "Ngày sinh";
            if (dgvStaff.Columns["Gender"] != null) dgvStaff.Columns["Gender"].HeaderText = "Giới tính";
            if (dgvStaff.Columns["PhoneNumber"] != null) dgvStaff.Columns["PhoneNumber"].HeaderText = "Số điện thoại";
            if (dgvStaff.Columns["CitizenID"] != null) dgvStaff.Columns["CitizenID"].HeaderText = "CCCD";
            if (dgvStaff.Columns["StartDate"] != null) dgvStaff.Columns["StartDate"].HeaderText = "Ngày bắt đầu";
            if (dgvStaff.Columns["Notes"] != null) dgvStaff.Columns["Notes"].HeaderText = "Ghi chú";
            if (dgvStaff.Columns["Status"] != null) dgvStaff.Columns["Status"].HeaderText = "Trạng thái";
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadStaffList();
        }
    }
}
