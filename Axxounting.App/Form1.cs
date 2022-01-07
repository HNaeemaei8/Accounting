using Accounting.Business;
using Accounting.utility.Convertor;
using Accounting.ViewModel.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Axxounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateConvertor.ToShamsi(DateTime.Now); 
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            Report();
            this.Hide();
            frmLogin frm = new frmLogin();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
            }

            void Report()
            {
                ReportViewModel report = Account.model();
                recive.Text = report.Recive.ToString("#,0");
                pay.Text = report.Pay.ToString("#,0");
                AccountBallance.Text = report.AccountBalance.ToString("#,0");


            }
        }

        private void btnNewAccounting_Click(object sender, EventArgs e)
        {
            frmNewAccounting frm = new frmNewAccounting();
            frm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeId = 2;
            frm.ShowDialog();
        }

        private void btnReportRecive_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport();
            frm.TypeId = 1;
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void اToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void تنظیماتورودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.IsEdit = true;
            frm.ShowDialog();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEditLogin_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
