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
    
    public partial class cdDiscountOfferAttribute
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdDiscountOfferAttribute()
        {
            this.cdDiscountOfferAttributeDesc = new HashSet<cdDiscountOfferAttributeDesc>();
            this.prDiscountOfferAttribute = new HashSet<prDiscountOfferAttribute>();
        }
    
        public byte AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public string Description { get; set; }
    
        public virtual cdDiscountOfferAttributeType cdDiscountOfferAttributeType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdDiscountOfferAttributeDesc> cdDiscountOfferAttributeDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prDiscountOfferAttribute> prDiscountOfferAttribute { get; set; }
    }
}
