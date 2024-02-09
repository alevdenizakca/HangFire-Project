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
    
    public partial class prFixedAssetInsurance
    {
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public System.Guid InsuranceLineID { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string InsuranceTypeCode { get; set; }
        public string PolicyNo { get; set; }
        public string CurrencyCode { get; set; }
        public decimal AnnualPremium { get; set; }
        public decimal PolicyCoverage { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdInsuranceType cdInsuranceType { get; set; }
        public virtual cdItem cdItem { get; set; }
    }
}
