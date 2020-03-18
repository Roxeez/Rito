using System.Collections.Generic;
using System.Threading.Tasks;
using NFluent;
using Rito.Services.Matches;
using Rito.Tests.Data;
using Xunit;

namespace Rito.Tests.Services
{
    public class MatchServiceTests : ServiceTestsBase
    {
        public static IEnumerable<object[]> Summoners = Database.GetSummoners();
        
        [Theory]
        [MemberData(nameof(Summoners))]
        public async Task Return_Correct_Matchlist(SummonerData summonerData)
        {
            Matchlist matchlist = await RiotAPI.Matches.GetMatchlist(summonerData.Region, summonerData.AccountId);

            Check.That(matchlist).IsNotNull();
        }
    }
}