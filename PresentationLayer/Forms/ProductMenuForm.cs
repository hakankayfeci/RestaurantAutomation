using BusinessLayer;
using BusinessLayer.Repository.Concrete;
using DataLayer;
using PresentationLayer.Extensions;
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
    public partial class ProductMenuForm : Form
    {
		public TablesForm _tablesForm;
        public ProductMenuForm(TablesForm Form)
        {
            this._tablesForm = Form;
            InitializeComponent();
        }
        private ProductBusiness pb = new ProductBusiness();
        CategoryBusiness cb = new CategoryBusiness();
        ProductTableBusiness ptb = new ProductTableBusiness();
		ProductOrderBusiness pob = new ProductOrderBusiness();
		AdditionBusiness ab = new AdditionBusiness();
		TableBusiness tb = new TableBusiness();
		StaffOrientationForm sof = new StaffOrientationForm(new Staff());
		public string d;

		private void ProductMenu_Load(object sender, EventArgs e)
        {
			txtID.Visible = false;
            Addition isvalidadition = ab.GetByTableId(_tablesForm.SelectedTable.TableID);
			//var deger = pb.Products();
			//foreach (var item in deger)
			//{
			//	lstProduct.Items.Add(item.ProductName);

			//}
			if (isvalidadition!=null)
            {
                lblTotalAdditions.Text = isvalidadition.TotalPrice.ToString();
            }
            lblMasaNo.Text = string.Format("{0} Nolu Masa Şiparişleri", _tablesForm.SelectedTable.TableID);
            cmbCategories.Items.Add("Seçiniz..");
            cmbCategories.BindCombobox<Category>("CategoryName", "CategoryId", (cb.GetAll()));
            cmbCategories.DataSource = cb.GetCategory();
        }

        private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var product = pb.GetCategoryProducts(cmbCategories.SelectedIndex);
            foreach (var item in product)
            {
                dataGridView1.Rows.Add(item.ProductName, item.Price);
            }
        }
        private void btnAddAdditions_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count<=0)
			{
				DialogResult xxx = MessageBox.Show("Lütfen Ürün Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			else if (numericUpDown1.Value==0)
			{	
				DialogResult xx = MessageBox.Show("Lütfen Ürün Adedi Belirtiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				Addition isvalidadition = ab.GetByTableId(_tablesForm.SelectedTable.TableID);

				if (isvalidadition != null)
				{
				    lblTotalAdditions.Text = isvalidadition.TotalPrice.ToString();
				}
				int a = dataGridView1.SelectedCells[0].RowIndex;
				DataGridViewRow selectedRow = dataGridView1.Rows[a];
				 d = selectedRow.Cells["ProductName"].Value.ToString();
				 
				lstProduct.Items.Add(d);
				var x = pb.GetAll().Where(s => s.ProductName == d).First();
				int adet = Convert.ToInt16(numericUpDown1.Value);
				int toplam = (Convert.ToInt16(x.Price) * adet);
				string productPrice = selectedRow.Cells["Price"].Value.ToString();

				if (isvalidadition!=null)
				{
				    if (isvalidadition.Status == true)
				    {
				        int? masaAdisyonu = 0;
				        masaAdisyonu += isvalidadition.TotalPrice+toplam;
				        lblTotalAdditions.Text = masaAdisyonu.ToString();

				        ab.Update(new Addition
				        {
				            Status=true,
				            TableID = isvalidadition.TableID,
				            AdditionID = isvalidadition.AdditionID,
				            AdditionDate = isvalidadition.AdditionDate,
				            TotalPrice = masaAdisyonu
				        });
						pob.Add(new ProductOrder
						{
						    OrderID=Convert.ToInt32(txtID),
							ProductID = Convert.ToInt16(d),
							ProductPiece = Convert.ToInt16(numericUpDown1.Value),
							OrderStatus = "Hazırlanıyor",
							OrderNote = txtNote.Text,
							TableID = _tablesForm.SelectedTable.TableID
						});
						MessageBox.Show("Ürün Başarıyla Adisyona Eklendi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				else
				{
				    int? masaAdisyonu = 0;
				    masaAdisyonu +=  toplam;
				    lblTotalAdditions.Text = masaAdisyonu.ToString();

				    ab.Insert(new Addition
				    {
				        TableID = _tablesForm.SelectedTable.TableID,
				        Status = true,
				        TotalPrice = masaAdisyonu,
				        AdditionDate = DateTime.Now,
				    });
						pob.Add(new ProductOrder
						{
						ProductID =Convert.ToInt16(d),
					    ProductPiece=Convert.ToInt16(numericUpDown1.Value),
					    OrderStatus="Hazırlanıyor",
						OrderNote=txtNote.Text,
						TableID = _tablesForm.SelectedTable.TableID,
						 					});
					MessageBox.Show("Ürün Başarıyla Adisyona Eklendi","ONAY",MessageBoxButtons.OK,MessageBoxIcon.Information);
				}
			}
		}

        private void btnFinishAdditions_Click(object sender, EventArgs e)
        {
			if (lblTotalAdditions.Text != "00")
			{
				Addition table = ab.GetByTable(_tablesForm.SelectedTable.TableID);

				Addition isvalidadition = ab.GetByTableId(_tablesForm.SelectedTable.TableID);
				Random rnd = new Random();
				
				int sayi = rnd.Next(1000, 9999);
				ptb.Edit(new Addition
				{
					TableID = _tablesForm.SelectedTable.TableID,
					TotalPrice = Convert.ToInt32(lblTotalAdditions.Text),
 					Status = false,
					PaymentCode = sayi
				});
              
			 	MessageBox.Show("Hesap Tutarınız : " + lblTotalAdditions.Text + "₺" + " \nHesap Ödeme Kodunuz :" + sayi,"",MessageBoxButtons.OK,MessageBoxIcon.Information);
				lblTotalAdditions.Text = "00";
				PaymentForm paymentForm = new PaymentForm(isvalidadition,table);
				paymentForm.Show();
			}
			else
			{
				DialogResult d = new DialogResult();
				d = MessageBox.Show("Lütfen Ürün Ekledikten Sonra Tekrar Deneyiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

				
			}
		}
		

        private void btnDeleteAddition_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                DialogResult xxx = MessageBox.Show("Lütfen Ürün Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (numericUpDown1.Value == 0)
            {
                DialogResult xx = MessageBox.Show("Lütfen Ürün Adedi Belirtiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Addition isvalidadition = ab.GetByTableId(_tablesForm.SelectedTable.TableID);

                if (isvalidadition != null)
                {
                    lblTotalAdditions.Text = isvalidadition.TotalPrice.ToString();
                }
                int a = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[a];
                string d = selectedRow.Cells["ProductName"].Value.ToString();
                var x = pb.GetAll().Where(s => s.ProductName == d).First();
                int adet = Convert.ToInt16(numericUpDown1.Value);
                int toplam = (Convert.ToInt16(x.Price) * adet);
                string productPrice = selectedRow.Cells["Price"].Value.ToString();

                if (isvalidadition != null)
                {
                    if (isvalidadition.Status == true)
                    {
                        int? masaAdisyonu = 0;
                        masaAdisyonu += isvalidadition.TotalPrice - toplam;
                        lblTotalAdditions.Text = masaAdisyonu.ToString();

                        ab.Update(new Addition
                        {
                            Status = true,
                            TableID = isvalidadition.TableID,
                            AdditionID = isvalidadition.AdditionID,
                            AdditionDate = isvalidadition.AdditionDate,
                            TotalPrice = masaAdisyonu
                        });
                    }
                }
                else
                {
                    int? masaAdisyonu = 0;
                    masaAdisyonu += toplam;
                    lblTotalAdditions.Text = masaAdisyonu.ToString();
                    ab.Delete(Convert.ToInt32(isvalidadition.TableID));
                    MessageBox.Show("Ürün Başarıyla Adisyondan Silindi", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
