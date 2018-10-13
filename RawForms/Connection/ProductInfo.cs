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
    
    public partial class ProductInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductInfo()
        {
            this.ProductPrices = new HashSet<ProductPrice>();
        }
    
        public int ProductID { get; set; }
        public int CatagoryID { get; set; }
        public int TypeID { get; set; }
        public int SubTypeID { get; set; }
        public int VarientID { get; set; }
        public string Description { get; set; }
        public string ProductCode { get; set; }
        public int UnitID { get; set; }
    
        public virtual ProductCatagory ProductCatagory { get; set; }
        public virtual ProductSubType ProductSubType { get; set; }
        public virtual ProductType ProductType { get; set; }
        public virtual ProductVarient ProductVarient { get; set; }
        public virtual ProductUnit ProductUnit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
