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
    
    public partial class prRequisitionConfirmationRuleStep
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prRequisitionConfirmationRuleStep()
        {
            this.prRequisitionConfirmationRuleStepUser = new HashSet<prRequisitionConfirmationRuleStepUser>();
            this.rpPurchaseRequisitionConfirmationHistory = new HashSet<rpPurchaseRequisitionConfirmationHistory>();
            this.tpPurchaseRequisitionConfirmation = new HashSet<tpPurchaseRequisitionConfirmation>();
            this.trPurchaseRequisitionConfirmationEMailNotification = new HashSet<trPurchaseRequisitionConfirmationEMailNotification>();
        }
    
        public System.Guid RequisitionConfirmationRuleID { get; set; }
        public int SortOrder { get; set; }
        public bool IsRequired { get; set; }
        public int ExpireTimeForNextStep { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public bool ValidateRequisitionConfirmationLimit { get; set; }
    
        public virtual cdRequisitionConfirmationRule cdRequisitionConfirmationRule { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prRequisitionConfirmationRuleStepUser> prRequisitionConfirmationRuleStepUser { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rpPurchaseRequisitionConfirmationHistory> rpPurchaseRequisitionConfirmationHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionConfirmation> tpPurchaseRequisitionConfirmation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPurchaseRequisitionConfirmationEMailNotification> trPurchaseRequisitionConfirmationEMailNotification { get; set; }
    }
}
