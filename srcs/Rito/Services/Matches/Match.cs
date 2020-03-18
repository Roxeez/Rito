using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rito.Services.Matches
{
    public sealed class Match
    {
        [JsonProperty]
        public int SeasonId { get; private set; }
        
        [JsonProperty]
        public int QueueId { get; private set; }
        
        [JsonProperty]
        public long GameId { get; private set; }
        
        [JsonProperty]
        public List<ParticipantIdentity> ParticipantIdentities { get; private set; }
        
        [JsonProperty]
        public string GameVersion { get; private set; }
        
        [JsonProperty]
        public string PlatformId { get; private set; }
        
        [JsonProperty]
        public string GameMode { get; private set; }
        
        [JsonProperty]
        public string MapId { get; private set; }
        
        [JsonProperty]
        public string GameType { get; private set; }
        
        [JsonProperty]
        public List<TeamStats> Teams { get; private set; }
        
        [JsonProperty]
        public List<Participant> Participants { get; private set; }
        
        [JsonProperty]
        public long GameDuration { get; private set; }
        
        [JsonProperty]
        public long GameCreation { get; private set; }
    }
}