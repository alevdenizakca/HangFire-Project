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
    
    public partial class OnlineBankWebService_Result
    {
        public decimal CompanyCode { get; set; }
        public string OnlineBankWebServiceCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string WebServiceAddress { get; set; }
        public string ApiKey { get; set; }
        public bool IsBlocked { get; set; }
        public System.DateTime StartDate { get; set; }
        public bool UsePaymentIDAsLineDesription { get; set; }
        public string LangCode { get; set; }
        public string OnlineBankWebServiceDescription { get; set; }
    }
}
