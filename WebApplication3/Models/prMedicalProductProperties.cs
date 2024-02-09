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
    
    public partial class prMedicalProductProperties
    {
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string BarcodeCompanyCode1 { get; set; }
        public string BarcodeTypeCode1 { get; set; }
        public string BarcodeCompanyCode2 { get; set; }
        public string BarcodeTypeCode2 { get; set; }
        public byte ManufacturerCurrAccTypeCode { get; set; }
        public string ManufacturerCurrAccCode { get; set; }
        public byte ImporterCurrAccTypeCode { get; set; }
        public string ImporterCurrAccCode { get; set; }
        public string UTSAttributeCode { get; set; }
        public string GDMNCode { get; set; }
        public string UTSBranchCode { get; set; }
        public bool IsManufacturedProduct { get; set; }
        public bool ContainsLatexOnLabel { get; set; }
        public bool ContainsIonizedRadiation { get; set; }
        public bool ContainsDEHPOnLabel { get; set; }
        public bool ContainsNanoMaterial { get; set; }
        public bool IsDisposable { get; set; }
        public int LimitedUseCount { get; set; }
        public bool IsSterilePacked { get; set; }
        public string SterilizationMethods { get; set; }
        public short CalibrationPeriod { get; set; }
        public short MaintenancePeriod { get; set; }
        public bool CanSellApartFromSalesCenter { get; set; }
        public string UTSDocumentNumbers { get; set; }
        public bool UTSSent { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public bool RequiresStorageCondition { get; set; }
        public bool AvailableForSinglePatient { get; set; }
        public string SutConvertStatus { get; set; }
        public bool CanSellApartFromHealthMarkets { get; set; }
        public bool HasUserGuide { get; set; }
        public string BrandCode { get; set; }
        public byte ProductTypeCode { get; set; }
        public string UTSMRGInfoCode { get; set; }
        public bool IsConfirmed { get; set; }
        public string ConfirmedInstitutionNumber { get; set; }
        public short ContentCount { get; set; }
        public string ExtraInfoLink { get; set; }
        public bool IsImplantable { get; set; }
        public string PackageSterilizationMethods { get; set; }
        public string MainProductBrachCodes { get; set; }
        public short ProductSurfaceArea { get; set; }
        public bool ReadyToApply { get; set; }
        public string BasicUDI_DI { get; set; }
    
        public virtual cdBarcodeCompany cdBarcodeCompany { get; set; }
        public virtual cdBarcodeCompany cdBarcodeCompany1 { get; set; }
        public virtual cdBrand cdBrand { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCurrAcc cdCurrAcc1 { get; set; }
        public virtual cdItem cdItem { get; set; }
        public virtual cdUTSAttribute cdUTSAttribute { get; set; }
        public virtual cdUTSMRGInfo cdUTSMRGInfo { get; set; }
    }
}
