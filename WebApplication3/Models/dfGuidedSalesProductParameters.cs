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
    
    public partial class dfGuidedSalesProductParameters
    {
        public System.Guid GuidedSalesProductParametersID { get; set; }
        public string ProductSearchLevel01 { get; set; }
        public string ProductSearchLevel02 { get; set; }
        public string ProductSearchLevel03 { get; set; }
        public string ProductSearchLevel04 { get; set; }
        public string ProductSearchLevel05 { get; set; }
        public string BarcodeTypeCode { get; set; }
        public string FirstSalePriceGroupCode { get; set; }
        public string AlternativeProductItemLikeTypeCode { get; set; }
        public string CombinedProductItemLikeTypeCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public Nullable<bool> ShowProductInformation { get; set; }
        public Nullable<bool> CanEditProductInformation { get; set; }
        public Nullable<bool> CanAddProductInformation { get; set; }
        public string ProductRecommendationFilterStringSQL { get; set; }
    }
}