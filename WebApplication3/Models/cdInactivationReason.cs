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
    
    public partial class cdInactivationReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdInactivationReason()
        {
            this.cdInactivationReasonDesc = new HashSet<cdInactivationReasonDesc>();
            this.dfCompanyDefault = new HashSet<dfCompanyDefault>();
            this.prCurrAccPersonalDataConfirmation = new HashSet<prCurrAccPersonalDataConfirmation>();
            this.prCustomerPresentCard = new HashSet<prCustomerPresentCard>();
        }
    
        public string InactivationReasonCode { get; set; }
        public bool CanNotBeReActivated { get; set; }
        public bool CanCreateNewPresentCard { get; set; }
        public bool UseStore { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdInactivationReasonDesc> cdInactivationReasonDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfCompanyDefault> dfCompanyDefault { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccPersonalDataConfirmation> prCurrAccPersonalDataConfirmation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCustomerPresentCard> prCustomerPresentCard { get; set; }
    }
}
