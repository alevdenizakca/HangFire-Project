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
    
    public partial class cdProductHierarchyLevel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdProductHierarchyLevel()
        {
            this.cdProductHierarchyLevelDesc = new HashSet<cdProductHierarchyLevelDesc>();
            this.dfProductHierarchy = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy1 = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy2 = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy3 = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy4 = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy5 = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy6 = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy7 = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy8 = new HashSet<dfProductHierarchy>();
            this.dfProductHierarchy9 = new HashSet<dfProductHierarchy>();
        }
    
        public int ProductHierarchyLevelCode { get; set; }
        public int LevelNumber { get; set; }
        public string ProductCodeParameter { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdProductHierarchyLevelDesc> cdProductHierarchyLevelDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfProductHierarchy> dfProductHierarchy9 { get; set; }
    }
}