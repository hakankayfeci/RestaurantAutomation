using BusinessLayer.Repository.Concrete;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class StaffPasswordUpdateForm : Form
    {
        public string UserText { get; set; }
        public StaffPasswordUpdateForm(string kullanicitext)
        {
            UserText = kullanicitext;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void bntConfirmation_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == "")
            {
                errorProvider1.SetError(txtAnswer, "Güvenlik Cevabınızı Giriniz");
            }
            else
            {
                errorProvider1.Clear();

                StaffBusiness sb = new StaffBusiness();
                var staff = sb.GetByUsername(UserText);
                if (staff.SecurityAnswer == txtAnswer.Text)
                {
                    MessageBox.Show("Güvenlik Cevabınız Doğru", "GÜVENLİK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = true;
					txtAnswer.Visible = false;
					lblUsername.Visible = false;
					lblQuestion.Visible = false;
					label4.Visible = false;
					label6.Visible = false;
					label7.Visible = false;
					btnConfirmation.Visible = false;
					
                }
                else
                {
                    MessageBox.Show("Güvenlik Cevabınız Yanlış", "GÜVENLİK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StaffPasswordUpdateForm_Load(object sender, EventArgs e)
        {
            StaffBusiness sb = new StaffBusiness();
            var staff = sb.GetByUsername(UserText);
            lblQuestion.Text = staff.SecurityQuestion;
            lblUsername.Text = staff.UserName;
            txtNewPassoword.PasswordChar = '*';
            txttxtNewPassowordAgain.PasswordChar = '*';
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassoword.Text) && string.IsNullOrEmpty(txttxtNewPassowordAgain.Text))
            {
                MessageBox.Show("Eksik Veri Girişi Yaptınız ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                StaffBusiness sb = new StaffBusiness();
                var staff = sb.GetByUsername(UserText);
                if (txtNewPassoword.Text == txttxtNewPassowordAgain.Text)
                {

                    staff.Password = txtNewPassoword.Text;
                    sb.Update(staff);
                    MessageBox.Show("Şifreniz Başarıyla Güncellendi \n Yeni Şifreniz= " + txttxtNewPassowordAgain.Text + "");
                    UserLoginForm userLoginForm = new UserLoginForm();
                    userLoginForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Girdiğiniz Şifreler Uyusmadı Kontrol Ediniz ","",MessageBoxButtons.OK,MessageBoxIcon.Question);
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtNewPassoword.PasswordChar = '\0';
                txttxtNewPassowordAgain.PasswordChar = '\0';
            }
            if (checkBox1.Checked == false)
            {
                txtNewPassoword.PasswordChar = '*';
                txttxtNewPassowordAgain.PasswordChar = '*';
            }
        }

        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (txtAnswer.Text == "")
                {
                    errorProvider1.SetError(txtAnswer, "Güvenlik Cevabınızı Giriniz");
                }
                else
                {
                    errorProvider1.Clear();

                    StaffBusiness sb = new StaffBusiness();
                    var staff = sb.GetByUsername(UserText);
                    if (staff.SecurityAnswer == txtAnswer.Text)
                    {
                        MessageBox.Show("Güvenlik Cevabınız Doğru", "GÜVENLİK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel1.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Güvenlik Cevabınız Yanlış", "GÜVENLİK", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Hide();
		}
	}
}
