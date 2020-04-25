namespace PresentationLayer.Forms
{
    partial class FinanceAndAccountingForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinanceAndAccountingForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnPrint = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pieChart1 = new LiveCharts.WinForms.PieChart();
			this.dgvList = new System.Windows.Forms.DataGridView();
			this.ExpenseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.StaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpenseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpensePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpenseType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.btnPrint);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.pieChart1);
			this.groupBox1.Controls.Add(this.dgvList);
			this.groupBox1.Location = new System.Drawing.Point(0, 31);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(1299, 669);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnPrint
			// 
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnPrint.ForeColor = System.Drawing.Color.Black;
			this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
			this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnPrint.Location = new System.Drawing.Point(1078, 24);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(140, 111);
			this.btnPrint.TabIndex = 6;
			this.btnPrint.Text = "Yazdır";
			this.btnPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1224, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pieChart1
			// 
			this.pieChart1.Location = new System.Drawing.Point(12, 31);
			this.pieChart1.Name = "pieChart1";
			this.pieChart1.Size = new System.Drawing.Size(1044, 620);
			this.pieChart1.TabIndex = 5;
			this.pieChart1.Text = "pieChart1";
			// 
			// dgvList
			// 
			this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExpenseID,
            this.StaffID,
            this.ExpenseName,
            this.ExpensePrice,
            this.ExpenseType});
			this.dgvList.Location = new System.Drawing.Point(1253, 49);
			this.dgvList.Name = "dgvList";
			this.dgvList.RowTemplate.Height = 24;
			this.dgvList.Size = new System.Drawing.Size(21, 19);
			this.dgvList.TabIndex = 8;
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
			this.ExpenseName.HeaderText = "ExpenseName";
			this.ExpenseName.Name = "ExpenseName";
			// 
			// ExpensePrice
			// 
			this.ExpensePrice.DataPropertyName = "ExpensePrice";
			this.ExpensePrice.HeaderText = "ExpensePrice";
			this.ExpensePrice.Name = "ExpensePrice";
			// 
			// ExpenseType
			// 
			this.ExpenseType.DataPropertyName = "ExpenseType";
			this.ExpenseType.HeaderText = "ExpenseType";
			this.ExpenseType.Name = "ExpenseType";
			// 
			// entityCommand1
			// 
			this.entityCommand1.CommandTimeout = 0;
			this.entityCommand1.CommandTree = null;
			this.entityCommand1.Connection = null;
			this.entityCommand1.EnablePlanCaching = true;
			this.entityCommand1.Transaction = null;
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
			this.toolStrip1.Size = new System.Drawing.Size(1300, 32);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Font = new System.Drawing.Font("Verdana", 10F);
			this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(228, 29);
			this.toolStripLabel1.Text = "Finans - Muhasebe Paneli";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.toolStripButton1.ForeColor = System.Drawing.Color.White;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Margin = new System.Windows.Forms.Padding(880, 1, 0, 2);
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
			this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
			// 
			// FinanceAndAccountingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1300, 703);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "FinanceAndAccountingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FinanceAndAccountingForm";
			this.Load += new System.EventHandler(this.FinanceAndAccountingForm_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private LiveCharts.WinForms.PieChart pieChart1;
		private System.Windows.Forms.Button btnPrint;
		private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
		private System.Windows.Forms.DataGridView dgvList;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseID;
		private System.Windows.Forms.DataGridViewTextBoxColumn StaffID;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpensePrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ExpenseType;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
	}
}