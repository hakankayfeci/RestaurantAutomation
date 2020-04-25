using BusinessLayer.Repository.Concrete;
using DataLayer;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MExcel = Microsoft.Office.Interop.Excel;

namespace PresentationLayer.Forms
{
	public partial class FinanceAndAccountingForm : Form
	{
		AdditionBusiness ab = new AdditionBusiness();
		Addition addition = new Addition();
		ExpenseBusiness Eb = new ExpenseBusiness();
		public decimal ToplamGelir;
		public decimal ToplamGider;
		public decimal PersonelMaaslari;
		public decimal Vergiler;
		public decimal Kira;
		public decimal Faturalar;
		public decimal MutfakIhtiyaclari;

		public FinanceAndAccountingForm()
		{
			InitializeComponent();
			ToplamGelir = Convert.ToInt32(db.Additions.Sum(x => x.TotalPrice));
			PersonelMaaslari = Convert.ToInt32(db.Staffs.Sum(x => x.MonthlySalary));
			ToplamGider = Convert.ToInt32(db.Expenses.Sum(x => x.ExpensePrice));
			Vergiler  = Convert.ToInt32(db.Expenses.Where(x=>x.ExpenseType=="Vergi").Sum(x=>x.ExpensePrice));
			Kira = Convert.ToInt32(db.Expenses.Where(x=>x.ExpenseType=="Kira").Sum(x=>x.ExpensePrice));
			Faturalar  = Convert.ToInt32(db.Expenses.Where(x=>x.ExpenseType=="Faturalar").Sum(x=>x.ExpensePrice));
			MutfakIhtiyaclari  = Convert.ToInt32(db.Expenses.Where(x=>x.ExpenseType== "Mutfak İhtiyaçları").Sum(x=>x.ExpensePrice));


			pieChart1.LegendLocation = LiveCharts.LegendLocation.Right;
			pieChart1.InnerRadius = 100;
			SeriesCollection series = new SeriesCollection();

			series.Add(new PieSeries  // gelir
			{
				Title = "Gelir",
				Values = new ChartValues<int> { Convert.ToInt32(ToplamGelir) },
				DataLabels = true
			});
			series.Add(new PieSeries  // gider
			{
				Title = "Personel Maaşları",
				Values = new ChartValues<int> { Convert.ToInt32(PersonelMaaslari) },
				DataLabels = true
			});
			series.Add(new PieSeries  // gider
			{
				Title = "Vergiler",
				Values = new ChartValues<int> { Convert.ToInt32(Vergiler) },
				DataLabels = true
			});
			series.Add(new PieSeries  // gider
			{
				Title = "Kira",
				Values = new ChartValues<int> { Convert.ToInt32(Kira) },
				DataLabels = true
			});
			series.Add(new PieSeries  // gider
			{
				Title = "Faturalar",
				Values = new ChartValues<int> { Convert.ToInt32(Faturalar) },
				DataLabels = true
			});
			series.Add(new PieSeries  // gider
			{
				Title = "Mutfak İhtiyaçları",
				Values = new ChartValues<int> { Convert.ToInt32(MutfakIhtiyaclari) },
				DataLabels = true
			});
			pieChart1.Series = series;
		}
		RestoranDBEntities db = new RestoranDBEntities();
		private void FinanceAndAccountingForm_Load(object sender, EventArgs e)
		{
			dgvList.DataSource = Eb.GetExpenses();
			dgvList.Visible = false;
		}
		private void pictureBox1_Click(object sender, EventArgs e)
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
			ExcelPage.Cells[1, 1] = "Id";
			ExcelPage.Cells[1, 2] = "Tür";
			ExcelPage.Cells[1, 3] = "Fiyat";
			ExcelPage.Cells[1, 4] = "Adı";
			

			foreach (DataGridViewRow row in dgvList.Rows)
			{
				rowNumber++;
				ExcelPage.Cells[rowNumber, 1] = row.Cells["ExpenseID"].Value;
				ExcelPage.Cells[rowNumber, 2] = row.Cells["ExpenseType"].Value;
				ExcelPage.Cells[rowNumber, 3] = row.Cells["ExpensePrice"].Value;
				ExcelPage.Cells[rowNumber, 4] = row.Cells["ExpenseName"].Value;
			}
			ExcelApp.Quit();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;

		}

		private void toolStripButton2_Click_1(object sender, EventArgs e)
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
