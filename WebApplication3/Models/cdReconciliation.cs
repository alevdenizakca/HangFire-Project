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
    
    public partial class cdReconciliation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdReconciliation()
        {
            this.cdReconciliationDesc = new HashSet<cdReconciliationDesc>();
            this.prCurrAccReconciliationContactReports = new HashSet<prCurrAccReconciliationContactReports>();
            this.trCurrAccReconciliationReport = new HashSet<trCurrAccReconciliationReport>();
        }
    
        public string ReconciliationCode { get; set; }
        public byte ReconciliationTypeCode { get; set; }
        public bool LockTransactions { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public bool ReportByCurrencyDetail { get; set; }
        public string ReportFileName { get; set; }
    
        public virtual bsReconciliationType bsReconciliationType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdReconciliationDesc> cdReconciliationDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccReconciliationContactReports> prCurrAccReconciliationContactReports { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCurrAccReconciliationReport> trCurrAccReconciliationReport { get; set; }
    }
}