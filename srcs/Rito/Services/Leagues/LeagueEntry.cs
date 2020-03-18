using Newtonsoft.Json;
using Rito.Core;

namespace Rito.Services.Leagues
{
    public class LeagueEntry : LeagueItem
    {
        [JsonProperty]
        public Queue QueueType { get; private set; }
        
        [JsonProperty]
        public string LeagueId { get; private set; }
        
        [JsonProperty]
        public Tier Tier { get; private set; }
    }
}