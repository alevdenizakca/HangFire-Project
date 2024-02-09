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
    
    public partial class e_InboxShipmentResponseHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public e_InboxShipmentResponseHeader()
        {
            this.e_InboxShipmentResponseLine = new HashSet<e_InboxShipmentResponseLine>();
        }
    
        public decimal CompanyCode { get; set; }
        public System.Guid UUID { get; set; }
        public string ID { get; set; }
        public string CopyIndicator { get; set; }
        public string ProfileID { get; set; }
        public System.DateTime IssueDate { get; set; }
        public System.DateTime IssueTime { get; set; }
        public string ReceiptAdviceTypeCode { get; set; }
        public string Note { get; set; }
        public System.Guid DespatchDocumentReferenceID { get; set; }
        public System.DateTime DespatchDocumentReferenceIssueDate { get; set; }
        public byte InboxShipmentStatusCode { get; set; }
    
        public virtual e_InboxShipmentResponseDeliveryCustomerParty e_InboxShipmentResponseDeliveryCustomerParty { get; set; }
        public virtual e_InboxShipmentResponseDespatchSupplierParty e_InboxShipmentResponseDespatchSupplierParty { get; set; }
        public virtual e_InboxShipmentStatus e_InboxShipmentStatus { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<e_InboxShipmentResponseLine> e_InboxShipmentResponseLine { get; set; }
    }
}