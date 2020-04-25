using BusinessLayer;
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
	public partial class UserLoginForm : Form
	{
		public static Staff staff;


		public UserLoginForm()
		{
			InitializeComponent();
		}

		private void UserLoginForm_Load(object sender, EventArgs e)
		{
			panel1.BackColor = Color.FromArgb(80,0,0,0);
		}
		private void btnExit_Click(object sender, EventArgs e)
		{
			DialogResult d = new DialogResult();
			d = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "ÇIKIŞ ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			switch (d)
			{
				case DialogResult.Yes:
					Application.Exit();
					break;
				case DialogResult.No:
					break;
				default:
					break;
			}
		}
		private void btnGiris_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {
                errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı Ad Girişi Yapmadınız");
            }
             if (string.IsNullOrEmpty(txtSifre.Text))
            {
                errorProvider1.SetError(txtSifre, "Şifre Girişi Yapmadınız");
            }
            else    
            {
                errorProvider1.Clear();
                StaffManagement um = new StaffManagement();

                StaffState state = um.GetUser(txtKullaniciAdi.Text, txtSifre.Text);
                switch (state)
                {
                    case StaffState.UserNotExists:
                        MessageBox.Show("Kullanıcı Adınız veya Şifreniz Hatalı");
                        break;
                    case StaffState.PasswordWrong:
                       
                        break;
                    case StaffState.UsernameWrong:
                       
                        break;
                    case StaffState.UserExists:

						Staff personel = um.GetUserr(txtKullaniciAdi.Text, txtSifre.Text);
                        StaffOrientationForm stf = new StaffOrientationForm(personel);
                        stf.Show();
                        this.Hide();

                        break;
                    default:

                        MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı");
                        break;
                }
            }
			
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				txtSifre.PasswordChar = '\0';
			}
			if (checkBox1.Checked == false)
			{
				txtSifre.PasswordChar = '*';
			}
		}
        string username;
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
            {

                MessageBox.Show("Lütfen kullanıcı adınızı giriniz");
            }
            else
            {
                username = txtKullaniciAdi.Text;
                using (RestoranDBEntities db = new RestoranDBEntities())
                {
                    var userpassword = db.Staffs.Where(u => u.UserName == username).Count();
                    if (userpassword > 0)
                    {
                        StaffPasswordUpdateForm stfu = new StaffPasswordUpdateForm(username);
                        stfu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Böyle bir kullanıcı sistemde kayıtlı değildir");
                    }
                }
            }
		}
        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtKullaniciAdi.Text))
                {
                    errorProvider1.SetError(txtKullaniciAdi, "Kullanıcı Ad Girişi Yapmadınız");
                }
                if (string.IsNullOrEmpty(txtSifre.Text))
                {
                    errorProvider1.SetError(txtSifre, "Şifre Girişi Yapmadınız");
                }
                else
                {
                    errorProvider1.Clear();
                    StaffManagement um = new StaffManagement();

                    StaffState state = um.GetUser(txtKullaniciAdi.Text, txtSifre.Text);
                    switch (state)
                    {
                        case StaffState.UserNotExists:
                            MessageBox.Show("Kullanıcı Adınız veya Şifreniz Hatalı");
                            break;
                        case StaffState.PasswordWrong:
                            MessageBox.Show("Şifreniz Hatalı");
                            break;
                        case StaffState.UsernameWrong:
                            MessageBox.Show("Kullancı Adınız Hatalı");
                            break;
                        case StaffState.UserExists:
						
							Staff personel = um.GetUserr(txtKullaniciAdi.Text, txtSifre.Text);
                            StaffOrientationForm stf = new StaffOrientationForm(personel);
                            stf.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Böyle Bir Kullanıcı Bulunamadı");
                            break;
                    }
                }
            }
        }
    }
}
