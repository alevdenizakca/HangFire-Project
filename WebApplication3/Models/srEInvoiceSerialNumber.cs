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
    
    public partial class srEInvoiceSerialNumber
    {
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public string EInvoicePrefixCode { get; set; }
        public decimal ValidYear { get; set; }
        public decimal LastNumber { get; set; }
        public bool IsDefault { get; set; }
        public bool IsTaxFreeDefault { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
    }
}
