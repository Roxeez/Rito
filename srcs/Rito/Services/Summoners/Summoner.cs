using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Rito.Services.Summoners
{
    public sealed class Summoner
    {
        [JsonProperty]
        public string Id { get; private set; }
        
        [JsonProperty]
        public string AccountId { get; private set; }
        
        [JsonProperty]
        public int ProfileIconId { get; private set; }
        
        [JsonProperty]
        public string Name { get; private set; }
        
        [JsonProperty]
        public long Level { get; private set; }
        
        [JsonProperty]
        public long RevisionDate { get; private set; }
    }
}