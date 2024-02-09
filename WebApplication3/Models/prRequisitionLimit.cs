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
    
    public partial class prRequisitionLimit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public prRequisitionLimit()
        {
            this.trPurchaseRequisitionLine = new HashSet<trPurchaseRequisitionLine>();
        }
    
        public System.Guid RequisitionLimitID { get; set; }
        public decimal CompanyCode { get; set; }
        public string RequisitionTypeCode { get; set; }
        public short ValidYear { get; set; }
        public byte ValidMonth { get; set; }
        public string RequisitionCode { get; set; }
        public string WorkPlaceCode { get; set; }
        public string JobDepartmentCode { get; set; }
        public byte EmployeeTypeCode { get; set; }
        public string EmployeeCode { get; set; }
        public double Qty { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Amount { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdJobDepartment cdJobDepartment { get; set; }
        public virtual cdRequisition cdRequisition { get; set; }
        public virtual cdRequisitionType cdRequisitionType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trPurchaseRequisitionLine> trPurchaseRequisitionLine { get; set; }
    }
}
