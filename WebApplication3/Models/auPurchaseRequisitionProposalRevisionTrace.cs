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
    
    public partial class auPurchaseRequisitionProposalRevisionTrace
    {
        public System.Guid TraceID { get; set; }
        public System.Guid PurchaseRequisitionProposalID { get; set; }
        public byte RevisionNumber { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public string UserName { get; set; }
        public string FieldName { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
