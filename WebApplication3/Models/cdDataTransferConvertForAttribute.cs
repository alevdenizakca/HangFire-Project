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
    
    public partial class cdDataTransferConvertForAttribute
    {
        public string ConvertTypeCode { get; set; }
        public byte ExternalAttributeType { get; set; }
        public string ExternalCode { get; set; }
        public byte InternalAttributeType { get; set; }
        public string InternalCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsDataTransferConvertType bsDataTransferConvertType { get; set; }
    }
}
