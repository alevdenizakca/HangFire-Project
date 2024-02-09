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
    
    public partial class trTFRSInvoiceAdjustment
    {
        public System.Guid TFRSInvoiceAdjustmentID { get; set; }
        public decimal CompanyCode { get; set; }
        public System.Guid InvoiceHeaderID { get; set; }
        public System.Guid InvoiceLineID { get; set; }
        public short ValidYear { get; set; }
        public byte ValidMonth { get; set; }
        public decimal Amount { get; set; }
        public float LateChargeRate { get; set; }
        public decimal LateChargeAmount { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual trInvoiceHeader trInvoiceHeader { get; set; }
    }
}