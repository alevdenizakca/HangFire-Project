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
    
    public partial class prCurrAccPersonalDataConfirmationStatus
    {
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public byte ConfirmationStatus { get; set; }
        public Nullable<System.Guid> CurrAccPersonalDataConfirmationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCurrAcc cdCurrAcc { get; set; }
    }
}
