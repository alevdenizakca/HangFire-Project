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
    
    public partial class cdATAttributeDesc
    {
        public byte AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
        public string LangCode { get; set; }
        public string AttributeDescription { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdATAttribute cdATAttribute { get; set; }
        public virtual cdDataLanguage cdDataLanguage { get; set; }
    }
}
