namespace PresentationLayer.Forms
{
	partial class ProductSettingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSettingForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtProductName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbCategoryName = new System.Windows.Forms.ComboBox();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.gbProductInfo = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.pbProductPhoto = new System.Windows.Forms.PictureBox();
			this.btnSelectPhoto = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txtProductID = new System.Windows.Forms.TextBox();
			this.gbÜrünListe = new System.Windows.Forms.GroupBox();
			this.dgvProductList = new System.Windows.Forms.DataGridView();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.gbProductInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProductPhoto)).BeginInit();
			this.gbÜrünListe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 124);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ürün Adı";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(14, 180);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Fiyatı";
			// 
			// txtProductName
			// 
			this.txtProductName.Location = new System.Drawing.Point(170, 117);
			this.txtProductName.Name = "txtProductName";
			this.txtProductName.Size = new System.Drawing.Size(247, 32);
			this.txtProductName.TabIndex = 1;
			this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sayiengelleme);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(170, 173);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(247, 32);
			this.txtPrice.TabIndex = 2;
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfengelleme);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 63);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "Kategori Adı  ";
			// 
			// cmbCategoryName
			// 
			this.cmbCategoryName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbCategoryName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbCategoryName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategoryName.FormattingEnabled = true;
			this.cmbCategoryName.Location = new System.Drawing.Point(170, 60);
			this.cmbCategoryName.Name = "cmbCategoryName";
			this.cmbCategoryName.Size = new System.Drawing.Size(247, 33);
			this.cmbCategoryName.TabIndex = 0;
			// 
			// cmbStatus
			// 
			this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(170, 229);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(247, 33);
			this.cmbStatus.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 237);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 25);
			this.label4.TabIndex = 0;
			this.label4.Text = "Durum";
			// 
			// gbProductInfo
			// 
			this.gbProductInfo.Controls.Add(this.txtSearch);
			this.gbProductInfo.Controls.Add(this.pbProductPhoto);
			this.gbProductInfo.Controls.Add(this.btnSelectPhoto);
			this.gbProductInfo.Controls.Add(this.btnInsert);
			this.gbProductInfo.Controls.Add(this.btnUpdate);
			this.gbProductInfo.Controls.Add(this.btnDelete);
			this.gbProductInfo.Controls.Add(this.label3);
			this.gbProductInfo.Controls.Add(this.cmbStatus);
			this.gbProductInfo.Controls.Add(this.label1);
			this.gbProductInfo.Controls.Add(this.cmbCategoryName);
			this.gbProductInfo.Controls.Add(this.label2);
			this.gbProductInfo.Controls.Add(this.txtPrice);
			this.gbProductInfo.Controls.Add(this.label5);
			this.gbProductInfo.Controls.Add(this.label4);
			this.gbProductInfo.Controls.Add(this.txtProductName);
			this.gbProductInfo.Controls.Add(this.txtProductID);
			this.gbProductInfo.ForeColor = System.Drawing.Color.Black;
			this.gbProductInfo.Location = new System.Drawing.Point(6, 15);
			this.gbProductInfo.Name = "gbProductInfo";
			this.gbProductInfo.Size = new System.Drawing.Size(1115, 317);
			this.gbProductInfo.TabIndex = 3;
			this.gbProductInfo.TabStop = false;
			this.gbProductInfo.Text = "Ürün Bilgileri";
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(810, 203);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(193, 32);
			this.txtSearch.TabIndex = 18;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// pbProductPhoto
			// 
			this.pbProductPhoto.Location = new System.Drawing.Point(460, 83);
			this.pbProductPhoto.Name = "pbProductPhoto";
			this.pbProductPhoto.Size = new System.Drawing.Size(197, 171);
			this.pbProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbProductPhoto.TabIndex = 9;
			this.pbProductPhoto.TabStop = false;
			// 
			// btnSelectPhoto
			// 
			this.btnSelectPhoto.BackColor = System.Drawing.Color.White;
			this.btnSelectPhoto.ForeColor = System.Drawing.Color.Black;
			this.btnSelectPhoto.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectPhoto.Image")));
			this.btnSelectPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSelectPhoto.Location = new System.Drawing.Point(460, 31);
			this.btnSelectPhoto.Name = "btnSelectPhoto";
			this.btnSelectPhoto.Size = new System.Drawing.Size(200, 46);
			this.btnSelectPhoto.TabIndex = 4;
			this.btnSelectPhoto.Text = "Resim Seç ";
			this.btnSelectPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSelectPhoto.UseVisualStyleBackColor = false;
			this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
			// 
			// btnInsert
			// 
			this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
			this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInsert.Location = new System.Drawing.Point(734, 31);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(127, 80);
			this.btnInsert.TabIndex = 5;
			this.btnInsert.Text = "Ekle";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdate.Location = new System.Drawing.Point(734, 117);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(269, 80);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDelete.Location = new System.Drawing.Point(867, 31);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(136, 80);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(740, 206);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 25);
			this.label5.TabIndex = 0;
			this.label5.Text = "Ara :";
			// 
			// txtProductID
			// 
			this.txtProductID.Location = new System.Drawing.Point(310, 67);
			this.txtProductID.Multiline = true;
			this.txtProductID.Name = "txtProductID";
			this.txtProductID.Size = new System.Drawing.Size(10, 10);
			this.txtProductID.TabIndex = 9;
			// 
			// gbÜrünListe
			// 
			this.gbÜrünListe.Controls.Add(this.dgvProductList);
			this.gbÜrünListe.ForeColor = System.Drawing.Color.Black;
			this.gbÜrünListe.Location = new System.Drawing.Point(3, 338);
			this.gbÜrünListe.Name = "gbÜrünListe";
			this.gbÜrünListe.Size = new System.Drawing.Size(1121, 387);
			this.gbÜrünListe.TabIndex = 5;
			this.gbÜrünListe.TabStop = false;
			this.gbÜrünListe.Text = "Ürün Listesi";
			// 
			// dgvProductList
			// 
			this.dgvProductList.AllowUserToAddRows = false;
			this.dgvProductList.AllowUserToResizeColumns = false;
			this.dgvProductList.AllowUserToResizeRows = false;
			this.dgvProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvProductList.BackgroundColor = System.Drawing.Color.White;
			this.dgvProductList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.CategoryID,
            this.CategoryName,
            this.ProductName,
            this.Price,
            this.Status,
            this.ProductImage});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProductList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvProductList.GridColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvProductList.Location = new System.Drawing.Point(3, 28);
			this.dgvProductList.Name = "dgvProductList";
			this.dgvProductList.ReadOnly = true;
			this.dgvProductList.RowTemplate.Height = 24;
			this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvProductList.Size = new System.Drawing.Size(1115, 356);
			this.dgvProductList.TabIndex = 0;
			this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_CellContentClick);
			this.dgvProductList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductList_RowEnter);
			// 
			// ProductID
			// 
			this.ProductID.DataPropertyName = "ProductID";
			this.ProductID.HeaderText = "Ürün No";
			this.ProductID.Name = "ProductID";
			this.ProductID.ReadOnly = true;
			// 
			// CategoryID
			// 
			this.CategoryID.DataPropertyName = "CategoryID";
			this.CategoryID.HeaderText = "Kategori No";
			this.CategoryID.Name = "CategoryID";
			this.CategoryID.ReadOnly = true;
			this.CategoryID.Visible = false;
			// 
			// CategoryName
			// 
			this.CategoryName.DataPropertyName = "CategoryName";
			this.CategoryName.HeaderText = "Kategori";
			this.CategoryName.Name = "CategoryName";
			this.CategoryName.ReadOnly = true;
			// 
			// ProductName
			// 
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.HeaderText = "Ürün Adı";
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			this.Price.HeaderText = "Fiyat";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			// 
			// Status
			// 
			this.Status.DataPropertyName = "Status";
			this.Status.HeaderText = "Durum";
			this.Status.Name = "Status";
			this.Status.ReadOnly = true;
			// 
			// ProductImage
			// 
			this.ProductImage.DataPropertyName = "ProductImage";
			this.ProductImage.HeaderText = "Ürün Resmi";
			this.ProductImage.Name = "ProductImage";
			this.ProductImage.ReadOnly = true;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.gbÜrünListe);
			this.groupBox1.Controls.Add(this.gbProductInfo);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(0, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1127, 696);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
			this.toolStrip1.Size = new System.Drawing.Size(1127, 32);
			this.toolStrip1.TabIndex = 13;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(225, 29);
			this.toolStripLabel1.Text = "Ürün İşlemleri Paneli";
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
			this.toolStripButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.toolStripButton2.ForeColor = System.Drawing.Color.White;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(31, 29);
			this.toolStripButton2.Text = "X";
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
			// 
			// ProductSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1127, 731);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ProductSettingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProductSetting";
			this.Load += new System.EventHandler(this.ProductSettingForm_Load);
			this.gbProductInfo.ResumeLayout(false);
			this.gbProductInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbProductPhoto)).EndInit();
			this.gbÜrünListe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProductName;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbCategoryName;
		private System.Windows.Forms.ComboBox cmbStatus;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox gbProductInfo;
		private System.Windows.Forms.GroupBox gbÜrünListe;
		private System.Windows.Forms.DataGridView dgvProductList;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pbProductPhoto;
		private System.Windows.Forms.Button btnSelectPhoto;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
		private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Status;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductImage;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label5;
	}
}