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
    
    public partial class tpInStockDeclarationInfo
    {
        public System.Guid InStockDeclarationInfoID { get; set; }
        public System.Guid InStockID { get; set; }
        public System.DateTime DeclarationDate { get; set; }
        public string DeclarationNumber { get; set; }
        public int DeclarationLineNumber { get; set; }
        public double Qty { get; set; }
        public string CreatedUserName { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string LastUpdatedUserName { get; set; }
        public System.DateTime LastUpdatedDate { get; set; }
    
        public virtual trStock trStock { get; set; }
    }
}