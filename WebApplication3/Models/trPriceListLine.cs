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
    
    public partial class trPriceListLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trPriceListLine()
        {
            this.trInvoiceLine = new HashSet<trInvoiceLine>();
            this.trOrderLine = new HashSet<trOrderLine>();
            this.trProposalLine = new HashSet<trProposalLine>();
            this.trShipmentLine = new HashSet<trShipmentLine>();
        }
    
        public System.Guid PriceListLineID { get; set; }
        public int SortOrder { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public string PaymentPlanCode { get; set; }
        public string LineDescription { get; set; }
        public string DocCurrencyCode { get; set; }
        public decimal Price { get; set; }
        public byte IsDisabled { get; set; }
        public System.DateTime DisableDate { get; set; }
        public decimal CompanyCode { get; set; }
        public string PriceGroupCode { get; set; }
        public System.DateTime ValidDate { get; set; }
        public System.TimeSpan ValidTime { get; set; }
        public System.Guid PriceListHeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdColor cdColor { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdItem cdItem { get; set; }
        public virtual cdItemDim1 cdItemDim1 { get; set; }
        public virtual cdItemDim2 cdItemDim2 { get; set; }
        public virtual cdItemDim3 cdItemDim3 { get; set; }
        public virtual cdPaymentPlan cdPaymentPlan { get; set; }
        public virtual cdUnitOfMeasure cdUnitOfMeasure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceLine> trInvoiceLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderLine> trOrderLine { get; set; }
        public virtual trPriceListHeader trPriceListHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trProposalLine> trProposalLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trShipmentLine> trShipmentLine { get; set; }
    }
}