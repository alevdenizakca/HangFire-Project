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
    
    public partial class OrderListFromSalesChannel
    {
        public System.Guid RowID { get; set; }
        public string SalesChannel { get; set; }
        public string OrderNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string InvoiceName { get; set; }
        public string ShipmentName { get; set; }
        public string ShipmentAddress { get; set; }
        public string InvoiceAddress { get; set; }
        public string CustomerMail { get; set; }
        public string CargoTrackingNumber { get; set; }
        public string CargoTrackingLink { get; set; }
        public string CargoProviderName { get; set; }
        public string ShipmentPackageStatus { get; set; }
        public string Barcode { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ColorDescription { get; set; }
        public string ItemDim1Code { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> DiscountAmount { get; set; }
        public string ECommerceOrderID { get; set; }
    }
}
