using System.Collections.Generic;
using Newtonsoft.Json;
using Rito.Core;

namespace Rito.Services.Matches
{
    public sealed class ParticipantTimeline
    {
        [JsonProperty]
        public Lane Lane { get; private set; }
        
        [JsonProperty]
        public int ParticipantId { get; private set; }
        
        [JsonProperty("csDiffPerMinDeltas")]
        public Dictionary<string, double> CreepScoreDifference { get; private set; }
        
        [JsonProperty("goldPerMinDeltas")]
        public Dictionary<string, double> GoldDifference { get; private set; }
        
        [JsonProperty("xpDiffPerMinDeltas")]
        public Dictionary<string, double> ExperienceDifference { get; private set; }
        
        [JsonProperty("creepsPerMinDeltas")]
        public Dictionary<string, double> CreepsPerMinute { get; private set; }
        
        [JsonProperty("xpPerMinDeltas")]
        public Dictionary<string, double> ExperiencesPerMinute { get; private set; }
        
        [JsonProperty]
        public Role Role { get; private set; }
        
        [JsonProperty]
        public Dictionary<string, double> DamageTakenDifference { get; private set; }
        
        [JsonProperty]
        public Dictionary<string, double> DamageTakenPerMinute { get; private set; }
        
    }
}