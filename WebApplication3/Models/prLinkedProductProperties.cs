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
    
    public partial class prLinkedProductProperties
    {
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public byte LinkedProductTypeCode { get; set; }
        public byte ContentItemTypeCode { get; set; }
        public string ContentItemCode { get; set; }
        public string ColorCode { get; set; }
        public string LotCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsLinkedProductType bsLinkedProductType { get; set; }
        public virtual cdItem cdItem { get; set; }
    }
}
