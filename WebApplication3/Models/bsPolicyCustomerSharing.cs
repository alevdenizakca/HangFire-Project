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
    
    public partial class bsPolicyCustomerSharing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsPolicyCustomerSharing()
        {
            this.bsPolicyCustomerSharingDesc = new HashSet<bsPolicyCustomerSharingDesc>();
            this.dfGlobalDefault = new HashSet<dfGlobalDefault>();
            this.dfGlobalDefault1 = new HashSet<dfGlobalDefault>();
            this.dfGlobalDefault2 = new HashSet<dfGlobalDefault>();
        }
    
        public byte PolicyCustomerSharing { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsPolicyCustomerSharingDesc> bsPolicyCustomerSharingDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfGlobalDefault> dfGlobalDefault { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfGlobalDefault> dfGlobalDefault1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfGlobalDefault> dfGlobalDefault2 { get; set; }
    }
}
