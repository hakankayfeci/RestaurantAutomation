namespace PresentationLayer.Forms
{
	partial class StaffOrientationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffOrientationForm));
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.tlStaffName = new System.Windows.Forms.ToolStripStatusLabel();
			this.tlTable = new System.Windows.Forms.ToolStripDropDownButton();
			this.masaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.masaAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tlProduct = new System.Windows.Forms.ToolStripDropDownButton();
			this.ürünİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.siparişlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlReservation = new System.Windows.Forms.ToolStripDropDownButton();
			this.rezervasyonİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tlPayment = new System.Windows.Forms.ToolStripDropDownButton();
			this.kasaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tlAdmin = new System.Windows.Forms.ToolStripDropDownButton();
			this.personelAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.finansMuhasebeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.giderİşlemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tlExit = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
			this.statusStrip.Dock = System.Windows.Forms.DockStyle.Top;
			this.statusStrip.Font = new System.Drawing.Font("Verdana", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStaffName,
            this.tlTable,
            this.tlProduct,
            this.tlReservation,
            this.tlPayment,
            this.tlAdmin,
            this.tlExit});
			this.statusStrip.Location = new System.Drawing.Point(0, 0);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.statusStrip.Size = new System.Drawing.Size(1568, 31);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			// 
			// tlStaffName
			// 
			this.tlStaffName.ForeColor = System.Drawing.Color.White;
			this.tlStaffName.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
			this.tlStaffName.Name = "tlStaffName";
			this.tlStaffName.Size = new System.Drawing.Size(137, 26);
			this.tlStaffName.Text = "Kullanıcı Adı";
			// 
			// tlTable
			// 
			this.tlTable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tlTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masaİşlemleriToolStripMenuItem,
            this.masaAyarlarıToolStripMenuItem});
			this.tlTable.ForeColor = System.Drawing.Color.White;
			this.tlTable.Image = ((System.Drawing.Image)(resources.GetObject("tlTable.Image")));
			this.tlTable.ImageTransparentColor = System.Drawing.Color.Black;
			this.tlTable.Margin = new System.Windows.Forms.Padding(10, 2, 0, 0);
			this.tlTable.Name = "tlTable";
			this.tlTable.Size = new System.Drawing.Size(104, 29);
			this.tlTable.Text = "Masalar";
			// 
			// masaİşlemleriToolStripMenuItem
			// 
			this.masaİşlemleriToolStripMenuItem.Name = "masaİşlemleriToolStripMenuItem";
			this.masaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
			this.masaİşlemleriToolStripMenuItem.Text = "Masa İşlemleri";
			this.masaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.masaİşlemleriToolStripMenuItem_Click);
			// 
			// masaAyarlarıToolStripMenuItem
			// 
			this.masaAyarlarıToolStripMenuItem.Name = "masaAyarlarıToolStripMenuItem";
			this.masaAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(236, 30);
			this.masaAyarlarıToolStripMenuItem.Text = "Masa Ayarları";
			this.masaAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.masaAyarlarıToolStripMenuItem_Click);
			// 
			// tlProduct
			// 
			this.tlProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tlProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünİşlemleriToolStripMenuItem1,
            this.siparişlerToolStripMenuItem1});
			this.tlProduct.ForeColor = System.Drawing.Color.White;
			this.tlProduct.Image = ((System.Drawing.Image)(resources.GetObject("tlProduct.Image")));
			this.tlProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlProduct.Margin = new System.Windows.Forms.Padding(10, 2, 0, 0);
			this.tlProduct.Name = "tlProduct";
			this.tlProduct.Size = new System.Drawing.Size(103, 29);
			this.tlProduct.Text = "Ürünler";
			// 
			// ürünİşlemleriToolStripMenuItem1
			// 
			this.ürünİşlemleriToolStripMenuItem1.Name = "ürünİşlemleriToolStripMenuItem1";
			this.ürünİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(235, 30);
			this.ürünİşlemleriToolStripMenuItem1.Text = "Ürün İşlemleri";
			this.ürünİşlemleriToolStripMenuItem1.Click += new System.EventHandler(this.ürünİşlemleriToolStripMenuItem1_Click);
			// 
			// siparişlerToolStripMenuItem1
			// 
			this.siparişlerToolStripMenuItem1.Name = "siparişlerToolStripMenuItem1";
			this.siparişlerToolStripMenuItem1.Size = new System.Drawing.Size(235, 30);
			this.siparişlerToolStripMenuItem1.Text = "Siparişler";
			this.siparişlerToolStripMenuItem1.Click += new System.EventHandler(this.siparişlerToolStripMenuItem1_Click);
			// 
			// tlReservation
			// 
			this.tlReservation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tlReservation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonİşlemleriToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem});
			this.tlReservation.ForeColor = System.Drawing.Color.White;
			this.tlReservation.Image = ((System.Drawing.Image)(resources.GetObject("tlReservation.Image")));
			this.tlReservation.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlReservation.Margin = new System.Windows.Forms.Padding(10, 2, 0, 0);
			this.tlReservation.Name = "tlReservation";
			this.tlReservation.Size = new System.Drawing.Size(155, 29);
			this.tlReservation.Text = "Rezervasyon";
			// 
			// rezervasyonİşlemleriToolStripMenuItem
			// 
			this.rezervasyonİşlemleriToolStripMenuItem.Name = "rezervasyonİşlemleriToolStripMenuItem";
			this.rezervasyonİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
			this.rezervasyonİşlemleriToolStripMenuItem.Text = "Rezervasyon İşlemleri";
			this.rezervasyonİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonİşlemleriToolStripMenuItem_Click_1);
			// 
			// müşteriİşlemleriToolStripMenuItem
			// 
			this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
			this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(314, 30);
			this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
			this.müşteriİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.müşteriİşlemleriToolStripMenuItem_Click);
			// 
			// tlPayment
			// 
			this.tlPayment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tlPayment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kasaİşlemleriToolStripMenuItem});
			this.tlPayment.ForeColor = System.Drawing.Color.White;
			this.tlPayment.Image = ((System.Drawing.Image)(resources.GetObject("tlPayment.Image")));
			this.tlPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlPayment.Margin = new System.Windows.Forms.Padding(10, 2, 0, 0);
			this.tlPayment.Name = "tlPayment";
			this.tlPayment.Size = new System.Drawing.Size(73, 29);
			this.tlPayment.Text = "Kasa";
			// 
			// kasaİşlemleriToolStripMenuItem
			// 
			this.kasaİşlemleriToolStripMenuItem.Name = "kasaİşlemleriToolStripMenuItem";
			this.kasaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(232, 30);
			this.kasaİşlemleriToolStripMenuItem.Text = "Kasa İşlemleri";
			this.kasaİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.kasaİşlemleriToolStripMenuItem_Click_1);
			// 
			// tlAdmin
			// 
			this.tlAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.tlAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelAyarlarıToolStripMenuItem,
            this.finansMuhasebeToolStripMenuItem,
            this.giderİşlemleriToolStripMenuItem1});
			this.tlAdmin.ForeColor = System.Drawing.Color.White;
			this.tlAdmin.Image = ((System.Drawing.Image)(resources.GetObject("tlAdmin.Image")));
			this.tlAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tlAdmin.Margin = new System.Windows.Forms.Padding(10, 2, 0, 0);
			this.tlAdmin.Name = "tlAdmin";
			this.tlAdmin.Size = new System.Drawing.Size(90, 29);
			this.tlAdmin.Text = "Admin";
			// 
			// personelAyarlarıToolStripMenuItem
			// 
			this.personelAyarlarıToolStripMenuItem.Name = "personelAyarlarıToolStripMenuItem";
			this.personelAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.personelAyarlarıToolStripMenuItem.Text = "Personel Ayarları";
			this.personelAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.personelAyarlarıToolStripMenuItem_Click);
			// 
			// finansMuhasebeToolStripMenuItem
			// 
			this.finansMuhasebeToolStripMenuItem.Name = "finansMuhasebeToolStripMenuItem";
			this.finansMuhasebeToolStripMenuItem.Size = new System.Drawing.Size(266, 30);
			this.finansMuhasebeToolStripMenuItem.Text = "Finans-Muhasebe";
			this.finansMuhasebeToolStripMenuItem.Click += new System.EventHandler(this.finansMuhasebeToolStripMenuItem_Click);
			// 
			// giderİşlemleriToolStripMenuItem1
			// 
			this.giderİşlemleriToolStripMenuItem1.Name = "giderİşlemleriToolStripMenuItem1";
			this.giderİşlemleriToolStripMenuItem1.Size = new System.Drawing.Size(266, 30);
			this.giderİşlemleriToolStripMenuItem1.Text = "Gider İşlemleri";
			this.giderİşlemleriToolStripMenuItem1.Click += new System.EventHandler(this.giderİşlemleriToolStripMenuItem1_Click);
			// 
			// tlExit
			// 
			this.tlExit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
			this.tlExit.ForeColor = System.Drawing.Color.White;
			this.tlExit.Margin = new System.Windows.Forms.Padding(750, 3, 0, 2);
			this.tlExit.Name = "tlExit";
			this.tlExit.Size = new System.Drawing.Size(27, 26);
			this.tlExit.Text = "X";
			this.tlExit.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 610);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1568, 30);
			this.statusStrip1.TabIndex = 4;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 12F);
			this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
			this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.Black;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(360, 25);
			this.toolStripStatusLabel1.Text = "Erdo Yazılım © 2019 - Version 1.0";
			// 
			// StaffOrientationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1568, 640);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.statusStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "StaffOrientationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StaffOrientation";
			this.TransparencyKey = System.Drawing.Color.DarkBlue;
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.StaffOrientation_Load);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel tlStaffName;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripDropDownButton tlTable;
		private System.Windows.Forms.ToolStripMenuItem masaİşlemleriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem masaAyarlarıToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton tlProduct;
		private System.Windows.Forms.ToolStripMenuItem ürünİşlemleriToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem1;
		private System.Windows.Forms.ToolStripDropDownButton tlAdmin;
		private System.Windows.Forms.ToolStripDropDownButton tlReservation;
		private System.Windows.Forms.ToolStripMenuItem rezervasyonİşlemleriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton tlPayment;
		private System.Windows.Forms.ToolStripMenuItem personelAyarlarıToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem finansMuhasebeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem giderİşlemleriToolStripMenuItem1;
		private System.Windows.Forms.ToolStripStatusLabel tlExit;
		private System.Windows.Forms.ToolStripMenuItem kasaİşlemleriToolStripMenuItem;
	}
}



