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
    
    public partial class RetailInstallments
    {
        public Nullable<byte> CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public decimal PaymentAmount { get; set; }
        public Nullable<decimal> RemainingAmount { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public decimal OverduePaymentAmount { get; set; }
        public Nullable<bool> DownPayment { get; set; }
        public string RefNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public string ProcessCode { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public string StoreCode { get; set; }
        public decimal PolicyCompanyCode { get; set; }
        public string PolicyOfficeCode { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public Nullable<System.Guid> DebitLineID { get; set; }
        public Nullable<System.Guid> OrderPaymentPlanID { get; set; }
    }
}