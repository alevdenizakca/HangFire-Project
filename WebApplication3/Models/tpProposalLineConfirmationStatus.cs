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
    
    public partial class tpProposalLineConfirmationStatus
    {
        public System.Guid ProposalLineID { get; set; }
        public byte ConfirmationStatusCode { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
        public bool RevisionRequested { get; set; }
    
        public virtual bsConfirmationStatus bsConfirmationStatus { get; set; }
        public virtual trProposalLine trProposalLine { get; set; }
    }
}
