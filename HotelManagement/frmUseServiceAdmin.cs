using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ET;

namespace HotelManagement
{
    public partial class frmUseServiceAdmin : Form
    {
        UseServiceBUS useServiceBUS = new UseServiceBUS();
        UseServiceET useServiceET = new UseServiceET();

        public frmUseServiceAdmin()
        {
            InitializeComponent();
            SetupLayout();
        }

        private void SetupLayout()
        {
            dgvMain.AutoGenerateColumns = false;
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // map cột (đúng tên DataProperty của ET)
            colUsageID.DataPropertyName = "UsageID";
            colServiceName.DataPropertyName = "ServiceName";
            colCustomerName.DataPropertyName = "CustomerName";
            colRoomName.DataPropertyName = "RoomName";
            colQuantity.DataPropertyName = "Quantity";
            colTotalAmount.DataPropertyName = "TotalAmount";
            colStaffName.DataPropertyName = "StaffName";
            colUsageDate.DataPropertyName = "UsageDate";
        }
        private string GetSelectedUsageId()
        {
            if (dgvMain.SelectedRows.Count == 0 && dgvMain.CurrentRow == null) return null;
            var row = (dgvMain.SelectedRows.Count > 0) ? dgvMain.SelectedRows[0] : dgvMain.CurrentRow;

            // ưu tiên cột tên "colUsageID" (đúng theo Designer)
            if (dgvMain.Columns.Contains("colUsageID"))
            {
                return row.Cells["colUsageID"].Value?.ToString();
            }

            // fallback: tìm theo DataPropertyName = "UsageID"
            var col = dgvMain.Columns.Cast<DataGridViewColumn>()
                         .FirstOrDefault(c => string.Equals(c.DataPropertyName, "UsageID", StringComparison.OrdinalIgnoreCase));
            if (col != null) return row.Cells[col.Index].Value?.ToString();

            return null;
        }
        private void frmUseServiceAdmin_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
            //dtpUsageDate.MinDate = DateTime.Today;
        }

        private void LoadData()
        {
            try
            {
                var list = useServiceBUS.getAllServiceUsages().ToList();
                dgvMain.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Services
                cboService.DataSource = useServiceBUS.getAllServices().ToList();
                cboService.DisplayMember = "ServiceName";
                cboService.ValueMember = "ServiceID";

                // Bookings
                cboBooking.DataSource = useServiceBUS.getAllBookings().ToList();
                cboBooking.DisplayMember = "CustomerName";
                cboBooking.ValueMember = "BookingID";

                // Staffs (CHỈ nhân viên dịch vụ)
                var serviceStaffs = useServiceBUS.getServiceStaffs().ToList();
                cboStaff.DataSource = serviceStaffs;
                cboStaff.DisplayMember = "FullName";
                cboStaff.ValueMember = "StaffID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboService.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboBooking.Text))
            {
                MessageBox.Show("Vui lòng chọn booking!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cboStaff.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpUsageDate.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Ngày sử dụng không hợp lệ (không được chọn ngày trong quá khứ)!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                // Generate UsageID tự động
                useServiceET.UsageID = useServiceBUS.generateUsageID();
                useServiceET.BookingID = cboBooking.SelectedValue?.ToString();
                useServiceET.ServiceID = cboService.SelectedValue?.ToString();
                useServiceET.Quantity = Convert.ToInt32(nudQuantity.Value);
                useServiceET.StaffID = cboStaff.SelectedValue?.ToString();
                useServiceET.UsageDate = dtpUsageDate.Value;

                bool success = useServiceBUS.addServiceUsage(useServiceET);
                if (success)
                {
                    MessageBox.Show("Thêm sử dụng dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm sử dụng dịch vụ thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedUsage();
            if (selected == null)
            {
                MessageBox.Show("Vui lòng chọn sử dụng dịch vụ cần sửa!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(cboService.Text) ||
                string.IsNullOrWhiteSpace(cboBooking.Text) ||
                string.IsNullOrWhiteSpace(cboStaff.Text))
            {
                MessageBox.Show("Vui lòng chọn đầy đủ dịch vụ / booking / nhân viên!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if (dtpUsageDate.Value.Date < DateTime.Today)
            //{
            //    MessageBox.Show("Ngày sử dụng không được ở trong quá khứ!",
            //        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            try
            {
                var et = new UseServiceET
                {
                    UsageID = selected.UsageID,
                    BookingID = cboBooking.SelectedValue?.ToString(),
                    ServiceID = cboService.SelectedValue?.ToString(),
                    Quantity = Convert.ToInt32(nudQuantity.Value),
                    StaffID = cboStaff.SelectedValue?.ToString(),
                    UsageDate = dtpUsageDate.Value
                };

                bool ok = useServiceBUS.updateServiceUsage(et);
                MessageBox.Show(ok ? "Cập nhật sử dụng dịch vụ thành công!" : "Cập nhật sử dụng dịch vụ thất bại!",
                    "Thông báo", MessageBoxButtons.OK, ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (ok) { LoadData(); ClearForm(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private UseServiceET GetSelectedUsage()
        {
            // Ưu tiên CurrentRow
            if (dgvMain.CurrentRow?.DataBoundItem is UseServiceET et1)
                return et1;

            // Nếu người dùng chọn nguyên dòng (SelectedRows)
            if (dgvMain.SelectedRows.Count > 0 &&
                dgvMain.SelectedRows[0].DataBoundItem is UseServiceET et2)
                return et2;

            return null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedUsage();
            if (selected == null)
            {
                MessageBox.Show("Vui lòng chọn sử dụng dịch vụ cần xóa!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi sử dụng dịch vụ này?",
                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                bool ok = useServiceBUS.removeServiceUsage(selected.UsageID);
                MessageBox.Show(ok ? "Xóa thành công!" : "Xóa thất bại!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                ok ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (ok) { LoadData(); ClearForm(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private int FindColIndex(DataGridView dgv, string field)
        {
            // Ưu tiên tìm theo Name
            var byName = dgv.Columns[field];
            if (byName != null) return byName.Index;

            // Không có Name thì tìm theo DataPropertyName
            var byProp = dgv.Columns
                            .Cast<DataGridViewColumn>()
                            .FirstOrDefault(c => string.Equals(c.DataPropertyName, field, StringComparison.OrdinalIgnoreCase));
            return byProp?.Index ?? -1;
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var item = dgvMain.Rows[e.RowIndex].DataBoundItem as UseServiceET;
            if (item == null) return;
            SetSelectedValueSafe(cboService, "ServiceID", item.ServiceID);
            SetSelectedValueSafe(cboBooking, "BookingID", item.BookingID);
            SetSelectedValueSafe(cboStaff, "StaffID", item.StaffID);
            nudQuantity.Value = Math.Max(nudQuantity.Minimum,
                                  Math.Min(nudQuantity.Maximum, item.Quantity));
            dtpUsageDate.Value = item.UsageDate == default ? DateTime.Now : item.UsageDate;
            cboStaff.Enabled = false;
        }



        private void SetSelectedValueSafe(ComboBox cbo, string valueMember, object value)
        {
            if (cbo.DataSource == null || value == null) { cbo.SelectedIndex = -1; return; }
            cbo.ValueMember = valueMember;
            // kiểm tra value có trong datasource
            bool exists = false;
            foreach (var it in (IEnumerable<object>)cbo.DataSource)
            {
                var prop = it.GetType().GetProperty(valueMember);
                if (prop != null && (prop.GetValue(it)?.ToString() ?? "") == value.ToString())
                {
                    exists = true; break;
                }
            }
            if (exists) cbo.SelectedValue = value;
            else cbo.SelectedIndex = -1; // không có trong danh sách (ví dụ NV không phải 'dịch vụ')
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private void ClearForm()
        {
            cboService.SelectedIndex = -1;
            cboBooking.SelectedIndex = -1;
            cboStaff.SelectedIndex = -1;
            nudQuantity.Value = 1;
            dtpUsageDate.Value = DateTime.Now;
            cboStaff.Enabled = true;
        }
    }
}
