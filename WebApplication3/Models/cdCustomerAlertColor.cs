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
    
    public partial class cdCustomerAlertColor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdCustomerAlertColor()
        {
            this.cdCustomerAlertColorDesc = new HashSet<cdCustomerAlertColorDesc>();
            this.cdCustomerCRMGroup = new HashSet<cdCustomerCRMGroup>();
            this.prCustomerCompanyBrandAttribute = new HashSet<prCustomerCompanyBrandAttribute>();
        }
    
        public byte CustomerAlertColorCode { get; set; }
        public string ColorHex { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCustomerAlertColorDesc> cdCustomerAlertColorDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCustomerCRMGroup> cdCustomerCRMGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCustomerCompanyBrandAttribute> prCustomerCompanyBrandAttribute { get; set; }
    }
}