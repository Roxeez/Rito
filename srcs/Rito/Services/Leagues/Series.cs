using Newtonsoft.Json;

namespace Rito.Services.Leagues
{
    public class Series
    {
        [JsonProperty]
        public string Progress { get; private set; }
        
        [JsonProperty]
        public int Wins { get; private set; }
        
        [JsonProperty]
        public int Losses { get; private set; }
        
        [JsonProperty]
        public int Target { get; private set; }
    }
}