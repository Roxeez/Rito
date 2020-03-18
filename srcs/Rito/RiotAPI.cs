using JetBrains.Annotations;
using Rito.Core.Serialization;
using Rito.Network;
using Rito.Services;
using Rito.Services.Champions;
using Rito.Services.Leagues;
using Rito.Services.Masteries;
using Rito.Services.Status;
using Rito.Services.Summoners;

namespace Rito
{
    public sealed class RiotAPI : IRiotAPI
    {
        public IChampionService Champions { get; }
        public ISummonerService Summoners { get; }
        public IChampionMasteryService ChampionMasteries { get; }
        public ILeagueService Leagues { get; }
        public IStatusService Status { get; }

        public RiotAPI([NotNull] string apiKey)
        {
            INetworkClient networkClient = new NetworkClient(apiKey);
            IDeserializer deserializer = new JsonDeserializer();
            
            Champions = new ChampionService(networkClient, deserializer);
            Summoners = new SummonerService(networkClient, deserializer);
            ChampionMasteries = new ChampionMasteryService(networkClient, deserializer);
            Leagues = new LeagueService(networkClient, deserializer);
            Status = new StatusService(networkClient, deserializer);
        }
    }
}