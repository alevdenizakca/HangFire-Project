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
    
    public partial class prGLAccUserWarning
    {
        public System.Guid GLAccUserWarningID { get; set; }
        public decimal CompanyCode { get; set; }
        public string GLAccCode { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public string UserWarningCode { get; set; }
        public string LineDescription { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdGLAcc cdGLAcc { get; set; }
        public virtual cdUserWarning cdUserWarning { get; set; }
    }
}
