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
    
    public partial class dfPayrollForm
    {
        public decimal CompanyCode { get; set; }
        public byte FormType { get; set; }
        public string FormName1 { get; set; }
        public byte CopyCount1 { get; set; }
        public string FormName2 { get; set; }
        public byte CopyCount2 { get; set; }
        public bool AskCopyCount { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
    }
}
