using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.Api
{
    public class SaleChannelsStatusResult
    {
        public class CargoPackage
        {
            [JsonProperty("TrackingNumber")]
            public string TrackingNumber { get; set; }

            [JsonProperty("FullAddress")]
            public string FullAddress { get; set; }

            [JsonProperty("Lines")]
            public List<Line> Lines { get; set; }
        }

        public class Line
        {
            [JsonProperty("CustomerCode")]
            public string CustomerCode { get; set; }

            [JsonProperty("OrderNumber")]
            public string OrderNumber { get; set; }

            [JsonProperty("Description")]
            public string Description { get; set; }

            [JsonProperty("OrderHeaderID")]
            public string OrderHeaderID { get; set; }

            [JsonProperty("OrderLineID")]
            public string OrderLineID { get; set; }

            [JsonProperty("UsedBarcode")]
            public string UsedBarcode { get; set; }

            [JsonProperty("ProductCode")]
            public string ProductCode { get; set; }

            [JsonProperty("ProductDescription")]
            public string ProductDescription { get; set; }

            [JsonProperty("Qty")]
            public int Qty { get; set; }

            [JsonProperty("Amount")]
            public string Amount { get; set; }

            [JsonProperty("LineDescription")]
            public string LineDescription { get; set; }

            [JsonProperty("TrackingNumber")]
            public string TrackingNumber { get; set; }

            [JsonProperty("ColorCode")]
            public string ColorCode { get; set; }

            [JsonProperty("ItemDim1Code")]
            public string ItemDim1Code { get; set; }

            [JsonProperty("SCOrderLineId")]
            public int SCOrderLineId { get; set; }

            [JsonProperty("FullAddress")]
            public string FullAddress { get; set; }
        }

        public class Meta
        {
            [JsonProperty("StatusCode")]
            public int StatusCode { get; set; }

            [JsonProperty("Message")]
            public string Message { get; set; }
        }

        public class MetaDataResponse
        {
            public Meta Meta { get; set; }
        }

        public class Result
        {
            [JsonProperty("FullName")]
            public string FullName { get; set; }

            [JsonProperty("FullAddress")]
            public string FullAddress { get; set; }

            [JsonProperty("OrderNumber")]
            public string OrderNumber { get; set; }

            [JsonProperty("OrderId")]
            public int OrderId { get; set; }

            [JsonProperty("PackageId")]
            public int PackageId { get; set; }

            [JsonProperty("CargoProviderName")]
            public string CargoProviderName { get; set; }

            [JsonProperty("CargoTrackingNumber")]
            public string CargoTrackingNumber { get; set; }

            [JsonProperty("SaleChannel")]
            public string SaleChannel { get; set; }

            [JsonProperty("PaymentType")]
            public string PaymentType { get; set; }

            [JsonProperty("PaymentMethod")]
            public string PaymentMethod { get; set; }

            [JsonProperty("Amount")]
            public string Amount { get; set; }

            [JsonProperty("Files")]
            public List<object> Files { get; set; }

            [JsonProperty("BarcodeBase64")]
            public string BarcodeBase64 { get; set; }

            [JsonProperty("CargoPackages")]
            public List<CargoPackage> CargoPackages { get; set; }
        }

        public class SaleChannelStatusResult
        {
            [JsonProperty("result")]
            public Result result { get; set; }

            [JsonProperty("meta")]
            public Meta meta { get; set; }
        }
    }
}