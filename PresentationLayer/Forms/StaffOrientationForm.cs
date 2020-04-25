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
    public partial class StaffOrientationForm : Form
    {
        private int childFormNumber = 0;

        public object TablesSetting { get; private set; }

		public Staff staffx { get; set; }

		public StaffOrientationForm(Staff staff)
        {
			staffx = staff;
            InitializeComponent();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void StaffOrientation_Load(object sender, EventArgs e)
        {
            tlAdmin.Enabled = false;
			//tlStaffName.Text ="Aktif Personel =" + UserLoginForm.staff.UserName;
			if (staffx==null)
			{
				MessageBox.Show("Veri bulunamadı");
			
			}
			tlStaffName.Text = "Aktif Personel: " + staffx.FirstName + staffx.LastName;
            if (staffx.TitleID==1)
            {
                tlAdmin.Enabled = true;
            }


			MdiClient ctlMDI;

            {
                foreach (Control ctl in this.Controls)
                {
                    try
                    {
                        ctlMDI = (MdiClient)ctl;
                        ctlMDI.BackColor = this.BackColor;
                    }
                    catch (InvalidCastException exc)
                    {

                    }
                }


            }
        }
        private void kasaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffSettingForm1 stf = new StaffSettingForm1();
            stf.MdiParent = this;
            stf.Show();
        }
		AdditionBusiness ab = new AdditionBusiness();
		

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
		//	Addition table = ab.GetByTable(_tablesForm.SelectedTable.TableID);
		//Addition isvalidadition = ab.GetByTableId(_tablesForm.SelectedTable.TableID);
          
        }
		private void masaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TablesForm tb = new TablesForm();
			tb.MdiParent = this;
			tb.Show();
		}

		private void masaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TablesSettingForm tbSetting = new TablesSettingForm();
			tbSetting.MdiParent = this;
			tbSetting.Show();
		}

		private void ürünİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ProductSettingForm addPro = new ProductSettingForm();
			addPro.MdiParent = this;
			addPro.Show();
		}

		private void siparişlerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			OrdersForm od = new OrdersForm();
			od.MdiParent = this;
			od.Show();
		}
		private void rezervasyonİşlemleriToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			ReservationForm rf = new ReservationForm();
			rf.MdiParent = this;
			rf.Show();
		}

		private void personelAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
		{
			StaffSettingForm1 stf = new StaffSettingForm1();
			stf.MdiParent = this;
			stf.Show();
		}

		private void finansMuhasebeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FinanceAndAccountingForm fa = new FinanceAndAccountingForm();
			fa.MdiParent = this;
			fa.Show();
		}

		private void giderİşlemleriToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			ExpenseForm ex = new ExpenseForm();
			ex.MdiParent = this;
			ex.Show();
		}

		private void toolStripStatusLabel2_Click(object sender, EventArgs e)
		{
			DialogResult d = new DialogResult();
			d = MessageBox.Show("Çıkış Yapmak İstediğinizden Emin Misiniz?", "ÇIKIŞ ONAY", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			switch (d)
			{
				case DialogResult.Yes:
					Application.Exit();
					break;
				case DialogResult.No:
					break;
				default:
					break;
			}


		}
		private void kasaİşlemleriToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			PaymentForm pf = new PaymentForm(new Addition(),new Addition());
			pf.MdiParent = this;
			pf.Show();
		}
		private void müşteriİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CustomersForm cf = new CustomersForm();
			cf.MdiParent = this;
			cf.Show();
		}
	}
}
