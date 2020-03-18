using Newtonsoft.Json;

namespace Rito.Services.Masteries
{
    public class ChampionMastery
    {
        [JsonProperty]
        public bool ChestGranted { get; private set; }
        
        [JsonProperty("championLevel")]
        public int Level { get; private set; }
        
        [JsonProperty("championPoints")]
        public int Points { get; private set; }
        
        [JsonProperty]
        public long ChampionId { get; private set; }
        
        [JsonProperty("championPointsUntilNextLevel")]
        public long PointsUntilNextLevel { get; private set; }
        
        [JsonProperty]
        public long LastPlayTime { get; private set; }
        
        [JsonProperty]
        public int TokensEarned { get; private set; }
        
        [JsonProperty("championPointsSinceLastLevel")]
        public long PointsSinceLastLevel { get; private set; }
        
        [JsonProperty]
        public string SummonerId { get; private set; }
    }
}