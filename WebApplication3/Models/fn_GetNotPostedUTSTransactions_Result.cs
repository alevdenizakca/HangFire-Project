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
    
    public partial class fn_GetNotPostedUTSTransactions_Result
    {
        public string BildirimTuru { get; set; }
        public Nullable<byte> CurrAccTypeCode { get; set; }
        public string CurrAccCode { get; set; }
        public string CurrAccDescription { get; set; }
        public string FisTipi { get; set; }
        public string FisTipiAciklamasi { get; set; }
        public string RefNumber { get; set; }
        public Nullable<long> GonderenKurumKodu { get; set; }
        public string GonderenKurumAciklamasi { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ColorCode { get; set; }
        public string Barcode { get; set; }
        public string SerialNumber { get; set; }
        public string PartyCode { get; set; }
        public Nullable<long> KurumNo { get; set; }
        public string BelgeNo { get; set; }
        public string GumrukBeyannameNo { get; set; }
        public string Gerekce { get; set; }
        public string GerekceAciklamasi { get; set; }
        public string KareBarkod { get; set; }
        public Nullable<System.DateTime> UretimTarihi { get; set; }
        public string IthalEdildigiUlke { get; set; }
        public string MenseiUlke { get; set; }
        public Nullable<System.DateTime> GercekIslemTarihi { get; set; }
        public Nullable<long> MeslekKodu { get; set; }
        public Nullable<long> OdaKodu { get; set; }
        public string ApplicationCode { get; set; }
        public Nullable<System.Guid> ApplicationID { get; set; }
        public Nullable<System.Guid> ApplicationLineID { get; set; }
        public Nullable<System.Guid> StockID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UTSToken { get; set; }
    }
}