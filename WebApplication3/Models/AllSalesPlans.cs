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
    
    public partial class AllSalesPlans
    {
        public System.Guid SalesPlanID { get; set; }
        public string SalesPlanNumber { get; set; }
        public System.DateTime PlanDate { get; set; }
        public decimal CompanyCode { get; set; }
        public short SalesYear { get; set; }
        public byte SalesMonth { get; set; }
        public byte SalesIsoWeek { get; set; }
        public string SalesPlanTypeCode { get; set; }
        public byte SalesWeek { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLocked { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsConfirmed { get; set; }
        public string ConfirmedUserName { get; set; }
        public System.DateTime ConfirmedDate { get; set; }
        public bool IsPostingOrder { get; set; }
        public bool IsPostingSaleOrder { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public System.Guid SubCurrAccID { get; set; }
        public int SortOrder { get; set; }
        public string StoreCode { get; set; }
        public string CustomerCode { get; set; }
        public byte ProductTypeCode { get; set; }
        public string ProductCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public double Qty1 { get; set; }
        public string LotCode { get; set; }
        public int LotQty { get; set; }
        public string LineDescription { get; set; }
        public System.Guid SalesPlanProductQtyID { get; set; }
        public System.Guid SalesPlanChannelID { get; set; }
        public System.Guid SalesPlanProductID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}