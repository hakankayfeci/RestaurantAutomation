using BusinessLayer;
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

namespace PresentationLayer.Forms
{
	public partial class ProductSettingForm : Form
	{
		public ProductSettingForm()
		{
			InitializeComponent();
		}
		ProductBusiness pb = new ProductBusiness();
		CategoryBusiness cb = new CategoryBusiness();
		RestoranDBEntities db = new RestoranDBEntities();

		public void Temizle()
		{
			foreach (Control c in gbProductInfo.Controls)
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
		
		private void btnInsert_Click(object sender, EventArgs e)
		{
			if (cmbCategoryName.Text == "Seçiniz...")
			{
				errorProvider1.SetError(cmbCategoryName, "Kategori Seçmediniz");
			}
			if (string.IsNullOrEmpty(txtProductName.Text))
			{
				errorProvider1.SetError(txtProductName, "Ürün Adı Girmediniz");
			}
			if (string.IsNullOrEmpty(txtPrice.Text))
			{
				errorProvider1.SetError(txtPrice, "Ürün Fiyatı Girmediniz");
			}
			else
			{
				errorProvider1.Clear();
				MemoryStream ms = new MemoryStream();
				pbProductPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				byte[] resim = ms.GetBuffer();

				pb.Insert(new Product
				{
					CategoryID = cmbCategoryName.SelectedIndex,
					ProductName = txtProductName.Text,
					Price = txtPrice.Text.ToString(),
					Status = Convert.ToBoolean(cmbStatus.Text),
					ProductImage = resim
				});
				dgvProductList.DataSource = pb.Products();
				MessageBox.Show("Ürün Başarıyla Eklendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Temizle();
			}
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			Temizle();
		}
		private void ProductSettingForm_Load(object sender, EventArgs e)
		{

			cmbStatus.Items.Add("True");
			cmbStatus.Items.Add("False");
			txtProductID.Visible = false;
			dgvProductList.DataSource = pb.Products();

			cmbCategoryName.BindCombobox<Category>("CategoryName", "CategoryId", (cb.GetAll()));

			cmbCategoryName.DataSource = cb.GetCategory();
		}
		private void btnSelectPhoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog dosya = new OpenFileDialog();
			dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png|Tüm Dosyalar |*.*";
			dosya.ShowDialog();
			string DosyaYolu = dosya.FileName;
			pbProductPhoto.ImageLocation = DosyaYolu;
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

		private void btnUpdate_Click(object sender, EventArgs e)
		{

			MemoryStream ms = new MemoryStream();
			pbProductPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
			byte[] resim = ms.GetBuffer();

			pb.Update(new Product
			{
				ProductID = Convert.ToInt32(txtProductID.Text),
				CategoryID = cmbCategoryName.SelectedIndex,
				ProductName = txtProductName.Text,
				Price = txtPrice.Text,
				Status = Convert.ToBoolean(cmbStatus.Text),
				ProductImage = resim
			});
			MessageBox.Show("Ürün Başarıyla Güncellendi");
			dgvProductList.DataSource = pb.Products();

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvProductList.SelectedRows.Count <= 0)
			{
				MessageBox.Show("Lütfen silmek için bir ürün seçiniz");
			}
			else
			{
				DialogResult dialogResult = new DialogResult();
				dialogResult = MessageBox.Show("Ürünü Silmek İstediginize Emin misiniz?", "DİKKAT !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				switch (dialogResult)
				{
					case DialogResult.None:
						break;
					case DialogResult.OK:
						break;
					case DialogResult.Cancel:
						break;
					case DialogResult.Abort:
						break;
					case DialogResult.Retry:
						break;
					case DialogResult.Ignore:
						break;
					case DialogResult.Yes:
						pb.Delete(Convert.ToInt32(txtProductID.Text));
						dgvProductList.DataSource = pb.Products();
						MessageBox.Show("Seçili Ürün Silindi");
						Temizle();
						break;
					case DialogResult.No:
						break;
					default:
						break;
				}
			}
		}

		public static Bitmap ByteToImage(byte[] blob)
		{
			MemoryStream mStream = new MemoryStream();
			byte[] pData = blob;
			mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
			Bitmap bm = new Bitmap(mStream, false);
			mStream.Dispose();
			return bm;
		}
		private void dgvProductList_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = dgvProductList.Rows[e.RowIndex];
			if (selectedRow != null)
			{
				txtProductID.Text = selectedRow.Cells["ProductID"].Value.ToString();
				cmbCategoryName.Text = selectedRow.Cells["CategoryName"].Value.ToString();
				txtProductName.Text = selectedRow.Cells["ProductName"].Value.ToString();
				txtPrice.Text = selectedRow.Cells["Price"].Value.ToString();
				cmbStatus.Text = selectedRow.Cells["Status"].Value.ToString();
				byte[] buffer = (byte[])selectedRow.Cells["ProductImage"].Value;
				pbProductPhoto.Image = ByteToImage(buffer);
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

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			dgvProductList.DataSource = pb.Products().Where(x => x.ProductName.Contains(txtSearch.Text)).ToList();

		}

		private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
