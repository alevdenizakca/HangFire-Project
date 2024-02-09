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
    
    public partial class tpOrderDeliveryDetail
    {
        public System.Guid OrderDeliveryDetailID { get; set; }
        public System.Guid OrderDeliveryID { get; set; }
        public System.Guid OrderLineID { get; set; }
        public byte OrderDeliveryRecordTypeCode { get; set; }
        public decimal CompanyCode { get; set; }
        public string OfficeCode { get; set; }
        public byte StoreTypeCode { get; set; }
        public string StoreCode { get; set; }
        public string WarehouseCode { get; set; }
        public double Qty1 { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.DateTime OrderDeliveryDate { get; set; }
    
        public virtual bsApplication bsApplication { get; set; }
        public virtual bsOrderDeliveryRecordType bsOrderDeliveryRecordType { get; set; }
        public virtual cdCompany cdCompany { get; set; }
        public virtual cdCurrAcc cdCurrAcc { get; set; }
        public virtual cdOffice cdOffice { get; set; }
        public virtual cdWarehouse cdWarehouse { get; set; }
        public virtual trOrderLine trOrderLine { get; set; }
    }
}