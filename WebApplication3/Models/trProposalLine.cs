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
    
    public partial class trProposalLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trProposalLine()
        {
            this.tpProposalDiscountOffer = new HashSet<tpProposalDiscountOffer>();
            this.tpProposalDiscountOfferContributor = new HashSet<tpProposalDiscountOfferContributor>();
            this.tpProposalITAttribute = new HashSet<tpProposalITAttribute>();
            this.tpProposalLineConfirmation = new HashSet<tpProposalLineConfirmation>();
            this.tpProposalLineRevision = new HashSet<tpProposalLineRevision>();
            this.trProposalLineCurrency = new HashSet<trProposalLineCurrency>();
            this.trPurchaseRequisitionProposalConfirmationEMailNotificationDetail = new HashSet<trPurchaseRequisitionProposalConfirmationEMailNotificationDetail>();
        }
    
        public System.Guid ProposalLineID { get; set; }
        public int SortOrder { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public double Qty1 { get; set; }
        public double Qty2 { get; set; }
        public string SalespersonCode { get; set; }
        public string PaymentPlanCode { get; set; }
        public string PurchasePlanCode { get; set; }
        public string GLTypeCode { get; set; }
        public string CostCenterCode { get; set; }
        public string LineDescription { get; set; }
        public string UsedBarcode { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public System.DateTime PlannedDateOfLading { get; set; }
        public string ImportFileNumber { get; set; }
        public string ExportFileNumber { get; set; }
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
        public System.Guid ProposalHeaderID { get; set; }
        public int ProposalLineSumID { get; set; }
        public bool IsTransformed { get; set; }
        public Nullable<System.Guid> InvoiceLineID { get; set; }
        public Nullable<System.Guid> OrderLineID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public Nullable<System.Guid> PurchaseRequisitionLineID { get; set; }
        public bool ClosedBySystem { get; set; }
        public Nullable<System.Guid> ClosedByProposalLineID { get; set; }
        public string WithHoldingTaxTypeCode { get; set; }
        public string DOVCode { get; set; }
    
        public virtual bsWithHoldingTaxType bsWithHoldingTaxType { get; set; }
        public virtual cdCostCenter cdCostCenter { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdCurrency cdCurrency1 { get; set; }
        public virtual cdDOV cdDOV { get; set; }
        public virtual cdExportFile cdExportFile { get; set; }
        public virtual cdGLType cdGLType { get; set; }
        public virtual cdImportFile cdImportFile { get; set; }
        public virtual cdPaymentPlan cdPaymentPlan { get; set; }
        public virtual cdPCT cdPCT { get; set; }
        public virtual cdPurchasePlan cdPurchasePlan { get; set; }
        public virtual cdSalesperson cdSalesperson { get; set; }
        public virtual cdVat cdVat { get; set; }
        public virtual prItemVariant prItemVariant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpProposalDiscountOffer> tpProposalDiscountOffer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpProposalDiscountOfferContributor> tpProposalDiscountOfferContributor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpProposalITAttribute> tpProposalITAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpProposalLineConfirmation> tpProposalLineConfirmation { get; set; }
        public virtual tpProposalLineConfirmationStatus tpProposalLineConfirmationStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpProposalLineRevision> tpProposalLineRevision { get; set; }
        public virtual trPriceListLine trPriceListLine { get; set; }
        public virtual trProposalHeader trProposalHeader { get; set; }
        public virtual trPurchaseRequisitionLine trPurchaseRequisitionLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trProposalLineCurrency> trProposalLineCurrency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPurchaseRequisitionProposalConfirmationEMailNotificationDetail> trPurchaseRequisitionProposalConfirmationEMailNotificationDetail { get; set; }
    }
}
