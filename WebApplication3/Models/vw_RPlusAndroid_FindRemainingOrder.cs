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
    
    public partial class vw_RPlusAndroid_FindRemainingOrder
    {
        public string ProcessCode { get; set; }
        public string CustomerCode { get; set; }
        public string OrderNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public string CurrAccCode { get; set; }
        public string WarehouseCode { get; set; }
        public Nullable<double> OrderQty1 { get; set; }
        public double RemainingOrderQty { get; set; }
    }
}