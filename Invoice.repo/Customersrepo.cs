using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice.db;
using Invoice.vm;

namespace Invoice.repo
{
    public class Customersrepo
    {
        public void Insert(CustomerVM customerVM)
        {
            var entity = new storeDBEntities();
            CustomerVM vm = new CustomerVM();

            customer customerobj = new customer(); //table
            customerobj.customerid = customerVM.customerid;
            customerobj.customername = customerVM.customername;
            customerobj.rewards = customerVM.rewards;
            customerobj.contactnumber = customerVM.contactnumber;
            customerobj.location = customerVM.location;

            entity.customers.Add(customerobj);  //db.table-object
            entity.SaveChanges();


        }
    }
}
