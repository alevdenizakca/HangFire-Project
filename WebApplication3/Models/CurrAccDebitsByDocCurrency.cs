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
    
    public partial class CurrAccDebitsByDocCurrency
    {
        public Nullable<byte> CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public string DocumentNumber { get; set; }
        public System.DateTime DueDate { get; set; }
        public string LineDescription { get; set; }
        public string RefNumber { get; set; }
        public string Doc_CurrencyCode { get; set; }
        public decimal Doc_Debit { get; set; }
        public Nullable<decimal> Doc_Balance { get; set; }
        public string Loc_CurrencyCode { get; set; }
        public double Loc_ExchangeRate { get; set; }
        public decimal Loc_Debit { get; set; }
        public Nullable<decimal> Loc_Balance { get; set; }
        public byte DebitTypeCode { get; set; }
        public string DebitReasonCode { get; set; }
        public System.Guid DebitLineID { get; set; }
        public System.Guid DebitHeaderID { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string ATAtt01 { get; set; }
        public string ATAtt02 { get; set; }
        public string ATAtt03 { get; set; }
        public string ATAtt04 { get; set; }
        public string ATAtt05 { get; set; }
    }
}
