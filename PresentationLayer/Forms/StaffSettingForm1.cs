using BusinessLayer.Repository.Concrete;
using DataLayer;
using PresentationLayer.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MExcel = Microsoft.Office.Interop.Excel;


namespace PresentationLayer.Forms
{
    public partial class StaffSettingForm1 : Form
    {
        public StaffSettingForm1()
        {
            InitializeComponent();
      
        }
        StaffBusiness sb = new StaffBusiness();
        TitleBusiness tb = new TitleBusiness();
        public void Temizle()
        {
            foreach (Control c in gbStaff.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
                else if (c is DateTimePicker)
                {
                    ((DateTimePicker)c).Value = DateTime.Now;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)c).Clear();
                }
            }
        }
        private void StaffSettingForm1_Load(object sender, EventArgs e)
        {
            linkLabel1.Visible = linkLabel2.Visible = false;
            dtWorkLeavingDate.Enabled = false;

            txtId.Visible = false;

            dgvStaffs.DataSource = sb.Staffs();

            cmbTitle.BindCombobox<Title>("TitleName", "TitleId", tb.GetAll());
            cmbTitle.DataSource = tb.GetTitle();
            txtTcNumber.MaxLength = 11;

            cmbQuestion.Items.Add("En Sevdiğiniz Arkadaşınızın İsmi?");
            cmbQuestion.Items.Add("Hayalinizdeki İş?");
            cmbQuestion.Items.Add("İlkokul Öğretmeninizin Adı?");
            cmbQuestion.Items.Add("İlk Arabanızın Markası?");
            cmbQuestion.Items.Add("Annenizin Kızlık Soyadı?");
            Temizle();
        }
        string username;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbTitle.Text == "Seçiniz...")
            {
                errorProvider1.SetError(cmbTitle, "Ünvan Seçiniz");
            }
            if (txtStaffName.Text == "")
            {
                errorProvider1.SetError(txtStaffName, "Ad Giriniz");
            }
            if (txtStaffLastname.Text == "")
            {
                errorProvider1.SetError(txtStaffLastname, "Soyad Giriniz");
            }
            if (txtUsername.Text == "")
            {
                errorProvider1.SetError(txtUsername, "Kullanıcı Adı Giriniz");
            }
            if (mtxtPhone.Text == "")
            {
                errorProvider1.SetError(mtxtPhone, "Telefon No Giriniz");
            }
            if (txtTcNumber.Text == "")
            {
                errorProvider1.SetError(txtTcNumber, "Tc Giriniz");
            }
            if (cmbQuestion.Text == "")
            {
                errorProvider1.SetError(cmbQuestion, "Güvenlik Sorusu Seçiniz");
            }
            if (txtAnswer.Text == "")
            {
                errorProvider1.SetError(txtAnswer, "Cevap Giriniz");
            }
            if (txtMonthlySalary.Text == "")
            {
                errorProvider1.SetError(txtMonthlySalary, "Maaş Giriniz");
            }
            else
            {
                errorProvider1.Clear();
                username = txtUsername.Text;

                using (RestoranDBEntities db = new RestoranDBEntities())
                {
                    var usercontrol = db.Staffs.Where(s => s.UserName == username).Count();
                    if (usercontrol > 0)
                    {
                        Random rnd = new Random();
                        MessageBox.Show(username + " Adlı kullanıcı sistemde kayıtlıdır başka bir isim deneyiniz");
                        linkLabel1.Visible = linkLabel2.Visible = true;
                        txtUsername.Enabled = true;
                        txtUsername.ForeColor = Color.Red;
                        linkLabel1.Text = txtStaffName.Text + rnd.Next(10, 999).ToString();
                        linkLabel2.Text = txtStaffName.Text + txtStaffLastname.Text + rnd.Next(1, 99).ToString();
                    }
                    else
                    {
                        Random sifre = new Random();
                        int userpassword = sifre.Next(1000, 9999);

                        MemoryStream ms = new MemoryStream();

                        pcStaffPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] resim = ms.GetBuffer();
                        DateTime? zaman = new DateTime();
                        if (rdSkip.Checked)
                        {
                            DateTime? ayrilma = new DateTime();
                            ayrilma = null;
                            zaman = ayrilma;
                        }

                        else
                        {
                            zaman = dtWorkLeavingDate.Value;
                        }
                        string user = txtStaffName.Text + txtStaffLastname.Text;
                        sb.Insert(new Staff
                        {

                            TitleID = cmbTitle.SelectedIndex,
                            FirstName = txtStaffName.Text,
                            LastName = txtStaffLastname.Text,
                            UserName = user,
                            Password = userpassword.ToString(),
                            Phone = mtxtPhone.Text,
                            TcNumber = txtTcNumber.Text,
                            SecurityQuestion = cmbQuestion.Text,
                            SecurityAnswer = txtAnswer.Text,
                            MonthlySalary = Convert.ToDecimal(txtMonthlySalary.Text),

                            WorkDateOfStarting = DateTime.Now,
                            WorkLeavingDate = zaman,
                            StaffImage = resim
                        });
                        MessageBox.Show("Kayıt Başarıyla Oluşturuldu \n Kullanıcı Adınız =" + user + " \n Şifreniz = " + userpassword);
                        dgvStaffs.DataSource = sb.Staffs();
                        Temizle();
                    }
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sb.Update(new Staff
            {
                StaffID = Convert.ToInt16(txtId.Text),
                TitleID = cmbTitle.SelectedIndex,
                FirstName = txtStaffName.Text,
                LastName = txtStaffLastname.Text,
                UserName = txtUsername.Text,
                Phone = mtxtPhone.Text,
                TcNumber = txtTcNumber.Text,
                SecurityQuestion = cmbQuestion.Text,
                SecurityAnswer = txtAnswer.Text,
                MonthlySalary = Convert.ToDecimal(txtMonthlySalary.Text),
                WorkLeavingDate = dtWorkLeavingDate.Value
            });
            dgvStaffs.DataSource = sb.Staffs();
            MessageBox.Show("Personel Bilgileri Başarıyla Güncellendi");
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaffs.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen silmek için bir personel seçiniz");
            }
            else
            {
                DialogResult dialogResult = new DialogResult();
                dialogResult = MessageBox.Show("Personeli Silmek İstediginize Emin misiniz?", "DİKKAT !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        sb.Delete(Convert.ToInt32(txtId.Text));
                        dgvStaffs.DataSource = sb.Staffs();
                        MessageBox.Show("Seçili Personel Silindi");
                        Temizle();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png|Tüm Dosyalar |*.*";
            dosya.ShowDialog();
            string DosyaYolu = dosya.FileName;
            pcStaffPhoto.ImageLocation = DosyaYolu;
        }

        private void rdLeave_CheckedChanged(object sender, EventArgs e)
        {
            if (rdLeave.Checked == true)
                dtWorkLeavingDate.Enabled = true;
            else
                dtWorkLeavingDate.Enabled = false;
        }

        private void dgvStaffs_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvStaffs.Rows[e.RowIndex];
            if (selectedRow != null)
            {
                txtId.Text = selectedRow.Cells["_StaffID"].Value.ToString();
                cmbTitle.Text = selectedRow.Cells["_TitleName"].Value.ToString();
                txtStaffName.Text = selectedRow.Cells["_FirstName"].Value.ToString();
                txtStaffLastname.Text = selectedRow.Cells["_LastName"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["_UserName"].Value.ToString();
                mtxtPhone.Text = selectedRow.Cells["_Phone"].Value.ToString();
                txtTcNumber.Text = selectedRow.Cells["_TcNumber"].Value.ToString();
                cmbQuestion.Text = selectedRow.Cells["_SecurityQuestion"].Value.ToString();
                txtAnswer.Text = selectedRow.Cells["_SecurityAnswer"].Value.ToString();
                txtMonthlySalary.Text = selectedRow.Cells["_MonthlySalary"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Personel Seçmediniz");
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = linkLabel2.Visible = false;
            txtUsername.Text = linkLabel1.Text;
            txtUsername.ForeColor = Color.Green;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Visible = linkLabel2.Visible = false;
            txtUsername.Text = linkLabel2.Text;
            txtUsername.ForeColor = Color.Green;
        }
        private void sayiengelleme(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
             && !char.IsSeparator(e.KeyChar);
        }
        private void harfengelleme(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
	
		private void btnPrint_Click(object sender, EventArgs e)
		{

			MExcel.Application ExcelApp = new MExcel.Application();
			MExcel.Workbook AlbumsBook = ExcelApp.Workbooks.Add(true);
			MExcel.Worksheet ExcelPage = (MExcel.Worksheet)ExcelApp.ActiveSheet;

			ExcelApp.Visible = true;
			int rowNumber = 1;
			ExcelPage.Cells[1, 1] = "Personel No";
			ExcelPage.Cells[1, 2] = "Ünvan";
			ExcelPage.Cells[1, 3] = "Adı";
			ExcelPage.Cells[1, 4] = "Soyadı";
			ExcelPage.Cells[1, 5] = "Kullanıcı Adı";
			ExcelPage.Cells[1, 6] = "Telefon";
			ExcelPage.Cells[1, 7] = "Tc Kimlik No";
			foreach (DataGridViewRow row in dgvStaffs.Rows)
			{
				rowNumber++;
				ExcelPage.Cells[rowNumber, 1] = row.Cells["_StaffID"].Value;
				ExcelPage.Cells[rowNumber, 2] = row.Cells["_TitleName"].Value;
				ExcelPage.Cells[rowNumber, 3] = row.Cells["_FirstName"].Value;
				ExcelPage.Cells[rowNumber, 4] = row.Cells["_LastName"].Value;
				ExcelPage.Cells[rowNumber, 5] = row.Cells["_UserName"].Value;
				ExcelPage.Cells[rowNumber, 6] = row.Cells["_Phone"].Value;
				ExcelPage.Cells[rowNumber, 7] = row.Cells["_TcNumber"].Value;
			}
			ExcelApp.Quit();
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			DialogResult d = new DialogResult();
			d = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "ÇIKIŞ ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			switch (d)
			{
				case DialogResult.Yes:
					this.Hide();
					break;
				case DialogResult.No:
					break;
				default:
					break;
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;

		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			dgvStaffs.DataSource = sb.Staffs().Where(x => x.FirstName.Contains(txtSearch.Text)|| x.LastName.Contains(txtSearch.Text)).ToList();

		}
	}
}
