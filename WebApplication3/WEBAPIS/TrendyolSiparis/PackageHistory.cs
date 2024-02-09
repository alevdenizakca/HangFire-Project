using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.WEBAPIS.TrendyolSiparis
{
    public class PackageHistory
    {
        [JsonProperty("createdDate")]
        public long CreatedDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}