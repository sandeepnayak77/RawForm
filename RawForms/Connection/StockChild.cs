//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RawForms.Connection
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockChild
    {
        public int StockChildID { get; set; }
        public int StockID { get; set; }
        public Nullable<decimal> OpeningBalance { get; set; }
        public Nullable<decimal> ClosingBalance { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    
        public virtual ProductStock ProductStock { get; set; }
    }
}
