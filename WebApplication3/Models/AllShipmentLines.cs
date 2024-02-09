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
    
    public partial class AllShipmentLines
    {
        public System.Guid ShipmentHeaderID { get; set; }
        public byte TransTypeCode { get; set; }
        public string ProcessCode { get; set; }
        public string ShippingNumber { get; set; }
        public bool IsReturn { get; set; }
        public System.DateTime ShippingDate { get; set; }
        public System.TimeSpan ShippingTime { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public string Series { get; set; }
        public decimal SeriesNumber { get; set; }
        public string Description { get; set; }
        public string InternalDescription { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public string ShipmentMethodCode { get; set; }
        public Nullable<System.Guid> ShippingPostalAddressID { get; set; }
        public Nullable<System.Guid> BillingPostalAddressID { get; set; }
        public string RoundsmanCode { get; set; }
        public string DeliveryCompanyCode { get; set; }
        public string LogisticsCompanyBOL { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public string WarehouseCode { get; set; }
        public string ToWarehouseCode { get; set; }
        public bool IsOrderBase { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsLocked { get; set; }
        public bool IsTransferApproved { get; set; }
        public System.DateTime TransferApprovedDate { get; set; }
        public Nullable<bool> IsPostingJournal { get; set; }
        public Nullable<System.DateTime> JournalDate { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string CustomerASNNumber { get; set; }
        public System.Guid ShipmentLineID { get; set; }
        public int SortOrder { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public double Qty1 { get; set; }
        public double Qty2 { get; set; }
        public string BatchCode { get; set; }
        public string SalespersonCode { get; set; }
        public string PaymentPlanCode { get; set; }
        public string PurchasePlanCode { get; set; }
        public string ReturnReasonCode { get; set; }
        public string LineDescription { get; set; }
        public string UsedBarcode { get; set; }
        public string DeliveryCompanyBarcode { get; set; }
        public string LogisticsPackageNumber { get; set; }
        public string ImportFileNumber { get; set; }
        public string ExportFileNumber { get; set; }
        public Nullable<System.Guid> ReserveLineID { get; set; }
        public Nullable<System.Guid> DispOrderLineID { get; set; }
        public Nullable<System.Guid> PickingLineID { get; set; }
        public Nullable<System.Guid> OrderAsnLineID { get; set; }
        public Nullable<System.Guid> OrderLineID { get; set; }
        public string PriceCurrencyCode { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.Guid> PriceListLineID { get; set; }
        public bool IsInvoiced { get; set; }
        public Nullable<System.Guid> SupportRequestHeaderID { get; set; }
        public int ShipmentLineSumID { get; set; }
        public int ShipmentLineSerialSumID { get; set; }
        public Nullable<int> ShipmentLineBOMID { get; set; }
        public string SectionCode { get; set; }
        public Nullable<System.DateTime> OrderDeliveryDate { get; set; }
        public Nullable<System.DateTime> ManufactureDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
    }
}
