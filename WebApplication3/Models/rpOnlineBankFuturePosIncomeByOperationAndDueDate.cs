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
    
    public partial class rpOnlineBankFuturePosIncomeByOperationAndDueDate
    {
        public System.Guid OnlineBankFuturePosIncomeByOperationAndDueDateID { get; set; }
        public decimal CompanyCode { get; set; }
        public string PosPaymentID { get; set; }
        public string BankCode { get; set; }
        public string AccountID { get; set; }
        public string AccountName { get; set; }
        public string TaxNumber { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public System.DateTime ValorDate { get; set; }
        public string CurrencyCode { get; set; }
        public decimal GrossAmount { get; set; }
        public decimal TotalCommission { get; set; }
        public double CommissionRate { get; set; }
        public decimal Amount { get; set; }
        public decimal BankServiceCommission { get; set; }
        public decimal OtherCommission { get; set; }
        public string BusinessNo { get; set; }
        public string TerminalID { get; set; }
        public string AuthCode { get; set; }
        public int InstallmentNumber { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}
