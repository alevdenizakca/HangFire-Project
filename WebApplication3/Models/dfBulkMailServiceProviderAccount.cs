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
    
    public partial class dfBulkMailServiceProviderAccount
    {
        public System.Guid BulkMailServiceProviderAccountID { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public string CompanyBrandCode { get; set; }
        public byte BulkMailServiceProviderCode { get; set; }
        public string SFTPHost { get; set; }
        public int SFTPPort { get; set; }
        public string SFTPUserName { get; set; }
        public string SFTPPassword { get; set; }
        public string SFTPOutgoingDirectory { get; set; }
        public string SFTPIncomingDirectory { get; set; }
        public string WebServiceUsername { get; set; }
        public string WebServicePassword { get; set; }
        public string WebServiceAddress1 { get; set; }
        public string WebServiceAddress2 { get; set; }
        public string WebServiceAddress3 { get; set; }
        public string WebServiceAddress4 { get; set; }
        public string NotificationEmailAddress { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual bsBulkMailServiceProvider bsBulkMailServiceProvider { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCompanyBrand cdCompanyBrand { get; set; }
    }
}