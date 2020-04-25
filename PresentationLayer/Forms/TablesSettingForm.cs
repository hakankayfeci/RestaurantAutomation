using BusinessLayer;
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
	public partial class TablesSettingForm : Form
	{
		TableBusiness tb = new TableBusiness();
		public TablesSettingForm()
		{
			InitializeComponent();
		}
        public void Temizle()
        {
            foreach (Control c in gbTableInfo.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = 0;
                }
            }
        }
		
		private void TablesSettingForm_Load(object sender, EventArgs e)
		{
			cmbStatus.Items.Add("True");
			cmbStatus.Items.Add("False");
			txtId.Visible = false;
			dgvTableList.DataSource = tb.GetAll();
            Temizle();
        }
		private void dgvTableList_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = dgvTableList.Rows[e.RowIndex];
			if (selectedRow != null)
			{
				txtId.Text = selectedRow.Cells["TableID"].Value.ToString();
				txtCapacity.Text = selectedRow.Cells["Capacity"].Value.ToString();
				cmbStatus.Text = selectedRow.Cells["Status"].Value.ToString();
			}
		}
		
        private void harfengelleme(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

		private void btnInsert_Click_1(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtCapacity.Text))
			{
				errorProvider1.SetError(txtCapacity, "Kapasite Girmediniz");
			}
			else
			{
				errorProvider1.Clear();

				tb.Insert(new DataLayer.Table
				{
					Capacity = txtCapacity.Text,
					Status = Convert.ToBoolean(cmbStatus.Text),
				});
				MessageBox.Show(txtCapacity.Text + " " + "Kişilik Masa Eklendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
				dgvTableList.DataSource = tb.GetAll();
				Temizle();
			}
		}

		private void btnUpdate_Click_1(object sender, EventArgs e)
		{
			tb.Update(new Table
			{
				TableID = Convert.ToInt32(txtId.Text),
				Capacity = txtCapacity.Text,
				Status = Convert.ToBoolean(cmbStatus.Text)
			});
			MessageBox.Show("Masa Bilgileri Başarıyla Güncellendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
			dgvTableList.DataSource = tb.GetAll();
			Temizle();
		}

		private void btnDelete_Click_1(object sender, EventArgs e)
		{
			DialogResult dialogResult = new DialogResult();
			dialogResult = MessageBox.Show("Masayı Silmek İstediğinden Emin Misin?", "MASA SİLME", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			switch (dialogResult)
			{
				case DialogResult.Yes:
					tb.Delete(Convert.ToInt32(txtId.Text));
					MessageBox.Show("Masa Başarıyla Silindi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
					dgvTableList.DataSource = tb.GetAll();
					Temizle();
					break;
				case DialogResult.No:
					break;
				default:
					break;
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
