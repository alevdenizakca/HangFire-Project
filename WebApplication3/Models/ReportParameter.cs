using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ReportParameter
    {
        public int Id { get; set; }
        public int ReportQueryId { get; set; }
        public string ParameterKey { get; set; }
        public string ParameterType { get; set; }
        public string ParameterValue { get; set; }
    }
}