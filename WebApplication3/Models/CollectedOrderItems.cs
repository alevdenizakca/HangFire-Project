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
    
    public partial class CollectedOrderItems
    {
        public System.Guid RowID { get; set; }
        public System.Guid OrderHeaderID { get; set; }
        public System.Guid OrderLineID { get; set; }
        public double OrderQty { get; set; }
        public double PickingQty { get; set; }
        public byte CollectedStatus { get; set; }
        public string LocationCode { get; set; }
    }
}