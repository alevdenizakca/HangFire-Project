using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Helpers
{
    public static class StaticFunctions
    {
        public static string toMessage(this Exception item)
        {
            string error = "";
            if (item.InnerException != null)
            {
                Exception err = item.InnerException;
                while (err != null)
                {
                    error += err.Message;
                    err = err.InnerException;
                }
            }
            else error = item.Message;
            return error;
        }

        public static Uri ToServisUri(this string Alan_Adi, string Path)
        { //1-R-2-16498
            string adres_format = "https://{0}/Servis/{1}.svc";
            return new Uri(string.Format(adres_format, Alan_Adi, Path));
        }


        public static string GET(string url, string username, string password)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);

            client.Authenticator = new HttpBasicAuthenticator(username, password);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Cache-Control", "no-cache");
            var response = client.Execute(request);
            return response.Content;
        }

        public static string GET(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.GET);
                request.Timeout = 60 * 1000;
                request.ReadWriteTimeout = 60 * 1000;
                client.Timeout = request.Timeout;
                client.ReadWriteTimeout = request.ReadWriteTimeout;

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Cache-Control", "no-cache");
                var response = client.Execute(request);
                if (response.ErrorException is null)
                    return response.Content;
                else
                    throw new Exception(response.ErrorMessage);
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
                return $"Error: {ex.Message}";
            }

        }

        public static T POST<T>(object jsonModel, string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);

            string jsonData = JsonConvert.SerializeObject(jsonModel);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
            string response = client.Execute(request).Content;
            return JsonConvert.DeserializeObject<T>(response);
        }

        public static string POST(string url)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.Timeout = 60 * 1000;
                request.ReadWriteTimeout = 60 * 1000;
                client.Timeout = request.Timeout;
                client.ReadWriteTimeout = request.ReadWriteTimeout;

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Cache-Control", "no-cache");
                var response = client.Execute(request);
                if (response.ErrorException is null)
                    return response.Content;
                else
                    throw new Exception(response.ErrorMessage);
            }
            catch (Exception ex)
            {
                WriteLog(ex.Message);
                return $"Error: {ex.Message}";
            }
        }

        public static T POST<T>(object jsonModel, string url, string username, string password)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            client.Authenticator = new HttpBasicAuthenticator(username, password);

            string jsonData = JsonConvert.SerializeObject(jsonModel);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
            string response = client.Execute(request).Content;
            return JsonConvert.DeserializeObject<T>(response);
        }

        public static void WriteToDatabase(string message)
        {
            using (AppManagement context = new AppManagement())
            {
                context.Logger.Add(new Logger()
                {
                    RowID = Guid.NewGuid(),
                    CreatedDate = DateTime.Now,
                    Message = message
                });
                context.SaveChanges();
            }

        }

        public static void WriteLog(string strLog)
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;

            string logFilePath = "C:\\Logs\\";
            logFilePath = logFilePath + "Log-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(strLog);
            log.Close();
        }
    }
}