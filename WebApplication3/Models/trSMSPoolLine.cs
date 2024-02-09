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
    
    public partial class trSMSPoolLine
    {
        public System.Guid SMSPoolLineID { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public string PhoneNumber { get; set; }
        public string EMail { get; set; }
        public System.Guid SMSPoolMessageID { get; set; }
        public bool IsRetried { get; set; }
        public byte SMSStatusCode { get; set; }
        public string MessageResponseID { get; set; }
        public string MessageErrorReason { get; set; }
        public byte DeliveryStatus { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public System.Guid SMSPoolHeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
    
        public virtual bsApplication bsApplication { get; set; }
        public virtual bsSMSStatus bsSMSStatus { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual prCurrAccContact prCurrAccContact { get; set; }
        public virtual prSubCurrAcc prSubCurrAcc { get; set; }
        public virtual tpSMSPoolLineExtension tpSMSPoolLineExtension { get; set; }
        public virtual trSMSPoolHeader trSMSPoolHeader { get; set; }
        public virtual trSMSPoolMessage trSMSPoolMessage { get; set; }
    }
}