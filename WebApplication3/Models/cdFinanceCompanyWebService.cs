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
    
    public partial class cdFinanceCompanyWebService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdFinanceCompanyWebService()
        {
            this.cdFinanceCompanyWebServiceDesc = new HashSet<cdFinanceCompanyWebServiceDesc>();
            this.dfCompanyDefault = new HashSet<dfCompanyDefault>();
        }
    
        public decimal CompanyCode { get; set; }
        public string FinanceCompanyWebServiceCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string WebServiceAddress { get; set; }
        public string PaymentApplicationFilePath { get; set; }
        public string PaymentApplicationName { get; set; }
        public int IdentitySharingSystemQueryPeriod { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdFinanceCompanyWebServiceDesc> cdFinanceCompanyWebServiceDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfCompanyDefault> dfCompanyDefault { get; set; }
    }
}
