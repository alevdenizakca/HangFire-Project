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
    
    public partial class srCashSerialNumber
    {
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public byte CashTransTypeCode { get; set; }
        public string CurrencyCode { get; set; }
        public string SeriesCode { get; set; }
        public string Series { get; set; }
        public decimal StartingNumber { get; set; }
        public decimal EndingNumber { get; set; }
        public decimal LastNumber { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdOffice cdOffice { get; set; }
    }
}