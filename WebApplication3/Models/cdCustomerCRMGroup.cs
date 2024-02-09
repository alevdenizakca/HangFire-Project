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
    
    public partial class cdCustomerCRMGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdCustomerCRMGroup()
        {
            this.cdCustomerCRMGroupDesc = new HashSet<cdCustomerCRMGroupDesc>();
            this.prCustomerPresentCard = new HashSet<prCustomerPresentCard>();
        }
    
        public string CustomerCRMGroupCode { get; set; }
        public string PresentCardTypeCode { get; set; }
        public byte CustomerShoppingLevelCode { get; set; }
        public byte CustomerShoppingHabitCode { get; set; }
        public byte CustomerAlertColorCode { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCustomerAlertColor cdCustomerAlertColor { get; set; }
        public virtual cdCustomerShoppingHabit cdCustomerShoppingHabit { get; set; }
        public virtual cdCustomerShoppingLevel cdCustomerShoppingLevel { get; set; }
        public virtual cdPresentCardType cdPresentCardType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCustomerCRMGroupDesc> cdCustomerCRMGroupDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCustomerPresentCard> prCustomerPresentCard { get; set; }
    }
}
