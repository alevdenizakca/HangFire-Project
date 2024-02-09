using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.WEBAPIS.TrendyolSiparis
{
    public class ShipmentAddress
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("cityCode")]
        public int CityCode { get; set; }

        [JsonProperty("district")]
        public string District { get; set; }

        [JsonProperty("districtId")]
        public int DistrictId { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("fullAddress")]
        public string FullAddress { get; set; }
    }
}