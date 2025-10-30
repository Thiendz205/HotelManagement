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
//using System.Globalization;

namespace HotelManagement
{
    public partial class frmLoaiPhong : Form
    {
        Room_Type_BUS roomType_BUS = new Room_Type_BUS();
        Room_Type_ET roomType_ET = new Room_Type_ET();
        //CultureInfo viVN = new CultureInfo("vi-VN");


        public frmLoaiPhong()
        {
            InitializeComponent();
        }


        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            dtGV_RoomType.DataSource = roomType_BUS.getAllRoomTypes();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(string.IsNullOrWhiteSpace(txtPricePerDay.Text))
            {
                MessageBox.Show("Vui lòng nhập giá theo ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPricePerHour.Text))
            {
                MessageBox.Show("Vui lòng nhập giá theo giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //if(txtCategory.Text != "Standard")
            //{
            //    MessageBox.Show("Thêm mới loại phòng chỉ được nhập 'Standard'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtCategory.Text = "Standard";
            //    return;
            //}

            decimal priceDay = decimal.Parse(txtPricePerDay.Text.Replace(",", "").Replace(".", ""));
            decimal priceHour = decimal.Parse(txtPricePerHour.Text.Replace(",", "").Replace(".", ""));

            if (priceDay < priceHour)
            {
                MessageBox.Show("Giá ngày không được nhỏ hơn giá giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPricePerDay.Clear();
                isHandlingTextChanged = false;
                return;
            }


            try
            {
                if(roomType_BUS.checkExistenceNameRoom(txtTypeName.Text, cbCategory.Text) == false)
                {
                    MessageBox.Show("Loại phòng này đã có, vui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                roomType_ET.TypeName = txtTypeName.Text;
                roomType_ET.PricePerDay = decimal.Parse(txtPricePerDay.Text.Replace(".", "").Replace(",", ""));
                roomType_ET.PricePerHour = decimal.Parse(txtPricePerHour.Text.Replace(".", "").Replace(",", ""));
                roomType_ET.Category = cbCategory.Text;
                roomType_ET.Description = txtMoTa.Text;
                bool success = roomType_BUS.addRoomType(roomType_ET);
                if (success)
                {
                    MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_RoomType.DataSource = roomType_BUS.getAllRoomTypes();
                }
                else
                {
                    MessageBox.Show("Thêm loại phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtRoomTypeID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập ID loại phòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            try
            {
                int roomTypeID = int.Parse(txtRoomTypeID.Text);
                bool success = roomType_BUS.removeRoomType(roomTypeID);
                if (success)
                {
                    MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_RoomType.DataSource = roomType_BUS.getAllRoomTypes();
                }
                else
                {
                    MessageBox.Show("Xóa loại phòng thất bại! Loại phòng có thể đang được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTypeName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPricePerDay.Text))
            {
                txtPricePerDay.Clear();
                MessageBox.Show("Vui lòng nhập giá theo ngày!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPricePerHour.Text))
            {
                txtPricePerHour.Clear();
                MessageBox.Show("Vui lòng nhập giá theo giờ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (roomType_BUS.checkExistenceNameRoomType_UPDate(txtTypeName.Text, int.Parse(txtRoomTypeID.Text)))
                {
                    MessageBox.Show("Tên loại phòng đã tồn tại, vui lòng nhập tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTypeName.Clear();
                    txtRoomTypeID.Focus();
                    return;
                }
                roomType_ET.RoomTypeID = int.Parse(txtRoomTypeID.Text);
                roomType_ET.TypeName = txtTypeName.Text;
                roomType_ET.PricePerDay = decimal.Parse(txtPricePerDay.Text.Replace(".", "").Replace(",", ""));
                roomType_ET.PricePerHour = decimal.Parse(txtPricePerHour.Text.Replace(".", "").Replace(",", ""));
                roomType_ET.Category = cbCategory.Text;
                roomType_ET.Description = txtMoTa.Text;
                bool success = roomType_BUS.updateRoomType(roomType_ET);
                if (success)
                {
                    MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGV_RoomType.DataSource = roomType_BUS.getAllRoomTypes();
                }
                else
                {
                    MessageBox.Show("Cập nhật loại phòng thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGV_RoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (dong >= 0)
            {
                txtRoomTypeID.Text = dtGV_RoomType.Rows[dong].Cells[0].Value.ToString();
                txtTypeName.Text = dtGV_RoomType.Rows[dong].Cells[1].Value.ToString();
                txtPricePerDay.Text = dtGV_RoomType.Rows[dong].Cells[2].Value.ToString();
                txtPricePerHour.Text = dtGV_RoomType.Rows[dong].Cells[3].Value.ToString();
                cbCategory.Text = dtGV_RoomType.Rows[dong].Cells[4].Value.ToString();
                txtMoTa.Text = dtGV_RoomType.Rows[dong].Cells[5].Value.ToString();
                cbCategory.Enabled = false;
            }
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
      
            txtMoTa.Text = "";
            txtPricePerDay.Text = "";
            txtPricePerHour.Text = "";
            txtRoomTypeID.Text = "";
            txtTypeName.Text = "";
            dtGV_RoomType.DataSource = roomType_BUS.getAllRoomTypes();
            cbCategory.Enabled = true;

        }

        private void txtTypeName_TextChanged(object sender, EventArgs e)
        {
            if (txtTypeName.Text.Length > 50)
            {
                MessageBox.Show("Tên loại phòng không được vượt quá 50 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeName.Text = txtTypeName.Text.Substring(0, 50);
                txtTypeName.SelectionStart = txtTypeName.Text.Length;
                txtTypeName.SelectionLength = 0;
            }
            if (txtTypeName.Text.StartsWith(" "))
            {
                MessageBox.Show("Tên loại phòng không được bắt đầu bằng khoảng trắng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTypeName.Text = txtTypeName.Text.TrimStart();
                txtTypeName.SelectionStart = txtTypeName.Text.Length;
                txtTypeName.SelectionLength = 0;
            }
            //if (Regex.IsMatch(txtTypeName.Text, @"[^a-zA-Z0-9\s\u00C0-\u1EF9]"))
            //{
            //    MessageBox.Show("Tên loại phòng không được chứa ký tự đặc biệt!",
            //                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //    txtTypeName.Clear();
            //    txtTypeName.Focus();
            //}
        }


        bool isHandlingTextChanged = false;
        private void txtPricePerDay_TextChanged(object sender, EventArgs e)
        {

            if (isHandlingTextChanged)
                return;

            isHandlingTextChanged = true;

            string input = txtPricePerDay.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                isHandlingTextChanged = false;
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^[0-9]*[.,]?[0-9]*$"))
            {
                MessageBox.Show("Chỉ được nhập số và dấu thập phân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPricePerDay.Clear();
                isHandlingTextChanged = false;
                return;
            }
           


            if (decimal.TryParse(input, out decimal value))
            {
                string[] parts = input.Split('.');

                if (parts[0].Length > 16)
                {
                    MessageBox.Show("Phần nguyên không được vượt quá 16 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPricePerDay.Clear();
                    isHandlingTextChanged = false;
                    return;
                }

                if (parts.Length > 1 && parts[1].Length > 2)
                {
                    MessageBox.Show("Chỉ được nhập tối đa 2 chữ số sau dấu thập phân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPricePerDay.Text = value.ToString("F2"); 
                    txtPricePerDay.SelectionStart = txtPricePerDay.Text.Length;
                }
            }
            else
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPricePerDay.Clear();
            }

            isHandlingTextChanged = false;
        }

        private void txtPricePerHour_TextChanged(object sender, EventArgs e)
        {
            if (isHandlingTextChanged)
                return;

            isHandlingTextChanged = true;

            string input = txtPricePerHour.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                isHandlingTextChanged = false;
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(input, @"^[0-9]*[.,]?[0-9]*$"))
            {
                MessageBox.Show("Chỉ được nhập số và dấu thập phân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPricePerHour.Clear();
                txtPricePerHour.Focus();
                isHandlingTextChanged = false;
                return;
            }

            if (decimal.TryParse(input, out decimal value))
            {
                string[] parts = input.Split('.');

                if (parts[0].Length > 16)
                {
                    MessageBox.Show("Phần nguyên không được vượt quá 16 chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPricePerHour.Clear();
                    txtPricePerHour.Focus();
                    isHandlingTextChanged = false;
                    return;
                }

                if (parts.Length > 1 && parts[1].Length > 2)
                {
                    MessageBox.Show("Chỉ được nhập tối đa 2 chữ số sau dấu thập phân!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPricePerHour.Text = value.ToString("F2");
                    txtPricePerHour.SelectionStart = txtPricePerHour.Text.Length;
                }
            }
            else
            {
                MessageBox.Show("Giá trị không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPricePerHour.Clear();
                txtPricePerHour.Focus();
            }

            isHandlingTextChanged = false;
        }

       
    }
}
