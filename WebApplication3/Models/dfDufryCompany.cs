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
    
    public partial class dfDufryCompany
    {
        public decimal CompanyCode { get; set; }
        public string FTPUserName { get; set; }
        public string FTPPassword { get; set; }
        public string FTPFileDirectory { get; set; }
        public byte FTPExchangeTypeCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public byte FTPExchangeTypeCodeForDomesticStore { get; set; }
    
        public virtual cdExchangeType cdExchangeType { get; set; }
        public virtual cdExchangeType cdExchangeType1 { get; set; }
    }
}
