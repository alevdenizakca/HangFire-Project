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
    
    public partial class Roundsman
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Roundsman()
        {
            this.DeliveryTransactionHeader = new HashSet<DeliveryTransactionHeader>();
        }
    
        public string RoundsmanCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FirstLastName { get; set; }
        public string VehiclePlateNum { get; set; }
        public bool IsBlocked { get; set; }
        public System.Guid RowID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliveryTransactionHeader> DeliveryTransactionHeader { get; set; }
    }
}
