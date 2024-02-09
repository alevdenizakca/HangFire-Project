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
    
    public partial class RetailCustomerTransactionsNoOrderR
    {
        public string RetailCustomerCode { get; set; }
        public Nullable<System.DateTime> OperationDate { get; set; }
        public Nullable<System.TimeSpan> OperationTime { get; set; }
        public string DocumentNumber { get; set; }
        public string SeriesNumber { get; set; }
        public Nullable<byte> ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public Nullable<decimal> Debit { get; set; }
        public Nullable<decimal> Payment { get; set; }
        public Nullable<double> Qty1 { get; set; }
        public int CancelQty1 { get; set; }
        public Nullable<decimal> PriceVI { get; set; }
        public Nullable<double> AmountVI { get; set; }
        public Nullable<double> DiscountVI { get; set; }
        public Nullable<double> Tax { get; set; }
        public Nullable<double> TaxBase { get; set; }
        public Nullable<double> NetAmount { get; set; }
        public Nullable<bool> IsInvoiced { get; set; }
        public string Invoice { get; set; }
        public Nullable<byte> TaxTypeCode { get; set; }
        public string SalespersonCode { get; set; }
        public string PaymentPlanCode { get; set; }
        public string RoundsmanCode { get; set; }
        public Nullable<byte> DiscountReasonCode { get; set; }
        public string ReturnReasonCode { get; set; }
        public string ProcessCode { get; set; }
        public Nullable<int> ProcessFlowCode { get; set; }
        public Nullable<bool> IsReturn { get; set; }
        public Nullable<int> DebitTypeCode { get; set; }
        public Nullable<int> PaymentTypeCode { get; set; }
        public string Type { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public string StoreCode { get; set; }
        public decimal PolicyCompanyCode { get; set; }
        public string PolicyOfficeCode { get; set; }
        public string PolicyStoreCode { get; set; }
        public string WareHouseCode { get; set; }
        public Nullable<short> PosTerminalID { get; set; }
        public string DocCurrencyCode { get; set; }
        public Nullable<decimal> Doc_Payment { get; set; }
        public string CreditCardTypeCode { get; set; }
        public Nullable<int> InstallmentCount { get; set; }
        public Nullable<int> RemainingInstallmentCount { get; set; }
        public string Code { get; set; }
        public string AcquirerBankCode { get; set; }
        public string IssuerBankCode { get; set; }
        public string BankCode { get; set; }
        public string BankBranchCode { get; set; }
        public string BankAccountCode { get; set; }
        public int SortOrder { get; set; }
        public string LineDescription { get; set; }
        public System.Guid LineID { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string TransType { get; set; }
        public Nullable<System.Guid> HeaderID { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public string ATAtt01 { get; set; }
    }
}
