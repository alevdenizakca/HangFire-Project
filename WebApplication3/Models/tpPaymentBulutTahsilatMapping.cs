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
    
    public partial class tpPaymentBulutTahsilatMapping
    {
        public System.Guid CorrelationID { get; set; }
        public Nullable<System.Guid> OrderHeaderID { get; set; }
        public Nullable<System.Guid> PaymentHeaderID { get; set; }
        public string OrderGuidCode { get; set; }
        public string OrderDate { get; set; }
        public string TotalPriceWithVat { get; set; }
        public string Currency { get; set; }
        public string CreditCardNumber { get; set; }
        public string VBankPosCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}
