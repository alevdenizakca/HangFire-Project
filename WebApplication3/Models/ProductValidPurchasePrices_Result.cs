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
    
    public partial class ProductValidPurchasePrices_Result
    {
        public byte VendorTypeCode { get; set; }
        public string VendorCode { get; set; }
        public string VendorPriceListNumber { get; set; }
        public System.DateTime VendorPriceListDate { get; set; }
        public System.DateTime ValidDate { get; set; }
        public System.DateTime ExpiredDate { get; set; }
        public bool IsTaxIncluded { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public string DocCurrencyCode { get; set; }
        public decimal Price { get; set; }
        public bool IsDisabled { get; set; }
        public System.DateTime DisableDate { get; set; }
        public string PurchasePlanCode { get; set; }
        public System.Guid VendorPriceListLineID { get; set; }
    }
}
