using Sorschia.Caching;
using Sorschia.SystemBase.Security.Entities;
using Sorschia.SystemBase.Security.Processes;
using System.Threading;
using System.Threading.Tasks;

namespace Sorschia.SystemBase.Security
{
    internal sealed class SystemBaseSecurityRepository : CachedRepositoryBase, ISystemBaseSecurityRepository
    {
        public SystemBaseSecurityRepository(IDependencyProvider dependencyProvider, ISorschiaCache cache, SystemBaseSecurityConfiguration configuration) : base(dependencyProvider, cache)
        {
            _configuration = configuration;
        }

        private readonly SystemBaseSecurityConfiguration _configuration;

        public async Task<bool> DeleteModuleAsync(DeleteModuleModel model, CancellationToken cancellationToken = default)
        {
            var cacheKey = CreateCacheKey<DeleteModuleModel, bool>(model);

            if (TryGetFromCache(cacheKey, out bool result))
            {
                return result;
            }

            using (var process = GetProcess<IDeleteModule>())
            {
                process.Model = model;
                return TrySaveToCache(cacheKey, await process.ExecuteAsync(cancellationToken), _configuration.CacheExpiration.DeleteModule);
            }
        }

        public Task<Module> GetModuleAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<Permission> GetPermissionAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }

        public Task<User> GetUserAsync(int id, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
