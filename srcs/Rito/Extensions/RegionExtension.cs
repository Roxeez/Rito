using System.Collections.Generic;
using JetBrains.Annotations;
using Rito.Core;

namespace Rito.Extensions
{
    internal static class RegionExtension
    {
        private const string GlobalDomain = ".api.riotgames.com";
        private static readonly Dictionary<Region, string> _domains;

        static RegionExtension()
        {
            _domains = new Dictionary<Region, string>
            {
                [Region.EUW] = "euw1",
                [Region.BR] = "br1",
                [Region.JP] = "jp1",
                [Region.NA] = "na1",
                [Region.EUNE] = "eun1",
                [Region.KR] = "kr",
                [Region.RU] = "ru",
                [Region.TR] = "tr1",
                [Region.LAN] = "la1",
                [Region.LAS] = "la2",
                [Region.OCE] = "oc1",
            };
        }
        
        [NotNull]
        public static string GetDomain(this Region region) => $"{_domains.GetValueOrDefault(region)}{GlobalDomain}";
    }
}