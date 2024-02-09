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
    
    public partial class trCreditCardPaymentLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trCreditCardPaymentLine()
        {
            this.tpCompanyCreditCardPaymentDueDate = new HashSet<tpCompanyCreditCardPaymentDueDate>();
            this.tpCreditCardPaymentDueDate = new HashSet<tpCreditCardPaymentDueDate>();
            this.tpCreditCardPaymentFTAttribute = new HashSet<tpCreditCardPaymentFTAttribute>();
            this.trCreditCardPaymentLineCurrency = new HashSet<trCreditCardPaymentLineCurrency>();
            this.trOrderAdvancePayments = new HashSet<trOrderAdvancePayments>();
            this.trPaymentLine = new HashSet<trPaymentLine>();
        }
    
        public System.Guid CreditCardPaymentLineID { get; set; }
        public int SortOrder { get; set; }
        public string AcquirerBankCode { get; set; }
        public string IssuerBankCode { get; set; }
        public string CreditCardTypeCode { get; set; }
        public string CompanyCreditCardCode { get; set; }
        public string PaymentProviderCode { get; set; }
        public string CreditCardNum { get; set; }
        public byte CreditCardInstallmentCount { get; set; }
        public System.DateTime InstallmentStartDate { get; set; }
        public string LineDescription { get; set; }
        public string POSProvisionID { get; set; }
        public string CancelWorkPlaceID { get; set; }
        public string CancelSortOrderNumber { get; set; }
        public string CancelEndOfDayNumber { get; set; }
        public string CancelBankCode { get; set; }
        public string CancelRefNumber { get; set; }
        public string CardHoldersBankCode { get; set; }
        public string PaymentCardBIN { get; set; }
        public string DocCurrencyCode { get; set; }
        public string CurrAccCurrencyCode { get; set; }
        public double CurrAccExchangeRate { get; set; }
        public decimal CurrAccAmount { get; set; }
        public System.Guid CreditCardPaymentHeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public bool VPosReturnStatus { get; set; }
    
        public virtual cdBank cdBank { get; set; }
        public virtual cdBank cdBank1 { get; set; }
        public virtual cdCompanyCreditCard cdCompanyCreditCard { get; set; }
        public virtual cdCreditCardType cdCreditCardType { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdCurrency cdCurrency1 { get; set; }
        public virtual cdPaymentProvider cdPaymentProvider { get; set; }
        public virtual tpBulutTahsilatCreditCardPayment tpBulutTahsilatCreditCardPayment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpCompanyCreditCardPaymentDueDate> tpCompanyCreditCardPaymentDueDate { get; set; }
        public virtual tpCreditCardBulutTahsilatVPOSReturn tpCreditCardBulutTahsilatVPOSReturn { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpCreditCardPaymentDueDate> tpCreditCardPaymentDueDate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpCreditCardPaymentFTAttribute> tpCreditCardPaymentFTAttribute { get; set; }
        public virtual tpPaynetCreditCardPayment tpPaynetCreditCardPayment { get; set; }
        public virtual trCreditCardPaymentHeader trCreditCardPaymentHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trCreditCardPaymentLineCurrency> trCreditCardPaymentLineCurrency { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trOrderAdvancePayments> trOrderAdvancePayments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPaymentLine> trPaymentLine { get; set; }
    }
}
