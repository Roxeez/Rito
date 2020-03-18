using Newtonsoft.Json;
using Rito.Core;

namespace Rito.Services.Leagues
{
    public class LeagueItem
    {
        [JsonProperty("summonerId")]
        public string Id { get; private set; }
        
        [JsonProperty("summonerName")]
        public string Name { get; private set; }
        
        [JsonProperty]
        public bool HotStreak { get; private set; }
        
        [JsonProperty("miniSeries")]
        public Series Series { get; private set; }
        
        [JsonProperty]
        public int Wins { get; private set; }
        
        [JsonProperty]
        public int Losses { get; private set; }
        
        [JsonProperty]
        public bool Veteran { get; private set; }
        
        [JsonProperty]
        public bool FreshBlood { get; private set; }
        
        [JsonProperty]
        public bool Inactive { get; private set; }
        
        [JsonProperty]
        public Division Rank { get; private set; }
        
        [JsonProperty("leaguePoints")]
        public int Points { get; private set; }
    }
}