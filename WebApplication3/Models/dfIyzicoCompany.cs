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
    
    public partial class dfIyzicoCompany
    {
        public decimal CompanyCode { get; set; }
        public string ServiceAddress { get; set; }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public string MerchantID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public string IP { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
    }
}
