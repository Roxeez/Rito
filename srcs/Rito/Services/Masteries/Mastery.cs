using Newtonsoft.Json;

namespace Rito.Services.Masteries
{
    public class Mastery
    {
        [JsonProperty]
        public bool ChestGranted { get; private set; }
        
        [JsonProperty]
        public int ChampionLevel { get; private set; }
        
        [JsonProperty]
        public int ChampionPoints { get; private set; }
        
        [JsonProperty]
        public long ChampionId { get; private set; }
        
        [JsonProperty]
        public long ChampionPointsUntilNextLevel { get; private set; }
        
        [JsonProperty]
        public long LastPlayTime { get; private set; }
        
        [JsonProperty]
        public int TokensEarned { get; private set; }
        
        [JsonProperty]
        public long ChampionPointsSinceLastLevel { get; private set; }
        
        [JsonProperty]
        public string SummonerId { get; private set; }
    }
}