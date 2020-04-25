namespace PresentationLayer.Forms
{
	partial class ExpenseForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseForm));
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.cmbType = new System.Windows.Forms.ComboBox();
			this.btnAddExpense = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.ExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpensePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblExpense = new System.Windows.Forms.Label();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Gider Adı ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Türü";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 186);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 25);
			this.label4.TabIndex = 6;
			this.label4.Text = "Fiyat";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(156, 94);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(222, 32);
			this.txtName.TabIndex = 7;
			this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sayiengelleme);
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(156, 179);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(222, 32);
			this.txtPrice.TabIndex = 7;
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.harfengelleme);
			// 
			// cmbType
			// 
			this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbType.FormattingEnabled = true;
			this.cmbType.Items.AddRange(new object[] {
            "Kira",
            "Vergi",
            "Mutfak İhtiyaçları",
            "Faturalar",
            "Personel Maaşları"});
			this.cmbType.Location = new System.Drawing.Point(156, 136);
			this.cmbType.Name = "cmbType";
			this.cmbType.Size = new System.Drawing.Size(222, 33);
			this.cmbType.TabIndex = 8;
			// 
			// btnAddExpense
			// 
			this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddExpense.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAddExpense.Image = ((System.Drawing.Image)(resources.GetObject("btnAddExpense.Image")));
			this.btnAddExpense.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAddExpense.Location = new System.Drawing.Point(406, 94);
			this.btnAddExpense.Name = "btnAddExpense";
			this.btnAddExpense.Size = new System.Drawing.Size(142, 114);
			this.btnAddExpense.TabIndex = 9;
			this.btnAddExpense.Text = "Gider Ekle";
			this.btnAddExpense.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnAddExpense.UseVisualStyleBackColor = true;
			this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dgvList);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.groupBox1.Location = new System.Drawing.Point(0, 242);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(992, 382);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Gider Listesi";
			// 
			// dgvList
			// 
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseID,
            this.StaffID,
            this.ExpenseName,
            this.ExpensePrice,
            this.ExpenseType,
            this.Staff});
			this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvList.Location = new System.Drawing.Point(3, 28);
			this.dgvList.Name = "dgvList";
			this.dgvList.RowTemplate.Height = 24;
			this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvList.Size = new System.Drawing.Size(986, 351);
			this.dgvList.TabIndex = 0;
			// 
			// ExpenseID
			// 
			this.ExpenseID.DataPropertyName = "ExpenseID";
			this.ExpenseID.HeaderText = "Gider No";
			this.ExpenseID.Name = "ExpenseID";
			// 
			// StaffID
			// 
			this.StaffID.DataPropertyName = "StaffID";
			this.StaffID.HeaderText = "StaffID";
			this.StaffID.Name = "StaffID";
			this.StaffID.Visible = false;
			// 
			// ExpenseName
			// 
			this.ExpenseName.DataPropertyName = "ExpenseName";
			this.ExpenseName.HeaderText = "Gider Adı";
			this.ExpenseName.Name = "ExpenseName";
			// 
			// ExpensePrice
			// 
			this.ExpensePrice.DataPropertyName = "ExpensePrice";
			this.ExpensePrice.HeaderText = "Gider Fiyat";
			this.ExpensePrice.Name = "ExpensePrice";
			// 
			// ExpenseType
			// 
			this.ExpenseType.DataPropertyName = "ExpenseType";
			this.ExpenseType.HeaderText = "Gider Türü";
			this.ExpenseType.Name = "ExpenseType";
			// 
			// Staff
			// 
			this.Staff.DataPropertyName = "Staff";
			this.Staff.HeaderText = "Staff";
			this.Staff.Name = "Staff";
			this.Staff.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblExpense);
			this.groupBox2.Location = new System.Drawing.Point(588, 94);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(392, 113);
			this.groupBox2.TabIndex = 11;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Toplam Gider";
			// 
			// lblExpense
			// 
			this.lblExpense.AutoSize = true;
			this.lblExpense.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
			this.lblExpense.Location = new System.Drawing.Point(43, 46);
			this.lblExpense.Name = "lblExpense";
			this.lblExpense.Size = new System.Drawing.Size(191, 29);
			this.lblExpense.TabIndex = 0;
			this.lblExpense.Text = "Toplam Gider";
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
			this.toolStrip1.Size = new System.Drawing.Size(992, 32);
			this.toolStrip1.TabIndex = 12;
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
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(700, 1, 0, 2);
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
			// ExpenseForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(992, 624);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnAddExpense);
			this.Controls.Add(this.cmbType);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ExpenseForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ExpenseForm";
			this.Load += new System.EventHandler(this.ExpenseForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.ComboBox cmbType;
		private System.Windows.Forms.Button btnAddExpense;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblExpense;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseID;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpensePrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseType;
		private System.Windows.Forms.DataGridViewTextBoxColumn Staff;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
	}
}