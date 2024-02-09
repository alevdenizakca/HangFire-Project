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
    
    public partial class AllChequesWithAttributes
    {
        public System.Guid ChequeHeaderID { get; set; }
        public byte ChequeTransTypeCode { get; set; }
        public string ChequeTransNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public System.TimeSpan DocumentTime { get; set; }
        public string DocumentNumber { get; set; }
        public Nullable<byte> CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public string Description { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public short POSTerminalID { get; set; }
        public string GLTypeCode { get; set; }
        public double ExchangeRate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLocked { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsPostingJournal { get; set; }
        public System.DateTime JournalDate { get; set; }
        public Nullable<byte> CashCurrAccTypeCode { get; set; }
        public string CashCurrAccCode { get; set; }
        public Nullable<byte> BankCurrAccTypeCode { get; set; }
        public string BankCurrAccCode { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid ChequeLineID { get; set; }
        public int SortOrder { get; set; }
        public int TransSortOrder { get; set; }
        public string ChequeCode { get; set; }
        public byte ChequeTypeCode { get; set; }
        public string BankCode { get; set; }
        public string BankBranchCode { get; set; }
        public string LineDescription { get; set; }
        public string DocCurrencyCode { get; set; }
        public string ChequeCurrencyCode { get; set; }
        public double ChequeExchangeRate { get; set; }
        public string ImportFileNumber { get; set; }
        public string ExportFileNumber { get; set; }
        public bool BankProtestChargePaid { get; set; }
        public byte EmployeePayTypeCode { get; set; }
        public string Doc_CurrencyCode { get; set; }
        public decimal Doc_Amount { get; set; }
        public decimal Doc_ProtestCharge { get; set; }
        public decimal Doc_TransferCharge { get; set; }
        public string Loc_CurrencyCode { get; set; }
        public double Loc_ExchangeRate { get; set; }
        public decimal Loc_Amount { get; set; }
        public decimal Loc_ProtestCharge { get; set; }
        public decimal Loc_TransferCharge { get; set; }
        public string Com_CurrencyCode { get; set; }
        public double Com_ExchangeRate { get; set; }
        public decimal Com_Amount { get; set; }
        public decimal Com_ProtestCharge { get; set; }
        public decimal Com_TransferCharge { get; set; }
        public string ATAtt01 { get; set; }
        public string ATAtt02 { get; set; }
        public string ATAtt03 { get; set; }
        public string ATAtt04 { get; set; }
        public string ATAtt05 { get; set; }
    }
}
