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
    
    public partial class auEuromsgSentAccountTrace
    {
        public System.Guid TraceID { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public string CompanyBrandCode { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurraccID { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public string Email { get; set; }
    }
}