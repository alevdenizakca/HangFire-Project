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
    
    public partial class cdEmployeeSocialInsuranceStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdEmployeeSocialInsuranceStatus()
        {
            this.cdEmployeeSocialInsuranceStatusDesc = new HashSet<cdEmployeeSocialInsuranceStatusDesc>();
            this.dfSocialInsuranceRates = new HashSet<dfSocialInsuranceRates>();
            this.hrEmployeePayrollProfile = new HashSet<hrEmployeePayrollProfile>();
        }
    
        public byte EmployeeSocialInsuranceStatusCode { get; set; }
        public string SGKDocumentType { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdEmployeeSocialInsuranceStatusDesc> cdEmployeeSocialInsuranceStatusDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfSocialInsuranceRates> dfSocialInsuranceRates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeePayrollProfile> hrEmployeePayrollProfile { get; set; }
    }
}