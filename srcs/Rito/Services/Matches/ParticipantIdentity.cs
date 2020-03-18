using Newtonsoft.Json;

namespace Rito.Services.Matches
{
    public class ParticipantIdentity
    {
        [JsonProperty]
        public Player Player { get; private set; }
        
        [JsonProperty]
        public int ParticipantId { get; private set; }
    }
}