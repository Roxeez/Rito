using System.Threading.Tasks;
using JetBrains.Annotations;
using Rito.Core;

namespace Rito.Network
{
    public interface INetworkClient
    {
        [NotNull]
        Task<string> SendGetRequest([NotNull] string url, Region region, [CanBeNull] params string[] parameters);

        [NotNull]
        Task<string> SendGetRequest([NotNull] string url, [CanBeNull] params string[] parameters);

        [NotNull]
        Task<string> SendFormattedGetRequest([NotNull] string url, [NotNull] params object[] parameters);
        
        [NotNull]
        Task<string> SendFormattedGetRequest([NotNull] string url, Region region, [NotNull] params object[] parameters);
    }
}