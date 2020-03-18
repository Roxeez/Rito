using Newtonsoft.Json;

namespace Rito.Services.Matches
{
    public class TeamBan
    {
        [JsonProperty("pickTurn")]
        public int Turn { get; private set; }
        
        [JsonProperty]
        public int ChampionId { get; private set; }
    }
}