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
    
    public partial class tpPurchaseRequisitionRevision
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tpPurchaseRequisitionRevision()
        {
            this.rpPurchaseRequisitionConfirmationHistory = new HashSet<rpPurchaseRequisitionConfirmationHistory>();
        }
    
        public System.Guid PurchaseRequisitionLineID { get; set; }
        public byte RevisionNumber { get; set; }
        public string RevisionDescription { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rpPurchaseRequisitionConfirmationHistory> rpPurchaseRequisitionConfirmationHistory { get; set; }
        public virtual trPurchaseRequisitionLine trPurchaseRequisitionLine { get; set; }
    }
}