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
    
    public partial class auTsmTransactionInfo
    {
        public System.Guid TsmTransactionInfoID { get; set; }
        public int SortOrder { get; set; }
        public string TsmTransactionID { get; set; }
        public string StoreCode { get; set; }
        public short POSTerminalID { get; set; }
        public byte DocumentType { get; set; }
        public System.Guid InvoiceHeaderID { get; set; }
        public string IdentityNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
        public string DocumentNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public int GetCount { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public bool CancelledFromDevice { get; set; }
    }
}