﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Rito.Core;
using Rito.Core.Serialization;
using Rito.Network;

namespace Rito.Services.Masteries
{
    public class ChampionMasteryService : IChampionMasteryService
    {
        private const string ROOT_URL = "/lol/champion-mastery/v4";
        private const string CHAMPION_MASTERIES = "/champion-masteries";
        private const string SCORES = "/scores";
        private const string BY_SUMMONER_ID = "/by-summoner/{0}";
        private const string BY_SUMMONER_AND_CHAMPION_ID = "/by-summoner/{0}/by-champion/{1}";

        private readonly INetworkClient _networkClient;
        private readonly IDeserializer _deserializer;

        public ChampionMasteryService(INetworkClient networkClient, IDeserializer deserializer)
        {
            _networkClient = networkClient;
            _deserializer = deserializer;
        }

        public async Task<IEnumerable<ChampionMastery>> GetMasteries(Region region, string encryptedSummonerId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{CHAMPION_MASTERIES}{BY_SUMMONER_ID}", encryptedSummonerId);
            return _deserializer.Deserialize<List<ChampionMastery>>(response);
        }

        public async Task<ChampionMastery> GetMastery(Region region, string encryptedSummonerId, long championId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{CHAMPION_MASTERIES}{BY_SUMMONER_AND_CHAMPION_ID}", encryptedSummonerId, championId);
            return _deserializer.Deserialize<ChampionMastery>(response);
        }

        public async Task<int> GetTotalMasteryScore(Region region, string encryptedSummonerId)
        {
            string response = await _networkClient.SendGetRequest(region, $"{ROOT_URL}{SCORES}{BY_SUMMONER_ID}", encryptedSummonerId);
            return _deserializer.Deserialize<int>(response);
        }
    }
}