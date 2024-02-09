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
    
    public partial class trOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trOrderHeader()
        {
            this.tpInnerLineDocument = new HashSet<tpInnerLineDocument>();
            this.tpOrderATAttribute = new HashSet<tpOrderATAttribute>();
            this.tpOrderCancelDetailHeader = new HashSet<tpOrderCancelDetailHeader>();
            this.tpOrderCashRegisterInfo = new HashSet<tpOrderCashRegisterInfo>();
            this.tpOrderDiscountOffer = new HashSet<tpOrderDiscountOffer>();
            this.tpOrderDiscountOfferContributor = new HashSet<tpOrderDiscountOfferContributor>();
            this.tpOrderFTAttribute = new HashSet<tpOrderFTAttribute>();
            this.trAdjustCostOrder = new HashSet<trAdjustCostOrder>();
            this.trOrderLine = new HashSet<trOrderLine>();
            this.trOrderLineSum = new HashSet<trOrderLineSum>();
            this.trOrderLineSumDetail = new HashSet<trOrderLineSumDetail>();
            this.trOrderOpticalProduct = new HashSet<trOrderOpticalProduct>();
            this.trOrderPaymentPlan = new HashSet<trOrderPaymentPlan>();
        }
    
        public System.Guid OrderHeaderID { get; set; }
        public byte OrderTypeCode { get; set; }
        public string ProcessCode { get; set; }
        public string OrderNumber { get; set; }
        public bool IsCancelOrder { get; set; }
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
        public string WithHoldingTaxTypeCode { get; set; }
        public string DOVCode { get; set; }
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
        public string DocCurrencyCode { get; set; }
        public string LocalCurrencyCode { get; set; }
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
        public bool IsClosed { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual bsApplication bsApplication { get; set; }
        public virtual bsIncoterm bsIncoterm { get; set; }
        public virtual bsIncoterm bsIncoterm1 { get; set; }
        public virtual bsOrderType bsOrderType { get; set; }
        public virtual bsProcess bsProcess { get; set; }
        public virtual bsTaxExemption bsTaxExemption { get; set; }
        public virtual bsTaxType bsTaxType { get; set; }
        public virtual bsWithHoldingTaxType bsWithHoldingTaxType { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCurrAcc cdCurrAcc1 { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdCurrency cdCurrency1 { get; set; }
        public virtual cdDeliveryCompany cdDeliveryCompany { get; set; }
        public virtual cdDiscountReason cdDiscountReason { get; set; }
        public virtual cdDOV cdDOV { get; set; }
        public virtual cdExportFile cdExportFile { get; set; }
        public virtual cdGLType cdGLType { get; set; }
        public virtual cdImportFile cdImportFile { get; set; }
        public virtual cdOffice cdOffice { get; set; }
        public virtual cdPaymentMethod cdPaymentMethod { get; set; }
        public virtual cdRoundsman cdRoundsman { get; set; }
        public virtual cdShipmentMethod cdShipmentMethod { get; set; }
        public virtual cdWarehouse cdWarehouse { get; set; }
        public virtual cdWarehouse cdWarehouse1 { get; set; }
        public virtual prCurrAccContact prCurrAccContact { get; set; }
        public virtual prCurrAccContact prCurrAccContact1 { get; set; }
        public virtual prCurrAccContact prCurrAccContact2 { get; set; }
        public virtual prCurrAccPostalAddress prCurrAccPostalAddress { get; set; }
        public virtual prCurrAccPostalAddress prCurrAccPostalAddress1 { get; set; }
        public virtual prSubCurrAcc prSubCurrAcc { get; set; }
        public virtual tpDistanceSaleBankPayment tpDistanceSaleBankPayment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpInnerLineDocument> tpInnerLineDocument { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderATAttribute> tpOrderATAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderCancelDetailHeader> tpOrderCancelDetailHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderCashRegisterInfo> tpOrderCashRegisterInfo { get; set; }
        public virtual tpOrderContractContext tpOrderContractContext { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderDiscountOffer> tpOrderDiscountOffer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderDiscountOfferContributor> tpOrderDiscountOfferContributor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderFTAttribute> tpOrderFTAttribute { get; set; }
        public virtual tpOrderHeaderExtension tpOrderHeaderExtension { get; set; }
        public virtual tpOrdersViaInternetInfo tpOrdersViaInternetInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trAdjustCostOrder> trAdjustCostOrder { get; set; }
        public virtual trOrderAuditorSurvey trOrderAuditorSurvey { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderLine> trOrderLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderLineSum> trOrderLineSum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderLineSumDetail> trOrderLineSumDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderOpticalProduct> trOrderOpticalProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderPaymentPlan> trOrderPaymentPlan { get; set; }
        public virtual trOrderSurvey trOrderSurvey { get; set; }
    }
}