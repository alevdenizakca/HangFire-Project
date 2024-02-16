using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.NebimV3
{
    public class ExportInvoiceOrder
    {
        public class Line
        {
            public string UsedBarcode { get; set; }
            public int Qty1 { get; set; }
            public double PriceVI { get; set; }
        }

        public class Payment
        {
            public string PaymentTypeCode { get; set; }
            public string Code { get; set; }
            public string CreditCardTypeCode { get; set; }
            public int InstallmentCount { get; set; }
            public string CurrencyCode { get; set; }
            public double Amount { get; set; }
        }

        public class OrderRequest
        {
            public int ModelType { get; set; }
            public DateTime OrderDate { get; set; }
            public string CustomerCode { get; set; }
            public int CompanyCode { get; set; }
            public string OfficeCode { get; set; }
            public string StoreCode { get; set; }
            public string WarehouseCode { get; set; }
            public string OrdererOfficeCode { get; set; }
            public string OrdererStoreCode { get; set; }
            public Guid ShippingPostalAddressID { get; set; }
            public Guid BillingPostalAddressID { get; set; }
            public string DeliveryCompanyCode { get; set; }
            public string ShipmentMethodCode { get; set; }
            public string DocumentNumber { get; set; }
            public string InternalDescription { get; set; }
            public string ExportFileNumber { get; set; }
            public List<Line> Lines { get; set; }
            public bool IsCompleted { get; set; }
        }
    }
}