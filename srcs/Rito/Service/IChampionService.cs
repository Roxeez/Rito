﻿using System.Threading.Tasks;
using Rito.Core;
using Rito.Service.Champions;

namespace Rito.Service
{
    /// <summary>
    /// Service allowing you to get information about champion rotation etc..
    /// </summary>
    public interface IChampionService
    {
        /// <summary>
        /// Get region current champion rotation
        /// </summary>
        /// <param name="region">Region on which you want to get the rotation</param>
        /// <returns>Current champion rotation on this region</returns>
        Task<ChampionRotation> GetChampionRotation(Region region);
    }
}