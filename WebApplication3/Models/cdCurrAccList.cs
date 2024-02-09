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
    
    public partial class cdCurrAccList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdCurrAccList()
        {
            this.cdCurrAccListDesc = new HashSet<cdCurrAccListDesc>();
            this.dfSMSForCustomerRelationship = new HashSet<dfSMSForCustomerRelationship>();
            this.prCurrAccListContent = new HashSet<prCurrAccListContent>();
            this.prDiscountOfferRules = new HashSet<prDiscountOfferRules>();
        }
    
        public string CurrAccListCode { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CompanyBrandCode { get; set; }
        public double ControlGroupRate { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCompanyBrand cdCompanyBrand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCurrAccListDesc> cdCurrAccListDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfSMSForCustomerRelationship> dfSMSForCustomerRelationship { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccListContent> prCurrAccListContent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prDiscountOfferRules> prDiscountOfferRules { get; set; }
    }
}