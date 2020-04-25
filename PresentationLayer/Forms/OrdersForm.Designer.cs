namespace PresentationLayer.Forms
{
	partial class OrdersForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.lblPiece = new System.Windows.Forms.Label();
			this.lblTableNo = new System.Windows.Forms.Label();
			this.btnReady = new System.Windows.Forms.Button();
			this.lblproductName = new System.Windows.Forms.Label();
			this.lblId = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dgvOrders = new System.Windows.Forms.DataGridView();
			this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TableID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductPiece = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductOrder1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductOrders1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbsaat = new System.Windows.Forms.GroupBox();
			this.lblHour = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
			this.gbsaat.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.txtSearch);
			this.groupBox1.Controls.Add(this.lblPiece);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblTableNo);
			this.groupBox1.Controls.Add(this.btnReady);
			this.groupBox1.Controls.Add(this.lblproductName);
			this.groupBox1.Controls.Add(this.lblId);
			this.groupBox1.Controls.Add(this.groupBox2);
			this.groupBox1.Controls.Add(this.gbsaat);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(0, 35);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1502, 714);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Verdana", 12F);
			this.txtSearch.Location = new System.Drawing.Point(758, 49);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(188, 32);
			this.txtSearch.TabIndex = 18;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// lblPiece
			// 
			this.lblPiece.AutoSize = true;
			this.lblPiece.Font = new System.Drawing.Font("Verdana", 13F);
			this.lblPiece.Location = new System.Drawing.Point(373, 43);
			this.lblPiece.Name = "lblPiece";
			this.lblPiece.Size = new System.Drawing.Size(63, 26);
			this.lblPiece.TabIndex = 13;
			this.lblPiece.Text = "Adet";
			// 
			// lblTableNo
			// 
			this.lblTableNo.AutoSize = true;
			this.lblTableNo.Font = new System.Drawing.Font("Verdana", 13F);
			this.lblTableNo.Location = new System.Drawing.Point(442, 42);
			this.lblTableNo.Name = "lblTableNo";
			this.lblTableNo.Size = new System.Drawing.Size(179, 26);
			this.lblTableNo.TabIndex = 12;
			this.lblTableNo.Text = "Masa Numarası";
			// 
			// btnReady
			// 
			this.btnReady.BackColor = System.Drawing.Color.Transparent;
			this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReady.Font = new System.Drawing.Font("Verdana", 12F);
			this.btnReady.ForeColor = System.Drawing.Color.Black;
			this.btnReady.Location = new System.Drawing.Point(971, 34);
			this.btnReady.Name = "btnReady";
			this.btnReady.Size = new System.Drawing.Size(200, 48);
			this.btnReady.TabIndex = 11;
			this.btnReady.Text = "Sipariş Tamamla";
			this.btnReady.UseVisualStyleBackColor = false;
			this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
			// 
			// lblproductName
			// 
			this.lblproductName.AutoSize = true;
			this.lblproductName.Font = new System.Drawing.Font("Verdana", 13F);
			this.lblproductName.Location = new System.Drawing.Point(196, 43);
			this.lblproductName.Name = "lblproductName";
			this.lblproductName.Size = new System.Drawing.Size(141, 26);
			this.lblproductName.TabIndex = 10;
			this.lblproductName.Text = "Sİpariş Adı ";
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Font = new System.Drawing.Font("Verdana", 13F);
			this.lblId.Location = new System.Drawing.Point(12, 43);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(149, 26);
			this.lblId.TabIndex = 10;
			this.lblId.Text = "Sipariş Kodu";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.dgvOrders);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F);
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(3, 91);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(1496, 620);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Siparişler";
			// 
			// dgvOrders
			// 
			this.dgvOrders.BackgroundColor = System.Drawing.Color.White;
			this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.ProductName,
            this.ProductID,
            this.TableID,
            this.Table,
            this.ProductPiece,
            this.OrderNote,
            this.OrderStatus,
            this.ProductOrder1,
            this.ProductOrders1});
			this.dgvOrders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOrders.Location = new System.Drawing.Point(3, 28);
			this.dgvOrders.Name = "dgvOrders";
			this.dgvOrders.RowTemplate.Height = 24;
			this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvOrders.Size = new System.Drawing.Size(1490, 589);
			this.dgvOrders.TabIndex = 0;
			this.dgvOrders.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrders_RowEnter);
			// 
			// OrderID
			// 
			this.OrderID.DataPropertyName = "OrderID";
			this.OrderID.HeaderText = "Sipariş No";
			this.OrderID.Name = "OrderID";
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
			// TableID
			// 
			this.TableID.DataPropertyName = "TableID";
			this.TableID.HeaderText = "Masa No";
			this.TableID.Name = "TableID";
			// 
			// Table
			// 
			this.Table.DataPropertyName = "Table";
			this.Table.HeaderText = "Masa No";
			this.Table.Name = "Table";
			this.Table.Visible = false;
			// 
			// ProductPiece
			// 
			this.ProductPiece.DataPropertyName = "ProductPiece";
			this.ProductPiece.HeaderText = "Ürün Adet";
			this.ProductPiece.Name = "ProductPiece";
			// 
			// OrderNote
			// 
			this.OrderNote.DataPropertyName = "OrderNote";
			this.OrderNote.HeaderText = "Sipariş Notu";
			this.OrderNote.Name = "OrderNote";
			// 
			// OrderStatus
			// 
			this.OrderStatus.DataPropertyName = "OrderStatus";
			this.OrderStatus.HeaderText = "Sipariş Durumu";
			this.OrderStatus.Name = "OrderStatus";
			// 
			// ProductOrder1
			// 
			this.ProductOrder1.DataPropertyName = "ProductOrder1";
			this.ProductOrder1.HeaderText = "ProductOrder1";
			this.ProductOrder1.Name = "ProductOrder1";
			this.ProductOrder1.Visible = false;
			// 
			// ProductOrders1
			// 
			this.ProductOrders1.DataPropertyName = "ProductOrders1";
			this.ProductOrders1.HeaderText = "ProductOrders1";
			this.ProductOrders1.Name = "ProductOrders1";
			this.ProductOrders1.Visible = false;
			// 
			// gbsaat
			// 
			this.gbsaat.Controls.Add(this.lblHour);
			this.gbsaat.Location = new System.Drawing.Point(1199, 24);
			this.gbsaat.Name = "gbsaat";
			this.gbsaat.Size = new System.Drawing.Size(182, 68);
			this.gbsaat.TabIndex = 0;
			this.gbsaat.TabStop = false;
			// 
			// lblHour
			// 
			this.lblHour.AutoSize = true;
			this.lblHour.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.lblHour.Location = new System.Drawing.Point(52, 24);
			this.lblHour.Name = "lblHour";
			this.lblHour.Size = new System.Drawing.Size(61, 25);
			this.lblHour.TabIndex = 0;
			this.lblHour.Text = "Saat";
			this.lblHour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
			this.toolStrip1.Size = new System.Drawing.Size(1502, 32);
			this.toolStrip1.TabIndex = 10;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(149, 29);
			this.toolStripLabel1.Text = "Sipariş Paneli";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.toolStripButton1.ForeColor = System.Drawing.Color.White;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(1250, 1, 0, 2);
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 13F);
			this.label1.Location = new System.Drawing.Point(685, 49);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 26);
			this.label1.TabIndex = 12;
			this.label1.Text = "Ara :";
			// 
			// OrdersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1502, 749);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "OrdersForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Orders Form";
			this.Load += new System.EventHandler(this.Orders_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
			this.gbsaat.ResumeLayout(false);
			this.gbsaat.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbsaat;
		private System.Windows.Forms.Label lblHour;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridView dgvOrders;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Button btnReady;
		private System.Windows.Forms.Label lblproductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
		private System.Windows.Forms.DataGridViewTextBoxColumn TableID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Table;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductPiece;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderNote;
		private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductOrder1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductOrders1;
		private System.Windows.Forms.Label lblPiece;
		private System.Windows.Forms.Label lblTableNo;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Label label1;
	}
}