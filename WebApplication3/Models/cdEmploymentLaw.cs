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
    
    public partial class cdEmploymentLaw
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdEmploymentLaw()
        {
            this.cdEmploymentLawDesc = new HashSet<cdEmploymentLawDesc>();
            this.hrEmployeePayrollProfile = new HashSet<hrEmployeePayrollProfile>();
            this.hrSGKMonthlyDocument = new HashSet<hrSGKMonthlyDocument>();
        }
    
        public string EmploymentLawCode { get; set; }
        public string DeclarationLawNo { get; set; }
        public string EmploymentLawCodeForOffDay { get; set; }
        public string EmploymentLawCodeNext { get; set; }
        public bool IsMinWageAssessment { get; set; }
        public float ReductionRate { get; set; }
        public int ApplicableDayCount { get; set; }
        public bool ApplyEmployer { get; set; }
        public bool ApplyEmployee { get; set; }
        public float ShortTermInsuranceReductionRate { get; set; }
        public System.DateTime LawRepealDate { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdEmploymentLawDesc> cdEmploymentLawDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeePayrollProfile> hrEmployeePayrollProfile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrSGKMonthlyDocument> hrSGKMonthlyDocument { get; set; }
    }
}
