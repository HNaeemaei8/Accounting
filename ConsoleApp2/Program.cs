using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Accounting_DbEntities db = new Accounting_DbEntities();

            //ICustomerRepository customer = new CustomerRepository(db);

            //Customer AddCustomer = new Customer()
            //{
            //    FullName = "سحر نعیمایی",
            //    Mobile = "09117575666",
            //    Address = "tehran",
            //     CustomerImage="nophoto"
            //}; 
            //customer.InsertCustomer(AddCustomer);
            //customer.Save();


            //var list = customer.SelectAllCustomer();

            UnitOfWork unit = new UnitOfWork();
          var list=  unit.customerRepository.SelectAllCustomer();
            unit.Dispose();
        }
    }
}
