namespace Rito.Tests
{
    public abstract class ServiceTestsBase
    {
        protected RiotAPI RiotAPI { get; }

        protected ServiceTestsBase()
        {
            RiotAPI = new RiotAPI("RGAPI-219b9e41-5359-475e-8dfc-1b624de94736");
        }
    }
}