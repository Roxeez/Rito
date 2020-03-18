using JetBrains.Annotations;
using Rito.Services;

namespace Rito
{
    public interface IRiotAPI
    {
        [NotNull]
        public IChampionService Champions { get; }
        
        [NotNull]
        public ISummonerService Summoners { get; }
        
        [NotNull]
        public IChampionMasteryService ChampionMasteries { get; }
        
        [NotNull]
        public ILeagueService Leagues { get; }
        
        [NotNull]
        public IStatusService Statuses { get; }
        
        [NotNull]
        public IMatchService Matches { get; }
    }
}