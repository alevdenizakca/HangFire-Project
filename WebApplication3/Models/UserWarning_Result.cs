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
    
    public partial class UserWarning_Result
    {
        public string UserWarningCode { get; set; }
        public bool UseOnOpenCard { get; set; }
        public bool UseOnOpenTransaction { get; set; }
        public bool IsBlocked { get; set; }
        public string LangCode { get; set; }
        public string UserWarningDescription { get; set; }
    }
}