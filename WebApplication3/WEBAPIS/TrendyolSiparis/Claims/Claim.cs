using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.WEBAPIS.TrendyolSiparis.Claims
{
    public class Claim
    {
        public class LineItemStatus
        {
            public string name { get; set; }
        }

        public class LineItem
        {
            public int id { get; set; }
            public LineItemStatus lineItemStatus { get; set; }
        }

        public class OrderLine
        {
            public int id { get; set; }
            public string productName { get; set; }
            public string barcode { get; set; }
            public string merchantSku { get; set; }
            public string productColor { get; set; }
            public string productSize { get; set; }
            public double price { get; set; }
            public int vatBaseAmount { get; set; }
            public int salesCampaignId { get; set; }
            public string productCategory { get; set; }
            public List<LineItem> lineItems { get; set; }
        }

        public class CustomerClaimItemReason
        {
            public string id { get; set; }
            public string name { get; set; }
            public int externalReasonId { get; set; }
            public string code { get; set; }
        }

        public class TrendyolClaimItemReason
        {
            public string id { get; set; }
            public string name { get; set; }
            public int externalReasonId { get; set; }
            public string code { get; set; }
        }

        public class ClaimItemStatus
        {
            public string name { get; set; }
        }

        public class ClaimItem
        {
            public string id { get; set; }
            public int orderLineItemId { get; set; }
            public CustomerClaimItemReason customerClaimItemReason { get; set; }
            public TrendyolClaimItemReason trendyolClaimItemReason { get; set; }
            public ClaimItemStatus claimItemStatus { get; set; }
            public string note { get; set; }
            public string customerNote { get; set; }
            public bool resolved { get; set; }
        }

        public class Item
        {
            public OrderLine orderLine { get; set; }
            public List<ClaimItem> claimItems { get; set; }
        }

        public class Content
        {
            public string id { get; set; }
            public string orderNumber { get; set; }
            public long orderDate { get; set; }
            public string customerFirstName { get; set; }
            public string customerLastName { get; set; }
            public long claimDate { get; set; }
            public string cargoTrackingNumber { get; set; }
            public string cargoTrackingLink { get; set; }
            public string cargoSenderNumber { get; set; }
            public string cargoProviderName { get; set; }
            public int orderShipmentPackageId { get; set; }
            public List<Item> items { get; set; }
        }

        public class Root
        {
            public int totalElements { get; set; }
            public int totalPages { get; set; }
            public int page { get; set; }
            public int size { get; set; }
            public List<Content> content { get; set; }
        }
    }
}