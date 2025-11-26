    using BUS;
    using ET;
    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Management;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace HotelManagement
    {
        public partial class frmMaintenanceCreateGUI : Form
        {
            public frmMaintenanceCreateGUI(List<string> selectedRooms)
            {
                InitializeComponent();
            rooms = selectedRooms;
        }
        private readonly List<string> rooms;
        private readonly MaintenanceBUS bus = new MaintenanceBUS();
        public Action<List<string>> OnCancelRollback;
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cboTechnician.SelectedItem == null ||
             cboMaintenanceType.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var et = new MaintenanceLogET
            {
                StaffID = ((KeyValuePair<string, string>)cboTechnician.SelectedItem).Key,
                MaintenanceTypeID = ((KeyValuePair<int, string>)cboMaintenanceType.SelectedItem).Key,
                RoomIDs = rooms.ToList(),
                EquipmentID = null,
                Note = Note,
                MaintenanceDate = DateTime.Now,
                Status = "Not completed"
            };

            bool ok = bus.CreateMaintenanceLogs(et);

            if (ok)
            {
                MessageBox.Show("Gửi yêu cầu bảo trì thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gửi yêu cầu bảo trì thất bại!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancelRollback?.Invoke(rooms);
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void frmMaintenanceCreateGUI_Load(object sender, EventArgs e)
            {

            // Nhân viên
            var techs = bus.GetTechnicians();
            cboTechnician.DataSource = techs;
            cboTechnician.DisplayMember = "Value"; // FullName
            cboTechnician.ValueMember = "Key";     // StaffID

            // AutoComplete cho nhân viên
            cboTechnician.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTechnician.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
            foreach (var t in techs)
                autoSource.Add(t.Value);

            cboTechnician.AutoCompleteCustomSource = autoSource;

            // Loại bảo trì
            var types = bus.GetMaintenanceTypes();
            cboMaintenanceType.DataSource = types;
            cboMaintenanceType.DisplayMember = "Value";
            cboMaintenanceType.ValueMember = "Key";

            // Danh sách phòng
            lstRooms.DataSource = rooms.ToList();
            lstRooms.Enabled = false;
            lstRooms.BackColor = Color.WhiteSmoke;
            lstRooms.ForeColor = Color.FromArgb(40, 40, 40);
            lstRooms.BorderStyle = BorderStyle.FixedSingle;
            lstRooms.DrawMode = DrawMode.OwnerDrawFixed;
            lstRooms.Font = new Font("Segoe UI", 10);
            lstRooms.ItemHeight = 28;

            lstRooms.DrawItem += (s, ev) =>
            {
                ev.DrawBackground();

                bool selected = (ev.State & DrawItemState.Selected) == DrawItemState.Selected;

                Color bg = selected ? Color.FromArgb(200, 220, 255) : Color.WhiteSmoke;
                Color fg = selected ? Color.Black : Color.FromArgb(40, 40, 40);

                using (SolidBrush backgroundBrush = new SolidBrush(bg))
                    ev.Graphics.FillRectangle(backgroundBrush, ev.Bounds);

                if (ev.Index >= 0)
                {
                    string text = lstRooms.Items[ev.Index].ToString();
                    TextRenderer.DrawText(ev.Graphics, text, lstRooms.Font,
                        ev.Bounds, fg, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                }

                ev.DrawFocusRectangle();
            };

        }
        public string Note { get; set; }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
