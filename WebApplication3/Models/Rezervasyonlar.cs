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
    
    public partial class Rezervasyonlar
    {
        public System.Guid ReserveHeaderID { get; set; }
        public byte Rezerve_Tipi { get; set; }
        public string Süreç_Kodu { get; set; }
        public string Süreç_Açıklaması { get; set; }
        public string Rezerve_Fişi_Ref__Numarası { get; set; }
        public bool İade { get; set; }
        public System.DateTime Rezerve_Fişi_Tarihi { get; set; }
        public System.TimeSpan Rezerve_Fişi_Saati { get; set; }
        public string Açıklama { get; set; }
        public string Dahili_Açıklama { get; set; }
        public byte Cari_Hesap_Tipi { get; set; }
        public string Cari_Hesap_Tipi_Açıklaması { get; set; }
        public string Cari_Hesap_Kodu { get; set; }
        public string Cari_Hesap_Açıklaması { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public string Alt_Hesap_Adı { get; set; }
        public string Alt_Hesap_Kodu { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public decimal Şirket_Kodu { get; set; }
        public string Ofis { get; set; }
        public byte Mağaza_Cari_Tipi { get; set; }
        public string Mağaza_Kodu { get; set; }
        public string Depo_Kodu { get; set; }
        public string Karşı_Depo_Kodu { get; set; }
        public bool Tamamlandı { get; set; }
        public bool Formdan_Dökümü_Yazdırıldı { get; set; }
        public bool Değişikliklere_Kilitlenmiş { get; set; }
        public string Uygulama_Kodu { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string Oluşturan_Kullanıcı { get; set; }
        public System.DateTime Oluşturulma_Tarihi { get; set; }
        public string Son_Güncelleyen_Kullanıcı { get; set; }
        public System.DateTime Son_Güncelleme_Tarihi { get; set; }
        public System.Guid ReserveLineID { get; set; }
        public int Sırası { get; set; }
        public double Miktar { get; set; }
        public double Miktar__2_ { get; set; }
        public double Giren_Miktar { get; set; }
        public string Satır_Açıklaması { get; set; }
        public string Barkod { get; set; }
        public System.Guid Satır_Sıra_ID { get; set; }
        public Nullable<System.Guid> PurchaseOrderLineID { get; set; }
        public Nullable<System.DateTime> Sipariş_Teslim_Tarihi { get; set; }
        public byte Madde_Tipi { get; set; }
        public string Madde_Kodu { get; set; }
        public string Madde_Açıklaması { get; set; }
        public string Renk_Kodu { get; set; }
        public string Renk_Açıklaması { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public double Sipariş_Miktarı { get; set; }
        public double Sipariş_Miktarı__2_ { get; set; }
        public string Sipariş_Ref__Numarası { get; set; }
        public System.DateTime Sipariş_Tarihi { get; set; }
        public System.DateTime Teslim_Tarihi { get; set; }
        public System.DateTime Planlanan_Yükleme_Tarihi { get; set; }
        public string İthalat_Dosya_Numarası { get; set; }
        public string İhracat_Dosya_Numarası { get; set; }
        public string DefBarkod { get; set; }
        public Nullable<double> KDV_Hariç_Tutar { get; set; }
        public Nullable<double> KDV_Dahil_Tutar { get; set; }
    }
}