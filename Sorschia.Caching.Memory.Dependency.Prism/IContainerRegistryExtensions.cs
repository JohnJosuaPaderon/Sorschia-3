using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Prism.Ioc;
using Sorschia.Caching;

namespace Sorschia
{
    public static class IContainerRegistryExtensions
    {
        public static IContainerRegistry AddSorschiaCache(this IContainerRegistry instance)
        {
            return instance
                .RegisterSingleton<IMemoryCache, MemoryCache>()
                .RegisterSingleton<IOptions<MemoryCacheOptions>, MemoryCacheOptions>()
                .RegisterSingleton<ISorschiaCache, SorschiaCache>();
        }
    }
}
