using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Services.Status
{
    public sealed class Message
    {
        [JsonProperty]
        public string Severity { get; private set; }
        
        [JsonProperty]
        public string Author { get; private set; }
        
        [JsonProperty]
        public string CreatedAt { get; private set; }
        
        [JsonProperty]
        public List<Translation> Translations { get; private set; }
        
        [JsonProperty]
        public string UpdatedAt { get; private set; }
        
        [JsonProperty]
        public string Content { get; private set; }
        
        [JsonProperty]
        public string Id { get; private set; }
    }
}