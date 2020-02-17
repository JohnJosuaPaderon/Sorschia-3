using Sorschia.SystemBase.Security.Entities;
using Sorschia.SystemBase.Security.Processes;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.SystemBase.Security
{
    public interface ISystemBaseSecurityRepository
    {
        Task<bool> DeleteModuleAsync(DeleteModuleModel model, CancellationToken cancellationToken = default);
        Task<bool> DeletePermissionAsync(
        Task<Module> GetModuleAsync(int id, CancellationToken cancellationToken = default);
        Task<Permission> GetPermissionAsync(int id, CancellationToken cancellationToken = default);
        Task<User> GetUserAsync(int id, CancellationToken cancellationToken = default);
    }
}
