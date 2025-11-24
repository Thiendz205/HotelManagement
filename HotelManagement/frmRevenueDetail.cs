using ET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace HotelManagement
{
    public partial class frmRevenueDetail : Form
    {
        private readonly List<InvoiceET> _data;
        private List<InvoiceET> _filtered;

        private Guna2DataGridView dgv;
        private Label lblTitle, lblTotal;
        private Guna2TextBox txtSearch;
        private Panel topPanel;

        public frmRevenueDetail(List<InvoiceET> data)
        {
            InitializeComponent();
            _data = data;
            _filtered = new List<InvoiceET>(_data);
        }

        private void frmRevenueDetail_Load(object sender, EventArgs e)
        {
            SetupUI();
            LoadGrid();
        }

        private void SetupUI()
        {
            this.Text = "Chi tiết doanh thu phòng";
            this.Size = new Size(950, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // ============================
            // TITLE
            // ============================
            lblTitle = new Label
            {
                Text = "CHI TIẾT DOANH THU",
                Dock = DockStyle.Top,
                Height = 60,
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(0, 90, 200)
            };
            this.Controls.Add(lblTitle);

            // ============================
            // TOP PANEL (SEARCH)
            // ============================
            topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                Padding = new Padding(20, 10, 20, 10)
            };
            this.Controls.Add(topPanel);

            txtSearch = new Guna2TextBox
            {
                PlaceholderText = "Tìm tên phòng...",
                Width = 250,
                Height = 40,
                BorderRadius = 8,
                Font = new Font("Segoe UI", 11),
                IconLeft = Properties.Resources.magnifier, // nếu có icon
                IconLeftSize = new Size(18, 18)
            };
            txtSearch.TextChanged += TxtSearch_TextChanged;

            topPanel.Controls.Add(txtSearch);

            // ============================
            // DATAGRIDVIEW
            // ============================

            dgv = new Guna2DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(245, 245, 245),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                ColumnHeadersHeight = 40,
                ColumnHeadersVisible = true,  // ⭐ FIX QUAN TRỌNG
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = Color.FromArgb(0, 120, 215),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font("Segoe UI", 11),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Padding = new Padding(4)
                },
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                GridColor = Color.FromArgb(230, 230, 230),
                RowTemplate = { Height = 38 },
                AllowUserToAddRows = false
            };

            // ThemeStyle (Guna đè style lên header)
            dgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(0, 120, 215);
            dgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            dgv.ThemeStyle.HeaderStyle.Height = 40;

            dgv.ThemeStyle.RowsStyle.Height = 38;
            dgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 11);

            dgv.AutoGenerateColumns = false;

            // ⭐ Add cột tiếng Việt
            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Phòng",
                DataPropertyName = "RoomName",
                FillWeight = 25
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Loại phòng",
                DataPropertyName = "RoomType",
                FillWeight = 25
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Giá (đ)",
                DataPropertyName = "Price",
                FillWeight = 25
            });

            dgv.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Doanh thu (đ)",
                DataPropertyName = "Revenue",
                FillWeight = 25
            });

            this.Controls.Add(dgv);

            // ============================
            // TOTAL LABEL
            // ============================
            lblTotal = new Label
            {
                Dock = DockStyle.Bottom,
                Height = 50,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight,
                ForeColor = Color.DarkRed,
                Padding = new Padding(0, 0, 25, 0)
            };
            this.Controls.Add(lblTotal);
        }
        private void LoadGrid()
        {
            dgv.DataSource = null;
            dgv.DataSource = _filtered;

            decimal total = _filtered.Sum(x => x.Revenue);
            lblTotal.Text = $"Tổng doanh thu: {total:N0} đ";
        }



        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            _filtered = _data
                .Where(x => x.RoomName.ToLower().Contains(keyword))
                .ToList();

            LoadGrid();
        }
    }
}
