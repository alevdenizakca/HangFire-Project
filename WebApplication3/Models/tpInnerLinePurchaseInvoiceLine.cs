//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tpInnerLinePurchaseInvoiceLine
    {
        public System.Guid InnerLinePurchaseInvoiceLineID { get; set; }
        public System.Guid InnerLineID { get; set; }
        public System.Guid InvoiceLineID { get; set; }
        public double InvoiceQty1 { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual trInnerLine trInnerLine { get; set; }
        public virtual trInvoiceLine trInvoiceLine { get; set; }
    }
}
