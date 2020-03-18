using System.Threading.Tasks;
using NFluent;
using Rito.Core;
using Rito.Services.Status;
using Rito.Tests.Extensions;
using Xunit;

namespace Rito.Tests.Services
{
    public class StatusServiceTests : ServiceTestsBase
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
        public async Task Return_Correct_Region_Status(Region region)
        {
            ShardStatus status = await RiotAPI.Statuses.GetRegionStatus(region);

            Check.That(status).IsNotNull();
            Check.That(status.Services).IsNotEmpty();
            Check.That(status.Locales).IsNotEmpty();
        }
    }
}