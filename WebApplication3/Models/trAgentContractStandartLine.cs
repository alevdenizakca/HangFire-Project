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
    
    public partial class trAgentContractStandartLine
    {
        public System.Guid AgentContractStandartLineID { get; set; }
        public System.Guid AgentContractHeaderID { get; set; }
        public string ProductGroupLevelCode01 { get; set; }
        public string ProductGroupLevelCode02 { get; set; }
        public string ProductGroupLevelCode03 { get; set; }
        public string ProductGroupLevelCode04 { get; set; }
        public string ProductGroupLevelCode05 { get; set; }
        public double AgentRate { get; set; }
        public double AgentOfficeRate { get; set; }
        public double TourGuideRate { get; set; }
        public double TourDriverRate { get; set; }
        public double TourLeaderRate { get; set; }
        public double TourHelperGuideRate { get; set; }
        public double HotelRate { get; set; }
        public double HotelPersonnelRate { get; set; }
        public double SpecialRate { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual trAgentContractHeader trAgentContractHeader { get; set; }
    }
}
