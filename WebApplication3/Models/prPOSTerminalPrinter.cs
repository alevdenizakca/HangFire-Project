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
    
    public partial class prPOSTerminalPrinter
    {
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public short POSTerminalID { get; set; }
        public byte FormType { get; set; }
        public bool PrintForm { get; set; }
        public string PrinterName { get; set; }
        public bool OpenPrintPreview { get; set; }
        public bool CanCancelPrint { get; set; }
        public byte NumberOfCopies { get; set; }
        public bool WaitOkPerPage { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdPOSTerminal cdPOSTerminal { get; set; }
    }
}