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
    
    public partial class dfMobildevStoreCollectorID
    {
        public decimal CompanyCode { get; set; }
        public string PermissionMarketingServiceCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public string OptInCollectorID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
        public byte OptInType { get; set; }
        public byte OptInMethod { get; set; }
        public string OptOutCollectorID { get; set; }
        public byte OptOutType { get; set; }
        public byte OptOutMethod { get; set; }
        public int BrandID { get; set; }
    
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdPermissionMarketingService cdPermissionMarketingService { get; set; }
    }
}
