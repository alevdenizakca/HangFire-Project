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
    
    public partial class SatisFiyatListesi
    {
        public System.Guid PriceListHeaderID { get; set; }
        public string Fiyat_Listesi_Ref__Numarası { get; set; }
        public System.DateTime Fiyat_Listesi_Tarihi { get; set; }
        public System.TimeSpan Fiyat_Listesi_Saati { get; set; }
        public string Fiyat_Listesi_Tipi { get; set; }
        public string Açıklama { get; set; }
        public bool Tutarlara_Vergi_Dahildir { get; set; }
        public bool Tamamlandı { get; set; }
        public bool Formdan_Dökümü_Yazdırıldı { get; set; }
        public bool Değişikliklere_Kilitlenmiş { get; set; }
        public bool Onaylandı { get; set; }
        public string Onaylayan_Kullanıcı { get; set; }
        public System.DateTime Onaylanan_Tarih { get; set; }
        public string Uygulama_Kodu { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string Oluşturan_Kullanıcı { get; set; }
        public System.DateTime Oluşturulma_Tarihi { get; set; }
        public string Son_Güncelleyen_Kullanıcı { get; set; }
        public System.DateTime Son_Güncelleme_Tarihi { get; set; }
        public System.Guid PriceListLineID { get; set; }
        public int Sırası { get; set; }
        public byte Madde_Tipi { get; set; }
        public string Madde_Kodu { get; set; }
        public string Madde_Açıklaması { get; set; }
        public string Renk_Kodu { get; set; }
        public string Renk_Açıklaması { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public string Birim_Cinsi { get; set; }
        public string Ödeme_Planı { get; set; }
        public string Satır_Açıklaması { get; set; }
        public string Döküman_Para_Birimi { get; set; }
        public decimal Fiyat { get; set; }
        public byte Geçersiz_Kalsın { get; set; }
        public System.DateTime DisableDate { get; set; }
        public decimal Şirket_Kodu { get; set; }
        public string Satış_Fiyat_Grubu { get; set; }
        public System.DateTime Geçerlilik_Tarihi { get; set; }
        public System.TimeSpan İlk_Geçerlilik_Saati { get; set; }
    }
}