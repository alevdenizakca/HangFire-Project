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
    
    public partial class bsConfirmationStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsConfirmationStatus()
        {
            this.bsConfirmationStatusDesc = new HashSet<bsConfirmationStatusDesc>();
            this.tpProposalLineConfirmationStatus = new HashSet<tpProposalLineConfirmationStatus>();
            this.tpPurchaseRequisitionProposal = new HashSet<tpPurchaseRequisitionProposal>();
        }
    
        public byte ConfirmationStatusCode { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsConfirmationStatusDesc> bsConfirmationStatusDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpProposalLineConfirmationStatus> tpProposalLineConfirmationStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionProposal> tpPurchaseRequisitionProposal { get; set; }
    }
}
