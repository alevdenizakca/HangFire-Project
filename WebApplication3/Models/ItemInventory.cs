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
    
    public partial class ItemInventory
    {
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public string WarehouseCode { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public Nullable<double> InventoryQty1 { get; set; }
        public Nullable<double> RemainingReserveQty1 { get; set; }
        public Nullable<double> RemainingDispOrderQty1 { get; set; }
        public Nullable<double> RemainingPickingQty1 { get; set; }
        public Nullable<double> AvailableInventoryQty1 { get; set; }
    }
}
