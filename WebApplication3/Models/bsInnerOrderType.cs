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
    
    public partial class bsInnerOrderType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsInnerOrderType()
        {
            this.bsInnerOrderTypeDesc = new HashSet<bsInnerOrderTypeDesc>();
            this.trInnerOrderHeader = new HashSet<trInnerOrderHeader>();
        }
    
        public byte InnerOrderTypeCode { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsInnerOrderTypeDesc> bsInnerOrderTypeDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInnerOrderHeader> trInnerOrderHeader { get; set; }
    }
}
