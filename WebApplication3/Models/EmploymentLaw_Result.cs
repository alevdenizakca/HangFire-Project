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
    
    public partial class EmploymentLaw_Result
    {
        public string EmploymentLawCode { get; set; }
        public string DeclarationLawNo { get; set; }
        public string EmploymentLawCodeForOffDay { get; set; }
        public string EmploymentLawCodeNext { get; set; }
        public bool IsMinWageAssessment { get; set; }
        public float ReductionRate { get; set; }
        public int ApplicableDayCount { get; set; }
        public bool ApplyEmployer { get; set; }
        public bool ApplyEmployee { get; set; }
        public float ShortTermInsuranceReductionRate { get; set; }
        public System.DateTime LawRepealDate { get; set; }
        public bool IsBlocked { get; set; }
        public string LangCode { get; set; }
        public string EmploymentLawDescription { get; set; }
    }
}
