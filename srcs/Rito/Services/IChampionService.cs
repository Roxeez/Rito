using System.Threading.Tasks;
using Rito.Core;
using Rito.Services.Champions;

namespace Rito.Services
{
    /// <summary>
    /// Service allowing you to get information about champion rotation etc..
    /// </summary>
    public interface IChampionService
    {
        /// <summary>
        /// Returns champion rotations, including free-to-play and low-level free-to-play rotations
        /// </summary>
        /// <param name="region">Region on which you want to get the rotation</param>
        /// <returns>Current champion rotation on this region</returns>
        Task<ChampionRotation> GetChampionRotation(Region region);
    }
}