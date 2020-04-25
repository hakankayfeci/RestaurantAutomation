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
	public partial class TablesForm : Form
	{
		Addition Addition = new Addition();
		AdditionBusiness ab = new AdditionBusiness();
		ReservationBusiness rb = new ReservationBusiness();

		private TableBusiness tb = new TableBusiness();
		private Table selectedTable;
		public TablesForm()
		{
			InitializeComponent();
		}
		public Table SelectedTable
		{
			get { return selectedTable; }
			set { selectedTable = value; }
		}
		private void Tables_Load(object sender, EventArgs e)
		{
			var tables = tb.GetTables();
			var count = 0;

			foreach (var t in tables)
			{
				PictureBox pb = new PictureBox();
				if (t.Status == true)
				{

					var addition = ab.GetByTableId(t.TableID);

					if (addition != null)
					{
						if (addition.TotalPrice > 0)
						{
							pb.Image = Resimler.MasaDolu;
						}
						else
						{
							pb.Image = Resimler.MasaBos;
						}
					}
					else
					{
						ab.Insert(new Addition
						{
							Status = true,
							AdditionDate = DateTime.Now,
							TableID = t.TableID,
							TotalPrice = 0,
						});
						pb.Image = Resimler.MasaBos;
					}

					var reservation = rb.GetAll();
					var date = reservation.FindAll(x => x.ReservationDate == DateTime.Today);
					foreach (var item in date)
					{
						if (item.ReservationDate != null)
						{
							pb.Image = Resimler.MasaRezerve;
						}
					}
					pb.Width = 150 + count + 10;
					pb.Height = 150;
					pb.SizeMode = PictureBoxSizeMode.StretchImage;
					pb.BorderStyle = BorderStyle.FixedSingle;
					pb.Cursor = Cursors.Hand;
					pb.MouseClick += Pb_MouseClick;
					pb.Tag = t;
					pb.Location = new Point(0, count * 150);
					count++;
					flwTables.Controls.Add(pb);
				}

			}
		}
		private void Pb_MouseClick(object sender, MouseEventArgs e)
		{
			PictureBox pb = (PictureBox)sender;
			SelectedTable = (Table)pb.Tag;

			ProductMenuForm pm = new ProductMenuForm(this);
			pm.ShowDialog();
		}
		private void btnRefresh_Click(object sender, EventArgs e)
		{
			this.Hide();
			TablesForm tb = new TablesForm();
			tb.MdiParent = StaffOrientationForm.ActiveForm;
			tb.Show();
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

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
	}
}
