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

namespace HotelManagement
{
    public partial class frmPaymentManagementREPCGUI : Form
    {

        public frmPaymentManagementREPCGUI(string staffId, string roomId, string roomName, string roomStatus)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.roomName = roomName;
            this.roomStatus = roomStatus;
            this.staffId = staffId;
        }
        private readonly string roomId;
        private readonly string roomName;
        private readonly string roomStatus;
        private readonly string staffId;
        private readonly InvoiceBUS invoiceBUS = new InvoiceBUS();
        private readonly FeeTypeBUS feeTypeBUS = new FeeTypeBUS();
        private string currentBookingId = "";
        private void frmPaymentManagementREPCGUI_Load(object sender, EventArgs e)
        {
            LoadCustomerInfo();
            LoadInvoiceDetails();
            LoadExtraFees();
            LoadPaymentMethods();
            picQRCode.Visible = false;
        }
        private void LoadExtraFees()
        {
            var list = feeTypeBUS.GetAllFeeTypes();
            cboExtraFee.DataSource = list;
            cboExtraFee.DisplayMember = "FeeTypeName";
            cboExtraFee.ValueMember = "FeeTypeID";
            if (list.Count > 0) cboExtraFee.SelectedIndex = 0;
        }

        private void LoadInvoiceDetails()
        {
            var list = invoiceBUS.GetUsageDetailsByRoom(roomId);
            if (list == null || list.Count == 0)
            {
                dgvInvoiceDetail.DataSource = null;
                lblTotalAmount.Text = "0 VND";
                return;
            }

            dgvInvoiceDetail.DataSource = list.Select(x => new
            {
                Loại = x.Type,
                Mục = x.ItemName,
                Giá = x.Price.ToString("N0"),
                Số_lượng = x.Quantity,
                Thành_tiền = (x.Price * x.Quantity).ToString("N0"),
                Ngày_dùng = x.UsedAt.ToString("dd/MM/yyyy HH:mm")
            }).ToList();

            lblTotalAmount.Text = invoiceBUS.GetTotalAmount(roomId).ToString("N0") + " VND";
        }

        private void LoadCustomerInfo()
        {
            var info = invoiceBUS.GetCustomerInfoByRoom(roomId);
            if (info == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng đang CheckIn ở phòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            currentBookingId = info.BookingID;
            lblCustomerName.Text = info.CustomerName;
            lblPhone.Text = info.Phone;
            lblRentalType.Text = info.RentalType;
            lblCheckIn.Text = info.CheckIn.ToString("dd/MM/yyyy HH:mm");
            lblCheckOut.Text = info.CheckOut?.ToString("dd/MM/yyyy HH:mm") ?? "Chưa CheckOut";
            lblRoomName.Text = info.RoomName;
        }

        private void LoadPaymentMethods()
        {
            cboPaymentMethod.Items.Clear();
            cboPaymentMethod.Items.AddRange(new string[] { "Tiền mặt", "Quét mã QR" });
            cboPaymentMethod.SelectedIndex = 0;
        }
        private void cboPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPaymentMethod.SelectedItem.ToString() == "Quét mã QR")
            {
                picQRCode.Visible = true;  // Hiện hình QR
            }
            else
            {
                picQRCode.Visible = false; // Ẩn hình QR
            }
        }


        private void cboExtraFee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboExtraFee.SelectedItem is FeeTypeET fee)
                lblExtraFeePrice.Text = $"{fee.DefaultPrice:N0} VND";
        }

        private void btnAddExtraFee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentBookingId))
            {
                MessageBox.Show("Không có Booking đang hoạt động để thêm phí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedFee = cboExtraFee.SelectedItem as FeeTypeET;
            if (selectedFee == null)
                return;

            DialogResult confirm = MessageBox.Show(
                $"Xác nhận thêm phí '{selectedFee.FeeTypeName}' ({selectedFee.DefaultPrice:N0} VND)?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool success = invoiceBUS.AddExtraFeeToBooking(currentBookingId, selectedFee.FeeTypeID);
                if (success)
                {
                    MessageBox.Show("Đã thêm phụ phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInvoiceDetails();
                }
                else
                    MessageBox.Show("Không thể thêm phụ phí!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentBookingId))
            {
                MessageBox.Show("Không có Booking đang hoạt động để thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string method = cboPaymentMethod.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(method))
            {
                MessageBox.Show("Vui lòng chọn hình thức thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Xác nhận thanh toán cho khách hàng '{lblCustomerName.Text}' bằng phương thức '{method}'?",
                "Xác nhận thanh toán",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                bool success = invoiceBUS.PayInvoiceByBooking(currentBookingId, staffId, method, txtNote.Text);
                if (success)
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmReportInvoiceDetailByBooking reportForm = new frmReportInvoiceDetailByBooking(currentBookingId);
                    reportForm.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
            if (parent != null)
            {
                var bookingDetailForm = new frmListRoomPaymentManagementREPCGUI(staffId);
                parent.OpenChildForm(bookingDetailForm);
            }
        }
    }
}
