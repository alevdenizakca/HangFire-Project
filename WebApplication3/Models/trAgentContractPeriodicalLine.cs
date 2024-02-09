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
    
    public partial class trAgentContractPeriodicalLine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public trAgentContractPeriodicalLine()
        {
            this.trAgentReservationHeader = new HashSet<trAgentReservationHeader>();
        }
    
        public System.Guid AgentContractPeriodicalLineID { get; set; }
        public System.Guid AgentContractHeaderID { get; set; }
        public string PeriodDescription { get; set; }
        public string TypeDescription { get; set; }
        public string LineDescription { get; set; }
        public string CurrencyCode { get; set; }
        public byte ExchangeTypeCode { get; set; }
        public decimal Amount { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdCurrency cdCurrency { get; set; }
        public virtual cdExchangeType cdExchangeType { get; set; }
        public virtual trAgentContractHeader trAgentContractHeader { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<trAgentReservationHeader> trAgentReservationHeader { get; set; }
    }
}
