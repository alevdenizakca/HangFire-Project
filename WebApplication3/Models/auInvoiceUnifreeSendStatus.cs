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
    
    public partial class auInvoiceUnifreeSendStatus
    {
        public System.Guid InvoiceUnifreeSendStatusID { get; set; }
        public System.Guid InvoiceHeaderID { get; set; }
        public string Target { get; set; }
        public string ServiceMethod { get; set; }
        public string StatusCode { get; set; }
        public string CustomProvisionNumber { get; set; }
        public int RetryCount { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}
