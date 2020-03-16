using System.Threading.Tasks;
using Rito.Core;
using Rito.Core.Serialization;
using Rito.Network;

namespace Rito.Services.Champions
{
    public class ChampionService : IChampionService
    {
        private const string ROOT_URL = "/lol/platform/v3/champion-rotations";
        
        private readonly INetworkClient _networkClient;
        private readonly IDeserializer _deserializer;

        public ChampionService(INetworkClient networkClient, IDeserializer deserializer)
        {
            _networkClient = networkClient;
            _deserializer = deserializer;
        }

        public async Task<ChampionRotation> GetChampionRotation(Region region)
        {
            string response = await _networkClient.SendGetRequest(ROOT_URL, region);
            return _deserializer.Deserialize<ChampionRotation>(response);
        }
    }
}