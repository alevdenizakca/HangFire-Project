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
    
    public partial class auSurveySectionPermit
    {
        public decimal CompanyCode { get; set; }
        public string RoleCode { get; set; }
        public string SurveyCode { get; set; }
        public int SurveySectionNumber { get; set; }
        public bool CanSelect { get; set; }
        public bool CanUpdate { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdRole cdRole { get; set; }
        public virtual cdSurveySection cdSurveySection { get; set; }
    }
}