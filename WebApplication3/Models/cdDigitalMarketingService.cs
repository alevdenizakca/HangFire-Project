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
    
    public partial class cdDigitalMarketingService
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdDigitalMarketingService()
        {
            this.cdDigitalMarketingServiceDesc = new HashSet<cdDigitalMarketingServiceDesc>();
            this.dfCompanyDigitalMarketingServiceAdress = new HashSet<dfCompanyDigitalMarketingServiceAdress>();
            this.dfStoreDigitalMarketingService = new HashSet<dfStoreDigitalMarketingService>();
            this.prDiscountOfferRules = new HashSet<prDiscountOfferRules>();
            this.trInvoiceHeader = new HashSet<trInvoiceHeader>();
        }
    
        public string DigitalMarketingServiceCode { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdDigitalMarketingServiceDesc> cdDigitalMarketingServiceDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfCompanyDigitalMarketingServiceAdress> dfCompanyDigitalMarketingServiceAdress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfStoreDigitalMarketingService> dfStoreDigitalMarketingService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prDiscountOfferRules> prDiscountOfferRules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceHeader> trInvoiceHeader { get; set; }
    }
}