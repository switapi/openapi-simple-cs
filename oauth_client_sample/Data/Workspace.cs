using Newtonsoft.Json;

namespace oauth_client_sample.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Workspace
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("domain")]
        public string Domain { get; set; }
        
        [JsonProperty("master_id")]
        public string MasterId { get; set; }
        
        [JsonProperty("created")]
        public string Created { get; set; }
    }
}