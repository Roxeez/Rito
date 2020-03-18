using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Rito.Core;

namespace Rito.Services.Matches
{
    public class Participant
    {
        [JsonProperty("participantId")]
        public int Id { get; private set; }
        
        [JsonProperty]
        public ParticipantStats Stats { get; private set; }
        
        [JsonProperty]
        public List<Rune> Runes { get; private set; }
        
        [JsonProperty]
        public ParticipantTimeline Timeline { get; private set; }
        
        [JsonProperty]
        public int TeamId { get; private set; }
        
        [JsonProperty("spell1Id")]
        public int FirstSummonerSpellId { get; private set; }
        
        [JsonProperty("spell2Id")]
        public int SecondSummonerSpellId { get; private set; }
        
        [Obsolete]
        [JsonProperty]
        public List<Mastery> Masteries { get; private set; }
        
        [JsonProperty("highestAchievedSeasonTier")]
        public Tier HighestSeasonTier { get; private set; }
        
        [JsonProperty("championId")]
        public int ChampionId { get; private set; }
    }
}