using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice.db;
using Invoice.vm;

namespace Invoice.repo
{
    public class Manufacturerrepo
    {
        public void Insert(ManufacturerVM manufacturerVM)
        {
            var entity = new storeDBEntities();
            ManufacturerVM vm = new ManufacturerVM();

            manufacturer manufacturerobj = new manufacturer();

            manufacturerobj.manufacturerid = manufacturerVM.manufacturerid;
            manufacturerobj.manufacturername = manufacturerVM.manufacturername;

            entity.manufacturers.Add(manufacturerobj);

            entity.SaveChanges();
        }
    }
}
