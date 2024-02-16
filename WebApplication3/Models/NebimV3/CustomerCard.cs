using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.NebimV3
{
    public class CustomerCard
    {
        public class PostalAddress
        {
            public string AddressTypeCode { get; set; }
            public string CountryCode { get; set; }
            public string StateCode { get; set; }
            public string CityCode { get; set; }
            public string DistrictCode { get; set; }
            public string Address { get; set; }
        }

        public class Attribute
        {
            public string AttributeTypeCode { get; set; }
            public string AttributeCode { get; set; }
        }

        public class Communication
        {
            public int CommunicationTypeCode { get; set; }
            public string CommAddress { get; set; }
        }

        public class CustomerResponse
        {
            public int ModelType { get; set; }
            public string CurrAccDescription { get; set; }
            public string IdentityNum { get; set; }
            public string OfficeCode { get; set; }
            public int? CompanyCode { get; set; }
            public string CurrencyCode { get; set; }
            public int CustomerTypeCode { get; set; }
            public string TaxNumber { get; set; }
            public string TaxOfficeCode { get; set; }
            public List<PostalAddress> PostalAddresses { get; set; }
            public List<Communication> Communications { get; set; }
        }
    }
}