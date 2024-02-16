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
    
    public partial class cdWarehouse
    {
        public string WarehouseCode { get; set; }
        public byte WarehouseOwnerCode { get; set; }
        public byte WarehouseTypeCode { get; set; }
        public string WarehouseCategoryCode { get; set; }
        public string OfficeCode { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public bool PermitNegativeStock { get; set; }
        public bool WarnNegativeStock { get; set; }
        public bool ControlStockLevel { get; set; }
        public bool WarnStockLevelRate { get; set; }
        public float TotalArea { get; set; }
        public float WarehouseWidth { get; set; }
        public float WarehouseLength { get; set; }
        public float WarehouseHeight { get; set; }
        public bool IsDefault { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public bool UseSection { get; set; }
        public bool PermitRetailSubsequentDelivery { get; set; }
        public string URNAddress { get; set; }
        public string EShipmentUrnAddress { get; set; }
    }
}
