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
    
    public partial class OrderDeliveryStatus_Result
    {
        public System.Guid OrderLineID { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public double DeliveryQty1 { get; set; }
        public double RemainingQty1 { get; set; }
    }
}