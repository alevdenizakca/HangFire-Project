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
    
    public partial class tpInvoiceSGKExtensions
    {
        public System.Guid InvoiceHeaderID { get; set; }
        public string SubInvoiceType { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public string DocumentNumber { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual trInvoiceHeader trInvoiceHeader { get; set; }
    }
}