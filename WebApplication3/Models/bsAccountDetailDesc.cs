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
    
    public partial class bsAccountDetailDesc
    {
        public byte AccountDetail { get; set; }
        public string LangCode { get; set; }
        public string AccountDetailDescription { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsAccountDetail bsAccountDetail { get; set; }
        public virtual cdDataLanguage cdDataLanguage { get; set; }
    }
}