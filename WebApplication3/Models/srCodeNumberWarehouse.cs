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
    
    public partial class srCodeNumberWarehouse
    {
        public decimal CompanyCode { get; set; }
        public byte WarehouseTypeCode { get; set; }
        public decimal OfficeCodeNumber { get; set; }
        public decimal LastNumber { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdWarehouseType cdWarehouseType { get; set; }
    }
}
