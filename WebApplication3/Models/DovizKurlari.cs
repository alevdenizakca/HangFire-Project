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
    
    public partial class DovizKurlari
    {
        public string Para_Birimi { get; set; }
        public string İlişkili_Para_Birimi { get; set; }
        public System.DateTime Kur_Tarihi { get; set; }
        public double Döviz_Kuru { get; set; }
        public byte Kur_Tipi { get; set; }
        public string Kur_Tipi_Açıklaması { get; set; }
    }
}
