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
    
    public partial class e_OutboxInvoiceDelivery
    {
        public System.Guid UUID { get; set; }
        public string StreetName { get; set; }
        public string BuildingNumber { get; set; }
        public string CitySubdivisionName { get; set; }
        public string CityName { get; set; }
        public string PostalZone { get; set; }
        public string CountryName { get; set; }
        public string Postbox { get; set; }
        public short Room { get; set; }
        public string BlockName { get; set; }
        public string BuildingName { get; set; }
        public string Region { get; set; }
        public string District { get; set; }
        public string AddressDescription { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual e_OutboxInvoiceHeader e_OutboxInvoiceHeader { get; set; }
    }
}