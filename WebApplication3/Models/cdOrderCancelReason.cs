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
    
    public partial class cdOrderCancelReason
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdOrderCancelReason()
        {
            this.cdOrderCancelReasonDesc = new HashSet<cdOrderCancelReasonDesc>();
            this.dfGetirCarsiOrderCancelReasonConvert = new HashSet<dfGetirCarsiOrderCancelReasonConvert>();
            this.dfOnlineSalesandPaymentParameters = new HashSet<dfOnlineSalesandPaymentParameters>();
            this.tpOrderCancelDetail = new HashSet<tpOrderCancelDetail>();
            this.trInnerOrderLine = new HashSet<trInnerOrderLine>();
            this.trOrderLine = new HashSet<trOrderLine>();
        }
    
        public string OrderCancelReasonCode { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdOrderCancelReasonDesc> cdOrderCancelReasonDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfGetirCarsiOrderCancelReasonConvert> dfGetirCarsiOrderCancelReasonConvert { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfOnlineSalesandPaymentParameters> dfOnlineSalesandPaymentParameters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderCancelDetail> tpOrderCancelDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInnerOrderLine> trInnerOrderLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderLine> trOrderLine { get; set; }
    }
}