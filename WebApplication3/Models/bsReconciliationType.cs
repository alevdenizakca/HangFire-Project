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
    
    public partial class bsReconciliationType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsReconciliationType()
        {
            this.bsReconciliationTypeDesc = new HashSet<bsReconciliationTypeDesc>();
            this.cdReconciliation = new HashSet<cdReconciliation>();
        }
    
        public byte ReconciliationTypeCode { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string SPName { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsCurrAccType bsCurrAccType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsReconciliationTypeDesc> bsReconciliationTypeDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdReconciliation> cdReconciliation { get; set; }
    }
}