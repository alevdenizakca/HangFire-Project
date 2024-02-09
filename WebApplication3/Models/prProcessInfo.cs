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
    
    public partial class prProcessInfo
    {
        public string ProcessCode { get; set; }
        public decimal CompanyCode { get; set; }
        public byte ItemTypeCode { get; set; }
        public bool UseApproval { get; set; }
        public bool UseGLType { get; set; }
        public bool ForceGLType { get; set; }
        public string GLTypeCode { get; set; }
        public bool ForceCostCenter { get; set; }
        public short TaxExemptionCode { get; set; }
        public bool UseTaxExemption { get; set; }
        public bool UsePaymentPlanByItem { get; set; }
        public string PaymentPlanCode { get; set; }
        public bool ForcePaymentPlanBasePrice { get; set; }
        public bool UseCreditCartPaymentPlanOnPOS { get; set; }
        public bool UseReturnReasonProductHierarcyFilter { get; set; }
        public bool UseDueDateFormula { get; set; }
        public string DueDateFormulaCode { get; set; }
        public string DOVCode { get; set; }
        public byte RetailInstallmentSaleAgeLimit { get; set; }
        public byte CreditLimitControlProcessFlow { get; set; }
        public bool AllowCreditLimitExceeded { get; set; }
        public double CreditLimitExceedanceRate { get; set; }
        public bool AllowToSaleHaveArrears { get; set; }
        public bool AllowToSaleHaveArrearsForVip { get; set; }
        public bool ApplyToLateChargeForArrears { get; set; }
        public bool NoApplyToLateChargeForArrearsVip { get; set; }
        public byte MinLatencyDay { get; set; }
        public decimal MinLatencyAmount { get; set; }
        public double MonthlyLateChargeRate { get; set; }
        public double MinLateChargeRate { get; set; }
        public bool ForceGuarantor { get; set; }
        public decimal DefaultLocalCreditLimit { get; set; }
        public bool UseCreditableConfirmationSurvey { get; set; }
        public bool ForceCreditableConfirmation { get; set; }
        public bool CanReceivePaymentUnconfirmedOrder { get; set; }
        public int InstallmentRoundingDigit { get; set; }
        public decimal AcceptableMissingPaymentAmount { get; set; }
        public bool ForcePaymentSortByInstallmentDate { get; set; }
        public bool AllowDuplicateSeriesNumber { get; set; }
        public bool IsInclutedVat { get; set; }
        public bool IsTransDirectlyPostToGL { get; set; }
        public bool IsOpenJournalAfterSave { get; set; }
        public byte DaysDiffInvoiceAndShipment { get; set; }
        public bool MustBeSameMonthInvoiceAndShipment { get; set; }
        public int OrderLeadTime { get; set; }
        public bool UseQty2 { get; set; }
        public bool UseToleranceQty { get; set; }
        public double SurplusOrderQtyToleranceRate { get; set; }
        public bool UseOrderDeliveryLocations { get; set; }
        public bool CanEditOtherStoreOrders { get; set; }
        public bool CommAddressRequiredOnProductReserveProcess { get; set; }
        public string RequiredCommunicationTypeCode { get; set; }
        public bool ApplyDiscountOfferOrderProcess { get; set; }
        public bool EarnPointAndVoucherOrderProcess { get; set; }
        public bool NoApplyDiscountOfferOrderBaseInvoice { get; set; }
        public bool AskDiscountOfferOrderProcess { get; set; }
        public bool ApplyVoucherAndPointDiscountsAfterPayment { get; set; }
        public bool ForeignLocalCurrAccControl { get; set; }
        public bool AllowZeroAmountInvoice { get; set; }
        public bool GetBasePriceWhenPriceCantfound { get; set; }
        public bool WarnZeroPriceOnOrder { get; set; }
        public bool WarnZeroPriceOnInvoice { get; set; }
        public bool CanSellProductWithLessPrice { get; set; }
        public bool AllowDiffPriceOnChangeVariant { get; set; }
        public bool ForceWarehouseOnOrders { get; set; }
        public bool ForceDescriptionOnOrders { get; set; }
        public bool ForceLineDescriptionOnOrders { get; set; }
        public bool WarnRepeatedItemCodeOnOrders { get; set; }
        public bool CombineGLAccInJournal { get; set; }
        public bool SeparateDiscountInJournal { get; set; }
        public bool SeparateReturnDiscountInJournal { get; set; }
        public bool CombineDiscountGLAccInJournal { get; set; }
        public bool CombineVatGLAccInJournal { get; set; }
        public bool UseEarlyPaymentDiscount { get; set; }
        public double DefaultEarlyPaymentDiscount { get; set; }
        public bool ApplyEPDAllInstalmentsClosed { get; set; }
        public double MaxEarlyPaymentDiscount { get; set; }
        public byte MinEarlyPaymentDay { get; set; }
        public bool UseSalesDateForReplacement { get; set; }
        public bool ForceSamePaymentForReplacement { get; set; }
        public bool CanEditAmountForReplacement { get; set; }
        public bool CanSearchCreditVoucher { get; set; }
        public bool IgnorOverageOfCash { get; set; }
        public bool UseSeriesCode { get; set; }
        public bool UseSeriesCodeOnEInvoiceShipments { get; set; }
        public bool RequiredSalesPerson { get; set; }
        public bool EnablePriceControlSystem { get; set; }
        public bool CreateGiftCardSalesAsEInvoice { get; set; }
        public bool CreateGiftCardSalesAsEArchiveInvoice { get; set; }
        public bool CanEditInvoicedShipment { get; set; }
        public bool UseEArchiveInvoiceConfirmation { get; set; }
        public bool UseDebitVoucher { get; set; }
        public bool CreateSequantialDebitVoucher { get; set; }
        public bool DisplayAdvanceInfoOnPayment { get; set; }
        public bool DisplayCreditVoucherInfoOnPayment { get; set; }
        public bool CreateCreditVoucherAsBearer { get; set; }
        public string LogisticsDiffWarehouseCode { get; set; }
        public bool UseRetailCustomerConditionalRequiredFields { get; set; }
        public bool CanEditProposalBasedTransactions { get; set; }
        public bool UseProposalPriceForInvoiceAndOrder { get; set; }
        public bool UseOnlyCompanyBrandedProducts { get; set; }
        public bool UseSerialProNumberOnOpticalOrders { get; set; }
        public bool StoreCanOnlyReturnOwnInvoices { get; set; }
        public bool ShowCustomizedItemInformationOnPos { get; set; }
        public bool IncludeZeroPriceLinesInSupportInvoices { get; set; }
        public bool UseOrderPriceOnInvoiceOrderBase { get; set; }
        public bool UseOrderPriceOnShipmentOrderBase { get; set; }
        public bool UseInstallmentCountRules { get; set; }
        public bool StoreCanOnlyChangeVariantOwnInvoices { get; set; }
        public bool DoNotAllowDifferentTDiscountsOnOrderBasedInvoices { get; set; }
        public bool CheckBadDebtStatusOnGuarantorEntry { get; set; }
        public bool CanInputWithNewBatchInReturnTransactions { get; set; }
        public bool CannotEditSalesPerson { get; set; }
        public bool UseLastPriceOnReturnInvoices { get; set; }
        public bool CreateDisposibleCreditVouchers { get; set; }
        public bool IsReturnReasonRequired { get; set; }
        public bool WarnNegativeDiscountPoints { get; set; }
        public bool AskReturnTypeOnCompanyReturnInvoices { get; set; }
        public bool UseDefaultExpenseTypeForExpensePurchase { get; set; }
        public bool DiscountPointsWillBeAddedToNewCustomerOnReturnGiftProduct { get; set; }
        public bool WarnRepeatedItemLotOnOrders { get; set; }
        public bool UseSelectedSubCurrAccAddress { get; set; }
        public byte IncompleteDownPaymentDistributionTypeCode { get; set; }
        public bool FirstInstallmentChangedSetAllInstallmentsSameAmount { get; set; }
        public bool OrderNumberIsRequiredForOrderBasedTransImportLines { get; set; }
        public bool SendInvoiceByEmailIsVisible { get; set; }
        public bool SendInvoiceByEmailIsSelected { get; set; }
        public bool SendInvoiceByEmailIsRequired { get; set; }
        public bool SendInvoiceBySMSIsVisible { get; set; }
        public bool SendInvoiceBySMSIsSelected { get; set; }
        public bool SendInvoiceBySMSIsRequired { get; set; }
        public bool UseRetailCustomerSurvey { get; set; }
        public string RetailCustomerSurveyCode { get; set; }
        public short RetailCustomerSurveryExpirePeriod { get; set; }
        public bool UseAuditorSurvey { get; set; }
        public string AuditorSurveyCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public bool ShowUserWarningsAsPopUpOnInstallmentPayment { get; set; }
        public bool UseConfirmationRequiredProductGroups { get; set; }
        public bool IsPasswordRequiredOnCancelTransaction { get; set; }
        public bool IsPasswordRequiredOnCancelItem { get; set; }
        public bool UseFixedCancelPassword { get; set; }
        public string CancelPassword { get; set; }
        public bool SendCancelPasswordSMSToStoreContact { get; set; }
        public bool UseBatchBarcodeInventoryForLineQty { get; set; }
        public bool IsPasswordRequiredOnReturnTransaction { get; set; }
        public bool ReturnShipmentNotAllowedForInvoicedOrder { get; set; }
        public bool MinLateChargeRateCanBeChangedWithPassword { get; set; }
        public bool UseFixedLateChargeRatePassword { get; set; }
        public string FixedLateChargeRatePassword { get; set; }
        public bool SendLateChargeRatePasswordSMSToStoreContact { get; set; }
        public bool SendLateChargeRatePasswordToDefinedContacts { get; set; }
        public string DefinedContactsForLateChargeRatePassword { get; set; }
        public bool DispOrderConfirmationNotRequiredForVIPCustomers { get; set; }
        public bool PackageShippingConfirmationNotRequiredForVIPCustomers { get; set; }
        public bool OpenPostingEInvoicesAfterEInvoiceCreated { get; set; }
        public bool IsPasswordRequiredOnReplacementTransaction { get; set; }
        public bool NewInstallmentCountValidForGreaterInstallmentCounts { get; set; }
        public bool FixInstallmentCountOnEditPaymentPlan { get; set; }
        public bool OpenPostingEShipmentsAfterEShipmentCreated { get; set; }
        public bool LateChargeMayNotBeAppliedIfAllArrearsSelected { get; set; }
        public bool ForcePurchasePlanPrice { get; set; }
        public bool SetBatchCode { get; set; }
        public bool FilterCompanyCodeOnApproveStoreReturns { get; set; }
        public bool UseToWarehouseFilter { get; set; }
        public bool ApplyRoundingDiffLastToInstallment { get; set; }
        public bool ApplyEPDRemainingBalanceClosed { get; set; }
        public bool CanEditInvoiceWithPaymentRecord { get; set; }
        public bool OpenPostingEShipmentsAfterEShipmentCreatedOnStore { get; set; }
        public bool CanAcceptUnDeliveredEShipments { get; set; }
        public bool CanReduceProposalPriceForInvoiceAndOrder { get; set; }
        public bool CanIncreaseProposalPriceForInvoiceAndOrder { get; set; }
        public bool ApplyEPDAllInstalmentsClosedSkipMinLatencyDay { get; set; }
        public bool SeparateDiscountInJournalTaxIncluded { get; set; }
        public bool UseAttributeProductOnChangeVariant { get; set; }
        public byte AttributeProductOnChangeVariant { get; set; }
        public bool ReturnDiscountVoucherChangeVariantAndPartialLines { get; set; }
        public bool ApplyMaxOrderLeadTimeAllLines { get; set; }
        public bool LeadTimeOnlyDelay { get; set; }
    
        public virtual bsIncompleteDownPaymentDistributionType bsIncompleteDownPaymentDistributionType { get; set; }
        public virtual bsItemType bsItemType { get; set; }
        public virtual bsProcess bsProcess { get; set; }
        public virtual bsTaxExemption bsTaxExemption { get; set; }
        public virtual cdCommunicationType cdCommunicationType { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdDOV cdDOV { get; set; }
        public virtual cdDueDateFormula cdDueDateFormula { get; set; }
        public virtual cdGLType cdGLType { get; set; }
        public virtual cdPaymentPlan cdPaymentPlan { get; set; }
    }
}