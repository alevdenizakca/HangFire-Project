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
    
    public partial class prDeclarationTypeDetail
    {
        public byte DeclarationTypeCode { get; set; }
        public byte TypeCode { get; set; }
        public string TypeDescription { get; set; }
        public string LineCode { get; set; }
        public string GroupDescription { get; set; }
        public string Description { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsDeclarationType bsDeclarationType { get; set; }
    }
}
