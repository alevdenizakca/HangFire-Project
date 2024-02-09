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
    
    public partial class OptInOptOutLastTrace
    {
        public System.Guid OptInOptOutTraceID { get; set; }
        public System.Guid CommunicationID { get; set; }
        public string CommAddress { get; set; }
        public System.DateTime OperationDate { get; set; }
        public string CommunicationTypeCode { get; set; }
        public byte CommunicationKindCode { get; set; }
        public string CompanyBrandCode { get; set; }
        public byte StatusType { get; set; }
        public bool IsSentToBusinessPartner { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public bool Call { get; set; }
        public bool SMS { get; set; }
        public bool EMail { get; set; }
        public string ConsentSource { get; set; }
        public System.DateTime ConsentTime { get; set; }
        public byte RecipientType { get; set; }
        public string OptDescription { get; set; }
        public string FormNumber { get; set; }
        public string MessageResponseID { get; set; }
        public bool IsBlocked { get; set; }
        public Nullable<long> SortOrder { get; set; }
    }
}
