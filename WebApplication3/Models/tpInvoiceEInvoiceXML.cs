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
    
    public partial class tpInvoiceEInvoiceXML
    {
        public System.Guid InvoiceHeaderID { get; set; }
        public string XmlData { get; set; }
        public byte SendStatus { get; set; }
        public string IncomingMsg { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public string StoreCode { get; set; }
        public short POSTerminalID { get; set; }
        public string EmailAddress { get; set; }
        public string GSMNo { get; set; }
        public string InvoiceURL { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual trInvoiceHeader trInvoiceHeader { get; set; }
    }
}
