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
    
    public partial class auRetailInvoiceLineChangeTrace
    {
        public System.Guid TraceID { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public string ProcessCode { get; set; }
        public string InvoiceNumber { get; set; }
        public bool IsReturn { get; set; }
        public System.DateTime InvoiceDate { get; set; }
        public System.TimeSpan InvoiceTime { get; set; }
        public string Series { get; set; }
        public decimal SeriesNumber { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public short POSTerminalID { get; set; }
        public string OldSalespersonCode { get; set; }
        public string SalespersonCode { get; set; }
        public string OldReturnReasonCode { get; set; }
        public string ReturnReasonCode { get; set; }
        public string UserName { get; set; }
    }
}
