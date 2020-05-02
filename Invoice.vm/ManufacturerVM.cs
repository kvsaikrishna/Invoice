using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice.db;
using Invoice.vm;

namespace Invoice.vm
{
    public class ManufacturerVM
    {
        public List<manufacturer> manufacturerslist { get; set; }
        public int manufacturerid { get; set; }
        public string manufacturername { get; set; }
    }
}
