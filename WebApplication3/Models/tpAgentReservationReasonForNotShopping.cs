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
    
    public partial class tpAgentReservationReasonForNotShopping
    {
        public System.Guid AgentReservationReasonForNotShoppingID { get; set; }
        public System.Guid AgentReservationHeaderID { get; set; }
        public int SortOrder { get; set; }
        public string ReasonForNotShoppingCode { get; set; }
        public string Description { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual cdReasonForNotShopping cdReasonForNotShopping { get; set; }
        public virtual trAgentReservationHeader trAgentReservationHeader { get; set; }
    }
}