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
    
    public partial class e_InboxShipmentResponseDespatchSupplierParty
    {
        public System.Guid UUID { get; set; }
        public string CompanyName { get; set; }
        public string TaxOfficeName { get; set; }
        public string TaxNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNum { get; set; }
        public string StreetName { get; set; }
        public string BuildingNumber { get; set; }
        public string CitySubdivisionName { get; set; }
        public string CityName { get; set; }
        public string PostalZone { get; set; }
        public string CountryName { get; set; }
        public string Telephone { get; set; }
        public string Telefax { get; set; }
        public string ElectronicMail { get; set; }
        public string WebsiteURI { get; set; }
        public string SubCurrAccCode { get; set; }
        public string URNAddress { get; set; }
        public string RecordedCurrAccCode { get; set; }
    
        public virtual e_InboxShipmentResponseHeader e_InboxShipmentResponseHeader { get; set; }
    }
}
