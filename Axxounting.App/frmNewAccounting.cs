using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Axxounting.App
{
    public partial class frmNewAccounting : Form
    {
      //  UnitOfWork db = new UnitOfWork();
        private UnitOfWork db;
        public  int AccountId = 0;
        public frmNewAccounting()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmNewAccounting_Load(object sender, EventArgs e)
        {
             db = new UnitOfWork();
            dgvCustomer.AutoGenerateColumns = false;
            dgvCustomer.DataSource = db.customerRepository.GetNameCustomer();
            if (AccountId != 0)
            {
                var account = db.accounting.GetById(AccountId);
                txtAmount.Value = account.Amount;
                txtDescription.Text = account.Description;
                txtName.Text = db.customerRepository.GetCustomerNameById(account.CustomerId);
                if (account.TypeId==2)
                {
                    rbPay.Checked = true;
                }
                else
                {
                    rbRecive.Checked = true;
                    this.Text = "ویرایش";
                    btnSave.Text = "ویرایش";
                    db.Dispose();

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = db.customerRepository.GetNameCustomer(txtfilter.Text);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomer.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                if (rbPay.Checked || rbRecive.Checked)
                {
                    db = new UnitOfWork();
                    Accounting.DataLayer.Accounting accounting = new Accounting.DataLayer.Accounting()
                    {
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerId = db.customerRepository.GetCustomerIdByName(txtName.Text),
                        TypeId = (rbRecive.Checked)?1:2,
                        DateTime = DateTime.Now,
                        Description = txtDescription.Text
                        };

                    if (AccountId == 0)
                    {
                        db.accounting.Insert(accounting);
                    }
                    else
                    {
    
                            accounting.Id = AccountId;
                            db.accounting.Update(accounting);
                        }
                    db.Save();
                    db.Dispose();
                    DialogResult = DialogResult.OK;

                }
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را انتخاب کنید");
                }

            }

        }
    }

