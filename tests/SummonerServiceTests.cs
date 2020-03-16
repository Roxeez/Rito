using System.Threading.Tasks;
using NFluent;
using Rito.Core;
using Rito.Service.Summoners;
using Xunit;

namespace Rito.Tests
{
    public sealed class SummonerServiceTests : ServiceTestsBase
    {
        [Theory]
        [InlineData(Region.EUW, "That Was Easy")]
        [InlineData(Region.EUW, "OmiRo")]
        public async Task Return_Correct_Summoner_Using_Summoner_Name(Region region, string summonerName)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerByName(region, summonerName);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo("That Was Easy");
        }
    }
}