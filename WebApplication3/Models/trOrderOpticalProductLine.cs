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
    
    public partial class trOrderOpticalProductLine
    {
        public System.Guid OrderOpticalProductLineID { get; set; }
        public System.Guid OrderOpticalProductID { get; set; }
        public System.Guid OrderLineID { get; set; }
        public string LeftRightFrame { get; set; }
        public string DistanceReading { get; set; }
        public string Sphere { get; set; }
        public string Cylinder { get; set; }
        public double Axis { get; set; }
        public double Prism { get; set; }
        public double EffectiveDiameter { get; set; }
        public double PupillaryDistance { get; set; }
        public double SegmentHeight { get; set; }
        public double BaseCurveRadius { get; set; }
        public double Addition { get; set; }
        public bool UsePolished { get; set; }
        public bool IsLocked { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ContributionAmount { get; set; }
        public double ExchangeRate { get; set; }
        public string ProtocolNumber { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string OpticalSutCode { get; set; }
    
        public virtual cdOpticalSut cdOpticalSut { get; set; }
        public virtual trOrderLine trOrderLine { get; set; }
        public virtual trOrderOpticalProduct trOrderOpticalProduct { get; set; }
    }
}