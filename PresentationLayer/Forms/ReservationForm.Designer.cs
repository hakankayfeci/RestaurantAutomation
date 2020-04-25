namespace PresentationLayer.Forms
{
	partial class ReservationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnNewCustomer = new System.Windows.Forms.Button();
			this.cmbCustomerSearch = new System.Windows.Forms.ComboBox();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.msPhone = new System.Windows.Forms.MaskedTextBox();
			this.txtPersonCount = new System.Windows.Forms.TextBox();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.cmbTableNumber = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtDate = new System.Windows.Forms.DateTimePicker();
			this.gbReservations = new System.Windows.Forms.GroupBox();
			this.dgvRezerve = new System.Windows.Forms.DataGridView();
			this.ReservationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ReservationNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PersonCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label7 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.tlMinimized = new System.Windows.Forms.ToolStripButton();
			this.tlExit = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbReservations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRezerve)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.gbReservations);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(1536, 727);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtSearch);
			this.groupBox2.Controls.Add(this.btnNewCustomer);
			this.groupBox2.Controls.Add(this.cmbCustomerSearch);
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.Controls.Add(this.btnDelete);
			this.groupBox2.Controls.Add(this.btnInsert);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.cmbStatus);
			this.groupBox2.Controls.Add(this.txtid);
			this.groupBox2.Controls.Add(this.msPhone);
			this.groupBox2.Controls.Add(this.txtPersonCount);
			this.groupBox2.Controls.Add(this.txtComment);
			this.groupBox2.Controls.Add(this.cmbTableNumber);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dtDate);
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(0, 32);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1532, 298);
			this.groupBox2.TabIndex = 19;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Rezervasyon İşlemleri";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(274, 232);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(217, 32);
			this.txtSearch.TabIndex = 37;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// btnNewCustomer
			// 
			this.btnNewCustomer.BackColor = System.Drawing.Color.Transparent;
			this.btnNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewCustomer.ForeColor = System.Drawing.Color.Black;
			this.btnNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnNewCustomer.Image")));
			this.btnNewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNewCustomer.Location = new System.Drawing.Point(1095, 150);
			this.btnNewCustomer.Name = "btnNewCustomer";
			this.btnNewCustomer.Size = new System.Drawing.Size(162, 87);
			this.btnNewCustomer.TabIndex = 10;
			this.btnNewCustomer.Text = "Müşteri\r\nOluştur";
			this.btnNewCustomer.UseVisualStyleBackColor = false;
			this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
			// 
			// cmbCustomerSearch
			// 
			this.cmbCustomerSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbCustomerSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCustomerSearch.FormattingEnabled = true;
			this.cmbCustomerSearch.Location = new System.Drawing.Point(274, 76);
			this.cmbCustomerSearch.Name = "cmbCustomerSearch";
			this.cmbCustomerSearch.Size = new System.Drawing.Size(217, 33);
			this.cmbCustomerSearch.TabIndex = 0;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
			this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdate.Location = new System.Drawing.Point(1095, 58);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(162, 86);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Transparent;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.Location = new System.Drawing.Point(927, 150);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(162, 87);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.Color.Transparent;
			this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
			this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInsert.Location = new System.Drawing.Point(927, 57);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(162, 87);
			this.btnInsert.TabIndex = 7;
			this.btnInsert.Text = "Ekle";
			this.btnInsert.UseVisualStyleBackColor = false;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(582, 232);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(110, 25);
			this.label10.TabIndex = 35;
			this.label10.Text = "Durumu :";
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Items.AddRange(new object[] {
            "True",
            "False"});
			this.cmbStatus.Location = new System.Drawing.Point(698, 229);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(200, 33);
			this.cmbStatus.TabIndex = 6;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(55, 50);
			this.txtid.Multiline = true;
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(10, 10);
			this.txtid.TabIndex = 31;
			this.txtid.Visible = false;
			// 
			// msPhone
			// 
			this.msPhone.Location = new System.Drawing.Point(274, 116);
			this.msPhone.Mask = "(999) 000-0000";
			this.msPhone.Name = "msPhone";
			this.msPhone.Size = new System.Drawing.Size(217, 32);
			this.msPhone.TabIndex = 1;
			// 
			// txtPersonCount
			// 
			this.txtPersonCount.Location = new System.Drawing.Point(698, 57);
			this.txtPersonCount.Name = "txtPersonCount";
			this.txtPersonCount.Size = new System.Drawing.Size(200, 32);
			this.txtPersonCount.TabIndex = 4;
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(698, 96);
			this.txtComment.Multiline = true;
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(200, 122);
			this.txtComment.TabIndex = 5;
			// 
			// cmbTableNumber
			// 
			this.cmbTableNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTableNumber.FormattingEnabled = true;
			this.cmbTableNumber.Location = new System.Drawing.Point(274, 196);
			this.cmbTableNumber.Name = "cmbTableNumber";
			this.cmbTableNumber.Size = new System.Drawing.Size(217, 33);
			this.cmbTableNumber.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(568, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(103, 25);
			this.label4.TabIndex = 24;
			this.label4.Text = "Açıklama";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(568, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 25);
			this.label3.TabIndex = 23;
			this.label3.Text = "Kişi Sayısı";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(50, 239);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 25);
			this.label8.TabIndex = 22;
			this.label8.Text = "Ara";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 204);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 25);
			this.label2.TabIndex = 22;
			this.label2.Text = "Masa Numarası";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(50, 123);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(187, 25);
			this.label6.TabIndex = 21;
			this.label6.Text = "Telefon Numarası";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(50, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(203, 25);
			this.label5.TabIndex = 20;
			this.label5.Text = "Rezerve Sahibi Adı";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 25);
			this.label1.TabIndex = 25;
			this.label1.Text = "Rezerve Tarihi ";
			// 
			// dtDate
			// 
			this.dtDate.Location = new System.Drawing.Point(274, 155);
			this.dtDate.Name = "dtDate";
			this.dtDate.Size = new System.Drawing.Size(217, 32);
			this.dtDate.TabIndex = 2;
			// 
			// gbReservations
			// 
			this.gbReservations.Controls.Add(this.dgvRezerve);
			this.gbReservations.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gbReservations.ForeColor = System.Drawing.Color.Black;
			this.gbReservations.Location = new System.Drawing.Point(4, 336);
			this.gbReservations.Name = "gbReservations";
			this.gbReservations.Size = new System.Drawing.Size(1528, 387);
			this.gbReservations.TabIndex = 8;
			this.gbReservations.TabStop = false;
			this.gbReservations.Text = "Rezervasyonlar";
			// 
			// dgvRezerve
			// 
			this.dgvRezerve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRezerve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationID,
            this.CustomerID,
            this.Customer,
            this.Phone,
            this.Table,
            this.TableID,
            this.ReservationDate,
            this.ReservationNote,
            this.PersonCount,
            this.Status});
			this.dgvRezerve.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvRezerve.Location = new System.Drawing.Point(3, 28);
			this.dgvRezerve.Name = "dgvRezerve";
			this.dgvRezerve.ReadOnly = true;
			this.dgvRezerve.RowTemplate.Height = 24;
			this.dgvRezerve.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRezerve.Size = new System.Drawing.Size(1522, 356);
			this.dgvRezerve.TabIndex = 0;
			this.dgvRezerve.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRezerve_RowEnter);
			// 
			// ReservationID
			// 
			this.ReservationID.DataPropertyName = "ReservationID";
			this.ReservationID.HeaderText = "RezerveNo";
			this.ReservationID.Name = "ReservationID";
			this.ReservationID.ReadOnly = true;
			// 
			// CustomerID
			// 
			this.CustomerID.DataPropertyName = "CustomerID";
			this.CustomerID.HeaderText = "Müşteri No";
			this.CustomerID.Name = "CustomerID";
			this.CustomerID.ReadOnly = true;
			this.CustomerID.Visible = false;
			// 
			// Customer
			// 
			this.Customer.DataPropertyName = "Customer";
			this.Customer.HeaderText = "Müsteri";
			this.Customer.Name = "Customer";
			this.Customer.ReadOnly = true;
			// 
			// Phone
			// 
			this.Phone.DataPropertyName = "Phone";
			this.Phone.HeaderText = "Müşteri Tel";
			this.Phone.Name = "Phone";
			this.Phone.ReadOnly = true;
			// 
			// Table
			// 
			this.Table.DataPropertyName = "Table";
			this.Table.HeaderText = "MasaID";
			this.Table.Name = "Table";
			this.Table.ReadOnly = true;
			this.Table.Visible = false;
			// 
			// TableID
			// 
			this.TableID.DataPropertyName = "TableID";
			this.TableID.HeaderText = "Masa";
			this.TableID.Name = "TableID";
			this.TableID.ReadOnly = true;
			// 
			// ReservationDate
			// 
			this.ReservationDate.DataPropertyName = "ReservationDate";
			this.ReservationDate.HeaderText = "Rezervasyon Tarihi";
			this.ReservationDate.Name = "ReservationDate";
			this.ReservationDate.ReadOnly = true;
			// 
			// ReservationNote
			// 
			this.ReservationNote.DataPropertyName = "ReservationNote";
			this.ReservationNote.HeaderText = "Acıklama";
			this.ReservationNote.Name = "ReservationNote";
			this.ReservationNote.ReadOnly = true;
			// 
			// PersonCount
			// 
			this.PersonCount.DataPropertyName = "PersonCount";
			this.PersonCount.HeaderText = "Kisi Sayisi";
			this.PersonCount.Name = "PersonCount";
			this.PersonCount.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Durum";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(38, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 25);
			this.label7.TabIndex = 1;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// errorProvider2
			// 
			this.errorProvider2.ContainerControl = this;
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.tlMinimized,
            this.tlExit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1536, 38);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(191, 35);
			this.toolStripLabel1.Text = "Reservation Form";
			// 
			// tlMinimized
			// 
			this.tlMinimized.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tlMinimized.Font = new System.Drawing.Font("Verdana", 15F);
			this.tlMinimized.ForeColor = System.Drawing.Color.White;
			this.tlMinimized.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlMinimized.Margin = new System.Windows.Forms.Padding(1250, 1, 0, 2);
			this.tlMinimized.Name = "tlMinimized";
			this.tlMinimized.Size = new System.Drawing.Size(29, 35);
			this.tlMinimized.Text = "-";
			this.tlMinimized.Click += new System.EventHandler(this.tlMinimized_Click);
			// 
			// tlExit
			// 
			this.tlExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tlExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.tlExit.ForeColor = System.Drawing.Color.White;
			this.tlExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlExit.Name = "tlExit";
			this.tlExit.Size = new System.Drawing.Size(29, 35);
			this.tlExit.Text = "X";
			this.tlExit.Click += new System.EventHandler(this.tlExit_Click);
			// 
			// ReservationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1536, 727);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ReservationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reservation Form";
			this.Load += new System.EventHandler(this.ReservationForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.gbReservations.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvRezerve)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbReservations;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.MaskedTextBox msPhone;
        private System.Windows.Forms.TextBox txtPersonCount;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbTableNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.DataGridView dgvRezerve;
        private System.Windows.Forms.ComboBox cmbCustomerSearch;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button btnNewCustomer;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReservationID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Customer;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Table;
		private System.Windows.Forms.DataGridViewTextBoxColumn TableID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReservationDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ReservationNote;
		private System.Windows.Forms.DataGridViewTextBoxColumn PersonCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton tlMinimized;
		private System.Windows.Forms.ToolStripButton tlExit;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label8;
	}
}