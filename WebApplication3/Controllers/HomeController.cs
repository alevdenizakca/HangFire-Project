using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static WebApplication3.Models.ApiReturnTypes.GetAllOrders;
using WebApplication3.Models;
using WebApplication3.WEBAPIS;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        TrendyolApi trendyolApi = new TrendyolApi();
        AppManagement db;
        V3 v3;
        ShipmentContent sContent;
        public ActionResult Index()
        {
            DateTime now = DateTime.Now;
            DateTime sevenYears = DateTime.Now.AddMonths(-2);
            var nowlong = ConvertToUnixTimestamp(now);
            var sevenlong = ConvertToUnixTimestamp(sevenYears);

            ShipmentResponse orders = trendyolApi.getOrdersAll(sevenlong, nowlong);
            #region yorum
            List<ShipmentContent> azOrders = new List<ShipmentContent>();
            if (orders != null)
            {
                for (int i = 0; i < orders.TotalPages; i++)
                {
                    //var trendyolOrders = trendyolApi.getOrdersAll(startDate: dateS, endDate: dateE, page: i, size: 200);
                    //azOrders.AddRange(trendyolOrders.Content.Where(x => x.InvoiceAddress.CountryCode != "TR").ToList());
                }

                //    gridControl1.DataSource = azOrders;

                //    try
                //    {
                //        foreach (ShipmentContent sc in azOrders)
                //        {

                //            bool orderExists = db.MarketPlaceExportOrderHeader.Any(o => o.OrderNumber == sc.OrderNumber);

                //            if (!orderExists)
                //            {
                //                MarketPlaceExportOrderHeader mpeoh = new MarketPlaceExportOrderHeader
                //                {
                //                    OrderHeaderID = Guid.NewGuid(),
                //                    OrderDate = ConvertToDateTime(sc.OrderDate),
                //                    OrderNumber = sc.OrderNumber,
                //                    ShipmentPackageStatus = sc.ShipmentPackageStatus,
                //                    OrderStatus = sc.Status,
                //                    CargoTrackingLink = sc.CargoTrackingLink,
                //                    CargoTrackingNumber = sc.CargoTrackingNumber.ToString(),
                //                    CargoSenderNumber = sc.CargoSenderNumber,
                //                    CargoProviderName = sc.CargoProviderName,
                //                    CustomerEmail = sc.CustomerEmail,
                //                    CustomerFirstName = sc.CustomerFirstName,
                //                    CustomerLastName = sc.CustomerLastName,
                //                    CustomerPhone = sc.InvoiceAddress.Phone,
                //                    GrossAmount = Convert.ToDecimal(sc.GrossAmount),
                //                    Invoiceaddress1 = sc.InvoiceAddress.Address1,
                //                    Invoiceaddress2 = sc.InvoiceAddress.Address2,
                //                    InvoiceLink = sc.InvoiceLink,
                //                    Invoicecity = sc.InvoiceAddress.City,
                //                    Invoicecompany = sc.InvoiceAddress.Company,
                //                    InvoicepostalCode = sc.InvoiceAddress.PostalCode,
                //                    Shipmentaddress1 = sc.ShipmentAddress.Address1,
                //                    Shipmentaddress2 = sc.ShipmentAddress.Address2,
                //                    Shipmentcity = sc.ShipmentAddress.City,
                //                    ShipmentcountryCode = sc.ShipmentAddress.CountryCode,
                //                    Shipmentdistrict = sc.ShipmentAddress.District,
                //                    ShipmentfirstName = sc.ShipmentAddress.FirstName,
                //                    ShipmentlastName = sc.ShipmentAddress.LastName,
                //                    ShipmentpostalCode = sc.ShipmentAddress.PostalCode,
                //                    TotalDiscount = Convert.ToDecimal(sc.TotalDiscount),
                //                    TotalPrice = Convert.ToDecimal(sc.TotalPrice),
                //                    TotalTyDiscount = Convert.ToDecimal(sc.TotalTyDiscount),
                //                    InvoicecountryCode = sc.InvoiceAddress.CountryCode,
                //                    Invoicedistrict = sc.InvoiceAddress.District,
                //                    InvoicefirstName = sc.InvoiceAddress.FirstName,
                //                    InvoicelastName = sc.InvoiceAddress.LastName
                //                };



                //                db.MarketPlaceExportOrderHeader.Add(mpeoh);
                //                db.SaveChanges();

                //                foreach (var line in sc.Lines)
                //                {
                //                    MarketPlaceExportOrderLine mpeoLine = new MarketPlaceExportOrderLine
                //                    {
                //                        OrderLineID = Guid.NewGuid(),
                //                        OrderLineItemStatusName = line.OrderLineItemStatusName,
                //                        Barcode = line.Barcode,
                //                        ProductCode = line.ProductCode.ToString(),
                //                        ProductName = line.ProductName,
                //                        ProductColor = line.ProductColor,
                //                        ProductSize = line.ProductSize,
                //                        Quantity = line.Quantity,
                //                        Amount = Convert.ToDecimal(line.Amount),
                //                        Discount = Convert.ToDecimal(line.Discount),
                //                        TyDiscount = Convert.ToDecimal(line.TyDiscount),
                //                        lineItemPrice = Convert.ToDecimal(line.DiscountDetails.Select(x => x.LineItemPrice).FirstOrDefault()),
                //                        lineItemDiscount = Convert.ToDecimal(line.DiscountDetails.Select(x => x.LineItemDiscount).FirstOrDefault()),
                //                        OrderHeaderID = mpeoh.OrderHeaderID
                //                    };
                //                    db.MarketPlaceExportOrderLine.Add(mpeoLine);
                //                    db.SaveChanges();
                //                }

                //                MarketPlaceExportOrderPackageHistory mpeopHistory = new MarketPlaceExportOrderPackageHistory
                //                {
                //                    OrderPackageHistoryID = Guid.NewGuid(),
                //                    CreatedDate = ConvertToDateTime(sc.PackageHistories.Select(x => x.CreatedDate).FirstOrDefault()),
                //                    Status = mpeoh.ShipmentPackageStatus,
                //                    OrderHeaderID = mpeoh.OrderHeaderID
                //                };
                //                db.MarketPlaceExportOrderPackageHistory.Add(mpeopHistory);
                //                db.SaveChanges();
                //            }
                //        }
                //    }
                //    catch (Exception ex)
                //    {
                //        XtraMessageBox.Show("Kayıt işleminde bir sorun meydana geldi.", "Hata");
                //        throw;
                //    }
                //    FormShowHelper.hideLoading();
                //}
                //else
                //{
                //    FormShowHelper.hideLoading();
                //    XtraMessageBox.Show("Seçilen tarihler arasında bir sipariş bulunamadı", "Uyarı");
            }
            #endregion
            return View();
        }

        static long ConvertToUnixTimestamp(DateTime dateTime)
        {
            DateTime unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            TimeSpan timeSpan = dateTime.ToUniversalTime() - unixEpoch;
            return (long)timeSpan.TotalMilliseconds;
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
    }
}