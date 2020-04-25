using BusinessLayer.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentationLayer.Extensions;
using DataLayer;

namespace PresentationLayer.Forms
{
	public partial class ReservationForm : Form
	{
		public ReservationForm()
		{
			InitializeComponent();
		}
		private int selectedIndex;
		ReservationBusiness rb = new ReservationBusiness();
		CustomerBusiness cb = new CustomerBusiness();
		TableBusiness tb = new TableBusiness();
		public void Temizle()
		{
			foreach (Control c in groupBox2.Controls)
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
				else if (c is MaskedTextBox)
				{
					((MaskedTextBox)c).Clear();
				}
			}
		}
	
		private void btnUpdate_Click(object sender, EventArgs e)
		{
			rb.Update(new DataLayer.Reservation
			{
				ReservationDate = dtDate.Value,
				PersonCount = Convert.ToInt32(txtPersonCount.Text),
				ReservationNote = txtComment.Text,
				TableID = cmbTableNumber.SelectedIndex,
				ReservationID = Convert.ToInt32(txtid.Text)

			});
			dgvRezerve.DataSource = rb.Reservations();
		}

		private void ReservationForm_Load(object sender, EventArgs e)
		{
			dgvRezerve.ClearSelection();
			dgvRezerve.DataSource = rb.Reservations();
			cmbCustomerSearch.BindCombobox<Customer>("NameSurname", "CustomerID", cb.GetAll());
			cmbTableNumber.BindCombobox<Table>("TableID", "TableID", tb.GetAll());
			dgvRezerve.Rows[selectedIndex].Selected = false;
			Temizle();
		}

		private void harfengelleme(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void sayiengelleme(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
			  && !char.IsSeparator(e.KeyChar);
		}
		
		private void btnInsert_Click_1(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(msPhone.Text))
			{
				errorProvider1.SetError(msPhone, "Telefon No Giriniz");
			}
			if (string.IsNullOrEmpty(cmbTableNumber.Text))
			{
				errorProvider1.SetError(cmbTableNumber, "Masa No Seçiniz");
			}
			if (string.IsNullOrEmpty(txtPersonCount.Text))
			{
				errorProvider1.SetError(txtPersonCount, "Kişi Sayısı Giriniz");
			}
			if (string.IsNullOrEmpty(txtComment.Text))
			{
				errorProvider1.SetError(txtComment, "Açıklama Yazınız");
			}
			else
			{
				errorProvider1.Clear();
				
				rb.Insert(new DataLayer.Reservation
				{
					CustomerID = Convert.ToInt32(cmbCustomerSearch.SelectedValue),
					Phone = msPhone.Text,
					ReservationDate = dtDate.Value,
					TableID = Convert.ToInt32(cmbTableNumber.SelectedValue),
					PersonCount = Convert.ToInt32(txtPersonCount.Text),
					ReservationNote = txtComment.Text,
					Status = Convert.ToBoolean(cmbStatus.Text)
				});
				dgvRezerve.DataSource = rb.Reservations();
				MessageBox.Show("Rezervasyon Başarıyla Oluşturuldu", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);			
				Temizle();
			}
		}
		private void dgvRezerve_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = dgvRezerve.Rows[e.RowIndex];
			selectedIndex = e.RowIndex;
			if (selectedRow != null)
			{
				txtid.Text = selectedRow.Cells["ReservationID"].Value.ToString();
				cmbCustomerSearch.Text = selectedRow.Cells["Customer"].Value.ToString();
				msPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
				dtDate.Text = selectedRow.Cells["ReservationDate"].Value.ToString();
				cmbTableNumber.Text = selectedRow.Cells["TableID"].Value.ToString();
				txtPersonCount.Text = selectedRow.Cells["PersonCount"].Value.ToString();
				txtComment.Text = selectedRow.Cells["ReservationNote"].Value.ToString();
				cmbStatus.Text = selectedRow.Cells["Status"].Value.ToString();
			}
			else
			{
				MessageBox.Show("Personel Seçmediniz");
			}
		}
		private void btnNewCustomer_Click(object sender, EventArgs e)
		{
			CustomersForm cf = new CustomersForm();
			cf.MdiParent = StaffOrientationForm.ActiveForm;
			cf.Show();

		}
		private void tlMinimized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;

		}
		private void tlExit_Click(object sender, EventArgs e)
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
		private void btnUpdate_Click_1(object sender, EventArgs e)
		{
			rb.Update(new DataLayer.Reservation
			{
				CustomerID = Convert.ToInt32(cmbCustomerSearch.SelectedValue),
				Phone = msPhone.Text,
				ReservationDate = dtDate.Value,
				TableID = Convert.ToInt32(cmbTableNumber.SelectedIndex),
				PersonCount = Convert.ToInt32(txtPersonCount.Text),
				ReservationNote = txtComment.Text,
				ReservationID=Convert.ToInt16(txtid.Text),
				Status = Convert.ToBoolean(cmbStatus.Text)
			});
			dgvRezerve.DataSource = rb.Reservations();
			MessageBox.Show("Rezervasyon Başarıyla Güncellendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Temizle();
		}
	

		private void btnDelete_Click_1(object sender, EventArgs e)
		{
			rb.Delete(Convert.ToInt32(txtid.Text));
			dgvRezerve.DataSource = rb.GetAll();

		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			dgvRezerve.DataSource = rb.Reservations().Where(x => x.Customer.Contains(txtSearch.Text)).ToList();

		}

	}
}
