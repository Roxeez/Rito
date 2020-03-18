using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Services.Matches
{
    public sealed class Matchlist
    {
        [JsonProperty]
        public List<MatchReference> Matches { get; private set; }
        
        [JsonProperty]
        public int TotalGames { get; private set; }
        
        [JsonProperty]
        public int StartIndex { get; private set; }
        
        [JsonProperty]
        public int EndIndex { get; private set; }
    }
}