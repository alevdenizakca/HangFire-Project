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
    
    public partial class zt_RGN_ProductAttributeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zt_RGN_ProductAttributeType()
        {
            this.zt_RGN_ProductAttribute = new HashSet<zt_RGN_ProductAttribute>();
        }
    
        public byte AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
        public string AttributeDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zt_RGN_ProductAttribute> zt_RGN_ProductAttribute { get; set; }
    }
}
