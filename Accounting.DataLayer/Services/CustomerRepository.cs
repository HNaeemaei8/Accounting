using Accounting.DataLayer.Repositories;
using Accounting.ViewModel.Customers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {

        //Accounting_DbEntities db = new Accounting_DbEntities();
        private Accounting_DbEntities db;
        public CustomerRepository(Accounting_DbEntities context)
        {
            db = context;
        }
        public bool DeleteCustomer(Customer customer)
        {
            {
                try
                {
                    db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                    return true;
                }
                catch (Exception)
                {
                    return false;

                }

            }

        }

        public bool DeleteCustomer(int customerid)
        {
            {
                try
                {
                    var Customer = GetCustomerById(customerid);
                    DeleteCustomer(customerid);
                    return true;

                }
                catch (Exception)
                {
                    return false;

                }

            }

        }

        public Customer GetCustomerById(int cusomerId)
        {
            return db.Customers.Find(cusomerId);
             
        }

        public bool InsertCustomer(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
            
        }

     

        public List<Customer> SelectAllCustomer()
        {
            return db.Customers.ToList();
             
        }

        public bool UpdateCustomer(Customer customer)
        {
            {
                try
                {
                    var local = db.Set<Customer>()
                         .Local
                         .FirstOrDefault(f => f.CustomerId == customer.CustomerId);
                    if (local != null)
                    {
                        db.Entry(local).State = EntityState.Detached;
                    }
                    db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                    return true;

                }
                catch (Exception)
                {
                    return false;

                }

            }
        }


        public IEnumerable<Customer> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(c => c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
      }


        List<ListCustomerViewModel> ICustomerRepository.GetNameCustomer(string filte)
        {
            if (filte == "")
            {
                return db.Customers.Select(c => new ListCustomerViewModel()
                {
                    FullName = c.FullName
                }).ToList();
                //return db.Customers.Select(c => c.FullName).ToList() ;
            }
            return db.Customers.Where(c => c.FullName.Contains(filte)).Select(c => new ListCustomerViewModel()
            {
                FullName = c.FullName
            }).ToList() ;
                           // return db.Customers.Where(c => c.FullName.Contains(filte)).Select(c => c.FullName).ToList();

        }

        public int GetCustomerIdByName(string name)
        {
            return db.Customers.First(c => c.FullName == name).CustomerId;
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).FullName;
        }
    }
}
