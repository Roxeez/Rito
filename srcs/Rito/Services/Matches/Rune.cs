using Newtonsoft.Json;

namespace Rito.Services.Matches
{
    public sealed class Rune
    {
        [JsonProperty("runeId")]
        public int Id { get; private set; }
        
        [JsonProperty]
        public int Rank { get; private set; }
    }
}