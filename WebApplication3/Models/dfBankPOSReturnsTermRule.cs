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
    
    public partial class dfBankPOSReturnsTermRule
    {
        public System.Guid BankPOSReturnRuleID { get; set; }
        public byte InstallmentNumber { get; set; }
        public float ServiceFeeRate { get; set; }
        public float TaxRate { get; set; }
        public float PosPointRate { get; set; }
        public short TermDay { get; set; }
        public float EarlyPaymentDiscountRate { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual dfBankPOSReturnsRule dfBankPOSReturnsRule { get; set; }
    }
}