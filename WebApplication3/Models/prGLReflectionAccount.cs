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
    
    public partial class prGLReflectionAccount
    {
        public System.Guid GLReflectionID { get; set; }
        public decimal CompanyCode { get; set; }
        public string GLReflectionCode { get; set; }
        public string ExpenseGLAccCode { get; set; }
        public string ReflectionGLAccCode { get; set; }
        public string IncomeGLAccCode { get; set; }
        public float Rate { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdGLAcc cdGLAcc { get; set; }
        public virtual cdGLAcc cdGLAcc1 { get; set; }
        public virtual cdGLAcc cdGLAcc2 { get; set; }
        public virtual cdGLReflection cdGLReflection { get; set; }
    }
}