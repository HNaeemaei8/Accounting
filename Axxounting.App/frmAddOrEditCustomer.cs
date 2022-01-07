using Accounting.DataLayer;
using Accounting.DataLayer.Context;
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
using ValidationComponents;

namespace Axxounting.App
{
    public partial class frmAddOrEditCustomer : Form
    {
        public int customerid = 0;
        UnitOfWork db = new UnitOfWork();
        int AccountId = 0;
        public frmAddOrEditCustomer()
        {
            InitializeComponent();
        }



        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog()==DialogResult.OK)
            {
                pc.ImageLocation = open.FileName;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                string image = Guid.NewGuid().ToString() + System.IO.Path.GetExtension(pc.ImageLocation);
               //  pc.Image.Save(Application.StartupPath + "/Images"+ image);
                string path = Application.StartupPath + "/Images/";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path );
                }
                pc.Image.Save(path+image);
                string location = pc.ImageLocation;
                Customer customer = new Customer()
                {

                    Address = txtAddress.Text,
                    Email = txtEmail.Text,
                    FullName = txtName.Text,
                    Mobile = txtMobile.Text,
                    CustomerImage= image
                };
                if (customerid==0)
                {
                    db.customerRepository.InsertCustomer(customer);

                }
                else
                {
                    customer.CustomerId = customerid;
                    db.customerRepository.UpdateCustomer(customer);
                }
                db.Save();
                DialogResult = DialogResult.OK;
            }

        }
        private void frmAddOrEditCustomer_Load(object sender, EventArgs e)
        {
            if (customerid != 0)
            {
                this.Text = "ویرایش شخص";
                btnSave.Text = "ویرایش";
               var customer= db.customerRepository.GetCustomerById(customerid);
                txtEmail.Text = customer.Email;
                txtAddress.Text = customer.Address;
                txtName.Text = customer.FullName;
                txtMobile.Text = customer.Mobile;
                pc.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
            }

        }
    }
}
