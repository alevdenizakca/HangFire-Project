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
    
    public partial class AllAllocationProductStatus
    {
        public System.Guid AllocationID { get; set; }
        public System.Guid AllocationChannelID { get; set; }
        public System.Guid AllocationProductID { get; set; }
        public double SalesQty1 { get; set; }
        public System.DateTime FirstIncomingDate { get; set; }
        public double AvailableInventoryQty1 { get; set; }
        public double RemainingInOrderQty1 { get; set; }
        public double RemainingOutOrderQty1 { get; set; }
        public double TransferNotApprovedQty1 { get; set; }
        public double RemainingReserveQty1 { get; set; }
    }
}
