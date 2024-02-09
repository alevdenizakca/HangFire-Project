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
    
    public partial class cdDeduction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdDeduction()
        {
            this.cdDeductionDesc = new HashSet<cdDeductionDesc>();
            this.dfCompanyDeductionDefault = new HashSet<dfCompanyDeductionDefault>();
            this.dfPayrollDefault = new HashSet<dfPayrollDefault>();
            this.trEmployeeDebit = new HashSet<trEmployeeDebit>();
            this.trPayrollLineDeduction = new HashSet<trPayrollLineDeduction>();
        }
    
        public string DeductionCode { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdDeductionDesc> cdDeductionDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfCompanyDeductionDefault> dfCompanyDeductionDefault { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfPayrollDefault> dfPayrollDefault { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trEmployeeDebit> trEmployeeDebit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPayrollLineDeduction> trPayrollLineDeduction { get; set; }
    }
}
