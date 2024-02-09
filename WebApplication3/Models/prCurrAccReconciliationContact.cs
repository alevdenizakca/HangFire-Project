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
    
    public partial class prCurrAccReconciliationContact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prCurrAccReconciliationContact()
        {
            this.prCurrAccReconciliationContactReports = new HashSet<prCurrAccReconciliationContactReports>();
            this.trCurrAccReconciliationEMailNotification = new HashSet<trCurrAccReconciliationEMailNotification>();
            this.trCurrAccReconciliationReportConfirmation = new HashSet<trCurrAccReconciliationReportConfirmation>();
        }
    
        public System.Guid ReconciliationContactID { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public Nullable<System.Guid> MobilePhoneCommunicationID { get; set; }
        public Nullable<System.Guid> EMailCommunicationID { get; set; }
        public string UserName { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual prCurrAccCommunication prCurrAccCommunication { get; set; }
        public virtual prCurrAccCommunication prCurrAccCommunication1 { get; set; }
        public virtual prCurrAccContact prCurrAccContact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccReconciliationContactReports> prCurrAccReconciliationContactReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCurrAccReconciliationEMailNotification> trCurrAccReconciliationEMailNotification { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCurrAccReconciliationReportConfirmation> trCurrAccReconciliationReportConfirmation { get; set; }
    }
}