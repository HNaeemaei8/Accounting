using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Context
{
  public   class UnitOfWork:IDisposable
    {
        Accounting_DbEntities db = new Accounting_DbEntities();

        private ICustomerRepository _customerRepository;

        private GenericRepository<Accounting> _accounting;

        private GenericRepository<Login> _loginRepository;


        public GenericRepository<Login> loginreposotory
        {
            get
            {
                if (_loginRepository ==null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }

        public GenericRepository<Accounting> accounting
        {
            get
            {
                if (_accounting ==null)
                {
                    _accounting = new GenericRepository<Accounting>(db);
                }
                return _accounting;

            }

            
        }

        public ICustomerRepository customerRepository 
        
        {
            get
            {
                if (_customerRepository==null)
                {
                    _customerRepository  = new CustomerRepository(db); 
                }
                return _customerRepository;
            }

        }

        public void Save()
        {
            db.SaveChanges();

        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
