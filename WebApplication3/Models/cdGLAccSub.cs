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
    
    public partial class cdGLAccSub
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdGLAccSub()
        {
            this.cdGLAcc = new HashSet<cdGLAcc>();
            this.cdGLAccSubDesc = new HashSet<cdGLAccSubDesc>();
        }
    
        public decimal CompanyCode { get; set; }
        public string GLAccMainCode { get; set; }
        public string GLAccSubCode1 { get; set; }
        public string GLAccSubCode2 { get; set; }
        public string GLAccSubCode3 { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdGLAcc> cdGLAcc { get; set; }
        public virtual cdGLAccMain cdGLAccMain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdGLAccSubDesc> cdGLAccSubDesc { get; set; }
    }
}
