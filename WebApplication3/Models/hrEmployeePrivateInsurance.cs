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
    
    public partial class hrEmployeePrivateInsurance
    {
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public decimal CompanyCode { get; set; }
        public short ValidYear { get; set; }
        public byte ValidMonth { get; set; }
        public string PrivateInsuranceCode { get; set; }
        public decimal InsurancePremium { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string Description { get; set; }
        public bool IsPaidByEmployer { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdPrivateInsurance cdPrivateInsurance { get; set; }
        public virtual hrEmployeePayrollProfile hrEmployeePayrollProfile { get; set; }
    }
}