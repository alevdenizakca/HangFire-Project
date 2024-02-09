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
    
    public partial class trVendorPriceListLine
    {
        public System.Guid VendorPriceListLineID { get; set; }
        public int SortOrder { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public string PurchasePlanCode { get; set; }
        public string LineDescription { get; set; }
        public string DocCurrencyCode { get; set; }
        public decimal Price { get; set; }
        public bool IsDisabled { get; set; }
        public System.DateTime DisableDate { get; set; }
        public System.Guid VendorPriceListHeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdColor cdColor { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdItem cdItem { get; set; }
        public virtual cdItemDim1 cdItemDim1 { get; set; }
        public virtual cdItemDim2 cdItemDim2 { get; set; }
        public virtual cdItemDim3 cdItemDim3 { get; set; }
        public virtual cdPurchasePlan cdPurchasePlan { get; set; }
        public virtual cdUnitOfMeasure cdUnitOfMeasure { get; set; }
        public virtual trVendorPriceListHeader trVendorPriceListHeader { get; set; }
    }
}