using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ReportQuery
    {
        public int Id { get; set; }
        public string QueryName { get; set; }
        public string QueryText { get; set; }
        public string DefaultReportPath { get; set; }
        public bool IsBlocked { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }

        public virtual List<ReportParameter> ReportParameters { get; set; } = new List<ReportParameter>();
    }
}