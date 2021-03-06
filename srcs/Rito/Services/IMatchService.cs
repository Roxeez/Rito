﻿using System.Threading.Tasks;
using Rito.Core;
using Rito.Services.Matches;

namespace Rito.Services
{
    public interface IMatchService
    {
        Task<Match> GetMatch(Region region, long matchId);
        Task<Matchlist> GetMatchlist(Region region, string encryptedAccountId);
    }
}