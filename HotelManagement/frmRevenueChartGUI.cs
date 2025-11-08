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
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManagement
{
    public partial class frmRevenueChartGUI : Form
    {
        public frmRevenueChartGUI()
        {
            InitializeComponent();
            SetupUI(); // Gọi UI Ở ĐÂY
            this.Load += frmRevenueChartGUI_Load;
        }
        private Panel panelTop;
        private Label lblTitle, lblMode, lblYear, lblMonth;
        private ComboBox cboMode;
        private NumericUpDown numYear, numMonth;
        private Button btnLoadChart;
        private Chart chartRevenue;

        private readonly InvoiceBUS invoiceBLL = new InvoiceBUS();
        private void SetupUI()
        {
            // Form properties
            this.Text = "Thống kê doanh thu";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(224, 224, 224);

            // ===== Panel Top =====
            panelTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 110,
                BackColor = Color.FromArgb(240, 240, 240)
            };
            this.Controls.Add(panelTop);

            lblTitle = new Label
            {
                Text = "THỐNG KÊ DOANH THU KHÁCH SẠN",
                AutoSize = false,
                Dock = DockStyle.Top,
                Height = 35,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14, FontStyle.Bold)
            };
            panelTop.Controls.Add(lblTitle);

            lblMode = new Label { Text = "Kiểu:", Location = new Point(40, 60), AutoSize = true };
            cboMode = new ComboBox { Location = new Point(90, 55), Width = 120, DropDownStyle = ComboBoxStyle.DropDownList };
            cboMode.Items.AddRange(new[] { "Ngày", "Tháng", "Năm" });
            cboMode.SelectedIndex = 0;
            cboMode.SelectedIndexChanged += (s, e) => numMonth.Enabled = cboMode.SelectedItem.ToString() == "Ngày";

            lblYear = new Label { Text = "Năm:", Location = new Point(240, 60), AutoSize = true };
            numYear = new NumericUpDown { Location = new Point(290, 55), Width = 80, Minimum = 2000, Maximum = 2100, Value = DateTime.Now.Year };

            lblMonth = new Label { Text = "Tháng:", Location = new Point(390, 60), AutoSize = true };
            numMonth = new NumericUpDown { Location = new Point(455, 55), Width = 60, Minimum = 1, Maximum = 12, Value = DateTime.Now.Month };

            btnLoadChart = new Button
            {
                Text = "Xem biểu đồ",
                Location = new Point(540, 53),
                Width = 120,
                Height = 30,
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnLoadChart.FlatAppearance.BorderSize = 1;
            btnLoadChart.Click += btnLoadChart_Click;

            panelTop.Controls.AddRange(new Control[] { lblMode, cboMode, lblYear, numYear, lblMonth, numMonth, btnLoadChart });

            // ===== Chart =====
            chartRevenue = new Chart { Dock = DockStyle.Fill };
            chartRevenue.ChartAreas.Add(new ChartArea("MainArea"));
            chartRevenue.Titles.Add("Biểu đồ doanh thu");
            this.Controls.Add(chartRevenue);
        }

        private void frmRevenueChartGUI_Load(object sender, EventArgs e)
        {
            
        }

        private void cboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            numMonth.Enabled = cboMode.SelectedItem.ToString() == "Ngày";
        }

        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            string sel = cboMode.SelectedItem.ToString();
            string mode = sel == "Ngày" ? "Day" : (sel == "Tháng" ? "Month" : "Year");

            int year = (int)numYear.Value;
            int? month = mode == "Day" ? (int?)numMonth.Value : null;

            var data = invoiceBLL.GetRevenueStatistics(mode, year, month);

            chartRevenue.Series.Clear();
            var series = new Series("Doanh thu")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                YValueType = ChartValueType.Double,
                IsValueShownAsLabel = true
            };

            foreach (var item in data)
                series.Points.AddXY(item.Period, (double)item.Revenue);

            chartRevenue.Series.Add(series);
            chartRevenue.ChartAreas[0].AxisX.Title = "Thời gian";
            chartRevenue.ChartAreas[0].AxisY.Title = "Doanh thu (VND)";
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;

            if (data.Count == 0)
                MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
