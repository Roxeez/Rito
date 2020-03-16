using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Services.Champions
{
    public sealed class ChampionRotation
    {
        /// <summary>
        /// Free champions rotation for beginners
        /// </summary>
        [JsonProperty("freeChampionIdsForNewPlayers")]
        public List<int> FreeChampionsForNewPlayers { get; private set; }
        
        /// <summary>
        /// Free champions rotation
        /// </summary>
        [JsonProperty("freeChampionIds")]
        public List<int> FreeChampions { get; private set; }
        
        /// <summary>
        /// Define what's the maximum level to be considered as beginner
        /// </summary>
        [JsonProperty]
        public int MaxNewPlayerLevel { get; private set; }
    }
}