using Newtonsoft.Json;

namespace oauth_client_sample.Data
{
    [JsonObject(MemberSerialization.OptIn)]
    class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("user_email")]
        public string Email { get; set; }
    }
}