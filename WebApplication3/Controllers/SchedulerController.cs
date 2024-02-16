using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Helpers;
using WebApplication3.Models;
using static WebApplication3.Models.Api.SaleChannelsStatusResult;

namespace WebApplication3.Controllers
{
    public class SchedulerController : Controller
    {
        private string apiURL;
        AppManagement dbContext;
        public SchedulerController()
        {
            apiURL = ConfigurationManager.AppSettings["api"];
            dbContext = new AppManagement();
        }
        // GET: Scheduler
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> RunSchedulerMethod()
        {
            try
            {
                LogToDatabase();
                return new HttpStatusCodeResult(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                // Hata durumunu logla veya başka bir işlem yap
                return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            }
        }

        public string PostNebimExportOrders()
        {
            string reqExtension = "postnebimexportorder";
            string request = apiURL + reqExtension;
            var responseStr = StaticFunctions.POST(request);
            var metaData = JsonConvert.DeserializeObject<MetaDataResponse>(responseStr);
            if (String.IsNullOrWhiteSpace(responseStr))
            {
                Meta meta = new Meta { Message = "Cevap alınamadı", StatusCode = 500 };
                return meta.Message;
            }
            else if (responseStr.ToLower().Contains("hata"))
            {
                Meta meta = new Meta { Message = responseStr, StatusCode = 500 };
                return meta.Message;
            }

            return metaData.Meta.Message;
        }

        public void LogToDatabase()
        {
            Logger log = new Logger();
            log.CreatedDate = DateTime.Now;
            log.Message = PostNebimExportOrders();
            log.RowID = Guid.NewGuid();
            dbContext.Logger.Add(log);
            dbContext.SaveChanges();
        }
    }
}