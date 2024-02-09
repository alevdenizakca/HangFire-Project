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
    
    public partial class prFixedAssetPurchases
    {
        public System.Guid FixedAssetPurchaseID { get; set; }
        public decimal CompanyCode { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public string LocCurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public double Qty { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> InvoiceLineID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdItem cdItem { get; set; }
        public virtual trInvoiceLine trInvoiceLine { get; set; }
    }
}
