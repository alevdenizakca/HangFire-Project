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
    
    public partial class TransferPlanData_ITR
    {
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ColorCode { get; set; }
        public string ColorDescription { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public string SalesChannelCode { get; set; }
        public string StoreCode { get; set; }
        public string StoreDescription { get; set; }
        public int ChannelSortID { get; set; }
        public int SortOrder { get; set; }
        public bool ProcessFlowDeny { get; set; }
        public string WarehouseCode { get; set; }
        public double MinimumQty { get; set; }
        public double MaximumQty { get; set; }
        public double SalesQty1 { get; set; }
        public System.DateTime FirstIncomingDate { get; set; }
        public System.DateTime LastIncomingDate { get; set; }
        public double AvailableInventoryQty1 { get; set; }
        public double RemainingInOrderQty1 { get; set; }
        public double RemainingOutOrderQty1 { get; set; }
        public double TransferNotApprovedQty1 { get; set; }
        public double RemainingReserveQty1 { get; set; }
        public double TargetChannelInventoryQty1 { get; set; }
        public float InventoryTurnoverRate { get; set; }
        public short ItemDim1SortOrder { get; set; }
        public short ItemDim2SortOrder { get; set; }
        public short ItemDim3SortOrder { get; set; }
        public System.Guid TransferPlanID { get; set; }
        public System.Guid TransferPlanProductID { get; set; }
        public System.Guid TransferPlanChannelID { get; set; }
    }
}
