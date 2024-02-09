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
    
    public partial class AllReportedSaleLines
    {
        public System.Guid ReportedSaleHeaderID { get; set; }
        public byte TransTypeCode { get; set; }
        public string ProcessCode { get; set; }
        public string ReportedSaleNumber { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public string Description { get; set; }
        public decimal CompanyCode { get; set; }
        public string WarehouseCode { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsLocked { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid ReportedSaleLineID { get; set; }
        public int SortOrder { get; set; }
        public bool IsReturn { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public double Qty1 { get; set; }
        public double Qty2 { get; set; }
        public double InvoicedQty1 { get; set; }
        public string LineDescription { get; set; }
        public string UsedBarcode { get; set; }
        public string SerialNumber { get; set; }
        public string PriceCurrencyCode { get; set; }
        public decimal Price { get; set; }
        public decimal PriceVI { get; set; }
        public string BatchCode { get; set; }
        public string VatCode { get; set; }
        public float VatRate { get; set; }
        public string PCTCode { get; set; }
        public float PCTRate { get; set; }
    }
}