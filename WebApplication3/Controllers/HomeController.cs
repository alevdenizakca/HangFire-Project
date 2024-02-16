using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using WebApplication3.Helpers;
using WebApplication3.Models;
using WebApplication3.Models.NebimV3;
using WebApplication3.WEBAPIS;
using X.PagedList;
using static WebApplication3.Models.Api.SaleChannelsStatusResult;
using static WebApplication3.Models.ApiReturnTypes.GetAllOrders;
using static WebApplication3.Models.NebimV3.CustomerCard;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        TrendyolApi trendyolApi;
        AppManagement db;
        V3 v3;
        ShipmentContent sContent;
        public string Token { get; set; }
        public string URL { get; set; }

        public HomeController()
        {
            trendyolApi = new TrendyolApi();
            db = new AppManagement();
            v3 = new V3();
            URL= !string.IsNullOrEmpty(ConfigurationManager.AppSettings.Get("NebimApi")) ? ConfigurationManager.AppSettings.Get("NebimApi") : "http://localhost:92";
        }
        public ActionResult Index()
        {
            if (Response.Cookies["selectedOrders"] != null)
            {

                System.Web.HttpCookie Cookie = new System.Web.HttpCookie("selectedOrders");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(DateTime startDate, DateTime endDate)
        {
            var startDateLong = ConvertToUnixTimestamp(startDate);
            var endDateLong = ConvertToUnixTimestamp(endDate);
            ShipmentResponse orders = trendyolApi.getOrdersAll(startDateLong, endDateLong);
            #region yorum
            List<ShipmentContent> azOrders = new List<ShipmentContent>();

            if (orders.Content.Count != 0)
            {
                for (int i = 0; i < orders.TotalPages; i++)
                {
                    var trendyolOrders = trendyolApi.getOrdersAll(startDate: startDateLong, endDate: endDateLong, page: i, size: 200);
                    azOrders.AddRange(trendyolOrders.Content.Where(x => x.InvoiceAddress.CountryCode != "TR").ToList());
                }

                try
                {
                    foreach (ShipmentContent sc in azOrders)
                    {

                        bool orderExists = db.MarketPlaceExportOrderHeader.Any(o => o.OrderNumber == sc.OrderNumber);

                        if (!orderExists)
                        {
                            MarketPlaceExportOrderHeader mpeoh = new MarketPlaceExportOrderHeader
                            {
                                OrderHeaderID = Guid.NewGuid(),
                                OrderDate = ConvertToDateTime(sc.OrderDate),
                                OrderNumber = sc.OrderNumber,
                                ShipmentPackageStatus = sc.ShipmentPackageStatus,
                                OrderStatus = sc.Status,
                                CargoTrackingLink = sc.CargoTrackingLink,
                                CargoTrackingNumber = sc.CargoTrackingNumber.ToString(),
                                CargoSenderNumber = sc.CargoSenderNumber,
                                CargoProviderName = sc.CargoProviderName,
                                CustomerEmail = sc.CustomerEmail,
                                CustomerFirstName = sc.CustomerFirstName,
                                CustomerLastName = sc.CustomerLastName,
                                CustomerPhone = sc.InvoiceAddress.Phone,
                                GrossAmount = Convert.ToDecimal(sc.GrossAmount),
                                Invoiceaddress1 = sc.InvoiceAddress.Address1,
                                Invoiceaddress2 = sc.InvoiceAddress.Address2,
                                InvoiceLink = sc.InvoiceLink,
                                Invoicecity = sc.InvoiceAddress.City,
                                Invoicecompany = sc.InvoiceAddress.Company,
                                InvoicepostalCode = sc.InvoiceAddress.PostalCode,
                                Shipmentaddress1 = sc.ShipmentAddress.Address1,
                                Shipmentaddress2 = sc.ShipmentAddress.Address2,
                                Shipmentcity = sc.ShipmentAddress.City,
                                ShipmentcountryCode = sc.ShipmentAddress.CountryCode,
                                Shipmentdistrict = sc.ShipmentAddress.District,
                                ShipmentfirstName = sc.ShipmentAddress.FirstName,
                                ShipmentlastName = sc.ShipmentAddress.LastName,
                                ShipmentpostalCode = sc.ShipmentAddress.PostalCode,
                                TotalDiscount = Convert.ToDecimal(sc.TotalDiscount),
                                TotalPrice = Convert.ToDecimal(sc.TotalPrice),
                                TotalTyDiscount = Convert.ToDecimal(sc.TotalTyDiscount),
                                InvoicecountryCode = sc.InvoiceAddress.CountryCode,
                                Invoicedistrict = sc.InvoiceAddress.District,
                                InvoicefirstName = sc.InvoiceAddress.FirstName,
                                InvoicelastName = sc.InvoiceAddress.LastName
                            };



                            db.MarketPlaceExportOrderHeader.Add(mpeoh);
                            db.SaveChanges();

                            foreach (var line in sc.Lines)
                            {
                                MarketPlaceExportOrderLine mpeoLine = new MarketPlaceExportOrderLine
                                {
                                    OrderLineID = Guid.NewGuid(),
                                    OrderLineItemStatusName = line.OrderLineItemStatusName,
                                    Barcode = line.Barcode,
                                    ProductCode = line.ProductCode.ToString(),
                                    ProductName = line.ProductName,
                                    ProductColor = line.ProductColor,
                                    ProductSize = line.ProductSize,
                                    Quantity = line.Quantity,
                                    Amount = Convert.ToDecimal(line.Amount),
                                    Discount = Convert.ToDecimal(line.Discount),
                                    TyDiscount = Convert.ToDecimal(line.TyDiscount),
                                    lineItemPrice = Convert.ToDecimal(line.DiscountDetails.Select(x => x.LineItemPrice).FirstOrDefault()),
                                    lineItemDiscount = Convert.ToDecimal(line.DiscountDetails.Select(x => x.LineItemDiscount).FirstOrDefault()),
                                    OrderHeaderID = mpeoh.OrderHeaderID
                                };
                                db.MarketPlaceExportOrderLine.Add(mpeoLine);
                                db.SaveChanges();
                            }

                            MarketPlaceExportOrderPackageHistory mpeopHistory = new MarketPlaceExportOrderPackageHistory
                            {
                                OrderPackageHistoryID = Guid.NewGuid(),
                                CreatedDate = ConvertToDateTime(sc.PackageHistories.Select(x => x.CreatedDate).FirstOrDefault()),
                                Status = mpeoh.ShipmentPackageStatus,
                                OrderHeaderID = mpeoh.OrderHeaderID
                            };
                            db.MarketPlaceExportOrderPackageHistory.Add(mpeopHistory);
                            db.SaveChanges();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Session.Add("Error", "Kayıt işleminde bir sorun meydana geldi. " + ex.Message);
                    throw;
                }

            }
            else
            {
                Session.Add("Error", "Seçilen tarihler arasında bir sipariş bulunamadı");
            }
            #endregion
            Session.Add("shipmentContent", azOrders);
            
            return RedirectToAction("PagedTable");
        }
        public ActionResult PagedTable(int page = 1)
        {
            IPagedList<ShipmentContent> values = null;
            ViewBag.Hata = (string)Session["Error"];
            Session.Remove("Error");
            List<ShipmentContent> shipmentContents = (List<ShipmentContent>)Session["shipmentContent"];
            values = shipmentContents.ToPagedList(page, 10);
            return View(values);
        }
        [HttpPost]
        public ActionResult PagedTable(List<string> selectedOrders,int page = 1)
        {
            ViewBag.Hata = (string)Session["Error"];
            selectedOrders = JsonConvert.DeserializeObject<List<string>>(Request.Cookies["selectedOrders"].Value);

            List<string> results = new List<string>();

            foreach (string orderId in selectedOrders)
            { 
               Meta result = PostNebimExportOrder(orderId);
               results.Add(result.Message);
            }

            IPagedList<ShipmentContent> values = null;
            List<ShipmentContent> shipmentContents = (List<ShipmentContent>)Session["shipmentContent"];
            values = shipmentContents.ToPagedList(page, 10);
            string resultString = string.Join(" ", results);
            ViewBag.Results = resultString;

            return View(values);
        }
        static long ConvertToUnixTimestamp(DateTime dateTime)
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan timeSpan = dateTime.ToUniversalTime() - unixEpoch;
            return (long)timeSpan.TotalMilliseconds;
        }
        static DateTime ConvertToDateTime(long longDate)
        {
            DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime date = start.AddMilliseconds(longDate).ToLocalTime();
            return date;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }




        private string GetToken()
        {
            try
            {
                if (string.IsNullOrEmpty(Token))
                {
                    string responseString = Helpers.StaticFunctions.GET(URL + "/IntegratorService/Connect?");
                    var queryResult = JsonConvert.DeserializeObject<Models.MetaData>(responseString);
                    Token = queryResult.Token;
                }
                else
                {
                    return Token;
                }
            }
            catch
            {
                throw new Exception("ERP'ye bağlanılamadı. Lütfen Parametrelerinizi Gözden Geçiriniz.");
            }
            return Token;
        }
        public Meta PostNebimExportOrder(string orderId)
        {
            Meta meta = new Meta();
            try
            {
                ShipmentResponse shipmentResponse = trendyolApi.getOrdersAll(orderNumber: orderId);
                ShipmentContent shipmentContent = shipmentResponse.Content.FirstOrDefault();

                var parameters = db.NebimParameters.AsNoTracking().FirstOrDefault();
                string token = GetToken();
                RestClient client = new RestClient($"{URL}/IntegratorService/POST/{token}?");
                string numberControl = v3.usp_RGN_ControlExportOrderByDocumentNumber(shipmentContent.Id).FirstOrDefault();

                if (!string.IsNullOrWhiteSpace(numberControl))
                    return new Meta() { Message = "Sipariş zaten nebime gönderilmiş.", StatusCode = 200 };
                else
                {
                    var sqlQuery = "EXEC usp_RGN_GetCityAndDistrictCode @CountryCode, @CityName, @DistrictName";

                    var sqlParameters = new[]
                    {
                                new SqlParameter("@CountryCode", shipmentContent.InvoiceAddress.CountryCode),
                                new SqlParameter("@CityName", shipmentContent.InvoiceAddress.City),
                                new SqlParameter("@DistrictName", shipmentContent.InvoiceAddress.District)
                    };

                    var cityDistrictResponse = v3.Database.SqlQuery<MicroOrderResponse>(sqlQuery, sqlParameters).FirstOrDefault();

                    RestRequest requestCustomerCard = new RestRequest(Method.POST);
                    List<ExportInvoiceOrder.Line> nebimOrderLines = new List<ExportInvoiceOrder.Line>();

                    requestCustomerCard.AddJsonBody(new
                    {
                        ModelType = 2,
                        CurrAccDescription = shipmentContent.CustomerFirstName + " " + shipmentContent.CustomerLastName,
                        FirstName = shipmentContent.CustomerFirstName,
                        LastName = shipmentContent.CustomerLastName,
                        IsIndividualAcc = true,
                        IdentityNum = "22222222222",
                        OfficeCode = parameters.ExportOfficeCode,
                        //CompanyCode = parameters.ExportCompanyCode,
                        TaxNumber = string.Empty,
                        TaxOfficeCode = string.Empty,
                        CurrencyCode = "TRY",
                        CustomerTypeCode = 3,
                        PostalAddresses = new List<CustomerCard.PostalAddress>
                                {
                                    new CustomerCard.PostalAddress
                                    {
                                        AddressTypeCode = "1",
                                        CountryCode = cityDistrictResponse.CountryCode,
                                        StateCode = cityDistrictResponse.StateCode,
                                        CityCode = cityDistrictResponse.CityCode,
                                        DistrictCode = cityDistrictResponse.DistrictCode,
                                        Address = shipmentContent.InvoiceAddress.FullAddress
                                    }
                                }.ToList(),
                        Communications = new[]
                                {
                                    new Communication
                                    {
                                        CommunicationTypeCode = 7,
                                        CommAddress = string.IsNullOrWhiteSpace(shipmentContent.InvoiceAddress.Phone) ? string.Empty : shipmentContent.InvoiceAddress.Phone
                                    },
                                    new Communication
                                    {
                                        CommunicationTypeCode = 3,
                                        CommAddress = string.IsNullOrWhiteSpace(shipmentContent.CustomerEmail) ? string.Empty : shipmentContent.CustomerEmail
                                    }
                                }.ToList(),
                    });
                    //return Ok(requestCustomerCard);
                    IRestResponse response = client.Execute(requestCustomerCard);
                    string responseCustomerCard = response.Content;

                    var metadataControl = JsonConvert.DeserializeObject<Models.MetaData>(responseCustomerCard);



                    if (!string.IsNullOrWhiteSpace(metadataControl.ExceptionMessage))
                    {
                        meta.Message = $"Nebime gönderirken müşteri kartı oluşturma kısmında bir hata oluştu.Hata: {metadataControl.ExceptionMessage}";
                        meta.StatusCode = 400;
                        return meta;
                    }

                    NebimModelTwoResponse jsonCustomerCard = JsonConvert.DeserializeObject<NebimModelTwoResponse>(responseCustomerCard);

                    foreach (var trendyolItem in shipmentContent.Lines)
                    {
                        ExportInvoiceOrder.Line nebimLine = new ExportInvoiceOrder.Line();

                        nebimLine.UsedBarcode = trendyolItem.Barcode;
                        nebimLine.Qty1 = trendyolItem.Quantity;
                        nebimLine.PriceVI = trendyolItem.Price;
                        nebimOrderLines.Add(nebimLine);
                    }

                    RestRequest requestOrders = new RestRequest(Method.POST);
                    requestOrders.AddJsonBody(new
                    {
                        ModelType = 14,
                        CustomerCode = jsonCustomerCard.CurrAccCode,
                        OrderDate = DateTimeOffset.FromUnixTimeMilliseconds(shipmentContent.OrderDate).UtcDateTime.Date,
                        //CompanyCode = parameters.ExportCompanyCode,
                        OfficeCode = parameters.ExportOfficeCode,
                        StoreCode = parameters.ExportStoreCode,
                        WarehouseCode = parameters.ExportWarehouseCode,
                        TaxExemptionCode = "301",
                        OrdererOfficeCode = parameters.ExportOfficeCode,
                        OrdererStoreCode = parameters.ExportStoreCode,
                        ShippingPostalAddressID = jsonCustomerCard.CurrAccDefault.BillingAddressID.ToGuid(),
                        BillingPostalAddressID = jsonCustomerCard.CurrAccDefault.BillingAddressID.ToGuid(),
                        DeliveryCompanyCode = parameters.ExportDeliveryCompanyCode,
                        ShipmentMethodCode = "2",
                        DocumentNumber = shipmentContent.Id,
                        InternalDescription = shipmentContent.CargoTrackingNumber.ToString(),
                        ExportFileNumber = string.Empty,
                        Lines = nebimOrderLines,
                        IsCompleted = true,
                    }); ;

                    IRestResponse responseOR = client.Execute(requestOrders);
                    string responseOrderRequest = responseOR.Content;

                    var metadataOrderControl = JsonConvert.DeserializeObject<Models.MetaData>(responseOrderRequest);

                    if (!string.IsNullOrWhiteSpace(metadataOrderControl.ExceptionMessage))
                    {
                        meta.Message = $"Nebime gönderirken ihracat sipariş kısmında bir hata oluştu.Hata: {metadataOrderControl.ExceptionMessage}";
                        meta.StatusCode = 400;
                        return meta;
                    }

                    meta.StatusCode = 200;
                    meta.Message = "Müşteri kartı ve ihracat siparişler başarıyla nebime aktarıldı";
                    return meta;
                }


            }
            catch (Exception ex)
            {
                meta.Message = $"Sistemsel bir hata meydana geldi.Hata: {ex.Message + " " + ex.InnerException}";
                meta.StatusCode = 500;
                return meta;
            }
        }
        public class NebimModelTwoResponse
        {
            public string CurrAccCode { get; set; }
            public CurrAccDefault CurrAccDefault { get; set; }
        }
        public class CurrAccDefault
        {
            public string BillingAddressID { get; set; }
        }
        public class MicroOrderResponse
        {
            public string CountryCode { get; set; }
            public string StateCode { get; set; }
            public string CityCode { get; set; }
            public string DistrictCode { get; set; }
        }
    }
}