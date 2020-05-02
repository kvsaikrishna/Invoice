using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice.db;
using Invoice.vm;

namespace Invoice.vm
{
    public class CustomerVM
    {
        public List<customer> customerslist { get; set; }
        public int customerid { get; set; }
        public string customername { get; set; }
        public Nullable<int> rewards { get; set; }
        public string contactnumber { get; set; }
        public string location { get; set; }
    }
}
