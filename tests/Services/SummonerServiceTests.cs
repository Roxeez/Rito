using System.Collections.Generic;
using System.Threading.Tasks;
using NFluent;
using Rito.Core;
using Rito.Services.Summoners;
using Rito.Tests.Data;
using Xunit;

namespace Rito.Tests.Services
{
    public class SummonerServiceTests : ServiceTestsBase
    {
        public static IEnumerable<object[]> Summoners = Database.GetSummoners();
        
        [Theory]
        [MemberData(nameof(Summoners))]
        public async Task Return_Correct_Summoner_Using_Name(SummonerData summonerData)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerByName(summonerData.Region, summonerData.Name);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo(summonerData.Name);
            Check.That(summoner.AccountId).IsEqualTo(summonerData.AccountId);
            Check.That(summoner.Id).IsEqualTo(summonerData.Id);
            Check.That(summoner.PUUID).IsEqualTo(summonerData.PUUID);
        }

        [Theory]
        [MemberData(nameof(Summoners))]
        public async Task Return_Correct_Summoner_Using_Account_Id(SummonerData summonerData)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerByAccountId(summonerData.Region, summonerData.AccountId);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo(summonerData.Name);
            Check.That(summoner.AccountId).IsEqualTo(summonerData.AccountId);
            Check.That(summoner.Id).IsEqualTo(summonerData.Id);
            Check.That(summoner.PUUID).IsEqualTo(summonerData.PUUID);
        }
        
        [Theory]
        [MemberData(nameof(Summoners))]
        public async Task Return_Correct_Summoner_Using_Summoner_Id(SummonerData summonerData)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerBySummonerId(summonerData.Region, summonerData.Id);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo(summonerData.Name);
            Check.That(summoner.AccountId).IsEqualTo(summonerData.AccountId);
            Check.That(summoner.Id).IsEqualTo(summonerData.Id);
            Check.That(summoner.PUUID).IsEqualTo(summonerData.PUUID);
        }

        [Theory]
        [MemberData(nameof(Summoners))]
        public async Task Return_Correct_Summoner_Using_PUUID(SummonerData summonerData)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerByPUUID(summonerData.Region, summonerData.PUUID);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo(summonerData.Name);
            Check.That(summoner.AccountId).IsEqualTo(summonerData.AccountId);
            Check.That(summoner.Id).IsEqualTo(summonerData.Id);
            Check.That(summoner.PUUID).IsEqualTo(summonerData.PUUID);
        }
    }
}