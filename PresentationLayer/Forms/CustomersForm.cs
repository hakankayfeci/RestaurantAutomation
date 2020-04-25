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
	public partial class CustomersForm : Form
	{
		CustomerBusiness cb = new CustomerBusiness();

		public CustomersForm()
		{
			InitializeComponent();
		}

		private void Customers_Load(object sender, EventArgs e)
		{
			lblID.Visible = false;
			dgvCustomers.DataSource = cb.GetAll();

		}


		private void btnInsert_Click(object sender, EventArgs e)
		{

			if (string.IsNullOrEmpty(txtCustomerName.Text))
			{
				errorProvider1.SetError(txtCustomerName, "Müşteri Adı Girmediniz");
			}

			if (msPhone.Text == "(   )   -  ")
			{
				errorProvider1.SetError(msPhone, "Müşteri Tel No Giriniz");
			}
			else
			{
				cb.Insert(new DataLayer.Customer
				{
					NameSurname = txtCustomerName.Text,
					Phone = msPhone.Text,
				});
				MessageBox.Show(txtCustomerName.Text + " Adlı Müşteri Başarıyla Kaydedildi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			dgvCustomers.DataSource = cb.GetAll();
		}
		private void btnDelete_Click(object sender, EventArgs e)
		{
			DialogResult d = new DialogResult();
			d = MessageBox.Show(txtCustomerName.Text + " Adlı Müşteriyi Silmek İstediğiinizden Emin Misiniz?", " SİLME ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			switch (d)
			{
				case DialogResult.Yes:
					cb.Delete(Convert.ToInt32(lblID.Text));
					MessageBox.Show(txtCustomerName.Text + " Adlı Müşteri Başarıyla Silindi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgvCustomers.DataSource = cb.GetAll();
					break;
				case DialogResult.No:
					break;
				default:
					break;
			}
		}
		private void dgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = dgvCustomers.Rows[e.RowIndex];
			if (selectedRow != null)
			{
				lblID.Text = selectedRow.Cells["CustomerID"].Value.ToString();
				msPhone.Text = selectedRow.Cells["Phone"].Value.ToString();
				txtCustomerName.Text = selectedRow.Cells["NameSurname"].Value.ToString();
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			cb.Update(new DataLayer.Customer
			{
				CustomerID = Convert.ToInt16(lblID.Text),
				NameSurname = txtCustomerName.Text,
				Phone = msPhone.Text
			});
			MessageBox.Show(txtCustomerName.Text + " Adlı Müşteri Başarıyla Güncellendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
			dgvCustomers.DataSource = cb.GetAll();

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

		private void btnSearch_Click(object sender, EventArgs e)
		{

		}
		RestoranDBEntities db = new RestoranDBEntities();
		private void txtSearch_TextChanged(object sender, EventArgs e)
		{

			dgvCustomers.DataSource = db.Customers.Where(x => x.NameSurname.Contains(txtSearch.Text)).ToList();
		}
	}
}
