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
    
    public partial class prDiscountPoint
    {
        public System.Guid DiscountPointID { get; set; }
        public byte CustomerTypeCode { get; set; }
        public string CustomerCode { get; set; }
        public string DiscountPointTypeCode { get; set; }
        public byte PointRecordTypeCode { get; set; }
        public System.DateTime FirstValidDate { get; set; }
        public System.DateTime LastValidDate { get; set; }
        public decimal Point { get; set; }
        public string PointModifyReasonCode { get; set; }
        public string Description { get; set; }
        public Nullable<System.Guid> InvoiceHeaderID { get; set; }
        public Nullable<System.Guid> OrderHeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public Nullable<System.Guid> OrderCancelDetailHeaderID { get; set; }
    
        public virtual bsPointRecordType bsPointRecordType { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdDiscountPointType cdDiscountPointType { get; set; }
        public virtual cdPointModifyReason cdPointModifyReason { get; set; }
    }
}
