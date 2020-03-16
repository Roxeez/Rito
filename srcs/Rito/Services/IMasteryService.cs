using System.Collections.Generic;
using System.Threading.Tasks;
using Rito.Core;
using Rito.Services.Masteries;

namespace Rito.Services
{
    public interface IMasteryService
    {
        /// <summary>
        /// Get all champion mastery entries sorted by number of champion points descending
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="encryptedSummonerId">Summoner ID associated with the player</param>
        /// <returns>All mastery of this summoner</returns>
        Task<IEnumerable<Mastery>> GetMasteries(Region region, string encryptedSummonerId);
        
        /// <summary>
        /// Get a champion mastery by player ID and champion ID
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="encryptedSummonerId">Summoner ID associated with the player</param>
        /// <param name="championId">Champion ID to retrieve Champion Mastery for</param>
        /// <returns>Summoner mastery for this champion</returns>
        Task<Mastery> GetMastery(Region region, string encryptedSummonerId, long championId);
        
        /// <summary>
        /// Get a player's total champion mastery score, which is the sum of individual champion mastery levels
        /// </summary>
        /// <param name="region">Region on which the summoner is located</param>
        /// <param name="encryptedSummonerId">Summoner ID associated with the player</param>
        /// <returns>Total champion mastery score for this summoner</returns>
        Task<int> GetTotalMasteryScore(Region region, string encryptedSummonerId);
    }
}