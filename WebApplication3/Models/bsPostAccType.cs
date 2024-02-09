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
    
    public partial class bsPostAccType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsPostAccType()
        {
            this.bsPostAccTypeDesc = new HashSet<bsPostAccTypeDesc>();
            this.prBankAdditionalChargeTypeGLAccs = new HashSet<prBankAdditionalChargeTypeGLAccs>();
            this.prBankPOSGLAccs = new HashSet<prBankPOSGLAccs>();
            this.prChequeGLAccs = new HashSet<prChequeGLAccs>();
            this.prCreditCardTypeGLAccs = new HashSet<prCreditCardTypeGLAccs>();
            this.prCurrAccGLAccount = new HashSet<prCurrAccGLAccount>();
            this.prDiscountTypeGLAccs = new HashSet<prDiscountTypeGLAccs>();
            this.prDOVGLAccs = new HashSet<prDOVGLAccs>();
            this.prImportFileGLAccs = new HashSet<prImportFileGLAccs>();
            this.prItemAccountGrGLAccs = new HashSet<prItemAccountGrGLAccs>();
            this.prNotesGLAccs = new HashSet<prNotesGLAccs>();
            this.prOfficeGLAccs = new HashSet<prOfficeGLAccs>();
            this.prPaymentProviderGLAccs = new HashSet<prPaymentProviderGLAccs>();
            this.prPCTGLAccs = new HashSet<prPCTGLAccs>();
            this.prStoreBankPOSGLAccs = new HashSet<prStoreBankPOSGLAccs>();
            this.prStoreCustomerGLAccount = new HashSet<prStoreCustomerGLAccount>();
            this.prVatGLAccs = new HashSet<prVatGLAccs>();
        }
    
        public byte PostAccTypeCode { get; set; }
        public byte GroupNum { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsPostAccTypeDesc> bsPostAccTypeDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prBankAdditionalChargeTypeGLAccs> prBankAdditionalChargeTypeGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prBankPOSGLAccs> prBankPOSGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prChequeGLAccs> prChequeGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCreditCardTypeGLAccs> prCreditCardTypeGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCurrAccGLAccount> prCurrAccGLAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prDiscountTypeGLAccs> prDiscountTypeGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prDOVGLAccs> prDOVGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prImportFileGLAccs> prImportFileGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prItemAccountGrGLAccs> prItemAccountGrGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prNotesGLAccs> prNotesGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prOfficeGLAccs> prOfficeGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prPaymentProviderGLAccs> prPaymentProviderGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prPCTGLAccs> prPCTGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prStoreBankPOSGLAccs> prStoreBankPOSGLAccs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prStoreCustomerGLAccount> prStoreCustomerGLAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prVatGLAccs> prVatGLAccs { get; set; }
    }
}