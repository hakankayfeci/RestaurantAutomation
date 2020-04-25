namespace PresentationLayer.Forms
{
	partial class CustomersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtCustomerName = new System.Windows.Forms.TextBox();
			this.msPhone = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvCustomers = new System.Windows.Forms.DataGridView();
			this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NameSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reservations = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblID = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Müşteri Adı-Soyadı :";
			// 
			// txtCustomerName
			// 
			this.txtCustomerName.Location = new System.Drawing.Point(267, 85);
			this.txtCustomerName.Name = "txtCustomerName";
			this.txtCustomerName.Size = new System.Drawing.Size(197, 32);
			this.txtCustomerName.TabIndex = 1;
			// 
			// msPhone
			// 
			this.msPhone.Location = new System.Drawing.Point(267, 123);
			this.msPhone.Mask = "(999) 000-0000";
			this.msPhone.Name = "msPhone";
			this.msPhone.Size = new System.Drawing.Size(197, 32);
			this.msPhone.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(58, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(203, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Telefon Numarası :";
			// 
			// btnInsert
			// 
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
			this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInsert.Location = new System.Drawing.Point(481, 85);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(127, 47);
			this.btnInsert.TabIndex = 8;
			this.btnInsert.Text = "Ekle";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdate.Location = new System.Drawing.Point(481, 139);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(269, 53);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.Location = new System.Drawing.Point(614, 85);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(136, 48);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvCustomers);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 215);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1043, 444);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteriler";
			// 
			// dgvCustomers
			// 
			this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.NameSurname,
            this.Phone,
            this.Reservations,
            this.AccountPayments});
			this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvCustomers.Location = new System.Drawing.Point(3, 28);
			this.dgvCustomers.Name = "dgvCustomers";
			this.dgvCustomers.RowTemplate.Height = 24;
			this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCustomers.Size = new System.Drawing.Size(1037, 413);
			this.dgvCustomers.TabIndex = 0;
			this.dgvCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_RowEnter);
			// 
			// CustomerID
			// 
			this.CustomerID.DataPropertyName = "CustomerID";
			this.CustomerID.HeaderText = "Müşteri No";
			this.CustomerID.Name = "CustomerID";
			// 
			// NameSurname
			// 
			this.NameSurname.DataPropertyName = "NameSurname";
			this.NameSurname.HeaderText = "Adı Soyadı ";
			this.NameSurname.Name = "NameSurname";
			// 
			// Phone
			// 
			this.Phone.DataPropertyName = "Phone";
			this.Phone.HeaderText = "Telefon Numarası";
			this.Phone.Name = "Phone";
			// 
			// Reservations
			// 
			this.Reservations.DataPropertyName = "Reservations";
			this.Reservations.HeaderText = "Rezervasyon";
			this.Reservations.Name = "Reservations";
			this.Reservations.Visible = false;
			// 
			// AccountPayments
			// 
			this.AccountPayments.DataPropertyName = "AccountPayments";
			this.AccountPayments.HeaderText = "AccountPayment";
			this.AccountPayments.Name = "AccountPayments";
			this.AccountPayments.Visible = false;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// lblID
			// 
			this.lblID.AutoSize = true;
			this.lblID.ForeColor = System.Drawing.Color.White;
			this.lblID.Location = new System.Drawing.Point(429, 25);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(35, 25);
			this.lblID.TabIndex = 13;
			this.lblID.Text = "ID";
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
			this.toolStrip1.Size = new System.Drawing.Size(1043, 32);
			this.toolStrip1.TabIndex = 14;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(155, 29);
			this.toolStripLabel1.Text = "Müşteri Paneli";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.toolStripButton1.ForeColor = System.Drawing.Color.White;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(800, 1, 0, 2);
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(26, 29);
			this.toolStripButton1.Text = "-";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton2.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripButton2.ForeColor = System.Drawing.Color.White;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(30, 29);
			this.toolStripButton2.Text = "X";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(267, 161);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(197, 32);
			this.txtSearch.TabIndex = 16;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(198, 164);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Ara :";
			// 
			// CustomersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1043, 659);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.lblID);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.msPhone);
			this.Controls.Add(this.txtCustomerName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CustomersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customers Form";
			this.Load += new System.EventHandler(this.Customers_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCustomerName;
		private System.Windows.Forms.MaskedTextBox msPhone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvCustomers;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameSurname;
		private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
		private System.Windows.Forms.DataGridViewTextBoxColumn Reservations;
		private System.Windows.Forms.DataGridViewTextBoxColumn AccountPayments;
		private System.Windows.Forms.Label lblID;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label2;
	}
}