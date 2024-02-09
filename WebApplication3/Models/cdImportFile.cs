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
    
    public partial class cdImportFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdImportFile()
        {
            this.cdImportFileDesc = new HashSet<cdImportFileDesc>();
            this.cdLetterOfGuarantee = new HashSet<cdLetterOfGuarantee>();
            this.prImportFileAttribute = new HashSet<prImportFileAttribute>();
            this.prImportFileGLAccs = new HashSet<prImportFileGLAccs>();
            this.prImportFileIndirectExpense = new HashSet<prImportFileIndirectExpense>();
            this.prImportFileInsurance = new HashSet<prImportFileInsurance>();
            this.prImportFileShippingInfo = new HashSet<prImportFileShippingInfo>();
            this.prImportFileStatusHistory = new HashSet<prImportFileStatusHistory>();
            this.trBankHeader = new HashSet<trBankHeader>();
            this.trBankLine = new HashSet<trBankLine>();
            this.trBankPaymentInstructionLine = new HashSet<trBankPaymentInstructionLine>();
            this.trBankPaymentListLine = new HashSet<trBankPaymentListLine>();
            this.trCashHeader = new HashSet<trCashHeader>();
            this.trCashLine = new HashSet<trCashLine>();
            this.trChequeLine = new HashSet<trChequeLine>();
            this.trCurrAccBook = new HashSet<trCurrAccBook>();
            this.trExpenseAccrualHeader = new HashSet<trExpenseAccrualHeader>();
            this.trExpenseSlipLine = new HashSet<trExpenseSlipLine>();
            this.trInnerHeader = new HashSet<trInnerHeader>();
            this.trInnerOrderHeader = new HashSet<trInnerOrderHeader>();
            this.trInvoiceHeader = new HashSet<trInvoiceHeader>();
            this.trInvoiceLine = new HashSet<trInvoiceLine>();
            this.trItemTestLine = new HashSet<trItemTestLine>();
            this.trJournalLine = new HashSet<trJournalLine>();
            this.trOrderAsnHeader = new HashSet<trOrderAsnHeader>();
            this.trOrderHeader = new HashSet<trOrderHeader>();
            this.trProposalHeader = new HashSet<trProposalHeader>();
            this.trProposalLine = new HashSet<trProposalLine>();
            this.trShipmentHeader = new HashSet<trShipmentHeader>();
            this.trShipmentLine = new HashSet<trShipmentLine>();
        }
    
        public string ImportFileNumber { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public System.DateTime StartDate { get; set; }
        public string CustomsOfficesCode { get; set; }
        public string CustomsCompanyCode { get; set; }
        public string ExtraNumber1 { get; set; }
        public string ExtraNumber2 { get; set; }
        public string IncotermCode1 { get; set; }
        public string IncotermCode2 { get; set; }
        public string LettersOfCreditNumber { get; set; }
        public string PaymentMethodCode { get; set; }
        public bool IsClosed { get; set; }
        public System.DateTime ClosingDate { get; set; }
        public bool IsBlocked { get; set; }
        public bool IsLocked { get; set; }
        public System.DateTime LockedDate { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsIncoterm bsIncoterm { get; set; }
        public virtual bsIncoterm bsIncoterm1 { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCustomsCompany cdCustomsCompany { get; set; }
        public virtual cdCustomsOffices cdCustomsOffices { get; set; }
        public virtual cdOffice cdOffice { get; set; }
        public virtual cdPaymentMethod cdPaymentMethod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdImportFileDesc> cdImportFileDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdLetterOfGuarantee> cdLetterOfGuarantee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileAttribute> prImportFileAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileGLAccs> prImportFileGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileIndirectExpense> prImportFileIndirectExpense { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileInsurance> prImportFileInsurance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileShippingInfo> prImportFileShippingInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileStatusHistory> prImportFileStatusHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBankHeader> trBankHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBankLine> trBankLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBankPaymentInstructionLine> trBankPaymentInstructionLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBankPaymentListLine> trBankPaymentListLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCashHeader> trCashHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCashLine> trCashLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trChequeLine> trChequeLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCurrAccBook> trCurrAccBook { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trExpenseAccrualHeader> trExpenseAccrualHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trExpenseSlipLine> trExpenseSlipLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInnerHeader> trInnerHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInnerOrderHeader> trInnerOrderHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceHeader> trInvoiceHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceLine> trInvoiceLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trItemTestLine> trItemTestLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trJournalLine> trJournalLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderAsnHeader> trOrderAsnHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderHeader> trOrderHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trProposalHeader> trProposalHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trProposalLine> trProposalLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trShipmentHeader> trShipmentHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trShipmentLine> trShipmentLine { get; set; }
    }
}
