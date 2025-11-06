namespace HotelManagement
{
    partial class frmCustomerRECPGUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.guna2GroupBox3.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.BorderRadius = 20;
            this.guna2GroupBox3.BorderThickness = 4;
            this.guna2GroupBox3.Controls.Add(this.btnRefresh);
            this.guna2GroupBox3.Controls.Add(this.guna2Button3);
            this.guna2GroupBox3.Controls.Add(this.btnSearch);
            this.guna2GroupBox3.Controls.Add(this.btnUpdate);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(1114, 12);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(810, 172);
            this.guna2GroupBox3.TabIndex = 13;
            this.guna2GroupBox3.Text = "Chức Năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BorderRadius = 20;
            this.btnRefresh.CheckedState.Parent = this.btnRefresh;
            this.btnRefresh.CustomImages.Parent = this.btnRefresh;
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.HoverState.Parent = this.btnRefresh;
            this.btnRefresh.Image = global::HotelManagement.Properties.Resources.refreshRECP;
            this.btnRefresh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Location = new System.Drawing.Point(622, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ShadowDecoration.Parent = this.btnRefresh;
            this.btnRefresh.Size = new System.Drawing.Size(178, 62);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2Button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::HotelManagement.Properties.Resources.ChangeRommRECP;
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(427, 67);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(178, 62);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Chuyển Phòng";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 20;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::HotelManagement.Properties.Resources.magnifier;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(220, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(178, 62);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.CheckedState.Parent = this.btnUpdate;
            this.btnUpdate.CustomImages.Parent = this.btnUpdate;
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.HoverState.Parent = this.btnUpdate;
            this.btnUpdate.Image = global::HotelManagement.Properties.Resources.editRECP;
            this.btnUpdate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdate.Location = new System.Drawing.Point(26, 67);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowDecoration.Parent = this.btnUpdate;
            this.btnUpdate.Size = new System.Drawing.Size(178, 62);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Sửa thông tin";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.BorderThickness = 4;
            this.guna2GroupBox2.Controls.Add(this.cboCountry);
            this.guna2GroupBox2.Controls.Add(this.dtpDOB);
            this.guna2GroupBox2.Controls.Add(this.txtAddress);
            this.guna2GroupBox2.Controls.Add(this.txtFullName);
            this.guna2GroupBox2.Controls.Add(this.txtCCCD);
            this.guna2GroupBox2.Controls.Add(this.txtPhone);
            this.guna2GroupBox2.Controls.Add(this.rdoNu);
            this.guna2GroupBox2.Controls.Add(this.rdoNam);
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.label18);
            this.guna2GroupBox2.Controls.Add(this.label20);
            this.guna2GroupBox2.Controls.Add(this.label17);
            this.guna2GroupBox2.Controls.Add(this.label12);
            this.guna2GroupBox2.Controls.Add(this.label11);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(985, 345);
            this.guna2GroupBox2.TabIndex = 14;
            this.guna2GroupBox2.Text = "Thông tin khách hàng";
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
            this.cboCountry.Location = new System.Drawing.Point(693, 127);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(175, 30);
            this.cboCountry.TabIndex = 42;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CalendarForeColor = System.Drawing.Color.Transparent;
            this.dtpDOB.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDOB.CustomFormat = "";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(693, 206);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(175, 30);
            this.dtpDOB.TabIndex = 33;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.BorderThickness = 3;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.Parent = this.txtAddress;
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedState.Parent = this.txtAddress;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.HoverState.Parent = this.txtAddress;
            this.txtAddress.Location = new System.Drawing.Point(258, 272);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.ShadowDecoration.Parent = this.txtAddress;
            this.txtAddress.Size = new System.Drawing.Size(175, 38);
            this.txtAddress.TabIndex = 26;
            // 
            // txtFullName
            // 
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtFullName.BorderRadius = 10;
            this.txtFullName.BorderThickness = 3;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.DisabledState.Parent = this.txtFullName;
            this.txtFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.FocusedState.Parent = this.txtFullName;
            this.txtFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFullName.HoverState.Parent = this.txtFullName;
            this.txtFullName.Location = new System.Drawing.Point(258, 54);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(8);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.ShadowDecoration.Parent = this.txtFullName;
            this.txtFullName.Size = new System.Drawing.Size(175, 38);
            this.txtFullName.TabIndex = 25;
            // 
            // txtCCCD
            // 
            this.txtCCCD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCCCD.BorderRadius = 10;
            this.txtCCCD.BorderThickness = 3;
            this.txtCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCCCD.DefaultText = "";
            this.txtCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.DisabledState.Parent = this.txtCCCD;
            this.txtCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.FocusedState.Parent = this.txtCCCD;
            this.txtCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCCCD.HoverState.Parent = this.txtCCCD;
            this.txtCCCD.Location = new System.Drawing.Point(258, 197);
            this.txtCCCD.Margin = new System.Windows.Forms.Padding(8);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.PasswordChar = '\0';
            this.txtCCCD.PlaceholderText = "";
            this.txtCCCD.SelectedText = "";
            this.txtCCCD.ShadowDecoration.Parent = this.txtCCCD;
            this.txtCCCD.Size = new System.Drawing.Size(175, 38);
            this.txtCCCD.TabIndex = 24;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPhone.BorderRadius = 10;
            this.txtPhone.BorderThickness = 3;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.Parent = this.txtPhone;
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.FocusedState.Parent = this.txtPhone;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.HoverState.Parent = this.txtPhone;
            this.txtPhone.Location = new System.Drawing.Point(258, 122);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.ShadowDecoration.Parent = this.txtPhone;
            this.txtPhone.Size = new System.Drawing.Size(175, 38);
            this.txtPhone.TabIndex = 23;
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Location = new System.Drawing.Point(812, 68);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(56, 26);
            this.rdoNu.TabIndex = 21;
            this.rdoNu.TabStop = true;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Location = new System.Drawing.Point(693, 68);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(68, 26);
            this.rdoNam.TabIndex = 20;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(560, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "Quốc gia:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(560, 211);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 22);
            this.label18.TabIndex = 7;
            this.label18.Text = "Ngày sinh:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(560, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 22);
            this.label20.TabIndex = 5;
            this.label20.Text = "Giới tính:";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "CCCD/CMND: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "Địa chỉ: ";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(927, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Danh sách khách hàng";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomers.GridColor = System.Drawing.Color.White;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 620);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(1924, 435);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            this.dgvCustomers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellDoubleClick);
            // 
            // frmCustomerRECPGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.dgvCustomers);
            this.Name = "frmCustomerRECPGUI";
            this.Text = "frmCustomerRECPGUI";
            this.Load += new System.EventHandler(this.frmCustomerRECPGUI_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtCCCD;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCountry;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}