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
    
    public partial class bsTransferPlanRule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsTransferPlanRule()
        {
            this.bsTransferPlanRuleDesc = new HashSet<bsTransferPlanRuleDesc>();
            this.cdTransferPlanTemplate = new HashSet<cdTransferPlanTemplate>();
            this.trTransferPlan = new HashSet<trTransferPlan>();
        }
    
        public string TransferPlanRuleCode { get; set; }
        public string ClassName { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsTransferPlanRuleDesc> bsTransferPlanRuleDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdTransferPlanTemplate> cdTransferPlanTemplate { get; set; }
        public virtual prTransferPlanRuleScript prTransferPlanRuleScript { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trTransferPlan> trTransferPlan { get; set; }
    }
}
