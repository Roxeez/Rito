using System.Collections.Generic;
using Newtonsoft.Json;
using Rito.Core;

namespace Rito.Services.Leagues
{
    public sealed class League
    {
        [JsonProperty("leagueId")]
        public string Id { get; private set; }
        
        [JsonProperty]
        public Tier Tier { get; private set; }
        
        [JsonProperty]
        public Queue Queue { get; private set; }
        
        [JsonProperty]
        public List<LeagueItem> Entries { get; private set; }
        
        [JsonProperty]
        public string Name { get; private set; }
    }
}