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
    
    public partial class cdCustomerPaymentPlanGr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdCustomerPaymentPlanGr()
        {
            this.cdCurrAcc = new HashSet<cdCurrAcc>();
            this.cdCustomerPaymentPlanGrDesc = new HashSet<cdCustomerPaymentPlanGrDesc>();
            this.prCustomerPaymentPlanGrAtt = new HashSet<prCustomerPaymentPlanGrAtt>();
            this.prSubCurrAcc = new HashSet<prSubCurrAcc>();
        }
    
        public string CustomerPaymentPlanGrCode { get; set; }
        public bool IsBlocked { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCurrAcc> cdCurrAcc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cdCustomerPaymentPlanGrDesc> cdCustomerPaymentPlanGrDesc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCustomerPaymentPlanGrAtt> prCustomerPaymentPlanGrAtt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prSubCurrAcc> prSubCurrAcc { get; set; }
    }
}