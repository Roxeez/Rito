using System.Threading.Tasks;
using NFluent;
using Rito.Core;
using Rito.Services.Champions;
using Rito.Tests.Extensions;
using Xunit;

namespace Rito.Tests.Services
{
    public class ChampionServiceTests : ServiceTestsBase
    {
        [Theory]
        [InlineData(Region.EUW)]
        [InlineData(Region.BR)]
        [InlineData(Region.JP)]
        [InlineData(Region.KR)]
        [InlineData(Region.NA)]
        [InlineData(Region.RU)]
        [InlineData(Region.TR)]
        [InlineData(Region.LAN)]
        [InlineData(Region.LAS)]
        [InlineData(Region.OCE)]
        [InlineData(Region.EUNE)]
        public async void Return_Correct_Champion_Rotation(Region region)
        {
            ChampionRotation rotation = await RiotAPI.Champions.GetChampionRotation(region);

            Check.That(rotation).IsNotNull();
            Check.That(rotation.FreeChampions).IsNotEmpty();
            Check.That(rotation.FreeChampionsForNewPlayers).IsNotEmpty();
            Check.That(rotation.MaxNewPlayerLevel).IsStrictlyGreaterThan(0);
        }
    }
}