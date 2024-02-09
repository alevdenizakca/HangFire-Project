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
    
    public partial class bsWithHoldingTaxType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsWithHoldingTaxType()
        {
            this.prWithHoldingTaxAvailableDovRates = new HashSet<prWithHoldingTaxAvailableDovRates>();
            this.trExpenseSlipLine = new HashSet<trExpenseSlipLine>();
            this.trInvoiceHeader = new HashSet<trInvoiceHeader>();
            this.trInvoiceLine = new HashSet<trInvoiceLine>();
            this.trJournalLine = new HashSet<trJournalLine>();
            this.trOrderHeader = new HashSet<trOrderHeader>();
            this.trOrderLine = new HashSet<trOrderLine>();
            this.trProposalHeader = new HashSet<trProposalHeader>();
            this.trProposalLine = new HashSet<trProposalLine>();
        }
    
        public string WithHoldingTaxTypeCode { get; set; }
        public string Description { get; set; }
        public byte TransTypeCode { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prWithHoldingTaxAvailableDovRates> prWithHoldingTaxAvailableDovRates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trExpenseSlipLine> trExpenseSlipLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceHeader> trInvoiceHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceLine> trInvoiceLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trJournalLine> trJournalLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderHeader> trOrderHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderLine> trOrderLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trProposalHeader> trProposalHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trProposalLine> trProposalLine { get; set; }
    }
}