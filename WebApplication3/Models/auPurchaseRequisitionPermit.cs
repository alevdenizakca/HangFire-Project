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
    
    public partial class auPurchaseRequisitionPermit
    {
        public decimal CompanyCode { get; set; }
        public string RoleCode { get; set; }
        public bool CanSelect { get; set; }
        public bool CanLocked { get; set; }
        public bool CanUnLocked { get; set; }
        public bool CanEditAmount { get; set; }
        public bool CanInsert { get; set; }
        public short InsertLastNDay { get; set; }
        public System.DateTime InsertMinDate { get; set; }
        public System.DateTime InsertMaxDate { get; set; }
        public bool CanUpdate { get; set; }
        public short UpdateLastNDay { get; set; }
        public System.DateTime UpdateMinDate { get; set; }
        public System.DateTime UpdateMaxDate { get; set; }
        public bool CanDelete { get; set; }
        public short DeleteLastNDay { get; set; }
        public System.DateTime DeleteMinDate { get; set; }
        public System.DateTime DeleteMaxDate { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdRole cdRole { get; set; }
    }
}
