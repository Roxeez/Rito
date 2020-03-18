using System.Threading.Tasks;
using Rito.Core;
using Rito.Core.Serialization;
using Rito.Network;

namespace Rito.Services.Matches
{
    public class MatchService : IMatchService
    {
        private const string ROOT_URL = "/lol/match/v4";
        private const string MATCH_BY_ID = "/matches/{0}";
        private const string MATCHLIST_BY_ACCOUNT_ID = "/matchlists/by-account/{0}";

        private readonly INetworkClient _networkClient;
        private readonly IDeserializer _deserializer;

        public MatchService(INetworkClient networkClient, IDeserializer deserializer)
        {
            _networkClient = networkClient;
            _deserializer = deserializer;
        }

        public async Task<Match> GetMatch(Region region, long matchId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{MATCH_BY_ID}", matchId);
            return _deserializer.Deserialize<Match>(response);
        }

        public async Task<Matchlist> GetMatchlist(Region region, string encryptedAccountId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{MATCHLIST_BY_ACCOUNT_ID}", encryptedAccountId);
            return _deserializer.Deserialize<Matchlist>(response);
        }
    }
}