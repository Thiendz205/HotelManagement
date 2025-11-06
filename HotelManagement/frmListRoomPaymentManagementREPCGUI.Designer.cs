namespace HotelManagement
{
    partial class frmListRoomPaymentManagementREPCGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboRoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRoomName = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanelRooms = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderThickness = 4;
            this.guna2GroupBox1.Controls.Add(this.btnSearch);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.cboRoomType);
            this.guna2GroupBox1.Controls.Add(this.txtRoomName);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(20, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(843, 211);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Chức năng";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::HotelManagement.Properties.Resources.magnifier;
            this.btnSearch.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSearch.Location = new System.Drawing.Point(657, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(154, 63);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn loại phòng";
            // 
            // cboRoomType
            // 
            this.cboRoomType.BackColor = System.Drawing.Color.Transparent;
            this.cboRoomType.BorderRadius = 10;
            this.cboRoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.FocusedColor = System.Drawing.Color.Empty;
            this.cboRoomType.FocusedState.Parent = this.cboRoomType;
            this.cboRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.HoverState.Parent = this.cboRoomType;
            this.cboRoomType.ItemHeight = 30;
            this.cboRoomType.Items.AddRange(new object[] {
            "Tất cả",
            "Phòng Đơn",
            "Phòng Đôi",
            "Phòng Đa",
            "Phòng Đơn VIP",
            "Phòng Đôi VIP",
            "Phòng Đa VIP"});
            this.cboRoomType.ItemsAppearance.Parent = this.cboRoomType;
            this.cboRoomType.Location = new System.Drawing.Point(170, 133);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.ShadowDecoration.Parent = this.cboRoomType;
            this.cboRoomType.Size = new System.Drawing.Size(389, 36);
            this.cboRoomType.TabIndex = 1;
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomName.BorderRadius = 10;
            this.txtRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomName.DefaultText = "";
            this.txtRoomName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.DisabledState.Parent = this.txtRoomName;
            this.txtRoomName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomName.FocusedState.Parent = this.txtRoomName;
            this.txtRoomName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomName.HoverState.Parent = this.txtRoomName;
            this.txtRoomName.IconRight = global::HotelManagement.Properties.Resources.hotel;
            this.txtRoomName.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtRoomName.IconRightSize = new System.Drawing.Size(30, 30);
            this.txtRoomName.Location = new System.Drawing.Point(170, 62);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(8);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtRoomName.PlaceholderText = "Nhập tên phòng";
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.ShadowDecoration.Parent = this.txtRoomName;
            this.txtRoomName.Size = new System.Drawing.Size(389, 36);
            this.txtRoomName.TabIndex = 0;
            this.txtRoomName.Tag = "";
            // 
            // flowLayoutPanelRooms
            // 
            this.flowLayoutPanelRooms.AutoScroll = true;
            this.flowLayoutPanelRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.flowLayoutPanelRooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanelRooms.Location = new System.Drawing.Point(0, 386);
            this.flowLayoutPanelRooms.Name = "flowLayoutPanelRooms";
            this.flowLayoutPanelRooms.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelRooms.Size = new System.Drawing.Size(1924, 669);
            this.flowLayoutPanelRooms.TabIndex = 2;
            // 
            // frmListRoomPaymentManagementREPCGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.flowLayoutPanelRooms);
            this.Name = "frmListRoomPaymentManagementREPCGUI";
            this.Text = "frmListRoomPaymentManagementREPCGUI";
            this.Load += new System.EventHandler(this.frmListRoomPaymentManagementREPCGUI_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cboRoomType;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRooms;
    }
}