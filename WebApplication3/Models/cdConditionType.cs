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
    
    public partial class cdConditionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdConditionType()
        {
            this.cdConditionTypeDesc = new HashSet<cdConditionTypeDesc>();
            this.dfRetailCustomerConditionalRequiredFields = new HashSet<dfRetailCustomerConditionalRequiredFields>();
            this.prPresentCardActivationSteps = new HashSet<prPresentCardActivationSteps>();
        }
    
        public string ConditionTypeCode { get; set; }
        public byte SortOrder { get; set; }
        public string ControlSpName { get; set; }
        public string CashierMessage { get; set; }
        public bool IsForPresentCardActivation { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdConditionTypeDesc> cdConditionTypeDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfRetailCustomerConditionalRequiredFields> dfRetailCustomerConditionalRequiredFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prPresentCardActivationSteps> prPresentCardActivationSteps { get; set; }
    }
}