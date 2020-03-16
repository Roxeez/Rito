using System.Collections.Generic;
using System.Threading.Tasks;
using Rito.Core;
using Rito.Services.Leagues;

namespace Rito.Services
{
    public interface ILeagueService
    {
        Task<League> GetChallengerLeague(Region region, Queue queue);
        Task<League> GetGrandMasterLeague(Region region, Queue queue);
        Task<League> GetMasterLeague(Region region, Queue queue);
        Task<League> GetLeague(Region region, string leagueId);
        Task<IEnumerable<LeagueEntry>> GetSummonerLeagues(Region region, string encryptedSummonerId);
        Task<IEnumerable<LeagueEntry>> GetAllLeagues(Region region, Queue queue, Tier tier, Division division);
    }
}