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
    
    public partial class dfEInvoiceOfficialForm
    {
        public string OfficeCode { get; set; }
        public string ProcessCode { get; set; }
        public byte ProcessFlowCode { get; set; }
        public byte FormType { get; set; }
        public string XsltName { get; set; }
        public string XsltData { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsProcess bsProcess { get; set; }
        public virtual bsProcessFlow bsProcessFlow { get; set; }
        public virtual cdOffice cdOffice { get; set; }
    }
}
