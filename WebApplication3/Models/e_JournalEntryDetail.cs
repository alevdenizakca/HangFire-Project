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
    
    public partial class e_JournalEntryDetail
    {
        public long LineID { get; set; }
        public long LineNumberCounter { get; set; }
        public string DocumentReference { get; set; }
        public int LineNumber { get; set; }
        public string AccountMainID { get; set; }
        public string AccountMainDescription { get; set; }
        public string AccountSubID { get; set; }
        public string AccountSubDescription { get; set; }
        public decimal Amount { get; set; }
        public string Debitcreditcode { get; set; }
        public System.DateTime Postingdate { get; set; }
        public string DocumentType { get; set; }
        public string DocumentTypedescription { get; set; }
        public string DocumentNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public string PaymentMethot { get; set; }
        public string DetailComment { get; set; }
        public long HeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual e_JournalEntryHeader e_JournalEntryHeader { get; set; }
    }
}
