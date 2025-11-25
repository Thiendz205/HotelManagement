using BUS;
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
    public partial class frmChooseStaffTech : Form
    {
        public frmChooseStaffTech()
        {
            InitializeComponent();
        }
        Staff_BUS staff_BUS = new Staff_BUS();
        private void frmChooseStaffTech_Load(object sender, EventArgs e)
        {
            dtgvStaff.DataSource = staff_BUS.GetStaffByRole("Kỹ thuật");

        }
        public string SelectedStaffID { get; private set; }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (dtgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên!", "Cảnh báo");
                return;
            }

            SelectedStaffID = dtgvStaff.SelectedRows[0].Cells["StaffID"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
