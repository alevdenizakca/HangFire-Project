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
    
    public partial class prUniFreeTenderTypeMapping
    {
        public System.Guid UniFreeTenderTypeMappingID { get; set; }
        public byte PaymentTypeCode { get; set; }
        public string CurrencyCode { get; set; }
        public string BankCode { get; set; }
        public string PaymentProviderCode { get; set; }
        public string TenderTypeCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual bsPaymentType bsPaymentType { get; set; }
        public virtual cdBank cdBank { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdPaymentProvider cdPaymentProvider { get; set; }
        public virtual cdUniFreeTenderType cdUniFreeTenderType { get; set; }
    }
}