using System;
using DataLayer;
using BusinessLayer.Repository.Concrete;
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
	public partial class OrdersForm : Form
	{
		ProductOrderBusiness pb = new ProductOrderBusiness();
		public OrdersForm()
		{
			InitializeComponent();
			dgvOrders.DataSource = pb.ProductOrders();

		}
		private void pbCikis_Click(object sender, EventArgs e)
		{
			this.Hide();
		}

		private void Orders_Load(object sender, EventArgs e)
		{
			dgvOrders.DataSource = pb.ProductOrders();
			timer1.Enabled = true;
			lblTableNo.Visible = false;
			lblPiece.Visible = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lblHour.Text = DateTime.Now.ToLongTimeString();
		}
		private void btnReady_Click(object sender, EventArgs e)
		{
			pb.Edit(new ProductOrder {
				OrderID=Convert.ToInt16(lblId.Text),
				TableID=Convert.ToInt16(lblTableNo.Text),
				ProductPiece=Convert.ToInt16(lblPiece.Text),
				OrderStatus="Hazırlandı",
			});
			MessageBox.Show("Sipariş Hazırlandı", "ONAY", MessageBoxButtons.OK, MessageBoxIcon.Information);

			dgvOrders.DataSource = pb.ProductOrders();
		}
		private void dgvOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow selectedRow = dgvOrders.Rows[e.RowIndex];
			lblId.Text = selectedRow.Cells["OrderID"].Value.ToString();
			lblPiece.Text = selectedRow.Cells["ProductPiece"].Value.ToString();
			lblTableNo.Text = selectedRow.Cells["TableID"].Value.ToString();
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
			dgvOrders.DataSource = pb.ProductOrders().Where(x => x.ProductName.Contains(txtSearch.Text)||x.Table.Contains(txtSearch.Text)).ToList();

		}
	}
}
