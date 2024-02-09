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
    
    public partial class cdJournalLedger
    {
        public decimal CompanyCode { get; set; }
        public string JournalLedgerCode { get; set; }
        public short JournalYear { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public long StartingNumber { get; set; }
        public long EndingNumber { get; set; }
        public string Description { get; set; }
        public decimal TurnoverDebit { get; set; }
        public decimal TurnoverCredit { get; set; }
        public double TurnoverDebitQty { get; set; }
        public double TurnoverCreditQty { get; set; }
        public bool IsConfirmed { get; set; }
        public string ConfirmedUserName { get; set; }
        public System.DateTime ConfirmedDate { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    }
}