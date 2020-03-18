using System.Collections.Generic;
using Newtonsoft.Json;
using Rito.Core;

namespace Rito.Services.Matches
{
    public class TeamStats
    {
        [JsonProperty]
        public bool FirstDragon { get; private set; }
        
        [JsonProperty]
        public bool FirstInhibitor { get; private set; }
        
        [JsonProperty]
        public List<TeamBan> Bans { get; private set; }
        
        [JsonProperty]
        public int BaronKills { get; private set; }
        
        [JsonProperty]
        public bool FirstRiftHerald { get; private set; }
        
        [JsonProperty]
        public bool FirstBaron { get; private set; }
        
        [JsonProperty]
        public int RiftHeraldKills { get; private set; }
        
        [JsonProperty]
        public bool FirstBlood { get; private set; }
        
        [JsonProperty]
        public int TeamId { get; private set; }
        
        [JsonProperty]
        public bool FirstTower { get; private set; }
        
        [JsonProperty]
        public int VilemawKills { get; private set; }
        
        [JsonProperty]
        public int InhibitorKills { get; private set; }
        
        [JsonProperty]
        public int TowerKills { get; private set; }
        
        [JsonProperty]
        public int DominionVictoryScore { get; private set; }
        
        [JsonProperty]
        public WinStatus Win { get; private set; }
        
        [JsonProperty]
        public int DragonKills { get; private set; }
    }
}