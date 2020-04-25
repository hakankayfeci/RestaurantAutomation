namespace PresentationLayer.Forms
{
	partial class UserLoginForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
			this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
			this.txtSifre = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnGiris = new System.Windows.Forms.Button();
			this.btnCikis = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtKullaniciAdi
			// 
			this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.txtKullaniciAdi.Location = new System.Drawing.Point(365, 107);
			this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4);
			this.txtKullaniciAdi.Multiline = true;
			this.txtKullaniciAdi.Name = "txtKullaniciAdi";
			this.txtKullaniciAdi.Size = new System.Drawing.Size(322, 32);
			this.txtKullaniciAdi.TabIndex = 0;
			this.txtKullaniciAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtKullaniciAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
			// 
			// txtSifre
			// 
			this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.txtSifre.Location = new System.Drawing.Point(365, 173);
			this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
			this.txtSifre.Multiline = true;
			this.txtSifre.Name = "txtSifre";
			this.txtSifre.PasswordChar = '*';
			this.txtSifre.Size = new System.Drawing.Size(322, 32);
			this.txtSifre.TabIndex = 1;
			this.txtSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtSifre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-21, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(418, 342);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnGiris
			// 
			this.btnGiris.BackColor = System.Drawing.Color.White;
			this.btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnGiris.CausesValidation = false;
			this.btnGiris.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnGiris.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGiris.ForeColor = System.Drawing.Color.Black;
			this.btnGiris.Location = new System.Drawing.Point(365, 247);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(182, 67);
			this.btnGiris.TabIndex = 2;
			this.btnGiris.Text = "Giriş Yap";
			this.btnGiris.UseVisualStyleBackColor = false;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// btnCikis
			// 
			this.btnCikis.BackColor = System.Drawing.Color.White;
			this.btnCikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCikis.CausesValidation = false;
			this.btnCikis.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnCikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCikis.ForeColor = System.Drawing.Color.Black;
			this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCikis.Location = new System.Drawing.Point(554, 247);
			this.btnCikis.Name = "btnCikis";
			this.btnCikis.Size = new System.Drawing.Size(133, 67);
			this.btnCikis.TabIndex = 3;
			this.btnCikis.Text = "Çıkış";
			this.btnCikis.UseVisualStyleBackColor = false;
			this.btnCikis.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gray;
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.btnGiris);
			this.panel1.Controls.Add(this.btnCikis);
			this.panel1.Controls.Add(this.txtKullaniciAdi);
			this.panel1.Controls.Add(this.txtSifre);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(402, 242);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(736, 345);
			this.panel1.TabIndex = 4;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 10F);
			this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.linkLabel1.LinkColor = System.Drawing.Color.White;
			this.linkLabel1.Location = new System.Drawing.Point(534, 216);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(153, 20);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Şifremi Unuttum";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Font = new System.Drawing.Font("Verdana", 10F);
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(365, 212);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(148, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Şifreyi Göster";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(360, 147);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Şifre ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 22F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(380, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(296, 45);
			this.label1.TabIndex = 5;
			this.label1.Text = "Sisteme Giriş";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(360, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 25);
			this.label2.TabIndex = 5;
			this.label2.Text = "Kullanıcı Adı ";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// UserLoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(59)))), ((int)(((byte)(67)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1312, 713);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "UserLoginForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UserLoginForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.UserLoginForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtKullaniciAdi;
		private System.Windows.Forms.TextBox txtSifre;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.Button btnCikis;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}