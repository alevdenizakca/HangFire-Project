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
    
    public partial class dfPeriodicalAllocationRule
    {
        public decimal CompanyCode { get; set; }
        public string AllocationTemplateCode { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public int RepetitionPeriod { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool Activated { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdAllocationTemplate cdAllocationTemplate { get; set; }
        public virtual cdCompany cdCompany { get; set; }
    }
}
