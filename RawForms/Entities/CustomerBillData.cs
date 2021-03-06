﻿using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RawForms.Reports.CustomerBillForm;

namespace RawForms.Entities
{
   

    
    public class CustomerBillData
    {
        public string shopName { get; set; }
        public string shopAddress { get; set; }
        public string gstn { get; set; }
        public string billNo { get; set; }
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
