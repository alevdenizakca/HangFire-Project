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
    
    public partial class e_OutboxShipmentStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public e_OutboxShipmentStatus()
        {
            this.e_OutboxShipmentHeader = new HashSet<e_OutboxShipmentHeader>();
            this.e_OutboxShipmentResponseHeader = new HashSet<e_OutboxShipmentResponseHeader>();
        }
    
        public byte OutboxShipmentStatusCode { get; set; }
        public string OutboxShipmentStatusDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<e_OutboxShipmentHeader> e_OutboxShipmentHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<e_OutboxShipmentResponseHeader> e_OutboxShipmentResponseHeader { get; set; }
    }
}
