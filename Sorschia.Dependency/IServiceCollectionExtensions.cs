using Microsoft.Extensions.DependencyInjection;

namespace Sorschia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSorschia(this IServiceCollection instance)
        {
            return instance
                .AddSingleton<IDependencyProvider, DependencyProvider>();
        }
    }
}
