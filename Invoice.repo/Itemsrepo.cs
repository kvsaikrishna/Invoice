using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice.db;
using Invoice.vm;

namespace Invoice.repo
{
    public class Itemsrepo
    {
       

        public void Insert(ItemsVM Items)
        {
            var _context = new storeDBEntities();
            ItemsVM vm = new ItemsVM();

            item newitemobj = new item();             //table
            newitemobj.itemid = Items.itemid;
            newitemobj.itemname = Items.itemname;
            newitemobj.price = Items.price;
            newitemobj.discount = Items.discount;
            newitemobj.manufacturedate = Items.manufacturedate;
            newitemobj.expirydate = Items.expirydate;
            newitemobj.manufacturerid = 1;
            newitemobj.itemtypeid = 1;
            

            _context.items.Add(newitemobj);
            _context.SaveChanges();

        }

        
    }
}
