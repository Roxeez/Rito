using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Services.Status
{
    public sealed class Incident
    {
        [JsonProperty]
        public long Id { get; private set; }
        
        [JsonProperty]
        public bool Active { get; private set; }
        
        [JsonProperty]
        public string CreatedAt { get; private set; }
        
        [JsonProperty]
        public List<Message> Updates { get; private set; }
    }
}