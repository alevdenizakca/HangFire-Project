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
    
    public partial class MarketPlaceExportOrderLine
    {
        public System.Guid OrderLineID { get; set; }
        public string OrderLineItemStatusName { get; set; }
        public string Barcode { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string ProductColor { get; set; }
        public string ProductSize { get; set; }
        public double Quantity { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> TyDiscount { get; set; }
        public decimal lineItemPrice { get; set; }
        public Nullable<decimal> lineItemDiscount { get; set; }
        public System.Guid OrderHeaderID { get; set; }
    
        public virtual MarketPlaceExportOrderHeader MarketPlaceExportOrderHeader { get; set; }
    }
}
