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
    
    public partial class zpPaynetCreditCardPaymentEventLog
    {
        public System.Guid PaynetCreditCardPaymentEventLogID { get; set; }
        public System.Guid CorrelationId { get; set; }
        public System.DateTime OperationDate { get; set; }
        public string EventType { get; set; }
        public string JsonData { get; set; }
        public string ApplicationCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}
