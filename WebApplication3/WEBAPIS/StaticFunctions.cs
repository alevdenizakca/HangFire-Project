using Newtonsoft.Json;
using RestSharp.Authenticators;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication3.WEBAPIS
{
    public static class StaticFunctions
    {
        public static object JsonHelper { get; internal set; }

        public static Uri ToServisUri(this string Alan_Adi, string Path)
        {
            string adres_format = "https://{0}/Servis/{1}.svc";
            return new Uri(string.Format(adres_format, Alan_Adi, Path));
        }

        public static T PUT<T>(object jsonModel, string url, string username, string password)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            client.Authenticator = new HttpBasicAuthenticator(username, password);

            string jsonData = JsonConvert.SerializeObject(jsonModel);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
            string response = client.Execute(request).Content;
            if (typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(response, typeof(T));
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(response);
            }
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

        public static T POST<T>(object jsonModel, string url)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);

            string jsonData = JsonConvert.SerializeObject(jsonModel);
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", jsonData, ParameterType.RequestBody);
            string response = client.Execute(request).Content;
            if (typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(response, typeof(T));
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(response);
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
            if (typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(response, typeof(T));
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(response);
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