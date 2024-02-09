using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Razor.Tokenizer;
using WebApplication3.Helpers;
using WebApplication3.Models;

namespace WebApplication3.WEBAPIS
{
    public class TrendyolApi
    {
        public static AppManagement appManager = new AppManagement();
        public enum dateQueries
        {
            CREATED_DATE,
            LAST_MODIFIED_DATE
        }

        public enum orderByFields
        {
            None,
            PackageLastModifiedDate,
            CreatedDate
        }

        public enum orderByDirections
        {
            NONE,
            ASC,
            DESC
        }

        public enum Statuses
        {
            None, Created, Picking, Invoiced, Shipped, Cancelled, Delivered, UnDelivered, Returned, Repack, UnPacked, UnSupplied
        }

        public static string ApiUrl = "https://api.trendyol.com/sapigw/";
        public static string SuplierID = "106499";
        public static string Username = "IhcuViRpu2TeBeENvaxP";
        public static string Password = "cFoAzzK5I29UMKG5no7v";

        public TrendyolApi()
        {
            Models.SaleChannels channel = appManager.SaleChannels.Where(s => s.SaleChannel == "Trendyol").FirstOrDefault();
            ApiUrl = channel.URL.Replace(" ", "");
            SuplierID = channel.SellerID;
            Username = channel.Username;
            Password = channel.Password;
        }

        public static TrendyolSiparis.Header getProducts(bool approved = true, string barcode = "", double startDate = 0, double endDate = 0, int page = 0, int size = 0, dateQueries dateQueryType = dateQueries.CREATED_DATE)
        {
            List<string> paramlist = new List<string>();
            paramlist.Add("approved=" + approved.ToString());
            if (!string.IsNullOrEmpty(barcode)) paramlist.Add("barcode=" + barcode);
            if (startDate > 0) paramlist.Add("startDate=" + startDate);
            if (endDate > 0) paramlist.Add("endDate=" + endDate);
            if (page > 0) paramlist.Add("page=" + page);
            if (size > 0) paramlist.Add("size=" + size);
            paramlist.Add("dateQueryType=" + dateQueryType.ToString());

            string Url = ApiUrl + "suppliers/" + SuplierID + "/products?" + String.Join("&", paramlist);
            return JsonConvert.DeserializeObject<TrendyolSiparis.Header>(Helpers.StaticFunctions.GET(Url, Username, Password));
        }

        public static TrendyolSiparis.Header getOrders(double startDate = 0, double endDate = 0, int page = 0, int size = 0, string orderNumber = "", Statuses status = Statuses.None, orderByFields orderByField = orderByFields.None, orderByDirections orderByDirection = orderByDirections.NONE, long shipmentPackageIds = 0)
        {
            List<string> paramlist = new List<string>();
            if (startDate > 0) paramlist.Add("startDate=" + startDate);
            if (endDate > 0) paramlist.Add("endDate=" + endDate);
            if (page > 0) paramlist.Add("page=" + page);
            if (size > 0) paramlist.Add("size=" + size);
            if (!string.IsNullOrEmpty(orderNumber)) paramlist.Add("orderNumber=" + orderNumber);
            if (status != Statuses.None) paramlist.Add("dateQueryType=" + status.ToString());
            if (orderByField != orderByFields.None) paramlist.Add("orderByField=" + orderByField.ToString());
            if (orderByDirection != orderByDirections.NONE) paramlist.Add("orderByDirection=" + orderByDirection.ToString());
            if (shipmentPackageIds > 0) paramlist.Add("shipmentPackageIds=" + shipmentPackageIds.ToString());

            string Url = ApiUrl + "suppliers/" + SuplierID + "/orders" + (paramlist.Count > 0 ? ("?" + String.Join("&", paramlist)) : "");
            return JsonConvert.DeserializeObject<TrendyolSiparis.Header>(Helpers.StaticFunctions.GET(Url, Username, Password));
        }

        public Models.ApiReturnTypes.GetAllOrders.ShipmentResponse getOrdersAll(long startDate = 0, long endDate = 0, int page = 0, int size = 200, string orderNumber = "", Statuses status = Statuses.Created, orderByFields orderByField = orderByFields.PackageLastModifiedDate, orderByDirections orderByDirection = orderByDirections.DESC, long shipmentPackageIds = 0)
        {
            List<string> paramlist = new List<string>();
            if (startDate > 0) paramlist.Add("startDate=" + startDate);
            if (endDate > 0) paramlist.Add("endDate=" + endDate);
            if (page > 0) paramlist.Add("page=" + page);
            if (size > 0) paramlist.Add("size=" + size);
            if (!string.IsNullOrEmpty(orderNumber)) paramlist.Add("orderNumber=" + orderNumber);
            if (status != Statuses.None) paramlist.Add("dateQueryType=" + status.ToString());
            if (orderByField != orderByFields.None) paramlist.Add("orderByField=" + orderByField.ToString());
            if (orderByDirection != orderByDirections.NONE) paramlist.Add("orderByDirection=" + orderByDirection.ToString());
            if (shipmentPackageIds > 0) paramlist.Add("shipmentPackageIds=" + shipmentPackageIds.ToString());

            string Url = ApiUrl + "suppliers/" + SuplierID + "/orders" + (paramlist.Count > 0 ? ("?" + String.Join("&", paramlist)) : string.Empty);
            return JsonConvert.DeserializeObject<Models.ApiReturnTypes.GetAllOrders.ShipmentResponse>(StaticFunctions.GET(Url, Username, Password));
        }

        public static TrendyolSiparis.Claims.Claim.Root getShipmentPackagesClaims()
        {
            string Url = ApiUrl + "suppliers/" + SuplierID + "/claims?claimItemStatus=Created";
            return JsonConvert.DeserializeObject<TrendyolSiparis.Claims.Claim.Root>(Helpers.StaticFunctions.GET(Url, Username, Password));
        }

        public TrendyolSiparis.Header ShipmentPackages(string orderNumber, bool showCancelled)
        {
            string url = string.Empty;
            if (showCancelled)
            {
                url = ApiUrl + "suppliers/" + SuplierID + "/orders?status=Cancelled,UnSupplied&orderNumber=" + orderNumber;
            }
            else
            {
                url = ApiUrl + "suppliers/" + SuplierID + "/orders?orderNumber=" + orderNumber;
            }

            return JsonConvert.DeserializeObject<TrendyolSiparis.Header>(StaticFunctions.GET(url, Username, Password));
        }

        public string setCargo(int shipmentPackageId, string cargoName)
        {
            string url = ApiUrl + "suppliers/" + SuplierID + "/shipment-packages/" + shipmentPackageId + "/cargo-providers";

            return StaticFunctions.PUT<string>(new TrendyolSiparis.Cargo(cargoName), url, Username, Password);
        }

        public List<TrendyolSiparis.CargoFirm> getCargoList()
        {
            string url = ApiUrl + "shipment-providers";
            var data = StaticFunctions.GET(url, Username, Password);
            try
            {
                return JsonConvert.DeserializeObject<List<TrendyolSiparis.CargoFirm>>(StaticFunctions.GET(url, Username, Password));
            }
            catch
            {
                List<TrendyolSiparis.CargoFirm> cargoFirm = new List<TrendyolSiparis.CargoFirm>();
                return cargoFirm;
            }
        }

    }
}