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
    
    public partial class trPurchaseRequisitionLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trPurchaseRequisitionLine()
        {
            this.tpPurchaseRequisitionClosedByInventory = new HashSet<tpPurchaseRequisitionClosedByInventory>();
            this.tpPurchaseRequisitionConfirmation = new HashSet<tpPurchaseRequisitionConfirmation>();
            this.tpPurchaseRequisitionItemAttributeInfo = new HashSet<tpPurchaseRequisitionItemAttributeInfo>();
            this.tpPurchaseRequisitionProposal = new HashSet<tpPurchaseRequisitionProposal>();
            this.tpPurchaseRequisitionReceiveInfo = new HashSet<tpPurchaseRequisitionReceiveInfo>();
            this.tpPurchaseRequisitionRevision = new HashSet<tpPurchaseRequisitionRevision>();
            this.tpPurchaseRequisitionTechnicalNotes = new HashSet<tpPurchaseRequisitionTechnicalNotes>();
            this.tpPurchaseRequisitionTrace = new HashSet<tpPurchaseRequisitionTrace>();
            this.trInvoiceLine = new HashSet<trInvoiceLine>();
            this.trOrderLine = new HashSet<trOrderLine>();
            this.trProposalLine = new HashSet<trProposalLine>();
            this.trPurchaseRequisitionConfirmationEMailNotification = new HashSet<trPurchaseRequisitionConfirmationEMailNotification>();
            this.trPurchaseRequisitionProposalConfirmationEMailNotification = new HashSet<trPurchaseRequisitionProposalConfirmationEMailNotification>();
        }
    
        public System.Guid PurchaseRequisitionLineID { get; set; }
        public int SortOrder { get; set; }
        public string RequisitionCode { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public System.DateTime NeedByDate { get; set; }
        public System.TimeSpan NeedByTime { get; set; }
        public string LineDescription { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public double Qty { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public byte Status { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public System.DateTime ClosedDate { get; set; }
        public string ClosedUserName { get; set; }
        public byte CloseType { get; set; }
        public Nullable<System.Guid> RequisitionLimitID { get; set; }
        public System.Guid PurchaseRequisitionHeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string CostCenterCode { get; set; }
        public bool IsSampleRequested { get; set; }
        public string DeliveryOfficeCode { get; set; }
        public byte DeliveryStoreTypeCode { get; set; }
        public string DeliveryStoreCode { get; set; }
        public string DeliveryWarehouseCode { get; set; }
        public bool RevisionRequested { get; set; }
    
        public virtual cdCostCenter cdCostCenter { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdOffice cdOffice { get; set; }
        public virtual cdRequisition cdRequisition { get; set; }
        public virtual cdUnitOfMeasure cdUnitOfMeasure { get; set; }
        public virtual cdWarehouse cdWarehouse { get; set; }
        public virtual prRequisitionLimit prRequisitionLimit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionClosedByInventory> tpPurchaseRequisitionClosedByInventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionConfirmation> tpPurchaseRequisitionConfirmation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionItemAttributeInfo> tpPurchaseRequisitionItemAttributeInfo { get; set; }
        public virtual tpPurchaseRequisitionItemInfo tpPurchaseRequisitionItemInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionProposal> tpPurchaseRequisitionProposal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionReceiveInfo> tpPurchaseRequisitionReceiveInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionRevision> tpPurchaseRequisitionRevision { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionTechnicalNotes> tpPurchaseRequisitionTechnicalNotes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpPurchaseRequisitionTrace> tpPurchaseRequisitionTrace { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceLine> trInvoiceLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderLine> trOrderLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trProposalLine> trProposalLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPurchaseRequisitionConfirmationEMailNotification> trPurchaseRequisitionConfirmationEMailNotification { get; set; }
        public virtual trPurchaseRequisitionHeader trPurchaseRequisitionHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPurchaseRequisitionProposalConfirmationEMailNotification> trPurchaseRequisitionProposalConfirmationEMailNotification { get; set; }
    }
}
