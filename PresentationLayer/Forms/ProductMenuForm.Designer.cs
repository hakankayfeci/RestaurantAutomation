namespace PresentationLayer.Forms
{
	partial class ProductMenuForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMenuForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gbProducts = new System.Windows.Forms.GroupBox();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.btnDeleteAddition = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnAddAdditions = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbCategories = new System.Windows.Forms.ComboBox();
			this.txtID = new System.Windows.Forms.TextBox();
			this.lblMasaNo = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lstProduct = new System.Windows.Forms.ListBox();
			this.btnFinishAdditions = new System.Windows.Forms.Button();
			this.lblTotalAdditions = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbProducts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbProducts
			// 
			this.gbProducts.Controls.Add(this.txtNote);
			this.gbProducts.Controls.Add(this.btnDeleteAddition);
			this.gbProducts.Controls.Add(this.dataGridView1);
			this.gbProducts.Controls.Add(this.btnAddAdditions);
			this.gbProducts.Controls.Add(this.numericUpDown1);
			this.gbProducts.Controls.Add(this.label4);
			this.gbProducts.Controls.Add(this.label2);
			this.gbProducts.Controls.Add(this.label1);
			this.gbProducts.Controls.Add(this.cmbCategories);
			this.gbProducts.Controls.Add(this.txtID);
			this.gbProducts.ForeColor = System.Drawing.Color.Black;
			this.gbProducts.Location = new System.Drawing.Point(3, 78);
			this.gbProducts.Margin = new System.Windows.Forms.Padding(4);
			this.gbProducts.Name = "gbProducts";
			this.gbProducts.Padding = new System.Windows.Forms.Padding(4);
			this.gbProducts.Size = new System.Drawing.Size(688, 416);
			this.gbProducts.TabIndex = 0;
			this.gbProducts.TabStop = false;
			this.gbProducts.Text = "Ürünler";
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(157, 316);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(371, 93);
			this.txtNote.TabIndex = 7;
			// 
			// btnDeleteAddition
			// 
			this.btnDeleteAddition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteAddition.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAddition.Image")));
			this.btnDeleteAddition.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDeleteAddition.Location = new System.Drawing.Point(533, 223);
			this.btnDeleteAddition.Name = "btnDeleteAddition";
			this.btnDeleteAddition.Size = new System.Drawing.Size(143, 138);
			this.btnDeleteAddition.TabIndex = 6;
			this.btnDeleteAddition.Text = "Adisyondan Sil";
			this.btnDeleteAddition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnDeleteAddition.UseVisualStyleBackColor = true;
			this.btnDeleteAddition.Click += new System.EventHandler(this.btnDeleteAddition_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductID,
            this.Price});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Location = new System.Drawing.Point(158, 79);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(370, 231);
			this.dataGridView1.TabIndex = 5;
			// 
			// btnAddAdditions
			// 
			this.btnAddAdditions.ForeColor = System.Drawing.Color.Black;
			this.btnAddAdditions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAdditions.Image")));
			this.btnAddAdditions.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAddAdditions.Location = new System.Drawing.Point(533, 79);
			this.btnAddAdditions.Name = "btnAddAdditions";
			this.btnAddAdditions.Size = new System.Drawing.Size(143, 138);
			this.btnAddAdditions.TabIndex = 4;
			this.btnAddAdditions.Text = "Adisyona  Ekle";
			this.btnAddAdditions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAddAdditions.UseVisualStyleBackColor = false;
			this.btnAddAdditions.Click += new System.EventHandler(this.btnAddAdditions_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(533, 41);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(113, 32);
			this.numericUpDown1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(105, 319);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 25);
			this.label4.TabIndex = 1;
			this.label4.Text = "Not";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Ürünler";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kategoriler";
			// 
			// cmbCategories
			// 
			this.cmbCategories.FormattingEnabled = true;
			this.cmbCategories.Location = new System.Drawing.Point(158, 40);
			this.cmbCategories.Name = "cmbCategories";
			this.cmbCategories.Size = new System.Drawing.Size(370, 33);
			this.cmbCategories.TabIndex = 0;
			this.cmbCategories.SelectedIndexChanged += new System.EventHandler(this.cmbCategories_SelectedIndexChanged);
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(614, 130);
			this.txtID.Multiline = true;
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(10, 10);
			this.txtID.TabIndex = 3;
			// 
			// lblMasaNo
			// 
			this.lblMasaNo.AutoSize = true;
			this.lblMasaNo.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
			this.lblMasaNo.Location = new System.Drawing.Point(300, 57);
			this.lblMasaNo.Name = "lblMasaNo";
			this.lblMasaNo.Size = new System.Drawing.Size(110, 26);
			this.lblMasaNo.TabIndex = 1;
			this.lblMasaNo.Text = "MasaNo";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lstProduct);
			this.groupBox1.Controls.Add(this.btnFinishAdditions);
			this.groupBox1.Controls.Add(this.lblTotalAdditions);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(3, 495);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(688, 241);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Adisyon";
			// 
			// lstProduct
			// 
			this.lstProduct.FormattingEnabled = true;
			this.lstProduct.ItemHeight = 25;
			this.lstProduct.Location = new System.Drawing.Point(158, 31);
			this.lstProduct.Name = "lstProduct";
			this.lstProduct.Size = new System.Drawing.Size(370, 154);
			this.lstProduct.TabIndex = 3;
			// 
			// btnFinishAdditions
			// 
			this.btnFinishAdditions.BackColor = System.Drawing.Color.White;
			this.btnFinishAdditions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFinishAdditions.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFinishAdditions.Location = new System.Drawing.Point(533, 31);
			this.btnFinishAdditions.Name = "btnFinishAdditions";
			this.btnFinishAdditions.Size = new System.Drawing.Size(149, 154);
			this.btnFinishAdditions.TabIndex = 2;
			this.btnFinishAdditions.Text = "Adisyonu Bitir";
			this.btnFinishAdditions.UseVisualStyleBackColor = false;
			this.btnFinishAdditions.Click += new System.EventHandler(this.btnFinishAdditions_Click);
			// 
			// lblTotalAdditions
			// 
			this.lblTotalAdditions.AutoSize = true;
			this.lblTotalAdditions.Location = new System.Drawing.Point(50, 71);
			this.lblTotalAdditions.Name = "lblTotalAdditions";
			this.lblTotalAdditions.Size = new System.Drawing.Size(38, 25);
			this.lblTotalAdditions.TabIndex = 1;
			this.lblTotalAdditions.Text = "00";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(-4, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 25);
			this.label3.TabIndex = 0;
			this.label3.Text = "Adisyon Tutarı";
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
			this.toolStrip1.Size = new System.Drawing.Size(728, 32);
			this.toolStrip1.TabIndex = 12;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(67, 29);
			this.toolStripLabel1.Text = "Menü";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.toolStripButton1.ForeColor = System.Drawing.Color.White;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(500, 1, 0, 2);
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
			// ProductName
			// 
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.HeaderText = "Ürün Adı";
			this.ProductName.Name = "ProductName";
			// 
			// ProductID
			// 
			this.ProductID.DataPropertyName = "ProductID";
			this.ProductID.HeaderText = "ProductID";
			this.ProductID.Name = "ProductID";
			this.ProductID.Visible = false;
			// 
			// Price
			// 
			this.Price.DataPropertyName = "Price";
			this.Price.HeaderText = "Fiyat";
			this.Price.Name = "Price";
			// 
			// ProductMenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(728, 742);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblMasaNo);
			this.Controls.Add(this.gbProducts);
			this.Font = new System.Drawing.Font("Verdana", 12F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "ProductMenuForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ProductMenu";
			this.Load += new System.EventHandler(this.ProductMenu_Load);
			this.gbProducts.ResumeLayout(false);
			this.gbProducts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbProducts;
		private System.Windows.Forms.ComboBox cmbCategories;
		private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Button btnAddAdditions;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFinishAdditions;
        private System.Windows.Forms.Label lblTotalAdditions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDeleteAddition;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lstProduct;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
	}
}