using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawForms.Entities
{
    public class CustomerBillData
    {
        public string name { get; set; }
        public string address { get; set; }
        public string gstn { get; set; }
        public List<CustomerBillProduct> billData { get; set; }
    }
    public class CustomerBillProduct
    {
        public string Productdesc { get; set; }
        public decimal Productunit { get; set; }
        public decimal Productprice { get; set; }
        public decimal Totalprice { get; set; }

    }
}
