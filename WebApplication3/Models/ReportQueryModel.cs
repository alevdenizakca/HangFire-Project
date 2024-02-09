using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class ReportQueryModel
    {
        public string Query { get; set; }
        public List<ParameterModel> Parameters { get; set; }
    }
}