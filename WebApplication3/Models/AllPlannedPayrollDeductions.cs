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
    
    public partial class AllPlannedPayrollDeductions
    {
        public System.Guid PayrollHeaderID { get; set; }
        public decimal CompanyCode { get; set; }
        public string WorkPlaceCode { get; set; }
        public short ValidYear { get; set; }
        public byte ValidMonth { get; set; }
        public byte SortOrder { get; set; }
        public byte PayrollTypeCode { get; set; }
        public string DocCurrencyCode { get; set; }
        public string LocalCurrencyCode { get; set; }
        public double HeaderExchangeRate { get; set; }
        public string Description { get; set; }
        public string WagePlanTypeCode { get; set; }
        public Nullable<bool> IsPlanned { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLocked { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsPostingJournal { get; set; }
        public System.DateTime JournalDate { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public double ShortTermInsuranceRateLevel { get; set; }
        public System.Guid PayrollLineID { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public string JobDepartmentCode { get; set; }
        public byte PremiumDay { get; set; }
        public byte MissingWorkDay { get; set; }
        public string MissingWorkReasonCode { get; set; }
        public decimal OldRoundingDiff { get; set; }
        public decimal RoundingDiff { get; set; }
        public decimal LineNetAmount { get; set; }
        public bool IsAccrualDone { get; set; }
        public bool IsWorkedWithReport { get; set; }
        public System.Guid PayrollLineDeductionID { get; set; }
        public string DeductionCode { get; set; }
        public string DeductionCurrencyCode { get; set; }
        public double ExchangeRate { get; set; }
        public decimal Amount { get; set; }
        public System.Guid EmployeeDebitID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public decimal AmountAdded { get; set; }
    }
}