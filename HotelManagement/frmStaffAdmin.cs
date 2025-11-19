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
    public partial class frmStaffAdmin : Form
    {
        StaffBUS staffBUS = new StaffBUS();
        StaffET staffET = new StaffET();

        public frmStaffAdmin()
        {
            InitializeComponent();
            SetupLayout();
        }

        private void SetupLayout()
        {
            dgvMain.AutoGenerateColumns = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Thiết lập các cột cho DataGridView
            colStaffID.DataPropertyName = "StaffID";
            colFullName.DataPropertyName = "FullName";
            colRole.DataPropertyName = "Role";
            colDOB.DataPropertyName = "DateOfBirth";
            colGender.DataPropertyName = "Gender";
            colPhone.DataPropertyName = "PhoneNumber";
            colCitizen.DataPropertyName = "CitizenID";
            colStartDate.DataPropertyName = "StartDate";
            colNotes.DataPropertyName = "Notes";
        }

        private void frmStaffAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadRoleComboBox();
            LoadRoleFilterComboBox();
            //LoadGenderComboBox();
        }

        private void LoadData()
        {
            try
            {
                _cacheAllStaffs = staffBUS.getAllStaffs().ToList();   // lấy 1 lần
                dgvMain.DataSource = _cacheAllStaffs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRoleComboBox()
        {
            cboRole.Items.Add("Lễ Tân");
            cboRole.Items.Add("Kỹ thuật");
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("Dịch vụ");
            cboRole.Items.Add("Nhân Sự");
        }

        private void LoadRoleFilterComboBox()
        {
            cboFilterRole.Items.Clear();
            cboFilterRole.Items.Add("Tất cả");
            cboFilterRole.Items.Add("Lễ tân");
            cboFilterRole.Items.Add("Kỹ thuật");
            cboFilterRole.Items.Add("Admin");
            cboFilterRole.Items.Add("Dịch vụ");
            cboFilterRole.Items.Add("Nhân sự");
            cboFilterRole.SelectedIndex = 0;
        }

        private void LoadGenderComboBox()
        {
            cboGender.Items.Add("Male");
            cboGender.Items.Add("Female");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboRole.Text))
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCitizen.Text))
            {
                MessageBox.Show("Vui lòng nhập CCCD/CMND!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboGender.Text))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpDOB.Value.Date > DateTime.Today.AddYears(-18))
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpDOB.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStartDate.Value.Date < dtpDOB.Value.AddYears(18).Date)
            {
                MessageBox.Show("Ngày bắt đầu làm phải sau khi nhân viên đủ 18 tuổi!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStartDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày bắt đầu làm không thể là ngày trong tương lai!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                if (!IsValidPhoneNumber(txtPhone.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidCitizenID(txtCitizen.Text))
                {
                    MessageBox.Show("CCCD/CMND không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (staffBUS.checkExistencePhoneNumber(txtPhone.Text) == false)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (staffBUS.checkExistenceCitizenID(txtCitizen.Text) == false)
                {
                    MessageBox.Show("CCCD/CMND này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                staffET.StaffID = staffBUS.generateStaffID();
                staffET.FullName = txtFullName.Text;
                staffET.Role = cboRole.Text;
                staffET.DateOfBirth = dtpDOB.Value; // DateTimePicker.Value trả về DateTime, không phải DateTime?
                staffET.Gender = cboGender.Text;
                staffET.PhoneNumber = txtPhone.Text;
                staffET.CitizenID = txtCitizen.Text;
                staffET.StartDate = dtpStartDate.Value;
                staffET.Notes = txtNotes.Text;
                
                bool success = staffBUS.addStaff(staffET);
                if (success)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboRole.Text))
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCitizen.Text))
            {
                MessageBox.Show("Vui lòng nhập CCCD/CMND!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboGender.Text))
            {
                MessageBox.Show("Vui lòng chọn giới tính!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpDOB.Value.Date > DateTime.Today.AddYears(-18))
            {
                MessageBox.Show("Nhân viên phải từ 18 tuổi trở lên!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpDOB.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày sinh không hợp lệ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStartDate.Value.Date < dtpDOB.Value.AddYears(18).Date)
            {
                MessageBox.Show("Ngày bắt đầu làm phải sau khi nhân viên đủ 18 tuổi!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpStartDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Ngày bắt đầu làm không thể là ngày trong tương lai!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string currentStaffID = "";
                if (dgvMain.SelectedRows.Count > 0)
                {
                    currentStaffID = dgvMain.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
                }
                else if (dgvMain.CurrentRow != null)
                {
                    currentStaffID = dgvMain.CurrentRow.Cells[0].Value?.ToString() ?? "";
                }
                
                if (string.IsNullOrEmpty(currentStaffID))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidPhoneNumber(txtPhone.Text))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidCitizenID(txtCitizen.Text))
                {
                    MessageBox.Show("CCCD/CMND không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (staffBUS.checkExistencePhoneNumber_Update(txtPhone.Text, currentStaffID) == false)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (staffBUS.checkExistenceCitizenID_Update(txtCitizen.Text, currentStaffID) == false)
                {
                    MessageBox.Show("CCCD/CMND này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                staffET.StaffID = currentStaffID;
                staffET.FullName = txtFullName.Text;
                staffET.Role = cboRole.Text;
                staffET.DateOfBirth = dtpDOB.Value; // DateTimePicker.Value trả về DateTime, không phải DateTime?
                staffET.Gender = cboGender.Text;
                staffET.PhoneNumber = txtPhone.Text;
                staffET.CitizenID = txtCitizen.Text;
                staffET.StartDate = dtpStartDate.Value;
                staffET.Notes = txtNotes.Text;
                
                bool success = staffBUS.updateStaff(staffET);
                if (success)
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy StaffID từ selection hiện tại
                string staffID = "";
                if (dgvMain.SelectedRows.Count > 0)
                {
                    staffID = dgvMain.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
                }
                else if (dgvMain.CurrentRow != null)
                {
                    staffID = dgvMain.CurrentRow.Cells[0].Value?.ToString() ?? "";
                }
                
                if (string.IsNullOrEmpty(staffID))
                {
                    MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                // Kiểm tra khóa ngoại trước khi xóa
                if (staffBUS.checkStaffHasForeignKey(staffID))
                {
                    MessageBox.Show("Không thể xóa nhân viên này vì đang được sử dụng trong hệ thống!\n" +
                                    "Vui lòng xóa các bản ghi liên quan trước.", "Thông báo", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool success = staffBUS.removeStaff(staffID);
                    if (success)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataGridViewRow GetCurrentRow()
        {
            if (dgvMain.CurrentRow != null && !dgvMain.CurrentRow.IsNewRow)
                return dgvMain.CurrentRow;

            if (dgvMain.CurrentCell != null)
                return dgvMain.Rows[dgvMain.CurrentCell.RowIndex];

            return null;
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
                txtStaffID.Text = row.Cells[0].Value?.ToString() ?? "";
                txtFullName.Text = row.Cells[1].Value?.ToString() ?? "";
                cboRole.Text = row.Cells[2].Value?.ToString() ?? "";

                // Chuyển đổi ngày sinh an toàn - xử lý DateTime? nullable
                if (row.Cells[3].Value != null)
                {
                    if (row.Cells[3].Value is DateTime dob)
                        dtpDOB.Value = dob;
                    else if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime parsedDob))
                        dtpDOB.Value = parsedDob;
                }
                else
                {
                    dtpDOB.Value = DateTime.Now.AddYears(-25); // Giá trị mặc định
                }

                cboGender.Text = row.Cells[4].Value?.ToString() ?? "";
                txtPhone.Text = row.Cells[5].Value?.ToString() ?? "";
                txtCitizen.Text = row.Cells[6].Value?.ToString() ?? "";

                // Chuyển đổi ngày bắt đầu an toàn
                if (row.Cells[7].Value != null)
                {
                    if (row.Cells[7].Value is DateTime start)
                        dtpStartDate.Value = start;
                    else if (DateTime.TryParse(row.Cells[7].Value.ToString(), out DateTime parsedStart))
                        dtpStartDate.Value = parsedStart;
                }
                else
                {
                    dtpStartDate.Value = DateTime.Now; // Giá trị mặc định
                }

                txtNotes.Text = row.Cells[8].Value?.ToString() ?? "";
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

        //private void txtSearch_TextChanged(object sender, EventArgs e)
        //{
        //    if (_isFillingControls) return; // <- quan trọng

        //    if (!string.IsNullOrEmpty(txtSearch.Text) && txtSearch.Text != "Tìm kiếm theo tên nhân viên...")
        //    {
        //        var allStaffs = staffBUS.getAllStaffs().ToList();
        //        var filteredStaffs = allStaffs.Where(s => s.FullName.Contains(txtSearch.Text)).ToList();
        //        dgvMain.DataSource = filteredStaffs;
        //    }
        //    else
        //    {
        //        LoadData();
        //    }
        //}


        //private void txtSearch_Enter(object sender, EventArgs e)
        //{
        //    if (txtSearch.Text == "Tìm kiếm theo tên nhân viên...")
        //    {
        //        txtSearch.Text = "";
        //        txtSearch.ForeColor = System.Drawing.Color.Black;
        //    }
        //}

        //private void txtSearch_Leave(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txtSearch.Text))
        //    {
        //        txtSearch.Text = "Tìm kiếm theo tên nhân viên...";
        //        txtSearch.ForeColor = System.Drawing.Color.Gray;
        //    }
        //}

        private void cboFilterRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isFillingControls) return;

            if (cboFilterRole.SelectedItem != null &&
                cboFilterRole.SelectedItem.ToString() != "Tất cả")
            {
                var role = cboFilterRole.SelectedItem.ToString();
                dgvMain.DataSource = _cacheAllStaffs.Where(s => s.Role == role).ToList();
            }
            else
            {
                dgvMain.DataSource = _cacheAllStaffs;
            }
        }


        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra số điện thoại Việt Nam (10-11 số, bắt đầu bằng 0)
            return Regex.IsMatch(phoneNumber, @"^0[0-9]{9,10}$");
        }

        private bool IsValidCitizenID(string citizenID)
        {
            // Kiểm tra CCCD/CMND (9-12 số)
            return Regex.IsMatch(citizenID, @"^[0-9]{9,12}$");
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.Text.Length > 11)
            {
                MessageBox.Show("Số điện thoại không được vượt quá 11 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Text = txtPhone.Text.Substring(0, 11);
                txtPhone.SelectionStart = txtPhone.Text.Length;
                txtPhone.SelectionLength = 0;
            }
        }

        private void txtCitizenID_TextChanged(object sender, EventArgs e)
        {
            if (txtCitizen.Text.Length > 12)
            {
                MessageBox.Show("CCCD/CMND không được vượt quá 12 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCitizen.Text = txtCitizen.Text.Substring(0, 12);
                txtCitizen.SelectionStart = txtCitizen.Text.Length;
                txtCitizen.SelectionLength = 0;
            }
        }
        private bool _isFillingControls = false;
        private List<StaffET> _cacheAllStaffs = new List<StaffET>();
        private void ClearForm()
        {
            txtStaffID.Text = "";
            txtFullName.Text = "";
            cboRole.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now.AddYears(-25);
            cboGender.SelectedIndex = -1;
            txtPhone.Text = "";
            txtCitizen.Text = "";
            dtpStartDate.Value = DateTime.Now;
            txtNotes.Text = "";
        }

        private void editorPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


