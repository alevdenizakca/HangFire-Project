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
    
    public partial class cdScheduleReSendSMSForCustomerRelationship
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdScheduleReSendSMSForCustomerRelationship()
        {
            this.dfReSendSMSForCustomerRelationship = new HashSet<dfReSendSMSForCustomerRelationship>();
        }
    
        public int ScheduleID { get; set; }
        public string ScheduleName { get; set; }
        public bool IsEnabled { get; set; }
        public string jsonData { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfReSendSMSForCustomerRelationship> dfReSendSMSForCustomerRelationship { get; set; }
    }
}
