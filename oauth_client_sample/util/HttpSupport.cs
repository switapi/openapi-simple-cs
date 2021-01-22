using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using Newtonsoft.Json;

namespace oauth_client_sample.util
{
    public class HttpSupport
    {
        public static T SendHttp<T>(string uri, string method, string body, string accessToken, string dataName) where T : class
        {
              
            if (method == "GET" && body.Length > 0)
            {
                uri = uri + "?" + body;
            }

            Console.WriteLine(uri);

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = method;
            request.Accept = "application/json";
            request.ContentType = "application/json";
            request.Headers.Add("Authorization", "Bearer " + accessToken);

            if (method != "GET" && body.Length > 0)
            {
                request.ContentLength = body.Length;
                Console.WriteLine(body);
                using (var requestStream = request.GetRequestStream())
                {
                    var writer = new StreamWriter(requestStream);
                    writer.Write(body);
                    writer.Close();
                }
            }
          
            
            var response = (HttpWebResponse)request.GetResponse();
            T t;
            
            using (var responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream);
                var json = reader.ReadToEnd();
                reader.Close();

                var dataModel = JsonConvert.DeserializeObject(json, typeof(DataModel)) as DataModel;
                var userJson = JsonConvert.SerializeObject(dataModel.Data[dataName]);
                t = JsonConvert.DeserializeObject(userJson, typeof(T)) as T;   
            }

            return t;
        }
        public  static  string SendHook(string uri, string method, string body) 
        {
              
            if (method == "GET" && body.Length > 0)
            {
                uri = uri + "?" + body;
            }

            Console.WriteLine(uri);

            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = method;
            request.Accept = "application/json";
            request.ContentType = "application/json";

            if (method != "GET" && body.Length > 0)
            {
                request.ContentLength = body.Length;
                Console.WriteLine(body);
                using (var requestStream = request.GetRequestStream())
                {
                    var writer = new StreamWriter(requestStream);
                    writer.Write(body);
                    writer.Close();
                }
            }
          
            
            var response = (HttpWebResponse)request.GetResponse();
            return response.StatusCode.ToString();

        }
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class DataModel
    {
        [JsonProperty("data")]
        public Dictionary<string, object> Data { get; set; }
    }
}