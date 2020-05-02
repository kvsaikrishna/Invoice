using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invoice.db;
using Invoice.repo;
using Invoice.vm;

namespace Invoice.Controllers
{
    public class ManufacturerController : Controller
    {
        // GET: Manufacturer
        public ActionResult Index()
        {
            storeDBEntities storeDB = new storeDBEntities();

            return View(from manufacturer in storeDB.manufacturers select manufacturer );
        }

        public ActionResult Create()
        {
            return View("SaveDetails");
            
        }

        public ActionResult ReturnSaveDetails()
        {
            return View("SaveDetails");
        }

        [HttpPost]
        public ActionResult SaveDetails(ManufacturerVM manufacturerVM)
        {
            Manufacturerrepo objmanufacturerrepo = new Manufacturerrepo();
            objmanufacturerrepo.Insert(manufacturerVM);
            return View("SaveDetails");
              
        }

    }
}