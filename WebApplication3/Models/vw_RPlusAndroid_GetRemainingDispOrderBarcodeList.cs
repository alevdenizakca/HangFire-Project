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
    
    public partial class vw_RPlusAndroid_GetRemainingDispOrderBarcodeList
    {
        public string CustomerCode { get; set; }
        public string ProcessCode { get; set; }
        public string DispOrderNumber { get; set; }
        public System.Guid DispOrderLineID { get; set; }
        public string UsedBarcode { get; set; }
        public double RemainingOrderQty { get; set; }
    }
}
