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
    
    public partial class Country_Result
    {
        public string CountryCode { get; set; }
        public string CurrencyCode { get; set; }
        public bool UseVat { get; set; }
        public bool IsVatRequired { get; set; }
        public string TaxDecCode { get; set; }
        public string CountryISOCode { get; set; }
        public bool UseItemDim1Equ { get; set; }
        public bool IsItemDim1Required { get; set; }
        public bool UseItemDim2Equ { get; set; }
        public bool IsItemDim2Required { get; set; }
        public bool UseItemDim3Equ { get; set; }
        public bool IsItemDim3Required { get; set; }
        public bool IsBlocked { get; set; }
        public bool ApplyPCTOnSelectedPaymentTypes { get; set; }
        public string LangCode { get; set; }
        public string CountryDescription { get; set; }
    }
}