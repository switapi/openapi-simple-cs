using Newtonsoft.Json;

namespace oauth_client_sample.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Message
    {
        [JsonProperty("message_id")]
        public string Id { get; set; }
        
        [JsonProperty("content")]
        public string Name { get; set; }
        
    }
}