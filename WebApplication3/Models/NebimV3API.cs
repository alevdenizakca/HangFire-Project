using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using WebApplication3.Models.NebimV3;

namespace WebApplication3.Models
{
    public class NebimV3API
    {
        public static string LastResult { get; set; }
        public static string ServerURL { get; set; }
        public static string ServerPort { get; set; }
        public static string URL { get; set; }
        public static string Session { get; set; }
        public static string Token { get; set; }
        static HttpClient client;

        static NebimV3API()
        {
            URL = ConfigurationManager.AppSettings["NebimApi"];
            client = new HttpClient();
        }

        public static string GetToken()
        {
            try
            {
                if (string.IsNullOrEmpty(Token))
                {
                    var request = client.GetAsync(URL + "/IntegratorService/Connect?").Result;
                    var queryResult = JsonConvert.DeserializeObject<MetaData>(request.Content.ReadAsStringAsync().Result);
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

        public static string Connect(ConnectModel model)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();

            settings.NullValueHandling = NullValueHandling.Ignore;

            string jsonData = JsonConvert.SerializeObject(model, settings);


            string url = URL + "/IntegratorService/Connect";

            var request = client.PostAsync(url, new StringContent(jsonData, Encoding.UTF8, "application/json")).Result;
            string response = request.Content.ReadAsStringAsync().Result;
            LastResult = response;
            if (!response.Contains("ExceptionMessage"))
            {
                var result = JsonConvert.DeserializeObject<dynamic>(response);

                return result.Token;
            }
            else
            {
                Error err = JsonConvert.DeserializeObject<Error>(response);
                throw new Exception(err.ExceptionMessage);
            }
        }

        public static string GetSession()
        {
            try
            {
                if (string.IsNullOrEmpty(Token))
                {
                    var request = client.GetAsync(URL + "/IntegratorService/Connect?").Result;
                    var queryResult = JsonConvert.DeserializeObject<MetaData>(request.Content.ReadAsStringAsync().Result);
                    Session = queryResult.SessionID;
                }
                else
                {
                    return Session;
                }
            }
            catch
            {
                throw new Exception("ERP'ye bağlanılamadı. Lütfen Parametrelerinizi Gözden Geçiriniz.");
            }
            return Session;
        }


        public static T GET<T>(string getUrl, string methodType)
        {
            string urlVal = "";
            if (methodType == "Token")
            {
                urlVal = URL + "/IntegratorService/GET?" + getUrl + "&Token=" + Token;
            }
            else
            {
                urlVal = URL + "/IntegratorService/GET?" + getUrl;
            }
            var request = client.GetAsync(urlVal).Result;
            string response = request.Content.ReadAsStringAsync().Result;
            LastResult = response;
            if (!response.Contains("ExceptionMessage")) return JsonConvert.DeserializeObject<T>(response);
            else
            {
                Error err = JsonConvert.DeserializeObject<Error>(response);
                throw new Exception(err.ExceptionMessage);
            }
        }

        public static T POST<T>(object jsonModel, string methodType, string token = null)
        {
            if (string.IsNullOrEmpty(token))
                GetToken();
            else
                Token = token;

            string urlVal = "";
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            string jsonData = JsonConvert.SerializeObject(jsonModel, settings);
            if (methodType == "Token")
            {
                urlVal = URL + "/IntegratorService/POST/" + Token;
            }
            else
            {
                urlVal = URL + "/(S(" + Session + "))" + "/IntegratorService/Post?";
            }
            var request = client.PostAsync(urlVal, new StringContent(jsonData, Encoding.UTF8, "application/json")).Result;
            string response = request.Content.ReadAsStringAsync().Result;
            LastResult = response;
            if (!response.Contains("ExceptionMessage")) return JsonConvert.DeserializeObject<T>(response);
            else
            {
                Error err = JsonConvert.DeserializeObject<Error>(response);
                throw new Exception(err.ExceptionMessage);
            }
        }

        public static T RunProc<T>(string procName, bool deleteArray, params Models.NebimV3.Parameter[] parameters)
        {
            Procedure procedure = new Procedure();
            procedure.ProcName = procName;
            procedure.Parameters = parameters;
            string jsonData = JsonConvert.SerializeObject(procedure);

            var request = client.PostAsync(URL + "/(S(" + Session + "))" + "/IntegratorService/RunProc?", new StringContent(jsonData, Encoding.UTF8, "application/json")).Result;

            string response = request.Content.ReadAsStringAsync().Result;
            LastResult = response;
            if (deleteArray)
            {
                response = response.Replace("[", "");
                response = response.Replace("]", "");
            }

            if (!response.Contains("ExceptionMessage")) return JsonConvert.DeserializeObject<T>(response);
            else
            {
                Error err = JsonConvert.DeserializeObject<Error>(response);
                throw new Exception(err.ExceptionMessage);
            }
        }
    }
    public class MetaData
    {
        public string StatusCode { get; set; }
        public string SessionID { get; set; }
        public string ExceptionMessage { get; set; }
        public string OrderNumber { get; set; }
        public string DocumentNumber { get; set; }
        public string Token { get; set; }
    }

    public class Procedure
    {
        //public string Token { get; set; }
        public string ProcName { get; set; }
        public Models.NebimV3.Parameter[] Parameters { get; set; }
    }

    public class Error
    {
        public int ModelType { get; set; }
        public string ExceptionMessage { get; set; }
        public string StackTrace { get; set; }
        public string ErrorSource { get; set; }
        public int StatusCode { get; set; }
    }
}
