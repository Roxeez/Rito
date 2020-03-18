using Newtonsoft.Json;

namespace Rito.Services.Matches
{
    public class Player
    {
        [JsonProperty]
        public string CurrentPlatformId { get; private set; }
        
        [JsonProperty]
        public string SummonerName { get; private set; }
        
        [JsonProperty]
        public string MatchHistoryUrl { get; private set; }
        
        [JsonProperty]
        public string PlatformId { get; private set; }
        
        [JsonProperty]
        public string currentAccountId { get; private set; }
        
        [JsonProperty]
        public int ProfileIcon { get; private set; }
        
        [JsonProperty]
        public string SummonerId { get; private set; }
        
        [JsonProperty]
        public string AccountId { get; private set; }
    }
}