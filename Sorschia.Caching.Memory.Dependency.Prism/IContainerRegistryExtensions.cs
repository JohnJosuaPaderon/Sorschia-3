using Prism.Ioc;
using Sorschia.Caching;

namespace Sorschia
{
    public static class IContainerRegistryExtensions
    {
        public static IContainerRegistry AddSorschiaCache(this IContainerRegistry instance)
        {
            return instance
                .RegisterSingleton<ISorschiaCache, SorschiaCache>();
        }
    }
}
