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
    
    public partial class cdCreditSurveyor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cdCreditSurveyor()
        {
            this.prCreditSurveyorResponsibilityArea = new HashSet<prCreditSurveyorResponsibilityArea>();
        }
    
        public string CreditSurveyorCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNum { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
        public bool IsAuditor { get; set; }
        public byte EmployeeTypeCode { get; set; }
        public string EmployeeCode { get; set; }
        public string UserGroupCode { get; set; }
        public string UserName { get; set; }
        public byte RegionAuthorizationType { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<prCreditSurveyorResponsibilityArea> prCreditSurveyorResponsibilityArea { get; set; }
    }
}