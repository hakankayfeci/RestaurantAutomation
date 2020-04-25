namespace PresentationLayer.Forms
{
    partial class StaffSettingForm1
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffSettingForm1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvStaffs = new System.Windows.Forms.DataGridView();
			this._StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._TitleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._TitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._TcNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._WorkDateOfStarting = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._WorkLeavingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._SecurityQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._SecurityAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._MonthlySalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._StaffImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbStaff = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.txtId = new System.Windows.Forms.TextBox();
			this.rdLeave = new System.Windows.Forms.RadioButton();
			this.rdSkip = new System.Windows.Forms.RadioButton();
			this.lblRandomSifre = new System.Windows.Forms.Label();
			this.txtTcNumber = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
			this.dtWorkLeavingDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.pcStaffPhoto = new System.Windows.Forms.PictureBox();
			this.cmbQuestion = new System.Windows.Forms.ComboBox();
			this.btnSelectPhoto = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbTitle = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMonthlySalary = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtStaffName = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtStaffLastname = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TitleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TitleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).BeginInit();
			this.gbStaff.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcStaffPhoto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvStaffs);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(0, 437);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.groupBox1.Size = new System.Drawing.Size(1439, 297);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Personel Listesi";
			// 
			// dgvStaffs
			// 
			this.dgvStaffs.AllowUserToResizeColumns = false;
			this.dgvStaffs.AllowUserToResizeRows = false;
			this.dgvStaffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStaffs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStaffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._StaffID,
            this._TitleID,
            this._TitleName,
            this._FirstName,
            this._LastName,
            this._UserName,
            this._Password,
            this._Phone,
            this._TcNumber,
            this._WorkDateOfStarting,
            this._WorkLeavingDate,
            this._SecurityQuestion,
            this._SecurityAnswer,
            this._MonthlySalary,
            this._StaffImage});
			this.dgvStaffs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvStaffs.Location = new System.Drawing.Point(3, 23);
			this.dgvStaffs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dgvStaffs.MultiSelect = false;
			this.dgvStaffs.Name = "dgvStaffs";
			this.dgvStaffs.ReadOnly = true;
			this.dgvStaffs.RowTemplate.Height = 24;
			this.dgvStaffs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStaffs.Size = new System.Drawing.Size(1433, 270);
			this.dgvStaffs.TabIndex = 0;
			this.dgvStaffs.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaffs_RowEnter);
			// 
			// _StaffID
			// 
			this._StaffID.DataPropertyName = "StaffID";
			this._StaffID.HeaderText = "PersonelNo";
			this._StaffID.Name = "_StaffID";
			this._StaffID.ReadOnly = true;
			// 
			// _TitleID
			// 
			this._TitleID.DataPropertyName = "TitleID";
			this._TitleID.HeaderText = "TitleID";
			this._TitleID.Name = "_TitleID";
			this._TitleID.ReadOnly = true;
			this._TitleID.Visible = false;
			// 
			// _TitleName
			// 
			this._TitleName.DataPropertyName = "TitleName";
			this._TitleName.HeaderText = "Ünvanı";
			this._TitleName.Name = "_TitleName";
			this._TitleName.ReadOnly = true;
			// 
			// _FirstName
			// 
			this._FirstName.DataPropertyName = "FirstName";
			this._FirstName.HeaderText = "Adı";
			this._FirstName.Name = "_FirstName";
			this._FirstName.ReadOnly = true;
			// 
			// _LastName
			// 
			this._LastName.DataPropertyName = "LastName";
			this._LastName.HeaderText = "Soyadı";
			this._LastName.Name = "_LastName";
			this._LastName.ReadOnly = true;
			// 
			// _UserName
			// 
			this._UserName.DataPropertyName = "UserName";
			this._UserName.HeaderText = "KullanıcıAdı";
			this._UserName.Name = "_UserName";
			this._UserName.ReadOnly = true;
			// 
			// _Password
			// 
			this._Password.DataPropertyName = "Password";
			this._Password.HeaderText = "Şifresi";
			this._Password.Name = "_Password";
			this._Password.ReadOnly = true;
			// 
			// _Phone
			// 
			this._Phone.DataPropertyName = "Phone";
			this._Phone.HeaderText = "Tel No";
			this._Phone.Name = "_Phone";
			this._Phone.ReadOnly = true;
			// 
			// _TcNumber
			// 
			this._TcNumber.DataPropertyName = "TcNumber";
			this._TcNumber.HeaderText = "TC No";
			this._TcNumber.Name = "_TcNumber";
			this._TcNumber.ReadOnly = true;
			// 
			// _WorkDateOfStarting
			// 
			this._WorkDateOfStarting.DataPropertyName = "WorkDateOfStarting";
			this._WorkDateOfStarting.HeaderText = "İşeBaşlamaTarihi";
			this._WorkDateOfStarting.Name = "_WorkDateOfStarting";
			this._WorkDateOfStarting.ReadOnly = true;
			// 
			// _WorkLeavingDate
			// 
			this._WorkLeavingDate.DataPropertyName = "WorkLeavingDate";
			this._WorkLeavingDate.HeaderText = "İştenAyrılmaTarihi";
			this._WorkLeavingDate.Name = "_WorkLeavingDate";
			this._WorkLeavingDate.ReadOnly = true;
			// 
			// _SecurityQuestion
			// 
			this._SecurityQuestion.DataPropertyName = "SecurityQuestion";
			this._SecurityQuestion.HeaderText = "Güvenlik Sorusu";
			this._SecurityQuestion.Name = "_SecurityQuestion";
			this._SecurityQuestion.ReadOnly = true;
			// 
			// _SecurityAnswer
			// 
			this._SecurityAnswer.DataPropertyName = "SecurityAnswer";
			this._SecurityAnswer.HeaderText = "Güvenlik Cevabı";
			this._SecurityAnswer.Name = "_SecurityAnswer";
			this._SecurityAnswer.ReadOnly = true;
			// 
			// _MonthlySalary
			// 
			this._MonthlySalary.DataPropertyName = "MonthlySalary";
			this._MonthlySalary.HeaderText = "Aylık Maaşı";
			this._MonthlySalary.Name = "_MonthlySalary";
			this._MonthlySalary.ReadOnly = true;
			// 
			// _StaffImage
			// 
			this._StaffImage.DataPropertyName = "StaffImage";
			this._StaffImage.HeaderText = "Personel Fotoğraf";
			this._StaffImage.Name = "_StaffImage";
			this._StaffImage.ReadOnly = true;
			this._StaffImage.Visible = false;
			// 
			// gbStaff
			// 
			this.gbStaff.BackColor = System.Drawing.Color.White;
			this.gbStaff.Controls.Add(this.txtSearch);
			this.gbStaff.Controls.Add(this.btnPrint);
			this.gbStaff.Controls.Add(this.linkLabel2);
			this.gbStaff.Controls.Add(this.linkLabel1);
			this.gbStaff.Controls.Add(this.txtId);
			this.gbStaff.Controls.Add(this.rdLeave);
			this.gbStaff.Controls.Add(this.rdSkip);
			this.gbStaff.Controls.Add(this.lblRandomSifre);
			this.gbStaff.Controls.Add(this.txtTcNumber);
			this.gbStaff.Controls.Add(this.label5);
			this.gbStaff.Controls.Add(this.label13);
			this.gbStaff.Controls.Add(this.label12);
			this.gbStaff.Controls.Add(this.mtxtPhone);
			this.gbStaff.Controls.Add(this.dtWorkLeavingDate);
			this.gbStaff.Controls.Add(this.label1);
			this.gbStaff.Controls.Add(this.label11);
			this.gbStaff.Controls.Add(this.btnInsert);
			this.gbStaff.Controls.Add(this.btnUpdate);
			this.gbStaff.Controls.Add(this.btnDelete);
			this.gbStaff.Controls.Add(this.pcStaffPhoto);
			this.gbStaff.Controls.Add(this.cmbQuestion);
			this.gbStaff.Controls.Add(this.btnSelectPhoto);
			this.gbStaff.Controls.Add(this.label2);
			this.gbStaff.Controls.Add(this.cmbTitle);
			this.gbStaff.Controls.Add(this.label6);
			this.gbStaff.Controls.Add(this.txtMonthlySalary);
			this.gbStaff.Controls.Add(this.label3);
			this.gbStaff.Controls.Add(this.txtAnswer);
			this.gbStaff.Controls.Add(this.label7);
			this.gbStaff.Controls.Add(this.txtStaffName);
			this.gbStaff.Controls.Add(this.txtUsername);
			this.gbStaff.Controls.Add(this.label8);
			this.gbStaff.Controls.Add(this.label4);
			this.gbStaff.Controls.Add(this.txtStaffLastname);
			this.gbStaff.Controls.Add(this.label9);
			this.gbStaff.Font = new System.Drawing.Font("Verdana", 10F);
			this.gbStaff.ForeColor = System.Drawing.Color.Black;
			this.gbStaff.Location = new System.Drawing.Point(5, 35);
			this.gbStaff.Name = "gbStaff";
			this.gbStaff.Size = new System.Drawing.Size(1431, 405);
			this.gbStaff.TabIndex = 15;
			this.gbStaff.TabStop = false;
			this.gbStaff.Text = "Personel Bilgileri";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(216, 309);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(236, 28);
			this.txtSearch.TabIndex = 42;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// btnPrint
			// 
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
			this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPrint.Location = new System.Drawing.Point(847, 225);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(171, 170);
			this.btnPrint.TabIndex = 40;
			this.btnPrint.Text = "Yazdır";
			this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.LinkColor = System.Drawing.Color.White;
			this.linkLabel2.Location = new System.Drawing.Point(337, 315);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(96, 20);
			this.linkLabel2.TabIndex = 37;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "linkLabel2";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(211, 315);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(96, 20);
			this.linkLabel1.TabIndex = 36;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "linkLabel1";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(216, 29);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(44, 28);
			this.txtId.TabIndex = 35;
			// 
			// rdLeave
			// 
			this.rdLeave.AutoSize = true;
			this.rdLeave.Location = new System.Drawing.Point(732, 31);
			this.rdLeave.Name = "rdLeave";
			this.rdLeave.Size = new System.Drawing.Size(85, 24);
			this.rdLeave.TabIndex = 34;
			this.rdLeave.TabStop = true;
			this.rdLeave.Text = "Ayrıldı";
			this.rdLeave.UseVisualStyleBackColor = true;
			this.rdLeave.CheckedChanged += new System.EventHandler(this.rdLeave_CheckedChanged);
			// 
			// rdSkip
			// 
			this.rdSkip.AutoSize = true;
			this.rdSkip.Location = new System.Drawing.Point(836, 31);
			this.rdSkip.Name = "rdSkip";
			this.rdSkip.Size = new System.Drawing.Size(90, 24);
			this.rdSkip.TabIndex = 33;
			this.rdSkip.TabStop = true;
			this.rdSkip.Text = "Devam";
			this.rdSkip.UseVisualStyleBackColor = true;
			// 
			// lblRandomSifre
			// 
			this.lblRandomSifre.AutoSize = true;
			this.lblRandomSifre.Location = new System.Drawing.Point(180, 320);
			this.lblRandomSifre.Name = "lblRandomSifre";
			this.lblRandomSifre.Size = new System.Drawing.Size(0, 20);
			this.lblRandomSifre.TabIndex = 32;
			// 
			// txtTcNumber
			// 
			this.txtTcNumber.Location = new System.Drawing.Point(216, 266);
			this.txtTcNumber.Name = "txtTcNumber";
			this.txtTcNumber.Size = new System.Drawing.Size(236, 28);
			this.txtTcNumber.TabIndex = 6;
			this.txtTcNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfengelleme);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(27, 266);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(69, 20);
			this.label13.TabIndex = 31;
			this.label13.Text = "Tc No :";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(27, 231);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(112, 20);
			this.label12.TabIndex = 30;
			this.label12.Text = "Telefon No :";
			// 
			// mtxtPhone
			// 
			this.mtxtPhone.Location = new System.Drawing.Point(216, 224);
			this.mtxtPhone.Mask = "(999) 000-0000";
			this.mtxtPhone.Name = "mtxtPhone";
			this.mtxtPhone.Size = new System.Drawing.Size(236, 28);
			this.mtxtPhone.TabIndex = 5;
			// 
			// dtWorkLeavingDate
			// 
			this.dtWorkLeavingDate.Location = new System.Drawing.Point(729, 71);
			this.dtWorkLeavingDate.Name = "dtWorkLeavingDate";
			this.dtWorkLeavingDate.Size = new System.Drawing.Size(290, 28);
			this.dtWorkLeavingDate.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(498, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 20);
			this.label1.TabIndex = 26;
			this.label1.Text = "Çalışma Durumu :";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(498, 71);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(192, 20);
			this.label11.TabIndex = 26;
			this.label11.Text = "İşten Ayrılma Tarihi :";
			// 
			// btnInsert
			// 
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsert.Font = new System.Drawing.Font("Verdana", 12F);
			this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
			this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInsert.Location = new System.Drawing.Point(537, 224);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(149, 85);
			this.btnInsert.TabIndex = 13;
			this.btnInsert.Text = "Ekle";
			this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Font = new System.Drawing.Font("Verdana", 12F);
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdate.Location = new System.Drawing.Point(537, 311);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(304, 84);
			this.btnUpdate.TabIndex = 14;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("Verdana", 12F);
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.Location = new System.Drawing.Point(692, 225);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(149, 84);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "Sil";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// pcStaffPhoto
			// 
			this.pcStaffPhoto.Location = new System.Drawing.Point(1038, 91);
			this.pcStaffPhoto.Name = "pcStaffPhoto";
			this.pcStaffPhoto.Size = new System.Drawing.Size(228, 230);
			this.pcStaffPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcStaffPhoto.TabIndex = 21;
			this.pcStaffPhoto.TabStop = false;
			// 
			// cmbQuestion
			// 
			this.cmbQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbQuestion.FormattingEnabled = true;
			this.cmbQuestion.Location = new System.Drawing.Point(729, 108);
			this.cmbQuestion.Name = "cmbQuestion";
			this.cmbQuestion.Size = new System.Drawing.Size(290, 28);
			this.cmbQuestion.TabIndex = 9;
			// 
			// btnSelectPhoto
			// 
			this.btnSelectPhoto.BackColor = System.Drawing.Color.White;
			this.btnSelectPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPhoto.Image")));
			this.btnSelectPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSelectPhoto.Location = new System.Drawing.Point(1038, 29);
			this.btnSelectPhoto.Name = "btnSelectPhoto";
			this.btnSelectPhoto.Size = new System.Drawing.Size(228, 46);
			this.btnSelectPhoto.TabIndex = 12;
			this.btnSelectPhoto.Text = "Resim Seç ";
			this.btnSelectPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSelectPhoto.UseVisualStyleBackColor = false;
			this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Personel Adı :\r\n";
			// 
			// cmbTitle
			// 
			this.cmbTitle.FormattingEnabled = true;
			this.cmbTitle.Location = new System.Drawing.Point(216, 71);
			this.cmbTitle.Name = "cmbTitle";
			this.cmbTitle.Size = new System.Drawing.Size(236, 28);
			this.cmbTitle.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(27, 79);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "Görev :";
			// 
			// txtMonthlySalary
			// 
			this.txtMonthlySalary.Location = new System.Drawing.Point(729, 185);
			this.txtMonthlySalary.Name = "txtMonthlySalary";
			this.txtMonthlySalary.Size = new System.Drawing.Size(290, 28);
			this.txtMonthlySalary.TabIndex = 11;
			this.txtMonthlySalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfengelleme);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(159, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "Personel Soyadı :\r\n";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(729, 147);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(290, 28);
			this.txtAnswer.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(498, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(164, 20);
			this.label7.TabIndex = 11;
			this.label7.Text = "Güvenlik Sorusu :";
			// 
			// txtStaffName
			// 
			this.txtStaffName.Location = new System.Drawing.Point(216, 110);
			this.txtStaffName.Name = "txtStaffName";
			this.txtStaffName.Size = new System.Drawing.Size(236, 28);
			this.txtStaffName.TabIndex = 1;
			this.txtStaffName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sayiengelleme);
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(216, 186);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(236, 28);
			this.txtUsername.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(498, 147);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 20);
			this.label8.TabIndex = 11;
			this.label8.Text = "Cevap :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(27, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Kullanıcı Adı :";
			// 
			// txtStaffLastname
			// 
			this.txtStaffLastname.Location = new System.Drawing.Point(216, 148);
			this.txtStaffLastname.Name = "txtStaffLastname";
			this.txtStaffLastname.Size = new System.Drawing.Size(236, 28);
			this.txtStaffLastname.TabIndex = 2;
			this.txtStaffLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sayiengelleme);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(498, 185);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(114, 20);
			this.label9.TabIndex = 11;
			this.label9.Text = "Aylık Maaş :";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// StaffID
			// 
			this.StaffID.DataPropertyName = "StaffID";
			this.StaffID.HeaderText = "Personel No";
			this.StaffID.Name = "StaffID";
			this.StaffID.Width = 109;
			// 
			// TitleID
			// 
			this.TitleID.DataPropertyName = "TitleID";
			this.TitleID.HeaderText = "Title";
			this.TitleID.Name = "TitleID";
			this.TitleID.Visible = false;
			// 
			// TitleName
			// 
			this.TitleName.DataPropertyName = "TitleName";
			this.TitleName.HeaderText = "Ünvanı";
			this.TitleName.Name = "TitleName";
			this.TitleName.Width = 109;
			// 
			// FirstName
			// 
			this.FirstName.DataPropertyName = "FirstName";
			this.FirstName.HeaderText = "Adı";
			this.FirstName.Name = "FirstName";
			this.FirstName.Width = 109;
			// 
			// LastName
			// 
			this.LastName.DataPropertyName = "LastName";
			this.LastName.HeaderText = "Soyadı";
			this.LastName.Name = "LastName";
			this.LastName.Width = 109;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1,
            this.toolStripButton2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1439, 32);
			this.toolStrip1.TabIndex = 16;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(222, 29);
			this.toolStripLabel1.Text = "Personel İşlem Panel";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.toolStripButton1.ForeColor = System.Drawing.Color.White;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(1000, 1, 0, 2);
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(26, 29);
			this.toolStripButton1.Text = "-";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.toolStripButton2.ForeColor = System.Drawing.Color.White;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(31, 29);
			this.toolStripButton2.Text = "X";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(31, 320);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 20);
			this.label5.TabIndex = 31;
			this.label5.Text = "Ara :";
			// 
			// StaffSettingForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1439, 734);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.gbStaff);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "StaffSettingForm1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StaffSetting";
			this.Load += new System.EventHandler(this.StaffSettingForm1_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStaffs)).EndInit();
			this.gbStaff.ResumeLayout(false);
			this.gbStaff.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcStaffPhoto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStaffs;
        private System.Windows.Forms.GroupBox gbStaff;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.RadioButton rdLeave;
        private System.Windows.Forms.RadioButton rdSkip;
        private System.Windows.Forms.Label lblRandomSifre;
        private System.Windows.Forms.TextBox txtTcNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.DateTimePicker dtWorkLeavingDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pcStaffPhoto;
        private System.Windows.Forms.ComboBox cmbQuestion;
        private System.Windows.Forms.Button btnSelectPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonthlySalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffLastname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.DataGridViewTextBoxColumn _StaffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn _TitleID;
		private System.Windows.Forms.DataGridViewTextBoxColumn _TitleName;
		private System.Windows.Forms.DataGridViewTextBoxColumn _FirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn _LastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn _UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Password;
		private System.Windows.Forms.DataGridViewTextBoxColumn _Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn _TcNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn _WorkDateOfStarting;
		private System.Windows.Forms.DataGridViewTextBoxColumn _WorkLeavingDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn _SecurityQuestion;
		private System.Windows.Forms.DataGridViewTextBoxColumn _SecurityAnswer;
		private System.Windows.Forms.DataGridViewTextBoxColumn _MonthlySalary;
		private System.Windows.Forms.DataGridViewTextBoxColumn _StaffImage;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label5;
	}
}