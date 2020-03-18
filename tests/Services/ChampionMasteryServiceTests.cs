using System.Collections.Generic;
using System.Threading.Tasks;
using NFluent;
using Rito.Services.Masteries;
using Rito.Tests.Data;
using Rito.Tests.Extensions;
using Xunit;

namespace Rito.Tests.Services
{
    public class ChampionMasteryServiceTests : ServiceTestsBase
    {
        public static IEnumerable<object[]> Summoners = Database.GetSummoners();
        
        [Theory]
        [MemberData(nameof(Summoners))]
        public async Task Return_Correct_Total_Mastery_Score(SummonerData summonerData)
        {
            int score = await RiotAPI.ChampionMasteries.GetTotalMasteryScore(summonerData.Region, summonerData.Id);

            Check.That(score).IsNotZero();
        }

        [Theory]
        [MemberData(nameof(Summoners))]
        public async Task Return_All_Masteries(SummonerData summonerData)
        {
            IEnumerable<ChampionMastery> masteries = await RiotAPI.ChampionMasteries.GetMasteries(summonerData.Region, summonerData.Id);
            
            Check.That(masteries).IsNotEmpty();
        }
    }
}