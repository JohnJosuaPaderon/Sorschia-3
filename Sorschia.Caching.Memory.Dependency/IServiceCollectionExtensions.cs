using Microsoft.Extensions.DependencyInjection;
using Sorschia.Caching;

namespace Sorschia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSorschiaCache(this IServiceCollection instance)
        {
            return instance
                .AddMemoryCache()
                .AddSingleton<ISorschiaCache, SorschiaCache>();
        }
    }
}
