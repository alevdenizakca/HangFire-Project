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
    
    public partial class bsSendingData
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsSendingData()
        {
            this.prDataTransferTemplateQuery = new HashSet<prDataTransferTemplateQuery>();
        }
    
        public string TransferName { get; set; }
        public string ElementName { get; set; }
        public string WizardName { get; set; }
        public string SpName { get; set; }
        public bool IsOptional { get; set; }
        public string FileName { get; set; }
        public int SortOrder { get; set; }
        public bool UseLanguageFilter { get; set; }
        public bool UseElementNameFilter { get; set; }
        public byte TemplateType { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prDataTransferTemplateQuery> prDataTransferTemplateQuery { get; set; }
    }
}