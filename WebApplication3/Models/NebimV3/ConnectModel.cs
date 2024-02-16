using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.NebimV3
{
    public class ConnectModel
    {
        public string DatabaseName { get; set; }
        public string UserGroupCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}