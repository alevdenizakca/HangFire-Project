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
    
    public partial class trCostCenterDistributions
    {
        public decimal CompanyCode { get; set; }
        public string ExpensePeriodCode { get; set; }
        public string CostCenterCode { get; set; }
        public string FromCostCenterCode { get; set; }
        public string GLAccCode { get; set; }
        public string LocalCurrencyCode { get; set; }
        public decimal CostAmount { get; set; }
        public decimal FixedCostAmount { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCostCenter cdCostCenter { get; set; }
        public virtual cdCostCenter cdCostCenter1 { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdExpensePeriod cdExpensePeriod { get; set; }
        public virtual cdGLAcc cdGLAcc { get; set; }
    }
}