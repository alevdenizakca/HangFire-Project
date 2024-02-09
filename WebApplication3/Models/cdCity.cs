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
    
    public partial class cdCity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdCity()
        {
            this.bsTaxFreeRefundCompany = new HashSet<bsTaxFreeRefundCompany>();
            this.cdCheque = new HashSet<cdCheque>();
            this.cdCityDesc = new HashSet<cdCityDesc>();
            this.cdDistrict = new HashSet<cdDistrict>();
            this.cdExecutionOffice = new HashSet<cdExecutionOffice>();
            this.cdPort = new HashSet<cdPort>();
            this.cdTaxOffice = new HashSet<cdTaxOffice>();
            this.cdWorkPlace = new HashSet<cdWorkPlace>();
            this.dfCompanyDefault = new HashSet<dfCompanyDefault>();
            this.dfOfficeDefault = new HashSet<dfOfficeDefault>();
            this.prBankBranch = new HashSet<prBankBranch>();
            this.prCurrAccPersonalInfo = new HashSet<prCurrAccPersonalInfo>();
            this.prCurrAccPostalAddress = new HashSet<prCurrAccPostalAddress>();
            this.prEmployeePrevJob = new HashSet<prEmployeePrevJob>();
            this.prResponsibilityAreaPostalAddress = new HashSet<prResponsibilityAreaPostalAddress>();
            this.prWarehousePostalAddress = new HashSet<prWarehousePostalAddress>();
            this.tpInvoiceadditionalDeliveryProcessesDistance = new HashSet<tpInvoiceadditionalDeliveryProcessesDistance>();
            this.tpInvoicePostalAddress = new HashSet<tpInvoicePostalAddress>();
            this.tpOrderPostalAddress = new HashSet<tpOrderPostalAddress>();
        }
    
        public string CityCode { get; set; }
        public string StateCode { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsTaxFreeRefundCompany> bsTaxFreeRefundCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCheque> cdCheque { get; set; }
        public virtual cdState cdState { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCityDesc> cdCityDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdDistrict> cdDistrict { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdExecutionOffice> cdExecutionOffice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdPort> cdPort { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdTaxOffice> cdTaxOffice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdWorkPlace> cdWorkPlace { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfCompanyDefault> dfCompanyDefault { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfOfficeDefault> dfOfficeDefault { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prBankBranch> prBankBranch { get; set; }
        public virtual prCityMapLocation prCityMapLocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccPersonalInfo> prCurrAccPersonalInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccPostalAddress> prCurrAccPostalAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prEmployeePrevJob> prEmployeePrevJob { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prResponsibilityAreaPostalAddress> prResponsibilityAreaPostalAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prWarehousePostalAddress> prWarehousePostalAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpInvoiceadditionalDeliveryProcessesDistance> tpInvoiceadditionalDeliveryProcessesDistance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpInvoicePostalAddress> tpInvoicePostalAddress { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderPostalAddress> tpOrderPostalAddress { get; set; }
    }
}