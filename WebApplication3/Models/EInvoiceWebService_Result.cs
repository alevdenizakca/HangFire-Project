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
    
    public partial class EInvoiceWebService_Result
    {
        public decimal CompanyCode { get; set; }
        public string EInvoiceWebServiceCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string WebServiceAddress1 { get; set; }
        public string WebServiceAddress2 { get; set; }
        public System.TimeSpan ReceiveCustomerPeriod { get; set; }
        public System.TimeSpan SendInvoicePeriod { get; set; }
        public System.TimeSpan ReceiveInvoicePeriod { get; set; }
        public System.TimeSpan AskInboxStatusPeriod { get; set; }
        public System.TimeSpan AskOutboxStatusPeriod { get; set; }
        public bool IsBlocked { get; set; }
        public string LangCode { get; set; }
        public string EInvoiceWebServiceDescription { get; set; }
    }
}