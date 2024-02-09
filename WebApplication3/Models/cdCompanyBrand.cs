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
    
    public partial class cdCompanyBrand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdCompanyBrand()
        {
            this.auOptInOptOutTrace = new HashSet<auOptInOptOutTrace>();
            this.cdCompanyBrandDesc = new HashSet<cdCompanyBrandDesc>();
            this.cdCurrAccList = new HashSet<cdCurrAccList>();
            this.cdPresentCardType = new HashSet<cdPresentCardType>();
            this.dfBulkMailServiceProviderAccount = new HashSet<dfBulkMailServiceProviderAccount>();
            this.dfMobilDevCompanyBrandCollectorID = new HashSet<dfMobilDevCompanyBrandCollectorID>();
            this.dfMobilDevStoreCompanyBrandCollectorID = new HashSet<dfMobilDevStoreCompanyBrandCollectorID>();
            this.dfOnlineSalesandPaymentParameters = new HashSet<dfOnlineSalesandPaymentParameters>();
            this.dfSMSForCustomerRelationship = new HashSet<dfSMSForCustomerRelationship>();
            this.prCurrAccCompanyBrand = new HashSet<prCurrAccCompanyBrand>();
            this.prCurrAccOptInOptOutStatus = new HashSet<prCurrAccOptInOptOutStatus>();
            this.prCustomerCompanyBrandAttribute = new HashSet<prCustomerCompanyBrandAttribute>();
            this.prInteractiveSMSApplications = new HashSet<prInteractiveSMSApplications>();
            this.prItemCompanyBrand = new HashSet<prItemCompanyBrand>();
        }
    
        public string CompanyBrandCode { get; set; }
        public string Originator { get; set; }
        public string OTPOriginator { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auOptInOptOutTrace> auOptInOptOutTrace { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCompanyBrandDesc> cdCompanyBrandDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCurrAccList> cdCurrAccList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdPresentCardType> cdPresentCardType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfBulkMailServiceProviderAccount> dfBulkMailServiceProviderAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfMobilDevCompanyBrandCollectorID> dfMobilDevCompanyBrandCollectorID { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfMobilDevStoreCompanyBrandCollectorID> dfMobilDevStoreCompanyBrandCollectorID { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfOnlineSalesandPaymentParameters> dfOnlineSalesandPaymentParameters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfSMSForCustomerRelationship> dfSMSForCustomerRelationship { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccCompanyBrand> prCurrAccCompanyBrand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccOptInOptOutStatus> prCurrAccOptInOptOutStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCustomerCompanyBrandAttribute> prCustomerCompanyBrandAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prInteractiveSMSApplications> prInteractiveSMSApplications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemCompanyBrand> prItemCompanyBrand { get; set; }
    }
}
