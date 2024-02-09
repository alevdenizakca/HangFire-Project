using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.WEBAPIS.TrendyolSiparis
{
    public class DiscountDetail
    {
        [JsonProperty("lineItemPrice")]
        public double LineItemPrice { get; set; }

        [JsonProperty("lineItemDiscount")]
        public double LineItemDiscount { get; set; }
    }
}