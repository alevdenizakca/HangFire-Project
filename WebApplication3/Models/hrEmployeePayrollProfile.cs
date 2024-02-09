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
    
    public partial class hrEmployeePayrollProfile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hrEmployeePayrollProfile()
        {
            this.hrEmployeeAGI = new HashSet<hrEmployeeAGI>();
            this.hrEmployeeJobTitle = new HashSet<hrEmployeeJobTitle>();
            this.hrEmployeeMonthlySum = new HashSet<hrEmployeeMonthlySum>();
            this.hrEmployeeMonthlySumDetail = new HashSet<hrEmployeeMonthlySumDetail>();
            this.trEmployeeDebit = new HashSet<trEmployeeDebit>();
            this.hrEmployeePrivateInsurance = new HashSet<hrEmployeePrivateInsurance>();
            this.hrEmployeeSGKBorrowing = new HashSet<hrEmployeeSGKBorrowing>();
            this.hrEmployeeWage = new HashSet<hrEmployeeWage>();
            this.hrEmployeeWorkPlace = new HashSet<hrEmployeeWorkPlace>();
            this.hrWageGarnishment = new HashSet<hrWageGarnishment>();
        }
    
        public byte CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public decimal CompanyCode { get; set; }
        public string EmployeeIDNumber { get; set; }
        public string SocialInsuranceNumber { get; set; }
        public string SGKProfessionCode { get; set; }
        public byte EmployeeSocialInsuranceStatusCode { get; set; }
        public bool HaveUnemploymentInsurance { get; set; }
        public string EmploymentLawCode { get; set; }
        public byte EmployeeTaxStatusCode { get; set; }
        public string JobTypeCode { get; set; }
        public byte EmployeeSpecialTypeCode { get; set; }
        public Nullable<bool> SignOff { get; set; }
        public System.DateTime JobEndDate { get; set; }
        public string ResignationCode { get; set; }
        public string LegalResignationCode { get; set; }
        public string LegalResignationLocalCode { get; set; }
        public System.DateTime EstimatedPensionDate { get; set; }
        public bool IsUnionMember { get; set; }
        public byte QualifyingChildCount { get; set; }
        public byte QualifyingChildCount06 { get; set; }
        public bool BenefitByAgi { get; set; }
        public bool BenefitByAgiForSpouse { get; set; }
        public byte BenefitByAgiChildCount { get; set; }
        public string EmployeeEarningsGLAccCode { get; set; }
        public string EmployeeDebitGLAccCode { get; set; }
        public string EmployeeWorkAdvanceGLAccCode { get; set; }
        public string EmployeeTaxRefundGLAccCode { get; set; }
        public bool CompulsoryPensionInsuranceDeductionEnable { get; set; }
        public bool UseDifferentCPIDeductionRate { get; set; }
        public float CPIDeductionRate { get; set; }
        public string SGKInsuaranceTypeCode { get; set; }
        public string SGKMissionCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public string SeveranceGLAccCode { get; set; }
        public string TerminationGLAccCode { get; set; }
        public bool UseEmployeeContactsForAgiInfo { get; set; }
        public float MaxGarnishmentRate { get; set; }
        public bool NotApplyMinWageTaxRelief { get; set; }
        public string TransferredEmployeeCode { get; set; }
    
        public virtual bsEmployeeSpecialType bsEmployeeSpecialType { get; set; }
        public virtual bsSGKInsuaranceType bsSGKInsuaranceType { get; set; }
        public virtual bsSGKMission bsSGKMission { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdEmployeeSocialInsuranceStatus cdEmployeeSocialInsuranceStatus { get; set; }
        public virtual cdEmployeeTaxStatus cdEmployeeTaxStatus { get; set; }
        public virtual cdEmploymentLaw cdEmploymentLaw { get; set; }
        public virtual cdGLAcc cdGLAcc { get; set; }
        public virtual cdGLAcc cdGLAcc1 { get; set; }
        public virtual cdGLAcc cdGLAcc2 { get; set; }
        public virtual cdGLAcc cdGLAcc3 { get; set; }
        public virtual cdGLAcc cdGLAcc4 { get; set; }
        public virtual cdGLAcc cdGLAcc5 { get; set; }
        public virtual cdJobType cdJobType { get; set; }
        public virtual cdLegalResignation cdLegalResignation { get; set; }
        public virtual cdLegalResignationLocal cdLegalResignationLocal { get; set; }
        public virtual cdResignation cdResignation { get; set; }
        public virtual cdSGKProfession cdSGKProfession { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeeAGI> hrEmployeeAGI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeeJobTitle> hrEmployeeJobTitle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeeMonthlySum> hrEmployeeMonthlySum { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeeMonthlySumDetail> hrEmployeeMonthlySumDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trEmployeeDebit> trEmployeeDebit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeePrivateInsurance> hrEmployeePrivateInsurance { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeeSGKBorrowing> hrEmployeeSGKBorrowing { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeeWage> hrEmployeeWage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrEmployeeWorkPlace> hrEmployeeWorkPlace { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hrWageGarnishment> hrWageGarnishment { get; set; }
    }
}
