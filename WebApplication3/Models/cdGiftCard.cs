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
    
    public partial class cdGiftCard
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdGiftCard()
        {
            this.prGiftCardCharge = new HashSet<prGiftCardCharge>();
            this.trGiftCardPaymentLine = new HashSet<trGiftCardPaymentLine>();
            this.trInnerLineGiftCard = new HashSet<trInnerLineGiftCard>();
            this.trInvoiceLineGiftCard = new HashSet<trInvoiceLineGiftCard>();
            this.trShipmentLineGiftCard = new HashSet<trShipmentLineGiftCard>();
        }
    
        public string SerialNumber { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public System.DateTime FirstValidDate { get; set; }
        public int AfterSaleAvailableDay { get; set; }
        public System.DateTime LastValidDate { get; set; }
        public bool IsDisposable { get; set; }
        public bool CannotReturn { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public decimal UsedAmount { get; set; }
        public Nullable<System.Guid> InvoiceHeaderID { get; set; }
        public Nullable<System.Guid> OrderHeaderID { get; set; }
        public bool IsBearerVoucher { get; set; }
        public bool IsAmountToBeEnteredOnSale { get; set; }
        public bool IsSold { get; set; }
        public bool IsUsed { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public decimal MinSaleAmount { get; set; }
        public decimal MaxSaleAmount { get; set; }
        public double SaleMultiplesOfValue { get; set; }
        public bool UseSMSVerificationOnUse { get; set; }
        public string VerifiedPhoneNumber { get; set; }
        public string MessageResponseID { get; set; }
        public bool IgnoreSMSVerificationOnUse { get; set; }
    
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdItem cdItem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prGiftCardCharge> prGiftCardCharge { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trGiftCardPaymentLine> trGiftCardPaymentLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInnerLineGiftCard> trInnerLineGiftCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceLineGiftCard> trInvoiceLineGiftCard { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trShipmentLineGiftCard> trShipmentLineGiftCard { get; set; }
    }
}
