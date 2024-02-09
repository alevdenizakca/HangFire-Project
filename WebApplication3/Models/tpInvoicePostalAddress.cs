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
    
    public partial class tpInvoicePostalAddress
    {
        public System.Guid InvoiceHeaderID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstLastName { get; set; }
        public string CompanyName { get; set; }
        public long AddressID { get; set; }
        public string Address { get; set; }
        public string SiteName { get; set; }
        public string BuildingName { get; set; }
        public string BuildingNum { get; set; }
        public short FloorNum { get; set; }
        public short DoorNum { get; set; }
        public int QuarterCode { get; set; }
        public string QuarterName { get; set; }
        public string Boulevard { get; set; }
        public int StreetCode { get; set; }
        public string Street { get; set; }
        public string Road { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public string CityCode { get; set; }
        public string DistrictCode { get; set; }
        public string ZipCode { get; set; }
        public string TaxOfficeCode { get; set; }
        public string TaxNumber { get; set; }
        public string IdentityNum { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdCity cdCity { get; set; }
        public virtual cdCountry cdCountry { get; set; }
        public virtual cdDistrict cdDistrict { get; set; }
        public virtual cdState cdState { get; set; }
        public virtual cdStreet cdStreet { get; set; }
    }
}
