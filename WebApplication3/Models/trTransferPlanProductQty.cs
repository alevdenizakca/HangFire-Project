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
    
    public partial class trTransferPlanProductQty
    {
        public System.Guid TransferPlanProductQtyID { get; set; }
        public System.Guid TransferPlanProductID { get; set; }
        public byte FromStoreTypeCode { get; set; }
        public string FromStoreCode { get; set; }
        public byte ToStoreTypeCode { get; set; }
        public string ToStoreCode { get; set; }
        public double TransferQty1 { get; set; }
        public string LineDescription { get; set; }
        public System.Guid TransferPlanID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual trTransferPlan trTransferPlan { get; set; }
        public virtual trTransferPlanProduct trTransferPlanProduct { get; set; }
    }
}