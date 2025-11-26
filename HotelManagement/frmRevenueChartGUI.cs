using BUS;
using ET;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HotelManagement
{
    public partial class frmRevenueChartGUI : Form
    {
        private readonly InvoiceBUS invoiceBUS = new InvoiceBUS();

        private Panel panelTop;
        private Label lblTitle, lblMode, lblYear, lblMonth;
        private ComboBox cboMode;
        private NumericUpDown numYear, numMonth;
        private Button btnLoadChart;
        private Chart chartRevenue;
        private DataGridView dgvRoomRevenue;
        private Panel panelMain;
        private Panel panelDetail;

        // <-- IMPORTANT: use Guna2Button list
        private List<Guna2Button> detailButtons = new List<Guna2Button>();

        public frmRevenueChartGUI()
        {
            InitializeComponent();
            SetupUI();
            this.Load += frmRevenueChartGUI_Load;
        }

        private void SetupUI()
        {
            this.Text = "Thống kê doanh thu";
            this.WindowState = FormWindowState.Maximized;

            // ===============================
            // 1) PANEL TOP
            // ===============================
            panelTop = new Panel
            {
                Dock = DockStyle.Top,
                Height = 150,
                BackColor = Color.FromArgb(240, 240, 240)
            };
            this.Controls.Add(panelTop);

            // ---------- TITLE ----------
            lblTitle = new Label
            {
                Text = "THỐNG KÊ DOANH THU KHÁCH SẠN",
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14, FontStyle.Bold)
            };
            panelTop.Controls.Add(lblTitle);

            // ---------- LINE 2: FIELDS ----------
            TableLayoutPanel table = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 8,
                RowCount = 1,
                Padding = new Padding(20, 0, 0, 0),
            };
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // lblMode
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // cboMode
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // lblYear
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // numYear
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // lblMonth
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // numMonth
            table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize)); // btn
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); // filler

            panelTop.Controls.Add(table);

            lblMode = new Label { Text = "Kiểu:", Anchor = AnchorStyles.Left };
            cboMode = new ComboBox
            {
                Width = 120,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Anchor = AnchorStyles.Left
            };
            cboMode.Items.AddRange(new[] { "Ngày", "Tháng", "Năm" });
            cboMode.SelectedIndex = 0;
            cboMode.SelectedIndexChanged += (s, e) =>
            {
                // chỉ enable chọn tháng khi cần (Ngày mode)
                numMonth.Enabled = cboMode.SelectedItem.ToString() == "Ngày";
            };

            lblYear = new Label { Text = "Năm:", Anchor = AnchorStyles.Left };
            numYear = new NumericUpDown
            {
                Width = 80,
                Minimum = 2000,
                Maximum = 2100,
                Value = DateTime.Now.Year,
                Anchor = AnchorStyles.Left
            };

            lblMonth = new Label { Text = "Tháng:", Anchor = AnchorStyles.Left };
            numMonth = new NumericUpDown
            {
                Width = 60,
                Minimum = 1,
                Maximum = 12,
                Value = DateTime.Now.Month,
                Anchor = AnchorStyles.Left
            };

            btnLoadChart = new Button
            {
                Text = "Xem biểu đồ",
                Width = 120,
                Height = 30,
                Anchor = AnchorStyles.Left
            };
            btnLoadChart.Click += btnLoadChart_Click;

            // ADD TO TABLE
            table.Controls.Add(lblMode, 0, 0);
            table.Controls.Add(cboMode, 1, 0);
            table.Controls.Add(lblYear, 2, 0);
            table.Controls.Add(numYear, 3, 0);
            table.Controls.Add(lblMonth, 4, 0);
            table.Controls.Add(numMonth, 5, 0);
            table.Controls.Add(btnLoadChart, 6, 0);

            // ===============================
            // 2) MAIN PANEL (CHART)
            // ===============================
            panelMain = new Panel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(panelMain);

            chartRevenue = new Chart { Dock = DockStyle.Fill };
            var ca = new ChartArea("MainArea");
            ca.AxisX.MajorGrid.Enabled = false;
            ca.AxisX.LabelStyle.Angle = 0;
            ca.AxisX.Interval = 1;
            ca.AxisX.IsLabelAutoFit = true;
            ca.AxisX.LabelStyle.IsEndLabelVisible = true;
            ca.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartRevenue.ChartAreas.Add(ca);
            chartRevenue.Titles.Add("Biểu đồ doanh thu");

            // handle resize to reposition buttons
            chartRevenue.Resize += (s, e) => RepositionDetailButtons();

            panelMain.Controls.Add(chartRevenue);

            // ===============================
            // 3) DETAIL PANEL (GRID)
            // ===============================
            panelDetail = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 260,
                Visible = false
            };
            this.Controls.Add(panelDetail);

            dgvRoomRevenue = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
                AllowUserToAddRows = false,
            };
            panelDetail.Controls.Add(dgvRoomRevenue);
        }

        private void frmRevenueChartGUI_Load(object sender, EventArgs e)
        {

        }

        // ============================
        // LOAD BIỂU ĐỒ
        // ============================
        private void btnLoadChart_Click(object sender, EventArgs e)
        {
            try
            {
                RemoveDetailButtons();

                string modeVN = cboMode.SelectedItem.ToString();
                string mode = modeVN == "Ngày" ? "Day" :
                              modeVN == "Tháng" ? "Month" : "Year";

                int year = (int)numYear.Value;
                int? month = mode == "Day" ? (int?)numMonth.Value : null;

                var data = invoiceBUS.GetRevenueStatistics(mode, year, month);

                chartRevenue.Series.Clear();

                Series ser = new Series("Revenue");
                ser.ChartType = SeriesChartType.Column;
                ser["PointWidth"] = "0.6";
                ser.IsXValueIndexed = true; // important
                chartRevenue.Series.Add(ser);

                for (int i = 0; i < data.Count; i++)
                {
                    var item = data[i];
                    string lbl;

                    if (mode == "Day")
                        lbl = $"{item.Period}/{year}";
                    else if (mode == "Month")
                        lbl = $"{invoiceBUS.ParseMonth(item.Period):D2}/{year}";
                    else
                        lbl = item.Period;

                    int index = ser.Points.AddXY(lbl, (double)item.Revenue);

                    // Important: ensure XValue distinct (index-based)
                    ser.Points[index].XValue = index + 1;

                    ser.Points[index].Tag = new
                    {
                        RawPeriod = item.Period,
                        Mode = mode,
                        Year = year
                    };
                }

                // force axis interval so ValueToPixelPosition works
                chartRevenue.ChartAreas[0].AxisX.Interval = 1;

                CreateDetailButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // create Guna2 buttons for each point
        private void CreateDetailButtons()
        {
            RemoveDetailButtons();

            var ser = chartRevenue.Series.FirstOrDefault();
            if (ser == null || ser.Points.Count == 0) return;

            chartRevenue.Update();
            var area = chartRevenue.ChartAreas[0];

            // compute bottom Y for buttons (leave margin for axis labels)
            int btnY = chartRevenue.ClientSize.Height - 35; // tweak if needed

            for (int i = 0; i < ser.Points.Count; i++)
            {
                var p = ser.Points[i];
                if (p.Tag == null) continue;

                // Use index-based mapping (i+1) because labels are strings
                double xPixel = area.AxisX.ValueToPixelPosition(i + 1);

                var btn = new Guna2Button
                {
                    Text = "Chi tiết",
                    Width = 84,
                    Height = 30,
                    BorderRadius = 8,
                    FillColor = Color.FromArgb(0, 120, 215),
                    HoverState = { FillColor = Color.FromArgb(30, 140, 255) },
                    ForeColor = Color.White,
                    Tag = p.Tag,
                    Cursor = Cursors.Hand,
                    ShadowDecoration = { Enabled = true, BorderRadius = 8 }
                };

                int left = (int)(xPixel - btn.Width / 2);
                left = Math.Max(2, Math.Min(chartRevenue.ClientSize.Width - btn.Width - 2, left));
                btn.Left = left;
                btn.Top = btnY;

                // attach handler (sender will be Guna2Button)
                btn.Click += Detail_Click;

                chartRevenue.Controls.Add(btn);
                detailButtons.Add(btn);
            }
        }

        // reposition existing buttons (called on resize)
        private void RepositionDetailButtons()
        {
            if (detailButtons == null || detailButtons.Count == 0) return;
            var ser = chartRevenue.Series.FirstOrDefault();
            if (ser == null) return;

            chartRevenue.Update();
            var area = chartRevenue.ChartAreas[0];
            int btnY = chartRevenue.ClientSize.Height - 48;

            for (int i = 0; i < ser.Points.Count && i < detailButtons.Count; i++)
            {
                var btn = detailButtons[i];
                if (btn == null) continue;
                double xPixel = area.AxisX.ValueToPixelPosition(i + 1);
                int left = (int)(xPixel - btn.Width / 2);
                left = Math.Max(2, Math.Min(chartRevenue.ClientSize.Width - btn.Width - 2, left));
                btn.Left = left;
                btn.Top = btnY;
            }
        }

        private void Detail_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna2Button;
            if (btn == null) return;

            dynamic tag = btn.Tag;

            string mode = tag.Mode;
            string raw = tag.RawPeriod;
            int year = tag.Year;

            int? month = null, day = null;

            if (mode == "Day")
            {
                var parts = raw.Split('/');
                if (parts.Length >= 2 &&
                    int.TryParse(parts[0], out int d) &&
                    int.TryParse(parts[1], out int m))
                {
                    day = d;
                    month = m;
                }
            }
            else if (mode == "Month")
            {
                month = invoiceBUS.ParseMonth(raw);
            }

            var list = invoiceBUS.GetRevenueByRoom(mode, year, month, day);

            if (list == null || list.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }

            // 👉 mở form chi tiết
            frmRevenueDetail frm = new frmRevenueDetail(list);
            frm.ShowDialog();
        }

        private void RemoveDetailButtons()
        {
            if (detailButtons == null) return;
            foreach (var b in detailButtons)
            {
                if (b == null) continue;
                if (chartRevenue.Controls.Contains(b)) chartRevenue.Controls.Remove(b);
                b.Dispose();
            }
            detailButtons.Clear();
        }

        // Helper: parse "Tháng X" -> X as int
        private static int ParseMonthFromDalMonthString(string dalMonth)
        {
            if (string.IsNullOrWhiteSpace(dalMonth))
                return -1;

            // possible formats: "Tháng 1", "Tháng 01", "Tháng 10"
            dalMonth = dalMonth.Trim();
            if (dalMonth.StartsWith("Tháng", StringComparison.OrdinalIgnoreCase))
            {
                var parts = dalMonth.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length >= 2 && int.TryParse(parts[1], out int m))
                    return m;
            }

            // fallback: try to extract digits
            var digits = new string(dalMonth.Where(char.IsDigit).ToArray());
            if (int.TryParse(digits, out int mm))
                return mm;

            return -1;
        }
    }
}
