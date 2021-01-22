using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace oauth_client_sample.util
{
    [JsonObject(MemberSerialization.OptIn)]
    public class AccessTokenInfo
    {
        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }
    }
    
    public class TokenSupport
    {
        public static AccessTokenInfo ExchangeToken(string uri, string body)
        {
            AccessTokenInfo token = null;
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.Accept = "application/json";
            request.ContentType = "application/x-www-form-urlencoded";

            request.ContentLength = body.Length;

            using (var requestStream = request.GetRequestStream())
            {
                var writer = new StreamWriter(requestStream);
                writer.Write(body);
                writer.Close();
            }

            var response = (HttpWebResponse)request.GetResponse();

            using (var responseStream = response.GetResponseStream())
            {
                var reader = new StreamReader(responseStream);
                var json = reader.ReadToEnd();
                reader.Close();
                token = JsonConvert.DeserializeObject(json, typeof(AccessTokenInfo)) as AccessTokenInfo;
            }

            return token;
        }
    }
}