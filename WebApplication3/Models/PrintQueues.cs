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
    
    public partial class PrintQueues
    {
        public System.Guid RowGuid { get; set; }
        public string UserName { get; set; }
        public string TargetDatabase { get; set; }
        public Nullable<System.DateTime> OperationTime { get; set; }
        public string ProcessCode { get; set; }
        public string ApplicationCode { get; set; }
        public string QueryTable { get; set; }
        public string QueryName { get; set; }
        public string KeyCodeName { get; set; }
        public string KeyCode { get; set; }
        public string LangCode { get; set; }
        public string DesignPath { get; set; }
        public string PrinterName { get; set; }
        public int Quantity { get; set; }
        public bool IsPrinted { get; set; }
        public string EArchiveHTML { get; set; }
        public bool IsEArchive { get; set; }
        public bool IsReturn { get; set; }
        public short Type { get; set; }
    }
}