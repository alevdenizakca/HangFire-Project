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
    
    public partial class prPCTGLAccs
    {
        public string OfficeCode { get; set; }
        public string PCTCode { get; set; }
        public string ProcessCode { get; set; }
        public byte PostAccTypeCode { get; set; }
        public decimal CompanyCode { get; set; }
        public string GLAccCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsPostAccType bsPostAccType { get; set; }
        public virtual bsProcess bsProcess { get; set; }
        public virtual cdGLAcc cdGLAcc { get; set; }
        public virtual cdOffice cdOffice { get; set; }
        public virtual cdPCT cdPCT { get; set; }
    }
}
