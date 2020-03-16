using System;

namespace Rito.Tests
{
    public class ServiceTestsBase
    {
        protected RiotAPI RiotAPI { get; }

        protected ServiceTestsBase()
        {
            RiotAPI = new RiotAPI("RGAPI-c2932661-52c0-4f56-93ac-e2a4e4ea41ac");
        }
    }
}