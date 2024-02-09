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
    
    public partial class trCostOfGoodsSoldHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trCostOfGoodsSoldHeader()
        {
            this.trAdjustCostInventory = new HashSet<trAdjustCostInventory>();
            this.trCostOfGoodsSoldLine = new HashSet<trCostOfGoodsSoldLine>();
            this.trEndOfPeriodInventory = new HashSet<trEndOfPeriodInventory>();
        }
    
        public System.Guid CostOfGoodsSoldHeaderID { get; set; }
        public decimal CompanyCode { get; set; }
        public string CostOfGoodsSoldPeriodCode { get; set; }
        public string OfficeCode { get; set; }
        public string WarehouseCode { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public string BatchCode { get; set; }
        public byte CostingMethodCode { get; set; }
        public byte CostingLevelCode { get; set; }
        public byte CostingVariantLevelCode { get; set; }
        public bool CalculateByBatchCode { get; set; }
        public bool IsPostingJournal { get; set; }
        public System.DateTime JournalDate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string OfficeCOGSGrCode { get; set; }
    
        public virtual bsCostingLevel bsCostingLevel { get; set; }
        public virtual bsCostingMethod bsCostingMethod { get; set; }
        public virtual bsCostingVariantLevel bsCostingVariantLevel { get; set; }
        public virtual cdBatch cdBatch { get; set; }
        public virtual cdCostOfGoodsSoldPeriod cdCostOfGoodsSoldPeriod { get; set; }
        public virtual cdItem cdItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trAdjustCostInventory> trAdjustCostInventory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCostOfGoodsSoldLine> trCostOfGoodsSoldLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trEndOfPeriodInventory> trEndOfPeriodInventory { get; set; }
    }
}
