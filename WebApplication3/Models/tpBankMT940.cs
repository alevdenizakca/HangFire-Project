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
    
    public partial class tpBankMT940
    {
        public System.Guid BankHeaderID { get; set; }
        public string MT940FileName { get; set; }
        public Nullable<System.Guid> MT940ProcessRulesID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual prMT940ProcessRules prMT940ProcessRules { get; set; }
        public virtual trBankHeader trBankHeader { get; set; }
    }
}
