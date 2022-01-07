using Accounting.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
  public  interface ICustomerRepository
    {
       List<Customer> SelectAllCustomer();
        Customer GetCustomerById(int cusomerid);
        bool InsertCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool DeleteCustomer(int customerid);
        IEnumerable<Customer> GetCustomersByFilter(string parameter);
        List<ListCustomerViewModel> GetNameCustomer(string filte="");
        int GetCustomerIdByName(string name);

        string GetCustomerNameById(int customerId);



    }
}
