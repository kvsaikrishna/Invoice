using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice.vm;
using Invoice.db;


namespace Invoice.vm
{
    public class ItemsVM
    {
        public List<item> Itemslist { get; set; }
        public int itemid { get; set; }
        public int itemtypeid { get; set; }
        public int manufacturerid { get; set; }
        public string itemname { get; set; }
        public decimal price { get; set; }
        public decimal discount { get; set; }
        public System.DateTime manufacturedate { get; set; }
        public System.DateTime expirydate { get; set; }
    }
}
