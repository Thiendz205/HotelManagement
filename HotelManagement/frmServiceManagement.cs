using BUS;
using ET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace HotelManagement
{
    public partial class frmServiceManagement : Form
    {
        public frmServiceManagement()
        {
            InitializeComponent();
            SetupDataGridViews();
        }

        private void SetupDataGridViews()
        {
            // Setup dgvServiceUsage columns
            dgvServiceUsage.Columns.Clear();
            dgvServiceUsage.Columns.Add("UsageID", "Mã sử dụng");
            dgvServiceUsage.Columns.Add("CustomerName", "Tên khách hàng");
            dgvServiceUsage.Columns.Add("RoomNumber", "Số phòng");
            dgvServiceUsage.Columns.Add("ServiceName", "Tên dịch vụ");
            dgvServiceUsage.Columns.Add("Quantity", "Số lượng");
            dgvServiceUsage.Columns.Add("TotalPrice", "Tổng tiền");
            dgvServiceUsage.Columns.Add("Status", "Trạng thái");
            dgvServiceUsage.Columns.Add("DateTime", "Thời gian");
        }
    //    private readonly UseServiceBUS _bus = new UseServiceBUS();
    //    private readonly BindingSource _bs = new BindingSource();

    //    public frmServiceUsage(string currentStaffId)
    //    {
    //        InitializeComponent();
    //        txtStaffID.Text = currentStaffId;     // hoặc lấy từ context đăng nhập
    //        Setup();
    //        LoadCombos();
    //        LoadGrid();
    //    }

    //    private void Setup()
    //    {
    //        dgvUsage.AutoGenerateColumns = false;

    //        nudQty.Minimum = 1;
    //        nudQty.Value = 1;
    //        nudQty.ValueChanged += (_, __) => RecalcLine();

    //        cboService.SelectedIndexChanged += (_, __) => {
    //            if (cboService.SelectedItem is ComboItem sv)
    //            {
    //                txtServicePrice.Text = sv.Price.ToString("0.##");
    //                RecalcLine();
    //            }
    //        };

    //        dtpUsageDate.Value = DateTime.Now;
    //    }

    //    private void LoadCombos()
    //    {
    //        // Booking
    //        var bookings = _bus.GetBookingOptions().ToList()
    //            .Select(x => new ComboItem { Id = x.Id, Text = x.Display })
    //            .ToList();
    //        cboBooking.DataSource = bookings;
    //        cboBooking.DisplayMember = "Text";
    //        cboBooking.ValueMember = "Id";

    //        // Service
    //        var services = _bus.GetServiceOptions().ToList()
    //            .Select(x => new ComboItem { Id = x.Id, Text = x.Name, Price = x.Price })
    //            .ToList();
    //        cboService.DataSource = services;
    //        cboService.DisplayMember = "Text";
    //        cboService.ValueMember = "Id";

    //        if (services.Any()) txtServicePrice.Text = services[0].Price.ToString("0.##");
    //        RecalcLine();
    //    }

    //    private void LoadGrid(string bookingId = null)
    //    {
    //        _bs.DataSource = _bus.Search(bookingId, DateTime.Today, DateTime.Today.AddDays(1)).ToList();
    //        dgvUsage.DataSource = _bs;
    //    }

    //    private void RecalcLine()
    //    {
    //        decimal price = decimal.TryParse(txtServicePrice.Text, out var p) ? p : 0;
    //        int qty = (int)nudQty.Value;
    //        txtLineTotal.Text = (price * qty).ToString("0.##");
    //    }

    //    private UseServiceET ReadForm()
    //    {
    //        return new UseServiceET
    //        {
    //            UsageID = txtUsageID.Text.Trim(),
    //            BookingID = _fixedBookingId, // đã truyền từ form cha
    //            ServiceID = cboService.SelectedValue?.ToString(),
    //            Quantity = (int)nudQty.Value,
    //            StaffID = txtStaffID.Text.Trim(),
    //            UsageDate = dtpUsageDate.Value
    //        };
    //    }

    //    private void btnAdd_Click(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            var et = ReadForm();
    //            string newId = _bus.Add(et);
    //            txtUsageID.Text = newId;
    //            LoadGrid(cboBooking.SelectedValue?.ToString());
    //            MessageBox.Show("Đã thêm sử dụng dịch vụ.");
    //        }
    //        catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi"); }
    //    }

    //    private void btnUpdate_Click(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            if (string.IsNullOrEmpty(txtUsageID.Text)) return;
    //            var et = ReadForm();
    //            _bus.Update(et);
    //            LoadGrid(cboBooking.SelectedValue?.ToString());
    //            MessageBox.Show("Đã cập nhật.");
    //        }
    //        catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi"); }
    //    }

    //    private void btnDelete_Click(object sender, EventArgs e)
    //    {
    //        try
    //        {
    //            if (string.IsNullOrEmpty(txtUsageID.Text)) return;
    //            _bus.Delete(txtUsageID.Text);
    //            txtUsageID.Clear();
    //            LoadGrid(cboBooking.SelectedValue?.ToString());
    //            MessageBox.Show("Đã xóa.");
    //        }
    //        catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi"); }
    //    }

    //    private void btnRefresh_Click(object sender, EventArgs e)
    //    {
    //        txtUsageID.Clear();
    //        nudQty.Value = 1;
    //        dtpUsageDate.Value = DateTime.Now;
    //        LoadGrid(cboBooking.SelectedValue?.ToString());
    //    }

    //    private void dgvUsage_CellClick(object sender, DataGridViewCellEventArgs e)
    //    {
    //        if (e.RowIndex < 0) return;
    //        var row = (UseServiceET)_bs[e.RowIndex];

    //        txtUsageID.Text = row.UsageID;
    //        cboBooking.SelectedValue = row.BookingID;
    //        cboService.SelectedValue = row.ServiceID;
    //        nudQty.Value = row.Quantity;
    //        dtpUsageDate.Value = row.UsageDate;
    //        txtServicePrice.Text = row.ServicePrice.ToString("0.##");
    //        RecalcLine();
    //    }

    //    private class ComboItem
    //    {
    //        public string Id { get; set; }
    //        public string Text { get; set; }
    //        public decimal Price { get; set; } // chỉ dùng cho Service
    //        public override string ToString() => Text;
    //    }
    //    private void btnClose_Click(object sender, EventArgs e)
    //    {
    //        this.Close();
    //    }

    //    private void btnSearch_Click(object sender, EventArgs e)
    //    {
    //        // TODO: Implement search functionality
    //    }

    //    private void btnRefresh_Click(object sender, EventArgs e)
    //    {
    //        // TODO: Implement refresh functionality
    //    }

    //    private void dgvServiceUsage_SelectionChanged(object sender, EventArgs e)
    //    {
    //        // TODO: Implement service usage selection functionality
    //    }
    private readonly UseServiceBUS useServiceBUS = new UseServiceBUS();
    private List<UseServiceET> serviceUsages = new List<UseServiceET>();

    private void frmServiceManagement_Load(object sender, EventArgs e)
    {
        LoadFilters();
        LoadServiceUsageGrid();
    }

    private void LoadFilters()
    {
        // Load các filter (khách hàng, phòng, dịch vụ) - chỉ dùng cho phần lọc
        var data = useServiceBUS.getAllServiceUsages().ToList();
        
        // Filter khách hàng
        cboFilterKhachHang.Items.Clear();
        cboFilterKhachHang.Items.Add("Tất cả");
        cboFilterKhachHang.Items.AddRange(data.Select(x => x.CustomerName).Distinct().Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());
        cboFilterKhachHang.SelectedIndex = 0;
        
        // Filter phòng
        cboFilterRoom.Items.Clear();
        cboFilterRoom.Items.Add("Tất cả");
        cboFilterRoom.Items.AddRange(data.Select(x => x.RoomName).Distinct().Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());
        cboFilterRoom.SelectedIndex = 0;
        
        // Filter dịch vụ
        cboFilterService.Items.Clear();
        cboFilterService.Items.Add("Tất cả");
        cboFilterService.Items.AddRange(data.Select(x => x.ServiceName).Distinct().Where(x => !string.IsNullOrWhiteSpace(x)).ToArray());
        cboFilterService.SelectedIndex = 0;
    }

    private void LoadServiceUsageGrid()
    {
        serviceUsages = useServiceBUS.getAllServiceUsages().ToList();
        ApplyFilters();
    }

    private void ApplyFilters()
    {
        string customer = cboFilterKhachHang.SelectedIndex > 0 ? cboFilterKhachHang.SelectedItem.ToString() : null;
        string room = cboFilterRoom.SelectedIndex > 0 ? cboFilterRoom.SelectedItem.ToString() : null;
        string service = cboFilterService.SelectedIndex > 0 ? cboFilterService.SelectedItem.ToString() : null;
        string searchText = txtSearch.Text.Trim().ToLower();

        var filtered = serviceUsages.Where(x =>
            (string.IsNullOrEmpty(customer) || x.CustomerName == customer)
            && (string.IsNullOrEmpty(room) || x.RoomName == room)
            && (string.IsNullOrEmpty(service) || x.ServiceName == service)
            && (string.IsNullOrEmpty(searchText) ||
                (x.CustomerName?.ToLower().Contains(searchText) ?? false) ||
                (x.RoomName?.ToLower().Contains(searchText) ?? false) ||
                (x.ServiceName?.ToLower().Contains(searchText) ?? false)
            )
        ).ToList();
        // Đổ vào grid
        dgvServiceUsage.Rows.Clear();
        foreach (var su in filtered)
        {
            dgvServiceUsage.Rows.Add(
                su.UsageID,
                su.CustomerName,
                su.RoomName,
                su.ServiceName,
                su.Quantity,
                su.TotalAmount.ToString("N0") + " VNĐ",
                "Đang dùng",
                su.UsageDate.ToString("dd/MM/yyyy HH:mm")
            );
        }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
        LoadServiceUsageGrid();
        ClearDetailFields();
    }

    private void ClearDetailFields()
    {
        txtUsageID.Text = "";
        txtCustomerName.Text = "";
        txtRoomName.Text = "";
        txtServiceName.Text = "";
        txtQuantity.Text = "";
        txtTotalPrice.Text = "";
        txtStatus.Text = "";
        txtDateTime.Text = "";
    }

    private void dgvServiceUsage_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        
        try
        {
            // Lấy UsageID từ cột đầu tiên
            string usageID = dgvServiceUsage.Rows[e.RowIndex].Cells[0].Value?.ToString();
            if (string.IsNullOrEmpty(usageID)) return;

            // Tìm thông tin từ danh sách serviceUsages
            var serviceUsage = serviceUsages.FirstOrDefault(x => x.UsageID == usageID);
            if (serviceUsage == null) return;

            // Hiển thị thông tin vào các TextBox
            txtUsageID.Text = serviceUsage.UsageID ?? "";
            txtCustomerName.Text = serviceUsage.CustomerName ?? "";
            txtRoomName.Text = serviceUsage.RoomName ?? "";
            txtServiceName.Text = serviceUsage.ServiceName ?? "";
            txtQuantity.Text = serviceUsage.Quantity.ToString();
            txtTotalPrice.Text = serviceUsage.TotalAmount.ToString("N0") + " VNĐ";
            txtStatus.Text = "Đang dùng";
            txtDateTime.Text = serviceUsage.UsageDate.ToString("dd/MM/yyyy HH:mm");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi hiển thị thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cboFilterKhachHang_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
    private void cboFilterRoom_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
    private void cboFilterService_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
    private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilters();

    // Hàm xuất PDF
    private void btnExportPDF_Click(object sender, EventArgs e)
    {
        var dialog = new SaveFileDialog
        {
            Filter = "PDF files (*.pdf)|*.pdf",
            Title = "Xuất danh sách khách sử dụng dịch vụ"
        };
        if (dialog.ShowDialog() != DialogResult.OK) return;
        string path = dialog.FileName;
            //// sử dụng iTextSharp
            ExportUsageListToPDF(path);
            MessageBox.Show($"Xuất PDF thành công: {path}");
    }

        private void ExportUsageListToPDF(string path)
        {
            var filtered = serviceUsages;
            try
            {

                var doc = new iTextSharp.text.Document();
                iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new System.IO.FileStream(path, System.IO.FileMode.Create));
                doc.Open();


                string fontPath = System.IO.Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Fonts),
                    "arial.ttf"
                );


                var bf = iTextSharp.text.pdf.BaseFont.CreateFont(
                    fontPath,
                    iTextSharp.text.pdf.BaseFont.IDENTITY_H,
                    iTextSharp.text.pdf.BaseFont.EMBEDDED
                );

   
                var fontTitle = new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD);
                var fontHeader = new iTextSharp.text.Font(bf, 11, iTextSharp.text.Font.BOLD);
                var fontRow = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

                doc.Add(new iTextSharp.text.Paragraph("DANH SÁCH KHÁCH SỬ DỤNG DỊCH VỤ", fontTitle));
                doc.Add(new iTextSharp.text.Paragraph("Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontRow));
                doc.Add(new iTextSharp.text.Paragraph(" ", fontRow));


                var table = new iTextSharp.text.pdf.PdfPTable(new float[] { 1.2f, 1.8f, 1.2f, 1.8f, 0.8f, 1.1f, 1.2f, 1.5f });
                table.WidthPercentage = 100;

                string[] headers = { "Mã sử dụng", "Khách hàng", "Phòng", "Dịch vụ", "SL", "Tổng tiền", "Trạng thái", "Thời gian" };
                foreach (string header in headers)
                {
                    var cell = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(header, fontHeader))
                    {
                        BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY,
                        HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER,
                        Padding = 5
                    };
                    table.AddCell(cell);
                }

                foreach (var su in filtered)
                {
                    table.AddCell(new iTextSharp.text.Phrase(su.UsageID, fontRow));
                    table.AddCell(new iTextSharp.text.Phrase(su.CustomerName, fontRow));
                    table.AddCell(new iTextSharp.text.Phrase(su.RoomName, fontRow));
                    table.AddCell(new iTextSharp.text.Phrase(su.ServiceName, fontRow));
                    table.AddCell(new iTextSharp.text.Phrase(su.Quantity.ToString(), fontRow));
                    table.AddCell(new iTextSharp.text.Phrase(su.TotalAmount.ToString("N0") + " VNĐ", fontRow));
                    table.AddCell(new iTextSharp.text.Phrase("Đang dùng", fontRow));
                    table.AddCell(new iTextSharp.text.Phrase(su.UsageDate.ToString("dd/MM/yyyy HH:mm"), fontRow));
                }

                doc.Add(table);
                doc.Close();

                MessageBox.Show("Xuất file PDF thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất PDF: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}