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
    
    public partial class prRequisitionConfirmationRuleDepartments
    {
        public System.Guid RequisitionConfirmationRuleID { get; set; }
        public string JobDepartmentCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdJobDepartment cdJobDepartment { get; set; }
        public virtual cdRequisitionConfirmationRule cdRequisitionConfirmationRule { get; set; }
    }
}
