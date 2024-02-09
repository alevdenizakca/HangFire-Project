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
    
    public partial class bsBankTransType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bsBankTransType()
        {
            this.auBankPermit = new HashSet<auBankPermit>();
            this.bsBankTransTypeDesc = new HashSet<bsBankTransTypeDesc>();
            this.dfBankDefATAttribute = new HashSet<dfBankDefATAttribute>();
            this.dfBankOfficialForm = new HashSet<dfBankOfficialForm>();
            this.prMT940ProcessRules = new HashSet<prMT940ProcessRules>();
            this.srRefNumberBankTrans = new HashSet<srRefNumberBankTrans>();
            this.trBankHeader = new HashSet<trBankHeader>();
        }
    
        public byte BankTransTypeCode { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<auBankPermit> auBankPermit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bsBankTransTypeDesc> bsBankTransTypeDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfBankDefATAttribute> dfBankDefATAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dfBankOfficialForm> dfBankOfficialForm { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prMT940ProcessRules> prMT940ProcessRules { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<srRefNumberBankTrans> srRefNumberBankTrans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBankHeader> trBankHeader { get; set; }
    }
}
