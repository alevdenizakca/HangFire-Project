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
    
    public partial class e_InboxShipmentStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public e_InboxShipmentStatus()
        {
            this.e_InboxShipmentHeader = new HashSet<e_InboxShipmentHeader>();
            this.e_InboxShipmentResponseHeader = new HashSet<e_InboxShipmentResponseHeader>();
        }
    
        public byte InboxShipmentStatusCode { get; set; }
        public string InboxShipmentStatusDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<e_InboxShipmentHeader> e_InboxShipmentHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<e_InboxShipmentResponseHeader> e_InboxShipmentResponseHeader { get; set; }
    }
}
