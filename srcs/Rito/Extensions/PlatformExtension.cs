using System.Collections.Generic;
using JetBrains.Annotations;
using Rito.Core;

namespace Rito.Extensions
{
    internal static class PlatformExtension
    {
        private const string PlatformDomain = ".api.riotgames.com";
        private static readonly Dictionary<Region, string> _platforms;

        static PlatformExtension()
        {
            _platforms = new Dictionary<Region, string>
            {
                [Region.EUW] = "euw1"
            };
        }
        
        [NotNull]
        public static string GetPlatform(this Region region) => $"{_platforms.GetValueOrDefault(region)}{PlatformDomain}";
    }
}