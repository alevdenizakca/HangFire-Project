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
    
    public partial class AllDebits
    {
        public System.Guid DebitHeaderID { get; set; }
        public byte DebitTypeCode { get; set; }
        public string DebitNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public System.TimeSpan DocumentTime { get; set; }
        public string DocumentNumber { get; set; }
        public string RefNumber { get; set; }
        public Nullable<byte> CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public string Description { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public string GLTypeCode { get; set; }
        public double ExchangeRate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLocked { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsPostingJournal { get; set; }
        public System.DateTime JournalDate { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid DebitLineID { get; set; }
        public int SortOrder { get; set; }
        public string DebitReasonCode { get; set; }
        public System.DateTime DueDate { get; set; }
        public string LineDescription { get; set; }
        public string DocCurrencyCode { get; set; }
        public string Doc_CurrencyCode { get; set; }
        public decimal Doc_Debit { get; set; }
        public decimal Doc_Credit { get; set; }
        public string Loc_CurrencyCode { get; set; }
        public double Loc_ExchangeRate { get; set; }
        public decimal Loc_Debit { get; set; }
        public decimal Loc_Credit { get; set; }
        public string Com_CurrencyCode { get; set; }
        public double Com_ExchangeRate { get; set; }
        public decimal Com_Debit { get; set; }
        public decimal Com_Credit { get; set; }
    }
}