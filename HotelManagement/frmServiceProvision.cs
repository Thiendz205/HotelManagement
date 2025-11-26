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
    public partial class frmServiceProvision : Form
    {
        private UseServiceBUS useServiceBUS = new UseServiceBUS();
        private List<ServiceItem> selectedServices = new List<ServiceItem>();
        private BookingET selectedBooking = null;
        private string currentStaffID = ""; // Sẽ được truyền từ form cha hoặc lấy từ session

        // Class để lưu dịch vụ đã chọn
        private class ServiceItem
        {
            public string ServiceID { get; set; }
            public string ServiceName { get; set; }
            public string Category { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal TotalPrice => UnitPrice * Quantity;
        }

        public frmServiceProvision()
        {
            InitializeComponent();
            SetupDataGridViews();
            LoadData();
        }

        public frmServiceProvision(string staffID) : this()
        {
            currentStaffID = staffID;
        }

        private void SetupDataGridViews()
        {
            // Setup dgvBookings columns
            dgvBookings.Columns.Clear();
            dgvBookings.Columns.Add("BookingID", "Mã booking");
            dgvBookings.Columns.Add("CustomerName", "Tên khách hàng");
            dgvBookings.Columns.Add("RoomName", "Số phòng");
            dgvBookings.Columns.Add("CheckIn", "Ngày check-in");
            dgvBookings.Columns.Add("Status", "Trạng thái");
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Setup dgvServices columns
            dgvServices.Columns.Clear();
            dgvServices.Columns.Add("ServiceID", "Mã dịch vụ");
            dgvServices.Columns.Add("ServiceName", "Tên dịch vụ");
            dgvServices.Columns.Add("Category", "Danh mục");
            dgvServices.Columns.Add("Price", "Đơn giá");
            dgvServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Setup dgvServiceList columns
            dgvServiceList.Columns.Clear();
            dgvServiceList.Columns.Add("ServiceID", "Mã dịch vụ");
            dgvServiceList.Columns.Add("ServiceName", "Tên dịch vụ");
            dgvServiceList.Columns.Add("Quantity", "Số lượng");
            dgvServiceList.Columns.Add("UnitPrice", "Đơn giá");
            dgvServiceList.Columns.Add("TotalPrice", "Thành tiền");
            dgvServiceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadData()
        {
            try
            {
                // Load danh sách booking (chỉ lấy các booking đang CheckIn)
                // So sánh không phân biệt hoa thường và kiểm tra null
                var allBookings = useServiceBUS.getAllBookings().ToList();
                var bookings = allBookings
                    .Where(b => !string.IsNullOrEmpty(b.Status) && 
                                b.Status.Trim().Equals("CheckIn", StringComparison.OrdinalIgnoreCase))
                    .ToList();
                
                dgvBookings.Rows.Clear();
                if (bookings.Count > 0)
                {
                    foreach (var booking in bookings)
                    {
                        dgvBookings.Rows.Add(
                            booking.BookingID ?? "",
                            booking.CustomerName ?? "",
                            booking.RoomName ?? "",
                            booking.CheckIn.ToString("dd/MM/yyyy HH:mm"),
                            booking.Status ?? ""
                        );
                    }
                }
                else
                {
                    // Hiển thị thông báo nếu không có booking nào
                    // Có thể hiển thị tất cả booking để debug
                    if (allBookings.Count > 0)
                    {
                        // Nếu có booking nhưng không có Status = "CheckIn", hiển thị tất cả để kiểm tra
                        foreach (var booking in allBookings.Take(10)) // Chỉ hiển thị 10 booking đầu tiên
                        {
                            dgvBookings.Rows.Add(
                                booking.BookingID ?? "",
                                booking.CustomerName ?? "",
                                booking.RoomName ?? "",
                                booking.CheckIn.ToString("dd/MM/yyyy HH:mm"),
                                booking.Status ?? ""
                            );
                        }
                    }
                }

                // Load danh sách dịch vụ
                var services = useServiceBUS.getAllServices().ToList();
                dgvServices.Rows.Clear();
                if (services.Count > 0)
                {
                    foreach (var service in services)
                    {
                        dgvServices.Rows.Add(
                            service.ServiceID ?? "",
                            service.ServiceName ?? "",
                            service.Category ?? "",
                            service.Price.ToString("N0") + " VNĐ"
                        );
                    }
                }

                // Load danh sách nhân viên dịch vụ
                var staffs = useServiceBUS.getServiceStaffs().ToList();
                cmbStaff.Items.Clear();
                if (staffs.Count > 0)
                {
                    foreach (var staff in staffs)
                    {
                        cmbStaff.Items.Add($"{staff.StaffID} - {staff.FullName}");
                    }
                    if (cmbStaff.Items.Count > 0)
                    {
                        cmbStaff.SelectedIndex = 0;
                        if (!string.IsNullOrEmpty(currentStaffID))
                        {
                            for (int i = 0; i < cmbStaff.Items.Count; i++)
                            {
                                if (cmbStaff.Items[i].ToString().StartsWith(currentStaffID))
                                {
                                    cmbStaff.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }
                }

                // Khởi tạo danh sách dịch vụ đã chọn (rỗng ban đầu)
                RefreshServiceList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchBooking_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearchBooking.Text.Trim().ToLower();
                var allBookings = useServiceBUS.getAllBookings().ToList();
                
                var bookings = allBookings
                    .Where(b => !string.IsNullOrEmpty(b.Status) && 
                                b.Status.Trim().Equals("CheckIn", StringComparison.OrdinalIgnoreCase) &&
                                (string.IsNullOrEmpty(searchText) ||
                                 (b.BookingID != null && b.BookingID.ToLower().Contains(searchText)) ||
                                 (b.CustomerName != null && b.CustomerName.ToLower().Contains(searchText)) ||
                                 (b.RoomName != null && b.RoomName.ToLower().Contains(searchText))))
                    .ToList();

                dgvBookings.Rows.Clear();
                if (bookings.Count > 0)
                {
                    foreach (var booking in bookings)
                    {
                        dgvBookings.Rows.Add(
                            booking.BookingID ?? "",
                            booking.CustomerName ?? "",
                            booking.RoomName ?? "",
                            booking.CheckIn.ToString("dd/MM/yyyy HH:mm"),
                            booking.Status ?? ""
                        );
                    }
                }
                else if (!string.IsNullOrEmpty(searchText))
                {
                    MessageBox.Show("Không tìm thấy booking nào phù hợp!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBookings_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                try
                {
                    string bookingID = dgvBookings.SelectedRows[0].Cells["BookingID"].Value.ToString();
                    var booking = useServiceBUS.getAllBookings()
                        .FirstOrDefault(b => b.BookingID == bookingID);

                    if (booking != null)
                    {
                        selectedBooking = booking;
                        txtBookingID.Text = booking.BookingID;
                        txtCustomerName.Text = booking.CustomerName;
                        txtRoomName.Text = booking.RoomName;
                        txtBookingStatus.Text = booking.Status;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn booking: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvServices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                try
                {
                    string serviceID = dgvServices.SelectedRows[0].Cells["ServiceID"].Value.ToString();
                    var service = useServiceBUS.getAllServices()
                        .FirstOrDefault(s => s.ServiceID == serviceID);

                    if (service != null)
                    {
                        txtServiceID.Text = service.ServiceID;
                        txtServiceName.Text = service.ServiceName;
                        txtCategory.Text = service.Category;
                        txtUnitPrice.Text = service.Price.ToString("N0") + " VNĐ";
                        numQuantity.Value = 1;
                        CalculateServiceTotal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            CalculateServiceTotal();
        }

        private void CalculateServiceTotal()
        {
            if (!string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                try
                {
                    decimal unitPrice = decimal.Parse(txtUnitPrice.Text.Replace(" VNĐ", "").Replace(",", ""));
                    int quantity = (int)numQuantity.Value;
                    decimal total = unitPrice * quantity;
                    txtServiceTotal.Text = total.ToString("N0") + " VNĐ";
                }
                catch { }
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (selectedBooking == null)
            {
                MessageBox.Show("Vui lòng chọn booking trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtServiceID.Text))
            {
                MessageBox.Show("Vui lòng chọn dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra xem dịch vụ đã có trong danh sách chưa
                var existingService = selectedServices.FirstOrDefault(s => s.ServiceID == txtServiceID.Text);
                if (existingService != null)
                {
                    // Nếu đã có, cập nhật số lượng
                    existingService.Quantity += (int)numQuantity.Value;
                }
                else
                {
                    // Nếu chưa có, thêm mới
                    decimal unitPrice = decimal.Parse(txtUnitPrice.Text.Replace(" VNĐ", "").Replace(",", ""));
                    selectedServices.Add(new ServiceItem
                    {
                        ServiceID = txtServiceID.Text,
                        ServiceName = txtServiceName.Text,
                        Category = txtCategory.Text,
                        UnitPrice = unitPrice,
                        Quantity = (int)numQuantity.Value
                    });
                }

                RefreshServiceList();
                ClearServiceFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveService_Click(object sender, EventArgs e)
        {
            if (dgvServiceList.SelectedRows.Count > 0)
            {
                try
                {
                    string serviceID = dgvServiceList.SelectedRows[0].Cells["ServiceID"].Value.ToString();
                    selectedServices.RemoveAll(s => s.ServiceID == serviceID);
                    RefreshServiceList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            if (dgvServiceList.SelectedRows.Count > 0)
            {
                try
                {
                    string serviceID = dgvServiceList.SelectedRows[0].Cells["ServiceID"].Value.ToString();
                    var service = selectedServices.FirstOrDefault(s => s.ServiceID == serviceID);
                    if (service != null)
                    {
                        if (numQuantity.Value > 0)
                        {
                            service.Quantity = (int)numQuantity.Value;
                            RefreshServiceList();
                            ClearServiceFields();
                        }
                        else
                        {
                            MessageBox.Show("Số lượng phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvServiceList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvServiceList.SelectedRows.Count > 0)
            {
                try
                {
                    string serviceID = dgvServiceList.SelectedRows[0].Cells["ServiceID"].Value.ToString();
                    var service = selectedServices.FirstOrDefault(s => s.ServiceID == serviceID);
                    if (service != null)
                    {
                        txtServiceID.Text = service.ServiceID;
                        txtServiceName.Text = service.ServiceName;
                        txtCategory.Text = service.Category;
                        txtUnitPrice.Text = service.UnitPrice.ToString("N0") + " VNĐ";
                        numQuantity.Value = service.Quantity;
                        CalculateServiceTotal();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshServiceList()
        {
            dgvServiceList.Rows.Clear();
            decimal totalAmount = 0;

            if (selectedServices != null && selectedServices.Count > 0)
            {
                foreach (var service in selectedServices)
                {
                    dgvServiceList.Rows.Add(
                        service.ServiceID ?? "",
                        service.ServiceName ?? "",
                        service.Quantity,
                        service.UnitPrice.ToString("N0") + " VNĐ",
                        service.TotalPrice.ToString("N0") + " VNĐ"
                    );
                    totalAmount += service.TotalPrice;
                }
            }

            txtTotalAmount.Text = totalAmount.ToString("N0") + " VNĐ";
        }

        private void ClearServiceFields()
        {
            txtServiceID.Text = "";
            txtServiceName.Text = "";
            txtCategory.Text = "";
            txtUnitPrice.Text = "";
            txtServiceTotal.Text = "";
            numQuantity.Value = 1;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tất cả dịch vụ đã chọn?", "Xác nhận", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                selectedServices.Clear();
                RefreshServiceList();
                ClearServiceFields();
            }
        }

        private void btnConfirmService_Click(object sender, EventArgs e)
        {
            if (selectedBooking == null)
            {
                MessageBox.Show("Vui lòng chọn booking trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedServices.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbStaff.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên dịch vụ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Lấy StaffID từ combobox
                string staffID = cmbStaff.SelectedItem.ToString().Split('-')[0].Trim();

                // Lưu từng dịch vụ vào database
                int successCount = 0;
                foreach (var service in selectedServices)
                {
                    string usageID = useServiceBUS.generateUsageID();
                    UseServiceET useService = new UseServiceET
                    {
                        UsageID = usageID,
                        BookingID = selectedBooking.BookingID,
                        ServiceID = service.ServiceID,
                        Quantity = service.Quantity,
                        StaffID = staffID,
                        UsageDate = DateTime.Now
                    };

                    if (useServiceBUS.addServiceUsage(useService))
                    {
                        successCount++;
                    }
                }

                if (successCount == selectedServices.Count)
                {
                    MessageBox.Show($"Đã cung cấp thành công {successCount} dịch vụ!", "Thành công", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    // Reset form
                    selectedServices.Clear();
                    RefreshServiceList();
                    ClearServiceFields();
                    selectedBooking = null;
                    txtBookingID.Text = "";
                    txtCustomerName.Text = "";
                    txtRoomName.Text = "";
                    txtBookingStatus.Text = "";
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Đã cung cấp {successCount}/{selectedServices.Count} dịch vụ!", "Cảnh báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xác nhận dịch vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearchBooking_TextChanged(object sender, EventArgs e)
        {
            // Tự động tìm kiếm khi gõ
            if (string.IsNullOrEmpty(txtSearchBooking.Text))
            {
                LoadData();
            }
        }


    }
}