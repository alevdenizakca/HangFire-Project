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
    
    public partial class zpHopiPayProcessedPayment
    {
        public System.Guid HopiPayProcessedPaymentID { get; set; }
        public System.Guid CreditCardPaymentLineID { get; set; }
        public string HopiPayID { get; set; }
        public decimal Amount { get; set; }
        public byte Installment { get; set; }
        public byte PaymentType { get; set; }
        public string IssuerCardCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}