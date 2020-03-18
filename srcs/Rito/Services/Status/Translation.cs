using Newtonsoft.Json;

namespace Rito.Services.Status
{
    public class Translation
    {
        [JsonProperty]
        public string Locale { get; private set; }
        
        [JsonProperty]
        public string Content { get; private set; }
        
        [JsonProperty]
        public string UpdatedAt { get; private set; }
    }
}