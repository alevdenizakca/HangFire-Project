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
    
    public partial class trChequeHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trChequeHeader()
        {
            this.tpChequeATAttribute = new HashSet<tpChequeATAttribute>();
            this.tpInvoiceExchangeDifferencePaidCheque = new HashSet<tpInvoiceExchangeDifferencePaidCheque>();
            this.trChequeLine = new HashSet<trChequeLine>();
        }
    
        public System.Guid ChequeHeaderID { get; set; }
        public byte ChequeTransTypeCode { get; set; }
        public string ChequeTransNumber { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public System.TimeSpan DocumentTime { get; set; }
        public string DocumentNumber { get; set; }
        public Nullable<byte> CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public string Description { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public short POSTerminalID { get; set; }
        public string GLTypeCode { get; set; }
        public string DocCurrencyCode { get; set; }
        public string LocalCurrencyCode { get; set; }
        public double ExchangeRate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsLocked { get; set; }
        public bool IsPrinted { get; set; }
        public bool IsPostingJournal { get; set; }
        public System.DateTime JournalDate { get; set; }
        public Nullable<byte> CashCurrAccTypeCode { get; set; }
        public string CashCurrAccCode { get; set; }
        public Nullable<byte> BankCurrAccTypeCode { get; set; }
        public string BankCurrAccCode { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual bsApplication bsApplication { get; set; }
        public virtual bsChequeTransType bsChequeTransType { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCurrAcc cdCurrAcc1 { get; set; }
        public virtual cdCurrAcc cdCurrAcc2 { get; set; }
        public virtual cdCurrAcc cdCurrAcc3 { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdCurrency cdCurrency1 { get; set; }
        public virtual cdGLType cdGLType { get; set; }
        public virtual cdOffice cdOffice { get; set; }
        public virtual prCurrAccContact prCurrAccContact { get; set; }
        public virtual prSubCurrAcc prSubCurrAcc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpChequeATAttribute> tpChequeATAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpInvoiceExchangeDifferencePaidCheque> tpInvoiceExchangeDifferencePaidCheque { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trChequeLine> trChequeLine { get; set; }
    }
}
