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
    
    public partial class PresentCardType_Result
    {
        public string PresentCardTypeCode { get; set; }
        public bool UsePOS { get; set; }
        public string StoreCRMGroupCode { get; set; }
        public string CompanyBrandCode { get; set; }
        public bool DisablePresentCardWhenCommAddressChanged { get; set; }
        public bool IsBlocked { get; set; }
        public bool UseConditionalPresentCardActivation { get; set; }
        public bool AutoGenerateCardNumber { get; set; }
        public string PrefixCode { get; set; }
        public byte DigitCount { get; set; }
        public decimal LastNumber { get; set; }
        public string LangCode { get; set; }
        public string PresentCardTypeDescription { get; set; }
    }
}