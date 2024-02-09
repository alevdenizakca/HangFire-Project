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
    
    public partial class AllOrdersWithAttributes
    {
        public System.Guid OrderHeaderID { get; set; }
        public byte OrderTypeCode { get; set; }
        public string ProcessCode { get; set; }
        public string OrderNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.TimeSpan OrderTime { get; set; }
        public string DocumentNumber { get; set; }
        public short PaymentTerm { get; set; }
        public System.DateTime AverageDueDate { get; set; }
        public string Description { get; set; }
        public string InternalDescription { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public string ShipmentMethodCode { get; set; }
        public Nullable<System.Guid> ShippingPostalAddressID { get; set; }
        public Nullable<System.Guid> BillingPostalAddressID { get; set; }
        public Nullable<System.Guid> GuarantorContactID { get; set; }
        public Nullable<System.Guid> GuarantorContactID2 { get; set; }
        public string RoundsmanCode { get; set; }
        public string DeliveryCompanyCode { get; set; }
        public byte TaxTypeCode { get; set; }
        public short TaxExemptionCode { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public short POSTerminalID { get; set; }
        public string WarehouseCode { get; set; }
        public string ToWarehouseCode { get; set; }
        public decimal OrdererCompanyCode { get; set; }
        public string OrdererOfficeCode { get; set; }
        public string OrdererStoreCode { get; set; }
        public string GLTypeCode { get; set; }
        public double ExchangeRate { get; set; }
        public double TDisRate1 { get; set; }
        public double TDisRate2 { get; set; }
        public double TDisRate3 { get; set; }
        public double TDisRate4 { get; set; }
        public double TDisRate5 { get; set; }
        public byte DiscountReasonCode { get; set; }
        public double SurplusOrderQtyToleranceRate { get; set; }
        public string ImportFileNumber { get; set; }
        public string ExportFileNumber { get; set; }
        public string IncotermCode1 { get; set; }
        public string IncotermCode2 { get; set; }
        public string LettersOfCreditNumber { get; set; }
        public string PaymentMethodCode { get; set; }
        public bool IsInclutedVat { get; set; }
        public bool IsCreditSale { get; set; }
        public bool IsCreditableConfirmed { get; set; }
        public string CreditableConfirmedUser { get; set; }
        public System.DateTime CreditableConfirmedDate { get; set; }
        public bool IsSalesViaInternet { get; set; }
        public bool IsProposalBased { get; set; }
        public bool IsSuspended { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsLocked { get; set; }
        public bool UserLocked { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid OrderLineID { get; set; }
        public int SortOrder { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public double Qty1 { get; set; }
        public double Qty2 { get; set; }
        public double CancelQty1 { get; set; }
        public double CancelQty2 { get; set; }
        public System.DateTime CancelDate { get; set; }
        public string OrderCancelReasonCode { get; set; }
        public System.DateTime ClosedDate { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public string SalespersonCode { get; set; }
        public string PaymentPlanCode { get; set; }
        public string PurchasePlanCode { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public System.DateTime PlannedDateOfLading { get; set; }
        public string LineDescription { get; set; }
        public string UsedBarcode { get; set; }
        public string CostCenterCode { get; set; }
        public string VatCode { get; set; }
        public float VatRate { get; set; }
        public string PCTCode { get; set; }
        public float PCTRate { get; set; }
        public double LDisRate1 { get; set; }
        public double LDisRate2 { get; set; }
        public double LDisRate3 { get; set; }
        public double LDisRate4 { get; set; }
        public double LDisRate5 { get; set; }
        public string DocCurrencyCode { get; set; }
        public string PriceCurrencyCode { get; set; }
        public double PriceExchangeRate { get; set; }
        public decimal Price { get; set; }
        public Nullable<System.Guid> PriceListLineID { get; set; }
        public string BaseProcessCode { get; set; }
        public string BaseOrderNumber { get; set; }
        public int BaseCustomerTypeCode { get; set; }
        public string BaseCustomerCode { get; set; }
        public Nullable<System.Guid> BaseSubCurrAccID { get; set; }
        public string BaseStoreCode { get; set; }
        public Nullable<System.Guid> SupportRequestHeaderID { get; set; }
        public double LineSurplusOrderQtyToleranceRate { get; set; }
        public int OrderLineSumID { get; set; }
        public Nullable<int> OrderLineBOMID { get; set; }
        public Nullable<System.Guid> PurchaseRequisitionLineID { get; set; }
        public string WithHoldingTaxTypeCode { get; set; }
        public string DovCode { get; set; }
        public string Doc_CurrencyCode { get; set; }
        public decimal Doc_PriceVI { get; set; }
        public decimal Doc_AmountVI { get; set; }
        public decimal Doc_Price { get; set; }
        public decimal Doc_Amount { get; set; }
        public decimal Doc_LDiscount1 { get; set; }
        public decimal Doc_LDiscount2 { get; set; }
        public decimal Doc_LDiscount3 { get; set; }
        public decimal Doc_LDiscount4 { get; set; }
        public decimal Doc_LDiscount5 { get; set; }
        public decimal Doc_LDiscountVI1 { get; set; }
        public decimal Doc_LDiscountVI2 { get; set; }
        public decimal Doc_LDiscountVI3 { get; set; }
        public decimal Doc_LDiscountVI4 { get; set; }
        public decimal Doc_LDiscountVI5 { get; set; }
        public decimal Doc_TDiscount1 { get; set; }
        public decimal Doc_TDiscount2 { get; set; }
        public decimal Doc_TDiscount3 { get; set; }
        public decimal Doc_TDiscount4 { get; set; }
        public decimal Doc_TDiscount5 { get; set; }
        public decimal Doc_TDiscountVI1 { get; set; }
        public decimal Doc_TDiscountVI2 { get; set; }
        public decimal Doc_TDiscountVI3 { get; set; }
        public decimal Doc_TDiscountVI4 { get; set; }
        public decimal Doc_TDiscountVI5 { get; set; }
        public decimal Doc_TaxBase { get; set; }
        public decimal Doc_Pct { get; set; }
        public decimal Doc_Vat { get; set; }
        public decimal Doc_VatDeducation { get; set; }
        public decimal Doc_NetAmount { get; set; }
        public decimal Doc_TDiscountTotal { get; set; }
        public decimal Doc_TDiscountVITotal { get; set; }
        public decimal Doc_LDiscountTotal { get; set; }
        public decimal Doc_LDiscountVITotal { get; set; }
        public string Loc_CurrencyCode { get; set; }
        public double Loc_ExchangeRate { get; set; }
        public decimal Loc_PriceVI { get; set; }
        public decimal Loc_AmountVI { get; set; }
        public decimal Loc_Price { get; set; }
        public decimal Loc_Amount { get; set; }
        public decimal Loc_LDiscount1 { get; set; }
        public decimal Loc_LDiscount2 { get; set; }
        public decimal Loc_LDiscount3 { get; set; }
        public decimal Loc_LDiscount4 { get; set; }
        public decimal Loc_LDiscount5 { get; set; }
        public decimal Loc_LDiscountVI1 { get; set; }
        public decimal Loc_LDiscountVI2 { get; set; }
        public decimal Loc_LDiscountVI3 { get; set; }
        public decimal Loc_LDiscountVI4 { get; set; }
        public decimal Loc_LDiscountVI5 { get; set; }
        public decimal Loc_TDiscount1 { get; set; }
        public decimal Loc_TDiscount2 { get; set; }
        public decimal Loc_TDiscount3 { get; set; }
        public decimal Loc_TDiscount4 { get; set; }
        public decimal Loc_TDiscount5 { get; set; }
        public decimal Loc_TDiscountVI1 { get; set; }
        public decimal Loc_TDiscountVI2 { get; set; }
        public decimal Loc_TDiscountVI3 { get; set; }
        public decimal Loc_TDiscountVI4 { get; set; }
        public decimal Loc_TDiscountVI5 { get; set; }
        public decimal Loc_TaxBase { get; set; }
        public decimal Loc_Pct { get; set; }
        public decimal Loc_Vat { get; set; }
        public decimal Loc_VatDeducation { get; set; }
        public decimal Loc_NetAmount { get; set; }
        public decimal Loc_TDiscountTotal { get; set; }
        public decimal Loc_TDiscountVITotal { get; set; }
        public decimal Loc_LDiscountTotal { get; set; }
        public decimal Loc_LDiscountVITotal { get; set; }
        public string Com_CurrencyCode { get; set; }
        public double Com_ExchangeRate { get; set; }
        public decimal Com_PriceVI { get; set; }
        public decimal Com_AmountVI { get; set; }
        public decimal Com_Price { get; set; }
        public decimal Com_Amount { get; set; }
        public decimal Com_LDiscount1 { get; set; }
        public decimal Com_LDiscount2 { get; set; }
        public decimal Com_LDiscount3 { get; set; }
        public decimal Com_LDiscount4 { get; set; }
        public decimal Com_LDiscount5 { get; set; }
        public decimal Com_LDiscountVI1 { get; set; }
        public decimal Com_LDiscountVI2 { get; set; }
        public decimal Com_LDiscountVI3 { get; set; }
        public decimal Com_LDiscountVI4 { get; set; }
        public decimal Com_LDiscountVI5 { get; set; }
        public decimal Com_TDiscount1 { get; set; }
        public decimal Com_TDiscount2 { get; set; }
        public decimal Com_TDiscount3 { get; set; }
        public decimal Com_TDiscount4 { get; set; }
        public decimal Com_TDiscount5 { get; set; }
        public decimal Com_TDiscountVI1 { get; set; }
        public decimal Com_TDiscountVI2 { get; set; }
        public decimal Com_TDiscountVI3 { get; set; }
        public decimal Com_TDiscountVI4 { get; set; }
        public decimal Com_TDiscountVI5 { get; set; }
        public decimal Com_TaxBase { get; set; }
        public decimal Com_Pct { get; set; }
        public decimal Com_Vat { get; set; }
        public decimal Com_VatDeducation { get; set; }
        public decimal Com_NetAmount { get; set; }
        public decimal Com_TDiscountTotal { get; set; }
        public decimal Com_TDiscountVITotal { get; set; }
        public decimal Com_LDiscountTotal { get; set; }
        public decimal Com_LDiscountVITotal { get; set; }
        public string ATAtt01 { get; set; }
        public string ATAtt02 { get; set; }
        public string ATAtt03 { get; set; }
        public string ATAtt04 { get; set; }
        public string ATAtt05 { get; set; }
        public string ITAtt01 { get; set; }
        public string ITAtt02 { get; set; }
        public string ITAtt03 { get; set; }
        public string ITAtt04 { get; set; }
        public string ITAtt05 { get; set; }
        public string ITAtt06 { get; set; }
        public string ITAtt07 { get; set; }
        public string ITAtt08 { get; set; }
        public string ITAtt09 { get; set; }
        public string ITAtt10 { get; set; }
    }
}
