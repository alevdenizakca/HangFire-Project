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
    
    public partial class cdEmployeeTaxStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdEmployeeTaxStatus()
        {
            this.cdEmployeeTaxStatusDesc = new HashSet<cdEmployeeTaxStatusDesc>();
            this.dfIncomeTaxRelief = new HashSet<dfIncomeTaxRelief>();
            this.hrEmployeePayrollProfile = new HashSet<hrEmployeePayrollProfile>();
        }
    
        public byte EmployeeTaxStatusCode { get; set; }
        public bool ExemptFromIncomeTax { get; set; }
        public bool ExemptFromStampDuty { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdEmployeeTaxStatusDesc> cdEmployeeTaxStatusDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfIncomeTaxRelief> dfIncomeTaxRelief { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeePayrollProfile> hrEmployeePayrollProfile { get; set; }
    }
}
