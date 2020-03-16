using JetBrains.Annotations;
using Rito.Core.Serialization;
using Rito.Network;
using Rito.Services;
using Rito.Services.Champions;
using Rito.Services.Leagues;
using Rito.Services.Masteries;
using Rito.Services.Summoners;

namespace Rito
{
    public sealed class RiotAPI
    {
        [NotNull]
        public IChampionService Champions { get; }
        
        [NotNull]
        public ISummonerService Summoners { get; }
        
        [NotNull]
        public IMasteryService Masteries { get; }
        
        [NotNull]
        public ILeagueService Leagues { get; }

        public RiotAPI([NotNull] string apiKey)
        {
            INetworkClient networkClient = new NetworkClient(apiKey);
            IDeserializer deserializer = new JsonDeserializer();
            
            Champions = new ChampionService(networkClient, deserializer);
            Summoners = new SummonerService(networkClient, deserializer);
            Masteries = new MasteryService(networkClient, deserializer);
            Leagues = new LeagueService(networkClient, deserializer);
        }
    }
}