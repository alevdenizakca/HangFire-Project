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
    
    public partial class auTRAVFDTransactionInfo
    {
        public System.Guid TRAVFDTransactionInfoID { get; set; }
        public System.Guid V3TransactionID { get; set; }
        public string rctvnum { get; set; }
        public string rctvcode { get; set; }
        public string znumber { get; set; }
        public string vfdinvoicenum { get; set; }
        public System.DateTime idate { get; set; }
        public System.TimeSpan itime { get; set; }
        public System.TimeSpan senttime { get; set; }
        public string qrpath { get; set; }
        public string qrcode_uri { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    }
}
