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
    
    public partial class ConfirmationFormType_Result
    {
        public string ConfirmationFormTypeCode { get; set; }
        public string FormName { get; set; }
        public bool UseForCommunication { get; set; }
        public bool UseForPresentCard { get; set; }
        public bool UsePreprintedForm { get; set; }
        public bool UseSameCardNumberWithFormNumber { get; set; }
        public bool UseForPersonalData { get; set; }
        public bool DoNotRequestReConfirmation { get; set; }
        public bool IsBlocked { get; set; }
        public string FormNumberPrefix { get; set; }
        public bool UseSMS { get; set; }
        public bool UsePreConfiguredOptions { get; set; }
        public bool CanShareWithThirdParty { get; set; }
        public bool CanShareWithForeignCountries { get; set; }
        public bool CallPermission { get; set; }
        public bool SmsPermission { get; set; }
        public bool EmailPermission { get; set; }
        public bool AddressPermission { get; set; }
        public string ConfirmationFormStatusCode { get; set; }
        public bool UseSMSWithCustomerInformation { get; set; }
        public string ConsentSource { get; set; }
        public bool DataProcessPermission { get; set; }
        public bool OptOutCommunicationsWithPDCInactivation { get; set; }
        public string LangCode { get; set; }
        public string ConfirmationFormTypeDescription { get; set; }
    }
}
