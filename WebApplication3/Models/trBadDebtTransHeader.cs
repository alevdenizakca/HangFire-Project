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
    
    public partial class trBadDebtTransHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trBadDebtTransHeader()
        {
            this.tpBadDebtLawyerHistory = new HashSet<tpBadDebtLawyerHistory>();
            this.trBadDebtTransLine = new HashSet<trBadDebtTransLine>();
        }
    
        public System.Guid BadDebtTransHeaderID { get; set; }
        public byte BadDebtTransTypeCode { get; set; }
        public string BadDebtNumber { get; set; }
        public System.DateTime OperationDate { get; set; }
        public System.TimeSpan OperationTime { get; set; }
        public string LawyerCode { get; set; }
        public string Description { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsPrinted { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual bsApplication bsApplication { get; set; }
        public virtual bsBadDebtTransType bsBadDebtTransType { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdLawyer cdLawyer { get; set; }
        public virtual cdOffice cdOffice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tpBadDebtLawyerHistory> tpBadDebtLawyerHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trBadDebtTransLine> trBadDebtTransLine { get; set; }
    }
}