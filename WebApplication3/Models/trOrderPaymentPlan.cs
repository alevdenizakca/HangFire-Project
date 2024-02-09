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
    
    public partial class trOrderPaymentPlan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trOrderPaymentPlan()
        {
            this.tpInnerLineDocument = new HashSet<tpInnerLineDocument>();
            this.trBadDebtTransLineInstalment = new HashSet<trBadDebtTransLineInstalment>();
            this.trOrderAdvancePayments = new HashSet<trOrderAdvancePayments>();
            this.trPaymentLine = new HashSet<trPaymentLine>();
        }
    
        public System.Guid OrderPaymentPlanID { get; set; }
        public System.DateTime DueDate { get; set; }
        public string LineDescription { get; set; }
        public string DocCurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal CanceledAmount { get; set; }
        public System.Guid OrderHeaderID { get; set; }
        public bool IsClosed { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdCurrency cdCurrency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpInnerLineDocument> tpInnerLineDocument { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBadDebtTransLineInstalment> trBadDebtTransLineInstalment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderAdvancePayments> trOrderAdvancePayments { get; set; }
        public virtual trOrderHeader trOrderHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPaymentLine> trPaymentLine { get; set; }
    }
}
