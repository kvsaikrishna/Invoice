using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invoice.repo;
using Invoice.vm;
using Invoice.db;

namespace Invoice.Controllers
{
    public class ItemController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            storeDBEntities entities = new storeDBEntities();
            return View(from item in entities.items select item);
        }
        public ActionResult Create()
        {
            return View("SaveItems");
        }

        
        
        
       
        
            public ActionResult Returnsaveitems()
        {
            return View("SaveItems");
        }
           
        

       [HttpPost]
       public ActionResult SaveItems(ItemsVM items)
        {
            Itemsrepo objitemsrepo = new Itemsrepo();
            objitemsrepo.Insert(items);
            return View("SaveItems");
        }
            

        
    }
}