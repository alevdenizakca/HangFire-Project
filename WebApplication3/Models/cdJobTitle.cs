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
    
    public partial class cdJobTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdJobTitle()
        {
            this.cdJobPosition = new HashSet<cdJobPosition>();
            this.cdJobTitleDesc = new HashSet<cdJobTitleDesc>();
            this.hrEmployeeJobTitle = new HashSet<hrEmployeeJobTitle>();
            this.hrJobTitleOrganizationChart = new HashSet<hrJobTitleOrganizationChart>();
            this.prCurrAccContact = new HashSet<prCurrAccContact>();
            this.prEmployeePrevJob = new HashSet<prEmployeePrevJob>();
            this.prEmployeeWorkplaceInformation = new HashSet<prEmployeeWorkplaceInformation>();
            this.prWorkPlaceOptimalEmployment = new HashSet<prWorkPlaceOptimalEmployment>();
        }
    
        public string JobTitleCode { get; set; }
        public string BasicSkills { get; set; }
        public string TermsOfReference { get; set; }
        public bool IsDepartmentManager { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public byte JobTitleLevelCode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdJobPosition> cdJobPosition { get; set; }
        public virtual cdJobTitleLevel cdJobTitleLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdJobTitleDesc> cdJobTitleDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeeJobTitle> hrEmployeeJobTitle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrJobTitleOrganizationChart> hrJobTitleOrganizationChart { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccContact> prCurrAccContact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prEmployeePrevJob> prEmployeePrevJob { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prEmployeeWorkplaceInformation> prEmployeeWorkplaceInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prWorkPlaceOptimalEmployment> prWorkPlaceOptimalEmployment { get; set; }
    }
}
