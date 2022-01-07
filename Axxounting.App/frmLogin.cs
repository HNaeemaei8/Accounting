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
    public partial class frmLogin : Form
    {
        public bool IsEdit = false;
        public int id = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (BaseValidator.IsFormValid(this.components))
            //{
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (IsEdit)
                    {
                        var login = db.loginreposotory.Get().First();
                        login.UseName = txtUseName.Text;
                        login.Password = txtPassword.Text;
                        db.loginreposotory.Update(login);
                        db.Save();
                        Application.Restart();

                }
                    else
                    {


                        if (db.loginreposotory.Get(c => c.UseName == txtUseName.Text && c.Password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;


                        }
                        else
                        {
                            RtlMessageBox.Show("کاربری یافت نشد");
                        }
                    }
                }
            //}
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                this.Text = "تنظیمات ورود به برنامه";
                btnLogin.Text = "ذخیره تغییرات";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.loginreposotory.Get().First();
                    txtUseName.Text = login.UseName;
                    txtPassword.Text = login.Password;


                    }
                }
            }
        }
    }

