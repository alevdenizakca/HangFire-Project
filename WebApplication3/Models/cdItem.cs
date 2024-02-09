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
    
    public partial class cdItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdItem()
        {
            this.cdGiftCard = new HashSet<cdGiftCard>();
            this.zt_ProductSupplier = new HashSet<zt_ProductSupplier>();
            this.cdItemDesc = new HashSet<cdItemDesc>();
            this.cdPlasticBagType = new HashSet<cdPlasticBagType>();
            this.dfCarriageExpenseCodes = new HashSet<dfCarriageExpenseCodes>();
            this.dfInsuaranceExpenseCodes = new HashSet<dfInsuaranceExpenseCodes>();
            this.prCompanyExpense = new HashSet<prCompanyExpense>();
            this.prCustomProcessGroupAtt = new HashSet<prCustomProcessGroupAtt>();
            this.prCustomProcessGroupAtt1 = new HashSet<prCustomProcessGroupAtt>();
            this.prExportFileIndirectExpense = new HashSet<prExportFileIndirectExpense>();
            this.prFixedAssetDepreciationInfo = new HashSet<prFixedAssetDepreciationInfo>();
            this.prFixedAssetEmployee = new HashSet<prFixedAssetEmployee>();
            this.prFixedAssetExpense = new HashSet<prFixedAssetExpense>();
            this.prFixedAssetInsurance = new HashSet<prFixedAssetInsurance>();
            this.prFixedAssetPurchases = new HashSet<prFixedAssetPurchases>();
            this.prFixedAssetReassessmentRates = new HashSet<prFixedAssetReassessmentRates>();
            this.prFixedAssetSales = new HashSet<prFixedAssetSales>();
            this.prFixedAssetStatusHistory = new HashSet<prFixedAssetStatusHistory>();
            this.prImportFileExpense = new HashSet<prImportFileExpense>();
            this.prImportFileIndirectExpense = new HashSet<prImportFileIndirectExpense>();
            this.prItemAirportSalesCommissionGroup = new HashSet<prItemAirportSalesCommissionGroup>();
            this.prItemAlike = new HashSet<prItemAlike>();
            this.prItemAlike1 = new HashSet<prItemAlike>();
            this.prItemAttribute = new HashSet<prItemAttribute>();
            this.prItemBasePrice = new HashSet<prItemBasePrice>();
            this.prItemColorAttributes = new HashSet<prItemColorAttributes>();
            this.prItemColorFabricBlend = new HashSet<prItemColorFabricBlend>();
            this.prItemCompanyBrand = new HashSet<prItemCompanyBrand>();
            this.prItemCostCenter = new HashSet<prItemCostCenter>();
            this.prItemCostCenterRates = new HashSet<prItemCostCenterRates>();
            this.prItemCrossUnitOfMeasure = new HashSet<prItemCrossUnitOfMeasure>();
            this.prItemInformation = new HashSet<prItemInformation>();
            this.prItemNotes = new HashSet<prItemNotes>();
            this.prItemRequisition = new HashSet<prItemRequisition>();
            this.prItemSerialNumber = new HashSet<prItemSerialNumber>();
            this.prItemTextileCareSymbol = new HashSet<prItemTextileCareSymbol>();
            this.prItemUnAcceptableExpense1 = new HashSet<prItemUnAcceptableExpense>();
            this.prItemVariant = new HashSet<prItemVariant>();
            this.prLinkedProductContent = new HashSet<prLinkedProductContent>();
            this.prLinkedProductContentSum = new HashSet<prLinkedProductContentSum>();
            this.prMarketPlaceProduct = new HashSet<prMarketPlaceProduct>();
            this.prMarketPlaceProductInformation = new HashSet<prMarketPlaceProductInformation>();
            this.prMedicalProductImportCountries = new HashSet<prMedicalProductImportCountries>();
            this.prMedicalProductOriginCountries = new HashSet<prMedicalProductOriginCountries>();
            this.prProductCareWarning = new HashSet<prProductCareWarning>();
            this.prProductColorAttribute = new HashSet<prProductColorAttribute>();
            this.prProductImageURLs = new HashSet<prProductImageURLs>();
            this.prProductLot = new HashSet<prProductLot>();
            this.prProductLotBarcode = new HashSet<prProductLotBarcode>();
            this.prProductPoint = new HashSet<prProductPoint>();
            this.prProductStatusHistory = new HashSet<prProductStatusHistory>();
            this.prServiceAvailableProductLevel = new HashSet<prServiceAvailableProductLevel>();
            this.prServiceAvailableSupportType = new HashSet<prServiceAvailableSupportType>();
            this.srCodeNumberGiftCard = new HashSet<srCodeNumberGiftCard>();
            this.tpOrderOpticalProductCustomProcess = new HashSet<tpOrderOpticalProductCustomProcess>();
            this.trBadDebtTransLineAddExpense = new HashSet<trBadDebtTransLineAddExpense>();
            this.trCostOfGoodsSoldHeader = new HashSet<trCostOfGoodsSoldHeader>();
            this.trExpenseSlipLine = new HashSet<trExpenseSlipLine>();
            this.trFixedAssetBookHeader = new HashSet<trFixedAssetBookHeader>();
            this.trPriceListLine = new HashSet<trPriceListLine>();
            this.trSalesPlanProduct = new HashSet<trSalesPlanProduct>();
            this.trSupportRequestLine = new HashSet<trSupportRequestLine>();
            this.trTaxIncurredHeader = new HashSet<trTaxIncurredHeader>();
            this.trVendorPriceListLine = new HashSet<trVendorPriceListLine>();
        }
    
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public byte ItemDimTypeCode { get; set; }
        public byte ProductTypeCode { get; set; }
        public int ProductHierarchyID { get; set; }
        public string UnitOfMeasureCode1 { get; set; }
        public string UnitOfMeasureCode2 { get; set; }
        public float UnitConvertRate { get; set; }
        public bool UnitConvertRateNotFixed { get; set; }
        public bool UseRoll { get; set; }
        public bool UseBatch { get; set; }
        public bool UseInternet { get; set; }
        public bool UsePOS { get; set; }
        public bool UseStore { get; set; }
        public bool EnablePartnerCompanies { get; set; }
        public bool UseManufacturing { get; set; }
        public bool UseSerialNumber { get; set; }
        public bool GenerateSerialNumber { get; set; }
        public bool GenerateOpticalDataMatrixCode { get; set; }
        public bool ByWeight { get; set; }
        public short SupplyPeriod { get; set; }
        public short GuaranteePeriod { get; set; }
        public short ShelfLife { get; set; }
        public int OrderLeadTime { get; set; }
        public string ItemAccountGrCode { get; set; }
        public string ItemTaxGrCode { get; set; }
        public string ItemPaymentPlanGrCode { get; set; }
        public string ItemDiscountGrCode { get; set; }
        public string ItemVendorGrCode { get; set; }
        public string PromotionGroupCode { get; set; }
        public string PromotionGroupCode2 { get; set; }
        public int ProductCollectionGrCode { get; set; }
        public byte StorePriceLevelCode { get; set; }
        public byte PerceptionOfFashionCode { get; set; }
        public byte CommercialRoleCode { get; set; }
        public string StoreCapacityLevelCode { get; set; }
        public string CustomsTariffNumberCode { get; set; }
        public bool IsFixedExpense { get; set; }
        public string BOMEntityCode { get; set; }
        public byte MaxCreditCardInstallmentCount { get; set; }
        public decimal CompanyCode { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsLocked { get; set; }
        public System.DateTime LockedDate { get; set; }
        public byte IsSalesOrderClosed { get; set; }
        public bool IsPurchaseOrderClosed { get; set; }
        public byte IsSubsequentDeliveryForR { get; set; }
        public byte IsSubsequentDeliveryForRI { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public string IGACommissionGroup { get; set; }
        public string UniFreeCommissionGroup { get; set; }
        public byte CustomsProductGroupCode { get; set; }
        public bool IsUTSDeclaratedItem { get; set; }
        public bool IsStoreOrderClosed { get; set; }
    
        public virtual bsCustomsProductGroup bsCustomsProductGroup { get; set; }
        public virtual bsItemDimType bsItemDimType { get; set; }
        public virtual bsItemType bsItemType { get; set; }
        public virtual bsProductType bsProductType { get; set; }
        public virtual cdBOMEntity cdBOMEntity { get; set; }
        public virtual cdCommercialRole cdCommercialRole { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCustomsTariffNumber cdCustomsTariffNumber { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdGiftCard> cdGiftCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zt_ProductSupplier> zt_ProductSupplier { get; set; }
        public virtual cdItemAccountGr cdItemAccountGr { get; set; }
        public virtual cdItemDiscountGr cdItemDiscountGr { get; set; }
        public virtual cdItemPaymentPlanGr cdItemPaymentPlanGr { get; set; }
        public virtual cdItemTaxGr cdItemTaxGr { get; set; }
        public virtual cdItemVendorGr cdItemVendorGr { get; set; }
        public virtual cdPerceptionOfFashion cdPerceptionOfFashion { get; set; }
        public virtual cdProductCollectionGr cdProductCollectionGr { get; set; }
        public virtual dfProductHierarchy dfProductHierarchy { get; set; }
        public virtual cdPromotionGroup cdPromotionGroup { get; set; }
        public virtual cdPromotionGroup cdPromotionGroup1 { get; set; }
        public virtual cdStoreCapacityLevel cdStoreCapacityLevel { get; set; }
        public virtual cdStorePriceLevel cdStorePriceLevel { get; set; }
        public virtual cdUnitOfMeasure cdUnitOfMeasure { get; set; }
        public virtual cdUnitOfMeasure cdUnitOfMeasure1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdItemDesc> cdItemDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdPlasticBagType> cdPlasticBagType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfCarriageExpenseCodes> dfCarriageExpenseCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfInsuaranceExpenseCodes> dfInsuaranceExpenseCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCompanyExpense> prCompanyExpense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCustomProcessGroupAtt> prCustomProcessGroupAtt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCustomProcessGroupAtt> prCustomProcessGroupAtt1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prExportFileIndirectExpense> prExportFileIndirectExpense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prFixedAssetDepreciationInfo> prFixedAssetDepreciationInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prFixedAssetEmployee> prFixedAssetEmployee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prFixedAssetExpense> prFixedAssetExpense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prFixedAssetInsurance> prFixedAssetInsurance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prFixedAssetPurchases> prFixedAssetPurchases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prFixedAssetReassessmentRates> prFixedAssetReassessmentRates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prFixedAssetSales> prFixedAssetSales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prFixedAssetStatusHistory> prFixedAssetStatusHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileExpense> prImportFileExpense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileIndirectExpense> prImportFileIndirectExpense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemAirportSalesCommissionGroup> prItemAirportSalesCommissionGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemAlike> prItemAlike { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemAlike> prItemAlike1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemAttribute> prItemAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemBasePrice> prItemBasePrice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemColorAttributes> prItemColorAttributes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemColorFabricBlend> prItemColorFabricBlend { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemCompanyBrand> prItemCompanyBrand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemCostCenter> prItemCostCenter { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemCostCenterRates> prItemCostCenterRates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemCrossUnitOfMeasure> prItemCrossUnitOfMeasure { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemInformation> prItemInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemNotes> prItemNotes { get; set; }
        public virtual prItemPhoto prItemPhoto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemRequisition> prItemRequisition { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemSerialNumber> prItemSerialNumber { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemTextileCareSymbol> prItemTextileCareSymbol { get; set; }
        public virtual prItemUnAcceptableExpense prItemUnAcceptableExpense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemUnAcceptableExpense> prItemUnAcceptableExpense1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemVariant> prItemVariant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prLinkedProductContent> prLinkedProductContent { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prLinkedProductContentSum> prLinkedProductContentSum { get; set; }
        public virtual prLinkedProductProperties prLinkedProductProperties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prMarketPlaceProduct> prMarketPlaceProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prMarketPlaceProductInformation> prMarketPlaceProductInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prMedicalProductImportCountries> prMedicalProductImportCountries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prMedicalProductOriginCountries> prMedicalProductOriginCountries { get; set; }
        public virtual prMedicalProductProperties prMedicalProductProperties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prProductCareWarning> prProductCareWarning { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prProductColorAttribute> prProductColorAttribute { get; set; }
        public virtual prProductFrameProperties prProductFrameProperties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prProductImageURLs> prProductImageURLs { get; set; }
        public virtual prProductLensProperties prProductLensProperties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prProductLot> prProductLot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prProductLotBarcode> prProductLotBarcode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prProductPoint> prProductPoint { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prProductStatusHistory> prProductStatusHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prServiceAvailableProductLevel> prServiceAvailableProductLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prServiceAvailableSupportType> prServiceAvailableSupportType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<srCodeNumberGiftCard> srCodeNumberGiftCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOrderOpticalProductCustomProcess> tpOrderOpticalProductCustomProcess { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBadDebtTransLineAddExpense> trBadDebtTransLineAddExpense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCostOfGoodsSoldHeader> trCostOfGoodsSoldHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trExpenseSlipLine> trExpenseSlipLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trFixedAssetBookHeader> trFixedAssetBookHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPriceListLine> trPriceListLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trSalesPlanProduct> trSalesPlanProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trSupportRequestLine> trSupportRequestLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trTaxIncurredHeader> trTaxIncurredHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trVendorPriceListLine> trVendorPriceListLine { get; set; }
    }
}