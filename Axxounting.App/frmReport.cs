using Accounting.DataLayer.Context;
using Accounting.DataLayer;
using Accounting.Utility;
using Accounting.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.utility.Convertor;
using Stimulsoft.Base;

namespace Axxounting.App
{
    public partial class frmReport : Form
    {
        public int TypeId = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    CustomerId = 0,
                    FullName = "لطفا انتخاب کنید"
                });
                list.AddRange(db.customerRepository.GetNameCustomer());
                cbCustomer.DataSource = list;
                // cbCustomer.DataSource = db.customerRepository.GetNameCustomer();
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerId";
            }
            dgReport.AutoGenerateColumns = false;
            if (TypeId == 1)
            {
                this.Text = "گزارش دریافتی ها";
            }
            else
            {
                this.Text = "گزارش پرداختی ها";
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                List<Accounting.DataLayer.Accounting> result = new List<Accounting.DataLayer.Accounting>();

                DateTime? startdate;
                DateTime? enddate;

                if ((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.accounting.Get(a => a.TypeId == TypeId && a.CustomerId == customerId));
                }
                else
                {
                    result.AddRange(db.accounting.Get(a => a.TypeId == TypeId));
                }

                if (txtFromDate.Text != "    /  /")
                {
                    startdate = Convert.ToDateTime(txtFromDate.Text);
                    startdate = DateConvertor.ToMiladi(startdate.Value);
                    result = result.Where(d => d.DateTime >= startdate.Value).ToList();
                }
                if (txtToDate.Text != "    /  /")
                {
                    enddate = Convert.ToDateTime(txtToDate.Text);
                    enddate = DateConvertor.ToMiladi(enddate.Value);
                    result = result.Where(d => d.DateTime <= enddate.Value).ToList();

                }



                // var result = db.accounting.Get(c => c.TypeId == TypeId);
                //  dgReport.DataSource = result;
                dgReport.Rows.Clear();
                foreach (var accounting in result)
                {
                    string customername = db.customerRepository.GetCustomerNameById(accounting.CustomerId);
                    dgReport.Rows.Add(accounting.Id, customername, accounting.Amount, accounting.DateTime.ToShams(), accounting.Description);
                }
            }
        }

        private void dgReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void brnDelete_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف مطمین هستبد", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.accounting.Delete(id);
                        db.Save();
                        Filter();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewAccounting frm = new frmNewAccounting();
                frm.AccountId = id;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("Customer");
            dtPrint.Columns.Add("Amount");
            dtPrint.Columns.Add("Date");
            dtPrint.Columns.Add("Description");
            foreach (DataGridViewRow item in dgReport.Rows)
            {
                dtPrint.Rows.Add(
                    item.Cells[0].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }
            stiReport.Load(Application.StartupPath + "/Report.mrt");
            stiReport.RegData("DT", dtPrint);
            stiReport.Show();

        }
    }
}
