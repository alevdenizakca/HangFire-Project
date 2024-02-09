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
    
    public partial class OrderTransaction
    {
        public System.Guid OrderHeaderID { get; set; }
        public string OrderTypeCode { get; set; }
        public string ProcessCode { get; set; }
        public string OrderNumber { get; set; }
        public int IsCancelOrder { get; set; }
        public string OrderDate { get; set; }
        public string OrderTime { get; set; }
        public string Description { get; set; }
        public int CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public int StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public Nullable<byte> CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public Nullable<System.Guid> ShippingPostalAddressID { get; set; }
        public Nullable<System.Guid> BillingPostalAddressID { get; set; }
        public string WarehouseCode { get; set; }
        public string DocCurrencyCode { get; set; }
        public string LocalCurrencyCode { get; set; }
        public int ExchangeRate { get; set; }
        public int IsCompleted { get; set; }
        public string ApplicationCode { get; set; }
        public System.Guid ApplicationID { get; set; }
        public Nullable<System.Guid> OrderLineID { get; set; }
        public Nullable<long> OrderLineSumID { get; set; }
        public string UsedBarcode { get; set; }
        public string LotCode { get; set; }
        public Nullable<byte> ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public string VatCode { get; set; }
        public Nullable<float> VatRate { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<double> LotQty { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string CreatedUserName { get; set; }
        public Nullable<bool> IsLotBarcode { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    }
}
