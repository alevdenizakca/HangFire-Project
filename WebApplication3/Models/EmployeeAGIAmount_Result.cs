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
    
    public partial class EmployeeAGIAmount_Result
    {
        public string EmployeeCode { get; set; }
        public Nullable<bool> BenefitByAgi { get; set; }
        public Nullable<bool> BenefitByAgiForSpouse { get; set; }
        public Nullable<byte> BenefitByAgiChildCount { get; set; }
        public Nullable<float> TotalRate { get; set; }
        public Nullable<decimal> AGIAmount { get; set; }
    }
}
