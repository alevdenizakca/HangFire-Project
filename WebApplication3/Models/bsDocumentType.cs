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
    
    public partial class bsDocumentType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsDocumentType()
        {
            this.bsDocumentTypeDesc = new HashSet<bsDocumentTypeDesc>();
            this.cdExpenseType = new HashSet<cdExpenseType>();
            this.cdPOSTerminal = new HashSet<cdPOSTerminal>();
            this.prMT940ProcessRules = new HashSet<prMT940ProcessRules>();
            this.trBankLine = new HashSet<trBankLine>();
            this.trExpenseSlipLine = new HashSet<trExpenseSlipLine>();
            this.trInvoiceHeader = new HashSet<trInvoiceHeader>();
            this.trJournalLine = new HashSet<trJournalLine>();
        }
    
        public byte DocumentTypeCode { get; set; }
        public string GLCode { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsDocumentTypeDesc> bsDocumentTypeDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdExpenseType> cdExpenseType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdPOSTerminal> cdPOSTerminal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prMT940ProcessRules> prMT940ProcessRules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBankLine> trBankLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trExpenseSlipLine> trExpenseSlipLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceHeader> trInvoiceHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trJournalLine> trJournalLine { get; set; }
    }
}
