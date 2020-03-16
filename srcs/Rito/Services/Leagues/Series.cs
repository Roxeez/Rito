namespace Rito.Services.Leagues
{
    public class Series
    {
        public string Progress { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public int Target { get; private set; }
    }
}