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

namespace Axxounting.App
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            BindGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void BindGrid()
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.AutoGenerateColumns = false;
                dgCustomers.DataSource = db.customerRepository.SelectAllCustomer();
                    
            }
        }

        private void txtFilter_Click(object sender, EventArgs e)
        {

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgCustomers.DataSource = db.customerRepository.GetCustomersByFilter(txtFilter.Text);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow  !=null)
            {

                using (UnitOfWork db = new UnitOfWork())
                {
                    string name = dgCustomers.CurrentRow.Cells[1].ToString();
                    if (RtlMessageBox.Show($"آیا از حذف {name} مطمن هستید؟","توجه ", MessageBoxButtons.YesNo , MessageBoxIcon.Warning)== DialogResult.OK)
                    {
                        int customerid = int.Parse(dgCustomers.CurrentRow.Cells[0].Value.ToString());
                        db.customerRepository.DeleteCustomer(customerid);
                        db.Save();
                        BindGrid();
                    }
    
                }

            }
            else
            {
                RtlMessageBox.Show("لطفا یک شخص را انتخاب کنید");
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddOrEditCustomer frm = new frmAddOrEditCustomer();
            if (frm.ShowDialog()== DialogResult.OK)

            {
                BindGrid();
            }
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (dgCustomers.CurrentRow !=null)
            {
                var customerId = int.Parse( dgCustomers.CurrentRow.Cells[0].Value.ToString());

                frmAddOrEditCustomer frm = new frmAddOrEditCustomer();
                frm.customerid = customerId;
                if (frm.ShowDialog()==DialogResult.OK)
                {
                    BindGrid();
                }
   
            }
        }
    }
}
