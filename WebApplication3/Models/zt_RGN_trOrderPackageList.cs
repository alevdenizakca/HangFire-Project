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
    
    public partial class zt_RGN_trOrderPackageList
    {
        public string PackageNumber { get; set; }
        public string CustomerCode { get; set; }
        public string OrderNumber { get; set; }
        public System.Guid OrderHeaderID { get; set; }
        public System.Guid OrderLineID { get; set; }
        public string WarehouseCode { get; set; }
        public string UsedBarcode { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ColorCode { get; set; }
        public string ColorDescription { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public double OrderQty1 { get; set; }
        public double PackageQty1 { get; set; }
        public System.DateTime OperationDate { get; set; }
        public Nullable<bool> IsCompleted { get; set; }
        public string Username { get; set; }
        public System.Guid RowID { get; set; }
        public string ShelfPackageNumber { get; set; }
    }
}
