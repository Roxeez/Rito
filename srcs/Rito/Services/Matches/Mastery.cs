using Newtonsoft.Json;

namespace Rito.Services.Matches
{
    public class Mastery
    {
        [JsonProperty("masteryId")]
        public int Id { get; private set; }
        
        [JsonProperty]
        public int Rank { get; private set; }
    }
}