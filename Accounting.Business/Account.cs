using Accounting.DataLayer.Context;
using Accounting.ViewModel.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.Business
{
  public  class Account
    {

        public static ReportViewModel model()
        {
            ReportViewModel rp = new ReportViewModel();
            using (UnitOfWork db = new UnitOfWork())
            {
                DateTime startdate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime enddate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);
                var recive = db.accounting.Get(c => c.TypeId == 1 && c.DateTime >= startdate && c.DateTime <= enddate).Select(e => e.Amount).ToList();
                var pay = db.accounting.Get(c => c.TypeId == 2 && c.DateTime >= startdate && c.DateTime <= enddate).Select(e => e.Amount).ToList();
                rp.Recive = recive.Sum();
                rp.Pay = pay.Sum();
                rp.AccountBalance = (recive.Sum() - pay.Sum());
            }
            return rp;
               
        }
    
	

	}

    }

