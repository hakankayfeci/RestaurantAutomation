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
	public partial class ExpenseForm : Form
	{
		RestoranDBEntities db = new RestoranDBEntities();
		public decimal ToplamGider;
		ExpenseBusiness Eb = new ExpenseBusiness();
		public ExpenseForm()
		{
			InitializeComponent();
		}
		
		private void btnAddExpense_Click(object sender, EventArgs e)
		{
			Eb.Add(new DataLayer.Expense
			{
				ExpenseName = txtName.Text,
				ExpensePrice = Convert.ToInt16(txtPrice.Text),
				ExpenseType=cmbType.Text
			});
			MessageBox.Show(txtPrice.Text + " " + "TL lik Gider Eklendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);

			ToplamGider = Convert.ToInt32(db.Expenses.Sum(x => x.ExpensePrice));
			lblExpense.Text = ToplamGider.ToString() + "TL";
			dgvList.DataSource = Eb.GetExpenses();
		}
		private void ExpenseForm_Load(object sender, EventArgs e)
		{
			ToplamGider = Convert.ToInt32(db.Expenses.Sum(x => x.ExpensePrice));
			lblExpense.Text = ToplamGider.ToString()+ "TL";
			dgvList.DataSource = Eb.GetExpenses();
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

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;

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
	}
}
