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
    
    public partial class e_OutboxStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public e_OutboxStatus()
        {
            this.e_OutboxInvoiceHeader = new HashSet<e_OutboxInvoiceHeader>();
        }
    
        public byte OutboxStatusCode { get; set; }
        public string OutboxStatusDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<e_OutboxInvoiceHeader> e_OutboxInvoiceHeader { get; set; }
    }
}