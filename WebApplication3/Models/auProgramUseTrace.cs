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
    
    public partial class auProgramUseTrace
    {
        public System.Guid ProgramUseTraceID { get; set; }
        public string UserGroupCode { get; set; }
        public string UserName { get; set; }
        public string ApplicationName { get; set; }
        public string ParentProgramName { get; set; }
        public string ProgramName { get; set; }
        public string ParentFormName { get; set; }
        public string FormName { get; set; }
        public string MenuName { get; set; }
        public string SubMenuName { get; set; }
        public string ParentFormCaption { get; set; }
        public string FormCaption { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public bool IsDialog { get; set; }
    }
}
