using System.Threading.Tasks;
using Rito.Core;
using Rito.Services.Status;

namespace Rito.Services
{
    public interface IStatusService
    {
        Task<ShardStatus> GetRegionStatus(Region region);
    }
}