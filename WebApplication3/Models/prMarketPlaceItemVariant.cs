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
    
    public partial class prMarketPlaceItemVariant
    {
        public string MarketPlaceCode { get; set; }
        public byte ItemTypeCode { get; set; }
        public string ItemCode { get; set; }
        public string ColorCode { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public string MarketPlaceItemVariantID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public System.Guid RowGuid { get; set; }
    
        public virtual bsMarketPlace bsMarketPlace { get; set; }
        public virtual prItemVariant prItemVariant { get; set; }
    }
}
