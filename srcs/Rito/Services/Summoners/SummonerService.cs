using System.Threading.Tasks;
using Rito.Core;
using Rito.Core.Serialization;
using Rito.Network;

namespace Rito.Services.Summoners
{
    public class SummonerService : ISummonerService
    {
        private const string ROOT_URL = "/lol/summoner/v4/summoners";
        private const string BY_NAME_URL = "/by-name/{0}";
        private const string BY_ACCOUNT_URL = "/by-account/{0}";
        private const string BY_PUUID = "/by-puuid/{0}";
        private const string BY_SUMMONER_ID = "/{0}";

        private readonly INetworkClient _networkClient;
        private readonly IDeserializer _deserializer;

        public SummonerService(INetworkClient networkClient, IDeserializer deserializer)
        {
            _networkClient = networkClient;
            _deserializer = deserializer;
        }

        public async Task<Summoner> GetSummonerByName(Region region, string summonerName)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{BY_NAME_URL}", summonerName);
            return _deserializer.Deserialize<Summoner>(response);
        }

        public async Task<Summoner> GetSummonerByAccountId(Region region, string encryptedAccountId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{BY_ACCOUNT_URL}", encryptedAccountId);
            return _deserializer.Deserialize<Summoner>(response);
        }

        public async Task<Summoner> GetSummonerBySummonerId(Region region, string encryptedSummonerId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{BY_SUMMONER_ID}", encryptedSummonerId);
            return _deserializer.Deserialize<Summoner>(response);
        }

        public async Task<Summoner> GetSummonerByPUUID(Region region, string encryptedPUUID)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{BY_PUUID}", encryptedPUUID);
            return _deserializer.Deserialize<Summoner>(response);
        }
    }
}