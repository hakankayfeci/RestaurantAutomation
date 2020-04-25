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
	public partial class PaymentForm : Form
	{
		AdditionBusiness ab = new AdditionBusiness();
		AccountPaymentBusiness apb = new AccountPaymentBusiness();
		Addition _Addition = new Addition();
		Addition _Table = new Addition();
		public PaymentForm(Addition addition, Addition table)
		{
			_Addition = addition;
			_Table = table;
			InitializeComponent();
		}

		private void PaymentForm_Load(object sender, EventArgs e)
		{
			timer1.Start();
			txtTableNo.Enabled = false;
			txtId.Visible = false;
			dgvPayment.DataSource = apb.AccountPayments();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			lbldate.Text = DateTime.Now.ToString();
		}
		int kod;
		
		private void btnPay_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPayCode.Text))
			{
				MessageBox.Show("Ödeme Kodu giriniz ");
			}
			else if (rdCash.Checked == false && rdCard.Checked == false)
			{
				MessageBox.Show("Ödeme Türü Seçiniz");
			}
			else
			{
				string paymenttype;

				if (rdCash.Checked)
				{
					paymenttype = rdCash.Text;
				}
				else
				{
					paymenttype = rdCard.Text;
				}

				apb.Insert(new DataLayer.AccountPayment
				{   CustomerID=1,
				   
					TableID = Convert.ToInt16(txtTableNo.Text),
					AdditionID = _Addition.AdditionID,
					TotalAmount = Convert.ToInt32(lblTotalAmount.Text),
					PaymentType = paymenttype,
					PaymentDate = System.DateTime.Now,
					AccountStatus = false
				});
				MessageBox.Show("Hesap Başarıyla Ödendi","ONAY",MessageBoxButtons.OK,MessageBoxIcon.Information);
				dgvPayment.DataSource = apb.AccountPayments();

			}
		}
		private void harfengelleme(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

		}
		private void btnSearch_Click(object sender, EventArgs e)
		{
			kod = Convert.ToInt16(txtPayCode.Text);
			using (RestoranDBEntities db = new RestoranDBEntities())
			{
				var kodkontrol = db.Additions.Where(a => a.PaymentCode == kod).Count();
				if (kodkontrol>0)
				{
					MessageBox.Show("Hesap Başarıyla Getirildi","ONAY",MessageBoxButtons.OK,MessageBoxIcon.Information);
					txtTableNo.Text =_Table.TableID.ToString();
					lblTotalAmount.Text = _Addition.TotalPrice.ToString();
					txtId.Text = _Table.TableID.ToString();
				}
				else
				{
					MessageBox.Show("Böyle Bir Kod Bulunmamaktadır"," ",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				}
			}
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
	}
}
