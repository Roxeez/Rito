using System.Collections.Generic;
using System.Threading.Tasks;
using NFluent;
using Rito.Core;
using Rito.Services.Summoners;
using Xunit;

namespace Rito.Tests.Services
{
    public class SummonerServiceTests : ServiceTestsBase
    {
        public static IEnumerable<object[]> GetSummonerData()
        {
            var data = new List<object[]>
            {
                new object[]
                {
                    Region.EUW, 
                    "That Was Easy", 
                    "FHw29MQwOU4Itx_32zorCJ87lZWmCVoy41zMpfO_ZGO-C5M", 
                    "R2GmO_0NpEdDPsVYx64r3xl906UGYh-YOdrmONJwjqY9v9w", 
                    "cXmg22Rc4UDeukcbWoRTKK-jG1_yHK5o6PLGkXasA1d66clhsKhqZGus5bNvE9WdGh_SM_a8DuIJNg"
                },
                new object[]
                {
                    Region.EUW, 
                    "GKO Roxeez", 
                    "tnHL2neAlPlGgJzhg4y72KpFUhnRr3q5vU6c74DF2FrzP69Loibli57s", 
                    "Xd-jS2Xj32hjmRI828ZFYXKoOvc-uzPcDjMmsI7CFhMKK8li",
                    "zC7RBUITKa-RPuJOW_aieqGcUPx9X-9U3AtleCYd-PzxZXCu2M97Xk5Ez3CwFwe6yK9LvDcW1jbh9g"
                },
                new object[]
                {
                    Region.EUW, 
                    "GKO Frozen", 
                    "qX7S3AkArB2U9_el9NL-YxQnpbca6Z9MzaeolV19UA2hZQ", 
                    "X8JLTE1H_J-CNJRw3v6PIRB5cJZ4aBgfae8xvVQjX7K2qf0",
                    "7ff0UmSDQO3faqhsQ8R-ZgvSV-fWYaOi_Is9saHP8L4XY5DHPJb9A2JcmZWl2Ny4hunKf0Oe-i8M2w"
                },
                new object[]
                {
                    Region.EUW, 
                    "GKO Frozen v2", 
                    "hZdqKwRUf8srGBklathJFx9pw9yb3m97zzdVI1aMG3Ey90E", 
                    "gFiIDV410xvKhYsVdosF8Arl8RiNC9Sd62CrXGtBvbDEJJKs",
                    "O6YBN9Sml-xkrNMVHoX6R0jaT8ILHXMogEyJyyP4S8abZr7rnM83TYDJWO5QaGtoZuhinhZDwhoyVQ"
                },
                new object[]
                {
                    Region.EUW, 
                    "OmiRo", 
                    "FdUORKzO3pZZ39oNOfJm1VGnuVw2vA7Jzaz2ixhY12begzg", 
                    "24a6lWGr0Gu4nrJ9D5_5JVVAgkMz6CvL2NwnlaVq0AfHBGQ",
                    "FsOrx0wJKBkqZiE7DFngMWMK0d6n3VluRh9IdeXgTvwyt8AIDu-ZYlNI1z0EJUxZIm7mu1nzbXoy4w"
                }
            };

            return data;
        }
        
        [Theory]
        [MemberData(nameof(GetSummonerData))]
        public async Task Return_Correct_Summoner_Using_Name(Region region, string summonerName, string accountId, string summonerId, string puuid)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerByName(region, summonerName);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo(summonerName);
            Check.That(summoner.AccountId).IsEqualTo(accountId);
            Check.That(summoner.Id).IsEqualTo(summonerId);
            Check.That(summoner.PUUID).IsEqualTo(puuid);
        }

        [Theory]
        [MemberData(nameof(GetSummonerData))]
        public async Task Return_Correct_Summoner_Using_Account_Id(Region region, string summonerName, string accountId, string summonerId, string puuid)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerByAccountId(region, accountId);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo(summonerName);
            Check.That(summoner.AccountId).IsEqualTo(accountId);
            Check.That(summoner.Id).IsEqualTo(summonerId);
            Check.That(summoner.PUUID).IsEqualTo(puuid);
        }
        
        [Theory]
        [MemberData(nameof(GetSummonerData))]
        public async Task Return_Correct_Summoner_Using_Summoner_Id(Region region, string summonerName, string accountId, string summonerId, string puuid)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerBySummonerId(region, summonerId);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo(summonerName);
            Check.That(summoner.AccountId).IsEqualTo(accountId);
            Check.That(summoner.Id).IsEqualTo(summonerId);
            Check.That(summoner.PUUID).IsEqualTo(puuid);
        }

        [Theory]
        [MemberData(nameof(GetSummonerData))]
        public async Task Return_Correct_Summoner_Using_PUUID(Region region, string summonerName, string accountId, string summonerId, string puuid)
        {
            Summoner summoner = await RiotAPI.Summoners.GetSummonerByPUUID(region, puuid);

            Check.That(summoner).IsNotNull();
            Check.That(summoner.Name.Trim()).IsEqualTo(summonerName);
            Check.That(summoner.AccountId).IsEqualTo(accountId);
            Check.That(summoner.Id).IsEqualTo(summonerId);
            Check.That(summoner.PUUID).IsEqualTo(puuid);
        }
    }
}