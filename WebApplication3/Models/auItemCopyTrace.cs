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
    
    public partial class auItemCopyTrace
    {
        public System.Guid ItemCopyTraceID { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public byte SourceItemTypeCode { get; set; }
        public string SourceItemCode { get; set; }
        public string UserName { get; set; }
    }
}
