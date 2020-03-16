using System.Threading.Tasks;
using JetBrains.Annotations;
using Rito.Core;
using Rito.Services.Summoners;

namespace Rito.Services
{
    /// <summary>
    /// Service allowing you to get summoner information from different way
    /// </summary>
    public interface ISummonerService
    {
        /// <summary>
        /// Get a summoner by summoner name
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="summonerName">Name of the summoner</param>
        /// <returns>Summoner with this name</returns>
        [NotNull]
        Task<Summoner> GetSummonerByName(Region region, [NotNull] string summonerName);

        /// <summary>
        /// Get a summoner by account ID
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="encryptedAccountId">Encrypted account id</param>
        /// <returns>Summoner with this account id</returns>
        [NotNull]
        Task<Summoner> GetSummonerByAccountId(Region region, [NotNull] string encryptedAccountId);

        /// <summary>
        /// Get a summoner by summoner ID
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="encryptedSummonerId">Encrypted summoner id</param>
        /// <returns>Summoner with this summoner id</returns>
        [NotNull]
        Task<Summoner> GetSummonerBySummonerId(Region region, [NotNull] string encryptedSummonerId);

        /// <summary>
        /// Get a summoner by PUUID
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="encryptedPUUID">Encrypted summoner PUUID</param>
        /// <returns>Summoner with this PUUID</returns>
        [NotNull]
        Task<Summoner> GetSummonerByPUUID(Region region, [NotNull] string encryptedPUUID);
    }
}