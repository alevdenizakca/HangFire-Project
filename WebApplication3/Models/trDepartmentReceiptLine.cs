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
    
    public partial class trDepartmentReceiptLine
    {
        public System.Guid DepartmentReceiptLineID { get; set; }
        public int SortOrder { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public double Qty { get; set; }
        public string SalespersonCode { get; set; }
        public string UsedBarcode { get; set; }
        public System.Guid DepartmentReceiptHeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string PaymentPlanCode { get; set; }
        public string LineDescription { get; set; }
        public byte ItemDeliveryStatus { get; set; }
    
        public virtual cdPaymentPlan cdPaymentPlan { get; set; }
        public virtual cdSalesperson cdSalesperson { get; set; }
        public virtual prItemVariant prItemVariant { get; set; }
        public virtual trDepartmentReceiptHeader trDepartmentReceiptHeader { get; set; }
    }
}