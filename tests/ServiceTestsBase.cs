using System;

namespace Rito.Tests
{
    public abstract class ServiceTestsBase
    {
        protected IRiotAPI RiotAPI { get; }

        protected ServiceTestsBase()
        {
            string key = Environment.GetEnvironmentVariable("RIOT_API_KEY");
            if (string.IsNullOrEmpty(key))
            {
                throw new InvalidOperationException("Failed to get RIOT_API_KEY from Environment");
            }
            RiotAPI = new RiotAPI(key);
        }
    }
}