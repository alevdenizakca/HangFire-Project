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
    
    public partial class TemelFiyatlar
    {
        public byte Madde_Tipi { get; set; }
        public string Madde_Kodu { get; set; }
        public string Ülke_Kodu { get; set; }
        public string Sezon_Kodu { get; set; }
        public string Maliyet_Fiyatı_Para_Birimi { get; set; }
        public Nullable<decimal> Maliyet_Birim_Fiyatı { get; set; }
        public string Satın_Alma_Fiyatı_Para_Birimi { get; set; }
        public Nullable<decimal> Satın_Alma_Fiyatı { get; set; }
        public string Satış_Fiyatı_Para_Birimi { get; set; }
        public Nullable<decimal> Satış_Fiyatı { get; set; }
        public string İlk_Satış_Fiyatı_Para_Birimi { get; set; }
        public Nullable<decimal> İlk_Satış_Fiyatı { get; set; }
        public string Hedef_Alım_Fiyatı_Para_Birimi { get; set; }
        public Nullable<decimal> Hedef_Alım_Fiyatı { get; set; }
        public string Hedef_Satış_Fiyatı_Para_Birimi { get; set; }
        public Nullable<decimal> Hedef_Satış_Fiyatı { get; set; }
        public string Perakende_Satış_Fiyatı_Para_Birimi { get; set; }
        public Nullable<decimal> Perakende_Satış_Fiyatı { get; set; }
        public string Perakende_Taksitli_Satış_Fiyatı_Para_Birimi { get; set; }
        public Nullable<decimal> Perakende_Taksitli_Satış_Fiyatı { get; set; }
    }
}
