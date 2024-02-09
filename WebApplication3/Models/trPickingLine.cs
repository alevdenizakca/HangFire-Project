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
    
    public partial class trPickingLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trPickingLine()
        {
            this.stItemRollNumberPicking = new HashSet<stItemRollNumberPicking>();
            this.trInvoiceLine = new HashSet<trInvoiceLine>();
            this.trShipmentLine = new HashSet<trShipmentLine>();
        }
    
        public System.Guid PickingLineID { get; set; }
        public int SortOrder { get; set; }
        public double Qty1 { get; set; }
        public double Qty2 { get; set; }
        public string LineDescription { get; set; }
        public string UsedBarcode { get; set; }
        public string SerialNumber { get; set; }
        public string BatchCode { get; set; }
        public System.Guid OrderLineID { get; set; }
        public Nullable<System.Guid> ReserveLineID { get; set; }
        public Nullable<System.Guid> DispOrderLineID { get; set; }
        public System.Guid PickingHeaderID { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public string SectionCode { get; set; }
        public Nullable<System.DateTime> OrderDeliveryDate { get; set; }
    
        public virtual cdBatch cdBatch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stItemRollNumberPicking> stItemRollNumberPicking { get; set; }
        public virtual trDispOrderLine trDispOrderLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trInvoiceLine> trInvoiceLine { get; set; }
        public virtual trOrderLine trOrderLine { get; set; }
        public virtual trPickingHeader trPickingHeader { get; set; }
        public virtual trReserveLine trReserveLine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trShipmentLine> trShipmentLine { get; set; }
    }
}