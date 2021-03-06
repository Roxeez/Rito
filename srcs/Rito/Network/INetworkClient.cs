﻿using System.Threading.Tasks;
using JetBrains.Annotations;
using Rito.Core;

namespace Rito.Network
{
    public interface INetworkClient
    {
        
        [NotNull]
        Task<string> SendGetRequest([NotNull] string url, [NotNull] params object[] parameters);
        
        [NotNull]
        Task<string> SendGetRequest(Region region, [NotNull] string url, [NotNull] params object[] parameters);
    }
}