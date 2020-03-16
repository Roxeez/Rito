namespace Rito.Tests
{
    public abstract class ServiceTests
    {
        protected RiotAPI RiotAPI { get; }

        protected ServiceTests()
        {
            RiotAPI = new RiotAPI("RGAPI-c2932661-52c0-4f56-93ac-e2a4e4ea41ac");
        }
    }
}