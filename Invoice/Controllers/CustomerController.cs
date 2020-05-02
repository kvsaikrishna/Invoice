using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invoice.db;
using Invoice.vm;
using Invoice.repo;

namespace Invoice.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            storeDBEntities storeDBEntities = new storeDBEntities();

            return View(from customer in storeDBEntities.customers select customer);
        }

        public ActionResult Create()
        {
            return View("SaveDetails");
        }
        

        [HttpPost]
        public ActionResult SaveDetails(CustomerVM customervm)
        {
            Customersrepo customersrepo = new Customersrepo();
            customersrepo.Insert(customervm);
           
            return View("SaveDetails");
            
                
        }
    }
}