using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Services.Status
{
    public sealed class Service
    {
        [JsonProperty]
        public string Status { get; private set; }
        
        [JsonProperty]
        public List<Incident> Incidents { get; private set; }
        
        [JsonProperty]
        public string Name { get; private set; }
        
        [JsonProperty]
        public string Slug { get; private set; }
    }
}