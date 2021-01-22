using Newtonsoft.Json;

namespace oauth_client_sample.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Channel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
    }
}