using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using NFluent;
using Rito.Core;
using Rito.Services.Leagues;
using Rito.Tests.Data;
using Rito.Tests.Extensions;
using Xunit;
using Queue = Rito.Core.Queue;

namespace Rito.Tests.Services
{
    public class LeagueServiceTests : ServiceTestsBase
    {
        public static IEnumerable<object[]> Summoners = Database.GetSummoners();
        
        [Theory]
        [InlineData(Region.EUW, Queue.RANKED_SOLO_5x5)]
        [InlineData(Region.EUW, Queue.RANKED_FLEX_SR)]
        [InlineData(Region.EUNE, Queue.RANKED_SOLO_5x5)]
        [InlineData(Region.EUNE, Queue.RANKED_FLEX_SR)]
        public async Task Return_Challenger_League(Region region, Queue queue)
        {
            League league = await RiotAPI.Leagues.GetChallengerLeague(region, queue);
            
            Check.That(league).IsNotNull();
        }
        
        [Theory]
        [InlineData(Region.BR, Queue.RANKED_SOLO_5x5)]
        [InlineData(Region.BR, Queue.RANKED_FLEX_SR)]
        [InlineData(Region.KR, Queue.RANKED_SOLO_5x5)]
        [InlineData(Region.KR, Queue.RANKED_FLEX_SR)]
        public async Task Return_Grand_Master_League(Region region, Queue queue)
        {
            League league = await RiotAPI.Leagues.GetGrandMasterLeague(region, queue);
            
            Check.That(league).IsNotNull();
        }
        
        [Theory]
        [InlineData(Region.RU, Queue.RANKED_SOLO_5x5)]
        [InlineData(Region.RU, Queue.RANKED_FLEX_SR)]
        [InlineData(Region.NA, Queue.RANKED_SOLO_5x5)]
        [InlineData(Region.NA, Queue.RANKED_FLEX_SR)]
        public async Task Return_Master_League(Region region, Queue queue)
        {
            League league = await RiotAPI.Leagues.GetMasterLeague(region, queue);
            
            Check.That(league).IsNotNull();
        }
        
        [Theory]
        [InlineData(Region.EUW, Queue.RANKED_SOLO_5x5, Tier.DIAMOND, Division.I)]
        [InlineData(Region.EUW, Queue.RANKED_FLEX_SR, Tier.GOLD, Division.III)]
        [InlineData(Region.OCE, Queue.RANKED_SOLO_5x5, Tier.PLATINUM, Division.II)]
        [InlineData(Region.OCE, Queue.RANKED_FLEX_SR, Tier.SILVER, Division.IV)]
        public async Task Return_Correct_Leagues(Region region, Queue queue, Tier tier, Division division)
        {
            IEnumerable<LeagueEntry> leagues = await RiotAPI.Leagues.GetAllLeagues(region, queue, tier, division);

            Check.That(leagues).IsNotNull();
            Check.That(leagues).IsNotEmpty();
            Check.That(leagues).ContainsOnlyElementsThatMatch(x => x.QueueType == queue);
        }

        [Theory]
        [MemberData(nameof(Summoners))]
        public async Task Return_Correct_Summoner_Leagues(SummonerData summonerData)
        {
            IEnumerable<LeagueEntry> leagues = await RiotAPI.Leagues.GetSummonerLeagues(summonerData.Region, summonerData.Id);
            
            Check.That(leagues).IsNotNull();
        }
    }
}