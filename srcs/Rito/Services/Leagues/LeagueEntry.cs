using Newtonsoft.Json;

namespace Rito.Services.Leagues
{
    public class LeagueEntry : LeagueItem
    {
        [JsonProperty]
        public string QueueType { get; private set; }
        
        [JsonProperty]
        public string LeagueId { get; private set; }
        
        [JsonProperty]
        public string Tier { get; private set; }
    }
}