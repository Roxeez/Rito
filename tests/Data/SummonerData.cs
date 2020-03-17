using Rito.Core;

namespace Rito.Tests.Data
{
    public class SummonerData
    {
        public Region Region { get; }
        public string Name { get; }
        public string Id { get; }
        public string AccountId { get; }
        public string PUUID { get; }

        public SummonerData(Region region, string summonerName, string summonerId, string accountId, string puuid)
        {
            Region = region;
            Name = summonerName;
            Id = summonerId;
            AccountId = accountId;
            PUUID = puuid;
        }
    }
}