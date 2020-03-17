using System.Collections.Generic;
using Rito.Core;
using Rito.Tests.Data;

namespace Rito.Tests
{
    public static class Database
    {
        public static IEnumerable<object[]> GetSummoners()
        {
            var data = new List<object[]>
            {
                new object[]
                {
                    new SummonerData(Region.EUW, "That Was Easy", "R2GmO_0NpEdDPsVYx64r3xl906UGYh-YOdrmONJwjqY9v9w", "FHw29MQwOU4Itx_32zorCJ87lZWmCVoy41zMpfO_ZGO-C5M", "cXmg22Rc4UDeukcbWoRTKK-jG1_yHK5o6PLGkXasA1d66clhsKhqZGus5bNvE9WdGh_SM_a8DuIJNg")
                },
                new object[]
                {
                    new SummonerData(Region.EUW, "GKO Roxeez", "Xd-jS2Xj32hjmRI828ZFYXKoOvc-uzPcDjMmsI7CFhMKK8li", "tnHL2neAlPlGgJzhg4y72KpFUhnRr3q5vU6c74DF2FrzP69Loibli57s", "zC7RBUITKa-RPuJOW_aieqGcUPx9X-9U3AtleCYd-PzxZXCu2M97Xk5Ez3CwFwe6yK9LvDcW1jbh9g")
                },
                new object[]
                {
                    new SummonerData(Region.EUW, "firweer", "pP27h6ZvbUrHhxg-X339klSkWR1QXxwjAeVr712Ji1k_S9rw", "uJBM2E6plWaiH_22hlnEq9Vct427nOf9hRB2R8D-H2zo37uLaJK_ZDrb", "5tyRnUrvyWy9K99Fh6M_SHEDBA_8KV8nxIPcoeBxwNUSdiN0_TnG4pT8DkQXb2DtCOGIoy4DfoaZ0Q")
                },
                new object[]
                {
                    new SummonerData(Region.EUW, "GKO Frozen v2", "gFiIDV410xvKhYsVdosF8Arl8RiNC9Sd62CrXGtBvbDEJJKs", "hZdqKwRUf8srGBklathJFx9pw9yb3m97zzdVI1aMG3Ey90E", "O6YBN9Sml-xkrNMVHoX6R0jaT8ILHXMogEyJyyP4S8abZr7rnM83TYDJWO5QaGtoZuhinhZDwhoyVQ"),
                },
                new object[]
                {
                    new SummonerData(Region.EUW, "OmiRo", "24a6lWGr0Gu4nrJ9D5_5JVVAgkMz6CvL2NwnlaVq0AfHBGQ", "FdUORKzO3pZZ39oNOfJm1VGnuVw2vA7Jzaz2ixhY12begzg", "FsOrx0wJKBkqZiE7DFngMWMK0d6n3VluRh9IdeXgTvwyt8AIDu-ZYlNI1z0EJUxZIm7mu1nzbXoy4w")
                }
            };

            return data;
        }
    }
}