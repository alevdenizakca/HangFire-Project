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
    
    public partial class zpHopiStartCoinTransaction
    {
        public System.Guid StartCoinTransactionID { get; set; }
        public System.Guid GetHopiUserInfoID { get; set; }
        public System.Guid InvoiceHeaderID { get; set; }
        public string MerchantCode { get; set; }
        public string StoreCode { get; set; }
        public long BirdID { get; set; }
        public decimal Amount { get; set; }
        public string ResponseCode { get; set; }
        public decimal ProvisionID { get; set; }
        public bool OtpNeeded { get; set; }
        public int OperationStatus { get; set; }
        public string ApplicationName { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}