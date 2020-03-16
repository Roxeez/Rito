using System.Threading.Tasks;
using JetBrains.Annotations;
using Rito.Core;
using Rito.Service.Summoners;

namespace Rito.Service
{
    /// <summary>
    /// Service allowing you to get summoner information from different way
    /// </summary>
    public interface ISummonerService
    {
        /// <summary>
        /// Get summoner information using summoner name
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="summonerName">Name of the summoner</param>
        /// <returns>Summoner with this name</returns>
        Task<Summoner> GetSummonerByName(Region region, [NotNull] string summonerName);

        /// <summary>
        /// Get summoner information using account id
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="encryptedAccountId">Encrypted account id of the summoner</param>
        /// <returns>Summoner with this account id</returns>
        Task<Summoner> GetSummonerByAccountId(Region region, [NotNull] string encryptedAccountId);
    }
}