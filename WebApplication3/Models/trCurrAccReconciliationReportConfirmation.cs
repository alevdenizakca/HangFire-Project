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
    
    public partial class trCurrAccReconciliationReportConfirmation
    {
        public System.Guid CurrAccReconciliationReportsID { get; set; }
        public System.Guid ReconciliationContactID { get; set; }
        public string ConfirmationUserName { get; set; }
        public bool IsConfirmed { get; set; }
        public System.DateTime ConfirmedDate { get; set; }
        public bool IsRejected { get; set; }
        public System.DateTime RejectDate { get; set; }
        public string RejectReasonDescription { get; set; }
        public Nullable<System.Guid> CurrAccReconciliationEMailNotificationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string IPAddress { get; set; }
        public string ClientName { get; set; }
    
        public virtual prCurrAccReconciliationContact prCurrAccReconciliationContact { get; set; }
        public virtual trCurrAccReconciliationEMailNotification trCurrAccReconciliationEMailNotification { get; set; }
        public virtual trCurrAccReconciliationReport trCurrAccReconciliationReport { get; set; }
    }
}