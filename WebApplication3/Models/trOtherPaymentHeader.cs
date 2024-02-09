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
    
    public partial class trOtherPaymentHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trOtherPaymentHeader()
        {
            this.tpOtherPaymentATAttribute = new HashSet<tpOtherPaymentATAttribute>();
            this.trOtherPaymentLine = new HashSet<trOtherPaymentLine>();
        }
    
        public System.Guid OtherPaymentHeaderID { get; set; }
        public string PaymentProviderCode { get; set; }
        public byte OtherPaymentTypeCode { get; set; }
        public string OtherPaymentNumber { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public System.TimeSpan PaymentTime { get; set; }
        public string DocumentNumber { get; set; }
        public string RefNumber { get; set; }
        public byte CurrAccTypeCode { get; set; }
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
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual bsApplication bsApplication { get; set; }
        public virtual bsOtherPaymentType bsOtherPaymentType { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCurrAcc cdCurrAcc1 { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdCurrency cdCurrency1 { get; set; }
        public virtual cdGLType cdGLType { get; set; }
        public virtual cdOffice cdOffice { get; set; }
        public virtual cdPaymentProvider cdPaymentProvider { get; set; }
        public virtual prCurrAccContact prCurrAccContact { get; set; }
        public virtual prSubCurrAcc prSubCurrAcc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpOtherPaymentATAttribute> tpOtherPaymentATAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOtherPaymentLine> trOtherPaymentLine { get; set; }
    }
}