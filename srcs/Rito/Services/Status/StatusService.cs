using System.Threading.Tasks;
using Rito.Core;
using Rito.Core.Serialization;
using Rito.Network;

namespace Rito.Services.Status
{
    public class StatusService : IStatusService
    {
        private const string ROOT_URL = "/lol/status/v3/shard-data";

        private readonly INetworkClient _networkClient;
        private readonly IDeserializer _deserializer;

        public StatusService(INetworkClient networkClient, IDeserializer deserializer)
        {
            _networkClient = networkClient;
            _deserializer = deserializer;
        }

        public async Task<ShardStatus> GetRegionStatus(Region region)
        {
            string response = await _networkClient.SendGetRequest(region, ROOT_URL);
            return _deserializer.Deserialize<ShardStatus>(response);
        }
    }
}