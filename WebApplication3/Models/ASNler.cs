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
    
    public partial class ASNler
    {
        public System.Guid OrderAsnHeaderID { get; set; }
        public byte Stok_Hareket_Şekli { get; set; }
        public string Süreç_Kodu { get; set; }
        public string Süreç_Açıklaması { get; set; }
        public string Asn_Ref__Numarası { get; set; }
        public bool İade { get; set; }
        public System.DateTime Asn_Tarihi { get; set; }
        public System.TimeSpan Asn_Fişi_Saati { get; set; }
        public string Açıklama { get; set; }
        public string Sevkiyat_Yöntemi_Kodu { get; set; }
        public string Kargo_Şirketi_Kodu { get; set; }
        public string Gemi_Adı { get; set; }
        public string Boşaltım_Limanı_Kodu { get; set; }
        public string Boşaltım_Limanı { get; set; }
        public string Incoterm_Kodu__1_ { get; set; }
        public string Incoterm_Kodu__2_ { get; set; }
        public string Akreditif_No { get; set; }
        public string Fatura_Ref__Numarası { get; set; }
        public System.DateTime Yükleme_Tarihi { get; set; }
        public string Yükleme_Limanı_Kodu { get; set; }
        public string Yükleme_Limanı { get; set; }
        public string Konşimento_Numarası { get; set; }
        public int Toplam_Paket_Sayısı { get; set; }
        public string Konteyner_Numarası { get; set; }
        public string Konteyner_Tipi { get; set; }
        public string Çıkış_Ülkesi__Vergiye_Tabi_Ülke_ { get; set; }
        public double Brüt_Ağırlık { get; set; }
        public double Net_Ağırlık { get; set; }
        public double Toplam_Hacim__CBM_ { get; set; }
        public double Ücrete_Tabi_Ağırlık__CHW_ { get; set; }
        public System.DateTime Tahmini_Varış_Tarihi { get; set; }
        public System.DateTime Fiili_Varış_Tarihi { get; set; }
        public System.DateTime Millileştirme_Tarihi { get; set; }
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
        public string Depo_Kodu { get; set; }
        public string İthalat_Dosya_Numarası { get; set; }
        public bool Tamamlandı { get; set; }
        public bool Formdan_Dökümü_Yazdırıldı { get; set; }
        public bool Değişikliklere_Kilitlenmiş { get; set; }
        public bool Transfer_Onaylanmış { get; set; }
        public bool Onaylandı { get; set; }
        public string Uygulama_Kodu { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public string Oluşturan_Kullanıcı { get; set; }
        public System.DateTime Oluşturulma_Tarihi { get; set; }
        public string Son_Güncelleyen_Kullanıcı { get; set; }
        public System.DateTime Son_Güncelleme_Tarihi { get; set; }
        public byte Mağaza_Cari_Tipi { get; set; }
        public string Mağaza_Kodu { get; set; }
        public System.Guid OrderAsnLineID { get; set; }
        public int Sırası { get; set; }
        public byte Madde_Tipi { get; set; }
        public string Madde_Kodu { get; set; }
        public string Madde_Açıklaması { get; set; }
        public string Renk_Kodu { get; set; }
        public string Renk_Açıklaması { get; set; }
        public string ItemDim1Code { get; set; }
        public string ItemDim2Code { get; set; }
        public string ItemDim3Code { get; set; }
        public double Miktar { get; set; }
        public double Miktar__2_ { get; set; }
        public string Satır_Açıklaması { get; set; }
        public string Barkod { get; set; }
        public string Paket_Ref__Numarası { get; set; }
        public string Uzunluk_Ölçü_Birimi { get; set; }
        public float Paketlenmiş_Eni { get; set; }
        public float Paketlenmiş_Boyu { get; set; }
        public float Paketlenmiş_Yüksekliği { get; set; }
        public string Ağırlık_Ölçü_Birimi { get; set; }
        public float Paketlenmiş_Ağırlığı { get; set; }
        public System.Guid Satır_Sıra_ID { get; set; }
        public int OrderAsnLineSumID { get; set; }
        public Nullable<System.DateTime> Sipariş_Teslim_Tarihi { get; set; }
        public string DefBarkod { get; set; }
        public Nullable<double> KDV_Hariç_Tutar { get; set; }
        public Nullable<double> KDV_Dahil_Tutar { get; set; }
    }
}