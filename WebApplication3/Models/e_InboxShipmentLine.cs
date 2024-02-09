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
    
    public partial class e_InboxShipmentLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public e_InboxShipmentLine()
        {
            this.e_InboxShipmentLineV3Items = new HashSet<e_InboxShipmentLineV3Items>();
        }
    
        public System.Guid InboxShipmentLineID { get; set; }
        public System.Guid UUID { get; set; }
        public int LineID { get; set; }
        public string UnitCode { get; set; }
        public double Qty { get; set; }
        public string ItemName { get; set; }
        public string SellersItemIdentificationID { get; set; }
        public string CompanyBarcode { get; set; }
        public string CurrencyCode { get; set; }
        public decimal Price { get; set; }
        public string BuyersItemIdentificationID { get; set; }
        public string ManufacturersItemIdentificationID { get; set; }
    
        public virtual e_InboxShipmentHeader e_InboxShipmentHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<e_InboxShipmentLineV3Items> e_InboxShipmentLineV3Items { get; set; }
    }
}