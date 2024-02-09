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
    
    public partial class CurrAccDebitsWithPayments
    {
        public string CurrAccCode { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public Nullable<long> SortOrder { get; set; }
        public System.Guid DebitLineID { get; set; }
        public string PaymentNumber { get; set; }
        public byte PaymentTypeCode { get; set; }
        public string PaymentRefNumber { get; set; }
        public string PaymentDocumentNumber { get; set; }
        public Nullable<System.DateTime> PaymentDueDate { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string Loc_CurrencyCode { get; set; }
        public decimal Loc_Payment { get; set; }
        public string Doc_CurrencyCode { get; set; }
        public decimal Doc_Payment { get; set; }
        public string RefNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public string DocumentNumber { get; set; }
        public System.DateTime DueDate { get; set; }
        public decimal Loc_Debit { get; set; }
        public decimal Doc_Debit { get; set; }
        public string ApplicationCode { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public string StoreCode { get; set; }
        public string ATAtt01 { get; set; }
        public string ATAtt02 { get; set; }
        public string ATAtt03 { get; set; }
        public string ATAtt04 { get; set; }
        public string ATAtt05 { get; set; }
    }
}
