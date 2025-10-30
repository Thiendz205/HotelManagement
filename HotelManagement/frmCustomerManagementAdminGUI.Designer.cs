namespace HotelManagement
{
    partial class frmCustomerManagementAdminGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(962, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 37);
            this.label3.TabIndex = 31;
            this.label3.Text = "Danh sách khách hàng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.White;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::HotelManagement.Properties.Resources.refreshRECP;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(587, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(178, 62);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = global::HotelManagement.Properties.Resources.updateHR;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(309, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(178, 62);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::HotelManagement.Properties.Resources.magnifier;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(26, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(178, 62);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Controls.Add(this.cboCountry);
            this.guna2GroupBox2.Controls.Add(this.dtpDOB);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.rdoNu);
            this.guna2GroupBox2.Controls.Add(this.rdoNam);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.txtAddress);
            this.guna2GroupBox2.Controls.Add(this.txtCCCD);
            this.guna2GroupBox2.Controls.Add(this.txtPhone);
            this.guna2GroupBox2.Controls.Add(this.txtFullName);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.label17);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(15, 13);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(981, 340);
            this.guna2GroupBox2.TabIndex = 30;
            this.guna2GroupBox2.Text = "Thông tin khách hàng";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(205, 283);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(231, 30);
            this.dtpDOB.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Ngày Sinh:";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(739, 60);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(56, 26);
            this.rdoNu.TabIndex = 37;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(608, 60);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(68, 26);
            this.rdoNam.TabIndex = 36;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "Giới tính: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(608, 213);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(231, 30);
            this.txtAddress.TabIndex = 19;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Location = new System.Drawing.Point(205, 213);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(231, 30);
            this.txtCCCD.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(205, 131);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(231, 30);
            this.txtPhone.TabIndex = 17;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(205, 59);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(231, 30);
            this.txtFullName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Địa chỉ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "CCCD/CMND:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quốc gia:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 22);
            this.label17.TabIndex = 4;
            this.label17.Text = "SDT:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Họ tên:";
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Controls.Add(this.btnRefresh);
            this.guna2GroupBox3.Controls.Add(this.btnUpdate);
            this.guna2GroupBox3.Controls.Add(this.btnSearch);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GroupBox3.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(1050, 19);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(810, 188);
            this.guna2GroupBox3.TabIndex = 29;
            this.guna2GroupBox3.Text = "Chức Năng";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomers.GridColor = System.Drawing.Color.White;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 590);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1924, 465);
            this.dgvCustomers.TabIndex = 28;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // cboCountry
            // 
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Items.AddRange(new object[] {
            "Việt nam",
            "Afghanistan  ",
            "Albania  ",
            "Algeria  ",
            "Samoa thuộc Mỹ  ",
            "Andorra  ",
            "Angola  ",
            "Anguilla  ",
            "Antarctica  ",
            "Antigua và Barbuda  ",
            "Argentina  ",
            "Armenia  ",
            "Aruba  ",
            "Úc  ",
            "Áo  ",
            "Azerbaijan  ",
            "Bahamas  ",
            "Bahrain  ",
            "Bangladesh  ",
            "Barbados  ",
            "Belarus  ",
            "Bỉ  ",
            "Belize  ",
            "Benin  ",
            "Bermuda  ",
            "Bhutan  ",
            "Bolivia  ",
            "Bonaire  ",
            "Bosnia và Herzegovina  ",
            "Botswana  ",
            "Đảo Bouvet  ",
            "Brazil  ",
            "Lãnh thổ Ấn Độ Dương thuộc Anh  ",
            "Nhà nước Brunei Darussalam  ",
            "Bulgaria  ",
            "Burkina Faso  ",
            "Burundi  ",
            "Campuchia  ",
            "Cameroon  ",
            "Canada  ",
            "Cape Verde  ",
            "Quần đảo Cayman  ",
            "Trung Phi  ",
            "Sát (Tchad)  ",
            "Chile  ",
            "Trung Quốc  ",
            "Đảo Giáng Sinh  ",
            "Quần đảo Cocos  ",
            "Colombia  ",
            "Comoros  ",
            "Cộng hòa Congo  ",
            "Cộng hòa Dân chủ Congo  ",
            "Quần đảo Cook  ",
            "Costa Rica  ",
            "Croatia  ",
            "Cuba  ",
            "Curacao  ",
            "Síp  ",
            "Séc  ",
            "Bờ Biển Ngà  ",
            "Đan Mạch  ",
            "Djibouti  ",
            "Dominica  ",
            "Cộng hoà Dominica  ",
            "Ecuador  ",
            "Ai Cập  ",
            "El Salvador  ",
            "Guinea Xích Đạo  ",
            "Eritrea  ",
            "Estonia  ",
            "Ethiopia  ",
            "Quần đảo Falkland (Malvinas)  ",
            "Quần đảo Faroe  ",
            "Fiji  ",
            "Phần Lan  ",
            "Pháp  ",
            "Guiana thuộc Pháp  ",
            "Polynesia thuộc Pháp  ",
            "Vùng đất phía Nam và châu Nam Cực thuộc Pháp  ",
            "Gabon  ",
            "Gambia  ",
            "Georgia  ",
            "Đức  ",
            "Ghana  ",
            "Gibraltar  ",
            "Hy Lạp  ",
            "Một quốc gia tự trị thuộc Đan Mạch  ",
            "Grenada  ",
            "Guadeloupe  ",
            "Đảo Guam  ",
            "Guatemala  ",
            "Guernsey  ",
            "Guinea  ",
            "Guinea-Bissau  ",
            "Guyana  ",
            "Haiti  ",
            "Đảo Heard và quần đảo McDonald  ",
            "Tòa thánh Vatican  ",
            "Honduras  ",
            "Hồng Kông  ",
            "Hungary  ",
            "Iceland  ",
            "Ấn Độ  ",
            "Indonesia  ",
            "Iran  ",
            "Iraq  ",
            "Ireland  ",
            "Đảo Man  ",
            "Israel  ",
            "Ý  ",
            "Jamaica  ",
            "Nhật Bản  ",
            "Jersey  ",
            "Jordan  ",
            "Kazakhstan  ",
            "Kenya  ",
            "Kiribati  ",
            "Triều tiên  ",
            "Hàn Quốc  ",
            "Kuwait  ",
            "Kyrgyzstan  ",
            "Lào  ",
            "Latvia  ",
            "Lebanon  ",
            "Lesotho  ",
            "Liberia  ",
            "Libya  ",
            "Liechtenstein  ",
            "Lithuania  ",
            "Luxembourg  ",
            "Macao  ",
            "Macedonia  ",
            "Madagascar  ",
            "Malawi  ",
            "Malaysia  ",
            "Maldives  ",
            "Mali  ",
            "Malta  ",
            "Quần đảo Marshall  ",
            "Martinique  ",
            "Mauritania  ",
            "Mauritius  ",
            "Mayotte  ",
            "Mexico  ",
            "Liên bang Micronesia  ",
            "Moldova  ",
            "Monaco  ",
            "Mông Cổ  ",
            "Montenegro  ",
            "Montserrat  ",
            "Ma Rốc (Maroc)  ",
            "Mozambique  ",
            "Myanmar  ",
            "Nam Phi  ",
            "Nauru  ",
            "Nepal  ",
            "Hà Lan  ",
            "New Caledonia  ",
            "New Zealand  ",
            "Nicaragua  ",
            "Niger  ",
            "Nigeria  ",
            "Niue  ",
            "Đảo Norfolk  ",
            "Quần đảo Bắc Mariana  ",
            "Na Uy  ",
            "Oman  ",
            "Pakistan  ",
            "Palau  ",
            "Palestine  ",
            "Panama  ",
            "Papua New Guinea  ",
            "Paraguay  ",
            "Peru  ",
            "Philippines  ",
            "Pitcairn  ",
            "Ba Lan  ",
            "Bồ Đào Nha  ",
            "Puerto Rico  ",
            "Qatar  ",
            "Romania  ",
            "Nga  ",
            "Rwanda  ",
            "Reunion  ",
            "Saint Barthelemy  ",
            "Saint Helena  ",
            "Saint Kitts và Nevis  ",
            "Saint Lucia  ",
            "Saint Martin (French part)  ",
            "Saint Pierre và Miquelon  ",
            "Saint Vincent và the Grenadines  ",
            "Samoa  ",
            "San Marino  ",
            "Sao Tome và Principe  ",
            "Ả Rập Xê Út  ",
            "Senegal  ",
            "Serbia  ",
            "Seychelles  ",
            "Sierra Leone  ",
            "Singapore  ",
            "Sint Maarten  ",
            "Slovakia  ",
            "Slovenia  ",
            "Quần đảo Solomon  ",
            "Somalia  ",
            "Nam Phi  ",
            "Nam Georgia và Quần đảo Nam Sandwich  ",
            "Nam Sudan  ",
            "Tây Ban Nha  ",
            "Sri Lanka  ",
            "Sudan  ",
            "Suriname  ",
            "Svalbard và Jan Mayen  ",
            "Swaziland  ",
            "Thụy Điển  ",
            "Thụy Sĩ  ",
            "Syria  ",
            "Đài Loan  ",
            "Tajikistan  ",
            "Tanzania  ",
            "Thái Lan  ",
            "Đông Timor  ",
            "Togo  ",
            "Tokelau  ",
            "Tonga  ",
            "Trinidad và Tobago  ",
            "Tunisia  ",
            "Thổ Nhĩ Kỳ  ",
            "Turkmenistan  ",
            "Quần đảo Turks và Caicos  ",
            "Tuvalu  ",
            "Uganda  ",
            "Ukraine  ",
            "Các tiểu vương quốc Ả Rập Thống nhất  ",
            "Vương quốc Liên hiệp Anh và Bắc Ireland  ",
            "Mỹ (Hoa Kỳ)  ",
            "Các tiểu đảo xa của Hoa Kỳ  ",
            "Uruguay  ",
            "Uzbekistan  ",
            "Vanuatu  ",
            "Venezuela  ",
            "Quần đảo Virgin thuộc Anh  ",
            "Quần đảo Virgin thuộc Mỹ  ",
            "Wallis và Futuna  ",
            "Tây Sahara  ",
            "Yemen  ",
            "Zambia  ",
            "Zimbabwe  "});
            this.cboCountry.Location = new System.Drawing.Point(608, 131);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(231, 30);
            this.cboCountry.TabIndex = 41;
            // 
            // frmCustomerManagementAdminGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "frmCustomerManagementAdminGUI";
            this.Text = "frmCustomerManagementAdminGUI";
            this.Load += new System.EventHandler(this.frmCustomerManagementAdminGUI_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.guna2GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCountry;
    }
}