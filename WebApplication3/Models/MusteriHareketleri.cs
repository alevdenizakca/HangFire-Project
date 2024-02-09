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
    
    public partial class MusteriHareketleri
    {
        public System.Guid CurrAccBookID { get; set; }
        public int Sırası { get; set; }
        public Nullable<byte> Cari_Hesap_Tipi { get; set; }
        public string Cari_Hesap_Tipi_Açıklaması { get; set; }
        public string Cari_Hesap_Kodu { get; set; }
        public string Cari_Hesap_Açıklaması { get; set; }
        public Nullable<System.Guid> SubCurrAccID { get; set; }
        public string Alt_Hesap_Adı { get; set; }
        public string Alt_Hesap_Kodu { get; set; }
        public Nullable<System.Guid> ContactID { get; set; }
        public System.DateTime Belge_Tarihi { get; set; }
        public System.TimeSpan Dökuman_Saati { get; set; }
        public string Belge_Numarası { get; set; }
        public System.DateTime Vade_Tarihi { get; set; }
        public string Satır_Açıklaması { get; set; }
        public string Açıklama { get; set; }
        public string Dahili_Açıklama { get; set; }
        public string Belge_Ref__Numarası { get; set; }
        public decimal Şirket_Kodu { get; set; }
        public string Ofis { get; set; }
        public byte Mağaza_Cari_Tipi { get; set; }
        public string Mağaza_Kodu { get; set; }
        public string Yerel_Para_Birimi { get; set; }
        public string Döküman_Para_Birimi { get; set; }
        public string Uygulama_Kodu { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public Nullable<System.Guid> ReturnApplicationID { get; set; }
        public string Kaynak_Uygulama_Kodu { get; set; }
        public Nullable<System.Guid> BaseApplicationID { get; set; }
        public byte Borç_Tipi { get; set; }
        public byte Banka_Hareketi_Tipi { get; set; }
        public byte Kasa_Fiş_Tipi { get; set; }
        public byte Kredi_Kartı_Ödeme_Tipi { get; set; }
        public byte Hediye_Kartı_Ödeme_Tipi { get; set; }
        public byte Ç_S_İşlem_Tipi { get; set; }
        public string İthalat_Dosya_Numarası { get; set; }
        public string İhracat_Dosya_Numarası { get; set; }
        public string Oluşturan_Kullanıcı { get; set; }
        public System.DateTime Oluşturulma_Tarihi { get; set; }
        public string Son_Güncelleyen_Kullanıcı { get; set; }
        public System.DateTime Son_Güncelleme_Tarihi { get; set; }
        public decimal PolicyCompanyCode { get; set; }
        public string PolicyOfficeCode { get; set; }
        public string PolicyStoreCode { get; set; }
        public string Para_Birimi__D_ { get; set; }
        public decimal Borç__D_ { get; set; }
        public decimal Alacak__D_ { get; set; }
        public string Para_Birimi__Y_ { get; set; }
        public double Döviz_Kuru__Y_ { get; set; }
        public decimal Borç__Y_ { get; set; }
        public decimal Alacak__Y_ { get; set; }
        public string ATAtt01 { get; set; }
        public string ATAtt01Desc { get; set; }
    }
}
