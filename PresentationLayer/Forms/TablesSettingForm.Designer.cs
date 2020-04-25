namespace PresentationLayer.Forms
{
	partial class TablesSettingForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TablesSettingForm));
			this.gbMasaListesi = new System.Windows.Forms.GroupBox();
			this.dgvTableList = new System.Windows.Forms.DataGridView();
			this.TableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Additions = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Reservations = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountPayments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductOrders = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbTableInfo = new System.Windows.Forms.GroupBox();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCapacity = new System.Windows.Forms.TextBox();
			this.txtId = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.gbMasaListesi.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).BeginInit();
			this.gbTableInfo.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbMasaListesi
			// 
			this.gbMasaListesi.Controls.Add(this.dgvTableList);
			this.gbMasaListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gbMasaListesi.ForeColor = System.Drawing.Color.Black;
			this.gbMasaListesi.Location = new System.Drawing.Point(3, 225);
			this.gbMasaListesi.Name = "gbMasaListesi";
			this.gbMasaListesi.Size = new System.Drawing.Size(946, 367);
			this.gbMasaListesi.TabIndex = 12;
			this.gbMasaListesi.TabStop = false;
			this.gbMasaListesi.Text = "Masa Listesi";
			// 
			// dgvTableList
			// 
			this.dgvTableList.AllowUserToAddRows = false;
			this.dgvTableList.AllowUserToResizeColumns = false;
			this.dgvTableList.AllowUserToResizeRows = false;
			this.dgvTableList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvTableList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTableList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTableList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableID,
            this.TableName,
            this.Capacity,
            this.Status,
            this.Additions,
            this.Reservations,
            this.AccountPayments,
            this.ProductOrders});
			this.dgvTableList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvTableList.Location = new System.Drawing.Point(3, 28);
			this.dgvTableList.Name = "dgvTableList";
			this.dgvTableList.RowTemplate.Height = 24;
			this.dgvTableList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTableList.Size = new System.Drawing.Size(940, 336);
			this.dgvTableList.TabIndex = 0;
			this.dgvTableList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTableList_RowEnter);
			// 
			// TableID
			// 
			this.TableID.DataPropertyName = "TableID";
			this.TableID.HeaderText = "Masa No";
			this.TableID.Name = "TableID";
			// 
			// TableName
			// 
			this.TableName.DataPropertyName = "TableName";
			this.TableName.HeaderText = "Masa Adı";
			this.TableName.Name = "TableName";
			this.TableName.Visible = false;
			// 
			// Capacity
			// 
			this.Capacity.DataPropertyName = "Capacity";
			this.Capacity.HeaderText = "Kapasite";
			this.Capacity.Name = "Capacity";
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Durum";
			this.Status.Name = "Status";
			// 
			// Additions
			// 
			this.Additions.DataPropertyName = "Additions";
			this.Additions.HeaderText = "Additions";
			this.Additions.Name = "Additions";
			this.Additions.Visible = false;
			// 
			// Reservations
			// 
			this.Reservations.DataPropertyName = "Reservations";
			this.Reservations.HeaderText = "Reservations";
			this.Reservations.Name = "Reservations";
			this.Reservations.Visible = false;
			// 
			// AccountPayments
			// 
			this.AccountPayments.DataPropertyName = "AccountPayments";
			this.AccountPayments.HeaderText = "AccountPayments";
			this.AccountPayments.Name = "AccountPayments";
			this.AccountPayments.Visible = false;
			// 
			// ProductOrders
			// 
			this.ProductOrders.DataPropertyName = "ProductOrders";
			this.ProductOrders.HeaderText = "ProductOrders";
			this.ProductOrders.Name = "ProductOrders";
			this.ProductOrders.Visible = false;
			// 
			// gbTableInfo
			// 
			this.gbTableInfo.BackColor = System.Drawing.Color.White;
			this.gbTableInfo.Controls.Add(this.txtSearch);
			this.gbTableInfo.Controls.Add(this.btnSearch);
			this.gbTableInfo.Controls.Add(this.cmbStatus);
			this.gbTableInfo.Controls.Add(this.label1);
			this.gbTableInfo.Controls.Add(this.label4);
			this.gbTableInfo.Controls.Add(this.txtCapacity);
			this.gbTableInfo.Controls.Add(this.txtId);
			this.gbTableInfo.ForeColor = System.Drawing.Color.Black;
			this.gbTableInfo.Location = new System.Drawing.Point(0, 16);
			this.gbTableInfo.Name = "gbTableInfo";
			this.gbTableInfo.Size = new System.Drawing.Size(516, 203);
			this.gbTableInfo.TabIndex = 8;
			this.gbTableInfo.TabStop = false;
			this.gbTableInfo.Text = "Masa Bilgileri";
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(199, 99);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(277, 33);
			this.cmbStatus.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(155, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Masa Kapasite";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(111, 102);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "Durum";
			// 
			// txtCapacity
			// 
			this.txtCapacity.Location = new System.Drawing.Point(199, 50);
			this.txtCapacity.Name = "txtCapacity";
			this.txtCapacity.Size = new System.Drawing.Size(277, 32);
			this.txtCapacity.TabIndex = 1;
			this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfengelleme);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(254, 58);
			this.txtId.Multiline = true;
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(13, 17);
			this.txtId.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.gbTableInfo);
			this.groupBox1.Controls.Add(this.btnUpdate);
			this.groupBox1.Controls.Add(this.btnInsert);
			this.groupBox1.Controls.Add(this.gbMasaListesi);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(0, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(952, 595);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.Location = new System.Drawing.Point(561, 163);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(158, 56);
			this.btnDelete.TabIndex = 16;
			this.btnDelete.Text = "Sil";
			this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdate.Location = new System.Drawing.Point(561, 101);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(158, 56);
			this.btnUpdate.TabIndex = 17;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
			// 
			// btnInsert
			// 
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
			this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInsert.Location = new System.Drawing.Point(561, 34);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(158, 56);
			this.btnInsert.TabIndex = 18;
			this.btnInsert.Text = "Ekle";
			this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
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
			this.toolStrip1.Size = new System.Drawing.Size(964, 32);
			this.toolStrip1.TabIndex = 17;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(203, 29);
			this.toolStripLabel1.Text = "Gider Hesap Paneli";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.toolStripButton1.ForeColor = System.Drawing.Color.White;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(650, 1, 0, 2);
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
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(199, 138);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(175, 32);
			this.txtSearch.TabIndex = 20;
			// 
			// btnSearch
			// 
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSearch.Location = new System.Drawing.Point(380, 138);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(96, 48);
			this.btnSearch.TabIndex = 19;
			this.btnSearch.Text = "Ara";
			this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearch.UseVisualStyleBackColor = true;
			// 
			// TablesSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(964, 642);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F);
			this.ForeColor = System.Drawing.Color.White;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "TablesSettingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tables Setting";
			this.Load += new System.EventHandler(this.TablesSettingForm_Load);
			this.gbMasaListesi.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTableList)).EndInit();
			this.gbTableInfo.ResumeLayout(false);
			this.gbTableInfo.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox gbMasaListesi;
		private System.Windows.Forms.GroupBox gbTableInfo;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCapacity;
		private System.Windows.Forms.DataGridView dgvTableList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TableID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TableName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn Additions;
		private System.Windows.Forms.DataGridViewTextBoxColumn Reservations;
		private System.Windows.Forms.DataGridViewTextBoxColumn AccountPayments;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductOrders;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnSearch;
	}
}