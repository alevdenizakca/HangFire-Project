using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.WEBAPIS.TrendyolSiparis
{
    public class Cargo
    {
        public string cargoProvider { get; set; }

        public Cargo(string cargoProvider)
        {
            this.cargoProvider = cargoProvider;
        }
    }
}