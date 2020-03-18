using Newtonsoft.Json;
using Rito.Core;

namespace Rito.Services.Matches
{
    public class MatchReference
    {
        [JsonProperty]
        public Lane Lane { get; private set; }
        
        [JsonProperty]
        public long GameId { get; private set; }
        
        [JsonProperty]
        public int Champion { get; private set; }
        
        [JsonProperty]
        public string PlatformId { get; private set; }
        
        [JsonProperty]
        public int Season { get; private set; }
        
        [JsonProperty]
        public int Queue { get; private set; }
        
        [JsonProperty]
        public string Role { get; private set; }
        
        [JsonProperty]
        public long Timestamp { get; private set; }
    }
}