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
    
    public partial class Reconciliation_Result
    {
        public string ReconciliationCode { get; set; }
        public byte ReconciliationTypeCode { get; set; }
        public bool LockTransactions { get; set; }
        public bool IsBlocked { get; set; }
        public bool ReportByCurrencyDetail { get; set; }
        public string ReportFileName { get; set; }
        public string LangCode { get; set; }
        public string ReconciliationDescription { get; set; }
    }
}