using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.WEBAPIS.TrendyolSiparis;

namespace WebApplication3.Models.ApiReturnTypes
{
    public class GetAllOrders
    {
        public class ShipmentResponse
        {
            public int Page { get; set; }
            public int Size { get; set; }
            public int TotalPages { get; set; }
            public int TotalElements { get; set; }
            public List<ShipmentContent> Content { get; set; }
        }

        public class ShipmentContent
        {
            public ShipmentAddress ShipmentAddress { get; set; }
            public string OrderNumber { get; set; }
            public double GrossAmount { get; set; }
            public double TotalDiscount { get; set; }
            public double TotalTyDiscount { get; set; }
            public string TaxNumber { get; set; }
            public InvoiceAddress InvoiceAddress { get; set; }
            public string CustomerFirstName { get; set; }
            public string CustomerEmail { get; set; }
            public int CustomerId { get; set; }
            public string CustomerLastName { get; set; }
            public string Id { get; set; }
            public long CargoTrackingNumber { get; set; }
            public string CargoTrackingLink { get; set; }
            public string CargoSenderNumber { get; set; }
            public string CargoProviderName { get; set; }
            public List<OrderLine> Lines { get; set; }
            public long OrderDate { get; set; }
            public string TcIdentityNumber { get; set; }
            public string CurrencyCode { get; set; }
            public List<PackageHistory> PackageHistories { get; set; }
            public string ShipmentPackageStatus { get; set; }
            public string Status { get; set; }
            public string DeliveryType { get; set; }
            public string TimeSlotId { get; set; }
            public string ScheduledDeliveryStoreId { get; set; }
            public long EstimatedDeliveryStartDate { get; set; }
            public long EstimatedDeliveryEndDate { get; set; }
            public double TotalPrice { get; set; }
            public string DeliveryAddressType { get; set; }
            public long AgreedDeliveryDate { get; set; }
            public bool AgreedDeliveryDateExtendible { get; set; }
            public long? ExtendedAgreedDeliveryDate { get; set; }
            public long? AgreedDeliveryExtensionStartDate { get; set; }
            public long? AgreedDeliveryExtensionEndDate { get; set; }
            public string InvoiceLink { get; set; }
            public bool FastDelivery { get; set; }
            public string FastDeliveryType { get; set; }
            public long OriginShipmentDate { get; set; }
            public long LastModifiedDate { get; set; }
            public bool Commercial { get; set; }
            public bool DeliveredByService { get; set; }
            public bool Micro { get; set; }
            public bool GiftBoxRequested { get; set; }
        }
        public class OrderLine
        {
            public int Quantity { get; set; }
            public int SalesCampaignId { get; set; }
            public string ProductSize { get; set; }
            public string MerchantSku { get; set; }
            public string ProductName { get; set; }
            public int ProductCode { get; set; }
            public string ProductOrigin { get; set; }
            public int MerchantId { get; set; }
            public double Amount { get; set; }
            public double Discount { get; set; }
            public double TyDiscount { get; set; }
            public List<DiscountDetail> DiscountDetails { get; set; }
            public List<FastDeliveryOption> FastDeliveryOptions { get; set; }
            public string CurrencyCode { get; set; }
            public string ProductColor { get; set; }
            public string Id { get; set; }
            public string Sku { get; set; }
            public double VatBaseAmount { get; set; }
            public string Barcode { get; set; }
            public string OrderLineItemStatusName { get; set; }
            public double Price { get; set; }
        }
        public class FastDeliveryOption
        {
            public string Type { get; set; }
        }
    }
}