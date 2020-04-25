namespace PresentationLayer.Forms
{
	partial class StaffPasswordUpdateForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffPasswordUpdateForm));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.btnConfirmation = new System.Windows.Forms.Button();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.lblUsername = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.bntUpdate = new System.Windows.Forms.Button();
			this.txttxtNewPassowordAgain = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNewPassoword = new System.Windows.Forms.TextBox();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Yeni Şifre";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtAnswer);
			this.groupBox1.Controls.Add(this.btnConfirmation);
			this.groupBox1.Controls.Add(this.lblQuestion);
			this.groupBox1.Controls.Add(this.lblUsername);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(2, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(802, 223);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(251, 133);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.Size = new System.Drawing.Size(205, 32);
			this.txtAnswer.TabIndex = 0;
			// 
			// btnConfirmation
			// 
			this.btnConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirmation.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmation.Image")));
			this.btnConfirmation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnConfirmation.Location = new System.Drawing.Point(534, 51);
			this.btnConfirmation.Name = "btnConfirmation";
			this.btnConfirmation.Size = new System.Drawing.Size(187, 110);
			this.btnConfirmation.TabIndex = 1;
			this.btnConfirmation.Text = "Onayla";
			this.btnConfirmation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConfirmation.UseVisualStyleBackColor = true;
			this.btnConfirmation.Click += new System.EventHandler(this.bntConfirmation_Click);
			// 
			// lblQuestion
			// 
			this.lblQuestion.AutoSize = true;
			this.lblQuestion.Location = new System.Drawing.Point(245, 91);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(60, 25);
			this.lblQuestion.TabIndex = 3;
			this.lblQuestion.Text = "Soru";
			// 
			// lblUsername
			// 
			this.lblUsername.AutoSize = true;
			this.lblUsername.Location = new System.Drawing.Point(246, 51);
			this.lblUsername.Name = "lblUsername";
			this.lblUsername.Size = new System.Drawing.Size(137, 25);
			this.lblUsername.TabIndex = 3;
			this.lblUsername.Text = "Kullanıcı Adı";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(59, 136);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(177, 25);
			this.label7.TabIndex = 3;
			this.label7.Text = "Güvenlik Cevabı";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(59, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(180, 25);
			this.label6.TabIndex = 3;
			this.label6.Text = "Güvenlik Sorusu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(59, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 25);
			this.label4.TabIndex = 3;
			this.label4.Text = "Kullanıcı Adı";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.bntUpdate);
			this.panel1.Controls.Add(this.txttxtNewPassowordAgain);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtNewPassoword);
			this.panel1.Location = new System.Drawing.Point(1, 14);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(790, 202);
			this.panel1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(685, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.BackColor = System.Drawing.Color.Transparent;
			this.checkBox1.Font = new System.Drawing.Font("Verdana", 10F);
			this.checkBox1.ForeColor = System.Drawing.Color.White;
			this.checkBox1.Location = new System.Drawing.Point(214, 145);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(148, 24);
			this.checkBox1.TabIndex = 4;
			this.checkBox1.Text = "Şifreyi Göster";
			this.checkBox1.UseVisualStyleBackColor = false;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 14);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(219, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Yeni Şifrenizi Giriniz";
			// 
			// bntUpdate
			// 
			this.bntUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntUpdate.Image = ((System.Drawing.Image)(resources.GetObject("bntUpdate.Image")));
			this.bntUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.bntUpdate.Location = new System.Drawing.Point(491, 73);
			this.bntUpdate.Name = "bntUpdate";
			this.bntUpdate.Size = new System.Drawing.Size(171, 78);
			this.bntUpdate.TabIndex = 2;
			this.bntUpdate.Text = "Güncelle";
			this.bntUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.bntUpdate.UseVisualStyleBackColor = true;
			this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
			// 
			// txttxtNewPassowordAgain
			// 
			this.txttxtNewPassowordAgain.Location = new System.Drawing.Point(215, 107);
			this.txttxtNewPassowordAgain.Name = "txttxtNewPassowordAgain";
			this.txttxtNewPassowordAgain.Size = new System.Drawing.Size(246, 32);
			this.txttxtNewPassowordAgain.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(191, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Yeni Şifre(Tekrar)";
			// 
			// txtNewPassoword
			// 
			this.txtNewPassoword.Location = new System.Drawing.Point(215, 69);
			this.txtNewPassoword.Name = "txtNewPassoword";
			this.txtNewPassoword.Size = new System.Drawing.Size(246, 32);
			this.txtNewPassoword.TabIndex = 0;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// StaffPasswordUpdateForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(805, 238);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "StaffPasswordUpdateForm";
			this.Load += new System.EventHandler(this.StaffPasswordUpdateForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button bntUpdate;
		private System.Windows.Forms.TextBox txttxtNewPassowordAgain;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNewPassoword;
		private System.Windows.Forms.Label lblQuestion;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnConfirmation;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}