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
    
    public partial class tpBankPaymentInstructionFTAttribute
    {
        public System.Guid BankPaymentInstructionLineID { get; set; }
        public byte AttributeTypeCode { get; set; }
        public string AttributeCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdFTAttribute cdFTAttribute { get; set; }
        public virtual trBankPaymentInstructionLine trBankPaymentInstructionLine { get; set; }
    }
}
