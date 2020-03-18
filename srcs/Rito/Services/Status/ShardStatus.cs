using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Services.Status
{
    public class ShardStatus
    {
        [JsonProperty]
        public string Name { get; private set; }
        
        [JsonProperty("region_tag")]
        public string Region { get; private set; }
        
        [JsonProperty]
        public string HostName { get; private set; }
        
        [JsonProperty]
        public List<Service> Services { get; private set; }
        
        [JsonProperty]
        public string Slug { get; private set; }
        
        [JsonProperty]
        public List<string> Locales { get; private set; }
    }
}