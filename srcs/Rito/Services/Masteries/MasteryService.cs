using System.Collections.Generic;
using System.Threading.Tasks;
using Rito.Core;
using Rito.Core.Serialization;
using Rito.Network;

namespace Rito.Services.Masteries
{
    public class MasteryService : IMasteryService
    {
        private const string MASTERY_ROOT_URL = "/lol/champion-mastery/v4/champion-masteries/by-summoner";
        private const string SCORE_ROOT_URL = "/lol/champion-mastery/v4/scores/by-summoner";
        private const string BY_SUMMONER_ID = "/{0}";
        private const string BY_SUMMONER_AND_CHAMPION_ID = "/{0}/by-champion/{1}";

        private readonly INetworkClient _networkClient;
        private readonly IDeserializer _deserializer;

        public MasteryService(INetworkClient networkClient, IDeserializer deserializer)
        {
            _networkClient = networkClient;
            _deserializer = deserializer;
        }

        public async Task<IEnumerable<Mastery>> GetMasteries(Region region, string encryptedSummonerId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{MASTERY_ROOT_URL}{BY_SUMMONER_ID}", encryptedSummonerId);
            return _deserializer.Deserialize<List<Mastery>>(response);
        }

        public async Task<Mastery> GetMastery(Region region, string encryptedSummonerId, long championId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{MASTERY_ROOT_URL}{BY_SUMMONER_AND_CHAMPION_ID}", encryptedSummonerId, championId);
            return _deserializer.Deserialize<Mastery>(response);
        }

        public async Task<int> GetTotalMasteryScore(Region region, string encryptedSummonerId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{SCORE_ROOT_URL}{BY_SUMMONER_ID}", encryptedSummonerId);
            return _deserializer.Deserialize<int>(response);
        }
    }
}