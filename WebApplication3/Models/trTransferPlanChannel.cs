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
    
    public partial class trTransferPlanChannel
    {
        public System.Guid TransferPlanChannelID { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public int SortOrder { get; set; }
        public System.Guid TransferPlanID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual trTransferPlan trTransferPlan { get; set; }
    }
}