using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Services.Leagues
{
    public sealed class League
    {
        [JsonProperty("leagueId")]
        public string Id { get; private set; }
        
        [JsonProperty]
        public string Tier { get; private set; }
        
        [JsonProperty]
        public string Queue { get; private set; }
        
        [JsonProperty]
        public List<LeagueItem> Entries { get; private set; }
        
        [JsonProperty]
        public string Name { get; private set; }
    }
}