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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace HotelManagement
{
    public partial class frmBookingGUI : Form
    {
        public frmBookingGUI(string staffId,string roomId, string roomName, string roomStatus)
        {
            InitializeComponent();
            this.roomId = roomId;
            this.roomName = roomName;
            this.roomStatus = roomStatus;
            this.staffId = staffId;
        }
        private readonly BookingBUS bookingBUS = new BookingBUS();
        private readonly CustomerBUS customerBUS = new CustomerBUS();
        private int currentCustomerRankId = 0; // Lưu RankID hiện tại (nếu có)
        private readonly string roomId;
        private readonly string roomName;
        private readonly string roomStatus;
        private readonly string staffId;
        private bool isUpdatingPrice = false; // tránh vòng lặp khi đổi giá tự động
        private void frmBookingGUI_Load(object sender, EventArgs e)
        {
            lblRoomInfo.Text = $"{roomName} ({roomStatus})";
            dtpCheckIn.Value = DateTime.Now;
            dtpCheckOut.Value = DateTime.Now.AddDays(1);
            var roomInfo = bookingBUS.GetRoomInfo(roomId);
            if (roomInfo != null)
            {
                lblRoomType.Text = roomInfo.RoomTypeName;
                lblCategory.Text = roomInfo.Category;
                lblCapacity.Text = roomInfo.Capacity.ToString();
                lblPricePerDay.Text = roomInfo.PricePerDay.ToString("N0") + " VND";
                lblPricePerHour.Text = roomInfo.PricePerHour.ToString("N0") + " VND";
            }
            txtPhoneNumber.Leave += txtPhoneNumber_Leave;
            txtNationalID.Leave += txtNationalID_Leave;
            UpdateRoomPrice();
            cboCountry.DropDownStyle = ComboBoxStyle.DropDown;
            cboCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void UpdateRoomPrice()
        {
            try
            {
                // ✅ Không có loại thuê nào được chọn
                if (!chkDay.Checked && !chkHour.Checked)
                {
                    lblPrice.Text = "0 VNĐ";
                    lblPrice.Tag = 0m;
                    return;
                }

                // ✅ Lấy loại thuê
                string rentalType = chkDay.Checked ? "Day" : "Hour";

                // ✅ Lấy thời gian
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;

                // ✅ Tính giá
                decimal price = bookingBUS.CalculateTotalPrice(roomId, rentalType, checkIn, checkOut);

                // ✅ Hiển thị kết quả
                if (price > 0)
                {
                    lblPrice.Text = price.ToString("N0") + " VNĐ";
                    lblPrice.Tag = price;
                }
                else
                {
                    lblPrice.Text = "Chưa có giá áp dụng";
                    lblPrice.Tag = 0m;
                }
            }
            catch (Exception ex)
            {
                lblPrice.Text = "Lỗi tính giá";
                lblPrice.Tag = 0m;
                Console.WriteLine("Lỗi tính giá: " + ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDay.Checked)
                chkHour.Enabled = false;
            else
                chkHour.Enabled = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHour.Checked)
                chkDay.Enabled = false;
            else
                chkDay.Enabled = true;
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ 1. Kiểm tra đầu vào cơ bản
                if (string.IsNullOrWhiteSpace(txtFullName.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên khách hàng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ❌ Không cho phép ký tự đặc biệt trong Họ tên
                if (!Regex.IsMatch(txtFullName.Text, @"^[\p{L}\s]+$"))
                {
                    MessageBox.Show("Họ tên chỉ được chứa chữ cái và khoảng trắng, không có ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text) && string.IsNullOrWhiteSpace(txtNationalID.Text))
                {
                    MessageBox.Show("Vui lòng nhập SĐT hoặc CMND/CCCD!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(txtPhoneNumber.Text.Trim(), @"^\d{9,15}$"))
                {
                    MessageBox.Show("Số điện thoại phải là số và từ 9–15 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtNationalID.Text) && !Regex.IsMatch(txtNationalID.Text.Trim(), @"^\d{9,20}$"))
                {
                    MessageBox.Show("CMND/CCCD phải là số và từ 9–20 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtAddress.Text.Length > 200)
                {
                    MessageBox.Show("Địa chỉ không được vượt quá 200 ký tự!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ❌ Không cho ký tự đặc biệt trong địa chỉ (cho phép số, chữ, khoảng trắng, dấu phẩy, chấm, /)
                if (!Regex.IsMatch(txtAddress.Text, @"^[\p{L}\p{N}\s,./-]+$"))
                {
                    MessageBox.Show("Địa chỉ không được chứa ký tự đặc biệt!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cboCountry.SelectedIndex < 0 || string.IsNullOrWhiteSpace(cboCountry.Text))
                {
                    MessageBox.Show("Vui lòng chọn quốc gia hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!rdoNam.Checked && !rdoNu.Checked)
                {
                    MessageBox.Show("Vui lòng chọn giới tính (Nam hoặc Nữ)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ 2. Kiểm tra tuổi >= 18
                DateTime dob = dtpDateOfBirth.Value.Date;
                int age = DateTime.Today.Year - dob.Year;
                if (dob > DateTime.Today.AddYears(-age)) age--;
                if (age < 18)
                {
                    MessageBox.Show("Khách hàng phải từ 18 tuổi trở lên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ 3. Kiểm tra kiểu thuê, ngày giờ
                if (!chkDay.Checked && !chkHour.Checked)
                {
                    MessageBox.Show("Vui lòng chọn kiểu đặt phòng (Theo ngày / Theo giờ)!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpCheckIn.Value < DateTime.Now)
                {
                    MessageBox.Show("Giờ Check-in phải lớn hơn giờ hiện tại!", "Lỗi ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dtpCheckOut.Value <= dtpCheckIn.Value)
                {
                    MessageBox.Show("Thời gian Check-out phải sau Check-in!", "Lỗi ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ 4. Tạo dữ liệu khách hàng
                string gender = rdoNam.Checked ? "Nam" : "Nữ";
                string rentalType = chkDay.Checked ? "Day" : "Hour";

                var customer = new CustomerET
                {
                    FullName = txtFullName.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    NationalID = txtNationalID.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Gender = gender,
                    Country = cboCountry.SelectedItem?.ToString() ?? "Việt Nam",
                    DateOfBirth = dob
                };

                // ✅ 5. Tạo dữ liệu booking
                var booking = new BookingET
                {
                    RoomID = roomId,
                    StaffID = staffId,
                    RentalType = rentalType,
                    CheckIn = dtpCheckIn.Value,
                    CheckOut = dtpCheckOut.Value,
                    Price = decimal.TryParse(lblPrice.Text.Replace(",", "").Replace("VNĐ", "").Trim(), out decimal price) ? price : 0
                };

                // ✅ 6. Gửi BUS xử lý
                var result = bookingBUS.AddBookingWithCustomer(booking, customer);

                // ✅ 7. Phản hồi kết quả
                switch (result)
                {
                    case AddBookingResult.Success:
                    case AddBookingResult.CustomerAddedBookingAdded:
                        MessageBox.Show("Đặt phòng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
                        if (parent != null)
                        {
                            var roomListForm = new frmReceptionistsRoomList(staffId);
                            parent.OpenChildForm(roomListForm);
                        }
                        this.Close();
                        break;

                    case AddBookingResult.DuplicateCustomerConflict:
                        MessageBox.Show("Thông tin khách trùng SĐT/CMND nhưng khác dữ liệu. Vui lòng kiểm tra lại!",
                                        "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case AddBookingResult.RoomConflict:
                        MessageBox.Show("Phòng đã được đặt trong khoảng thời gian này. Vui lòng chọn giờ khác!",
                                        "Lỗi trùng giờ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    default:
                        MessageBox.Show("Đã xảy ra lỗi khi đặt phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkDay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDay.Checked)
            {
                chkHour.Checked = false;
                if (!isUpdatingPrice)
                    UpdateRoomPrice();
            }
        }

        private void chkHour_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHour.Checked)
            {
                chkDay.Checked = false;
                if (!isUpdatingPrice)
                    UpdateRoomPrice();
            }
        }

        private void dtpCheckIn_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoomPrice();
        }

        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            UpdateRoomPrice();
        }
        private void AutoFillCustomerInfo()
        {
            string phone = txtPhoneNumber.Text.Trim();
            string nationalId = txtNationalID.Text.Trim();

            if (string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(nationalId))
                return;

            var existingCustomer = customerBUS.GetCustomerByPhoneOrId(phone, nationalId);

            if (existingCustomer != null)
            {
                // ✅ Gán thông tin khách hàng
                txtFullName.Text = existingCustomer.FullName;
                txtPhoneNumber.Text = existingCustomer.PhoneNumber;
                txtNationalID.Text = existingCustomer.NationalID;
                txtAddress.Text = existingCustomer.Address;

                // ✅ Giới tính (Nam/Nữ hoặc Male/Female)
                string gender = (existingCustomer.Gender ?? "").Trim().ToLower();
                if (gender == "nam" || gender == "male") rdoNam.Checked = true;
                else if (gender == "nữ" || gender == "nu" || gender == "female") rdoNu.Checked = true;

                // ✅ Quốc gia
                string country = existingCustomer.Country?.Trim();
                if (!string.IsNullOrEmpty(country))
                {
                    if (!cboCountry.Items.Contains(country))
                        cboCountry.Items.Add(country);
                    cboCountry.SelectedItem = country;
                }
                else cboCountry.SelectedItem = "Việt Nam";

                // ✅ Ngày sinh
                if (existingCustomer.DateOfBirth.HasValue)
                    dtpDateOfBirth.Value = existingCustomer.DateOfBirth.Value;

                // ✅ Rank khách hàng
                currentCustomerRankId = existingCustomer.RankID;
                lblRank.Text = "Hạng: " + customerBUS.GetRankNameById(existingCustomer.RankID);

                // ✅ Khóa các ô nhập
                txtFullName.Enabled = false;
                txtAddress.Enabled = false;
                rdoNam.Enabled = false;
                rdoNu.Enabled = false;
            }
            else
            {
                // ✅ Mở lại nếu không tìm thấy khách
                txtFullName.Enabled = true;
                txtAddress.Enabled = true;
                rdoNam.Enabled = true;
                rdoNu.Enabled = true;
                lblRank.Text = "Hạng: Mặc định";
                currentCustomerRankId = customerBUS.GetDefaultRankId();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                var parent = Application.OpenForms["frmBookingStaffHomeGUI"] as frmBookingStaffHomeGUI;
                if (parent != null)
                {
                    // ✅ Truyền lại staffId khi quay về danh sách phòng
                    var bookingListForm = new frmReceptionistsRoomList(staffId);
                    parent.OpenChildForm(bookingListForm);
                }
                else
                {
                    // Nếu không tìm thấy form cha (rất hiếm), thì chỉ đóng lại form hiện tại
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi quay lại danh sách phòng: " + ex.Message,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            AutoFillCustomerInfo();
        }

        private void txtNationalID_Leave(object sender, EventArgs e)
        {
            AutoFillCustomerInfo();
        }
    }
}
