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
    public partial class frmRankCustomerAdminGUI : Form
    {
        public frmRankCustomerAdminGUI()
        {
            InitializeComponent();
        }
        RankCusstomerBUS bus = new RankCusstomerBUS();
        List<RankCustomerET> listRank;
        private void frmRankCustomerAdminGUI_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            listRank = bus.GetAll();
            dgvRankCustomer.DataSource = listRank;
            dgvRankCustomer.Columns["RankID"].HeaderText = "Mã hạng";
            dgvRankCustomer.Columns["RankName"].HeaderText = "Tên hạng";
            dgvRankCustomer.Columns["DiscountPercent"].HeaderText = "Giảm giá %";
            dgvRankCustomer.Columns["MinSpending"].HeaderText = "Chi tiêu tối thiểu";

            dgvRankCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRankCustomer.ClearSelection();
            ClearInput();
        }
        private void ClearInput()
        {
            txtRankName.Clear();
            txtDiscountPercent.Clear();
            txtMinSpending.Clear();
            txtRankName.Focus();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRankName.Text))
            {
                MessageBox.Show("Tên hạng khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDiscountPercent.Text, out decimal discount))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho phần trăm giảm giá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtMinSpending.Text, out decimal minSpending))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng số cho Chi phí tối thiểu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("Phần trăm giảm giá phải nằm trong khoảng từ 0 đến 100!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (minSpending < 0)
            {
                MessageBox.Show("Chi phí tối thiểu không được nhỏ hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!bus.CheckMinSpendingDifference(minSpending))
            {
                MessageBox.Show("Chi phí tối thiểu của hạng mới phải cách ít nhất 1.000.000₫ so với các hạng hiện có!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RankCustomerET rank = new RankCustomerET
            {
                RankName = txtRankName.Text.Trim(),
                DiscountPercent = discount,
                MinSpending = minSpending
            };

            if (bus.Insert(rank))
            {
                MessageBox.Show("Thêm hạng khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Có thể tên hạng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string oldRankName = null;

        private void dgvRankCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRankCustomer.Rows[e.RowIndex];
                selectedRankId = Convert.ToInt32(row.Cells["RankID"].Value);
                txtRankName.Text = row.Cells["RankName"].Value.ToString();
                txtDiscountPercent.Text = row.Cells["DiscountPercent"].Value.ToString();
                txtMinSpending.Text = row.Cells["MinSpending"].Value.ToString();
                oldRankName = txtRankName.Text.Trim();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedRankId == null)
            {
                MessageBox.Show("Vui lòng chọn hạng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRankName.Text))
            {
                MessageBox.Show("Tên hạng khách hàng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtDiscountPercent.Text, out decimal discount) ||
                !decimal.TryParse(txtMinSpending.Text, out decimal minSpending))
            {
                MessageBox.Show("Phần trăm giảm giá và Chi phí tối thiểu phải là số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (discount < 0 || discount > 100)
            {
                MessageBox.Show("Phần trăm giảm giá phải nằm trong khoảng 0 - 100!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (minSpending < 0)
            {
                MessageBox.Show("Chi phí tối thiểu không được âm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newRankName = txtRankName.Text.Trim();
            if (!newRankName.Equals(oldRankName, StringComparison.OrdinalIgnoreCase))
            {
                if (listRank.Any(r => r.RankName.Equals(newRankName, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Tên hạng khách hàng đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (!bus.CheckMinSpendingDifference(minSpending, selectedRankId))
            {
                MessageBox.Show("Chi phí tối thiểu sau khi chỉnh sửa phải cách ít nhất 1.000.000₫ so với các hạng khác!",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RankCustomerET rank = new RankCustomerET
            {
                RankID = selectedRankId.Value,
                RankName = txtRankName.Text.Trim(),
                DiscountPercent = discount,
                MinSpending = minSpending
            };

            if (bus.Update(rank))
            {
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int? selectedRankId = null;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRankId == null)
            {
                MessageBox.Show("Vui lòng chọn hạng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa hạng này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
                return;

            bool result = bus.Delete(selectedRankId.Value);
            if (result)
            {
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Không thể xóa! Hạng này đang được sử dụng hoặc không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
