using System.Collections.Generic;
using JetBrains.Annotations;
using Rito.Core;

namespace Rito.Extensions
{
    public static class RegionExtension
    {
        private const string PlatformDomain = ".api.riotgames.com";
        private static readonly Dictionary<Region, string> _platforms;

        static RegionExtension()
        {
            _platforms = new Dictionary<Region, string>
            {
                [Region.Euw] = "euw1"
            };
        }
        
        [NotNull]
        public static string GetPlatform(this Region region) => $"{_platforms.GetValueOrDefault(region)}{PlatformDomain}";
    }
}