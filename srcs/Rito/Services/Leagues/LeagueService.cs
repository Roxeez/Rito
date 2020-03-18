using System.Collections.Generic;
using System.Threading.Tasks;
using Rito.Core;
using Rito.Core.Serialization;
using Rito.Network;

namespace Rito.Services.Leagues
{
    public sealed class LeagueService : ILeagueService
    {
        private const string ROOT_URL = "/lol/league/v4";
        private const string CHALLENGER_LEAGUES = "/challengerleagues";
        private const string GRAND_MASTER_LEAGUES = "/grandmasterleagues";
        private const string MASTER_LEAGUES = "/masterleagues";
        private const string BY_QUEUE = "/by-queue/{0}";
        private const string BY_LEAGUE = "/leagues/{0}";
        private const string ENTRIES_BY_QUEUE_TIER_DIVISION = "/entries/{0}/{1}/{2}";
        private const string ENTRIES_BY_SUMMONER_ID = "/entries/by-summoner/{0}";

        private readonly INetworkClient _networkClient;
        private readonly IDeserializer _deserializer;

        public LeagueService(INetworkClient networkClient, IDeserializer deserializer)
        {
            _networkClient = networkClient;
            _deserializer = deserializer;
        }

        public async Task<League> GetChallengerLeague(Region region, Queue queue)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{CHALLENGER_LEAGUES}{BY_QUEUE}", queue);
            return _deserializer.Deserialize<League>(response);
        }

        public async Task<League> GetGrandMasterLeague(Region region, Queue queue)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{GRAND_MASTER_LEAGUES}{BY_QUEUE}", queue);
            return _deserializer.Deserialize<League>(response);
        }

        public async Task<League> GetMasterLeague(Region region, Queue queue)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{MASTER_LEAGUES}{BY_QUEUE}", queue);
            return _deserializer.Deserialize<League>(response);
        }

        public async Task<League> GetLeague(Region region, string leagueId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{BY_LEAGUE}", leagueId);
            return _deserializer.Deserialize<League>(response);
        }

        public async Task<IEnumerable<LeagueEntry>> GetSummonerLeagues(Region region, string encryptedSummonerId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{ENTRIES_BY_SUMMONER_ID}", encryptedSummonerId);
            return _deserializer.Deserialize<List<LeagueEntry>>(response);
        }

        public async Task<IEnumerable<LeagueEntry>> GetAllLeagues(Region region, Queue queue, Tier tier, Division division)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{ENTRIES_BY_QUEUE_TIER_DIVISION}", queue, tier, division);
            return _deserializer.Deserialize<List<LeagueEntry>>(response);
        }
    }
}