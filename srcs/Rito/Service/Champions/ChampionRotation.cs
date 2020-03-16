﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Service.Champions
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
        [JsonProperty("maxNewPlayerLevel")]
        public int MaximumNewPlayerLevel { get; private set; }
    }
}