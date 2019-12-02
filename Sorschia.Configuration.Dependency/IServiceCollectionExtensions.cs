using Microsoft.Extensions.DependencyInjection;
using Sorschia.Data;
using System;

namespace Sorschia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSorschiaConfiguration(this IServiceCollection instance, Action<DependencySettings> configure = null)
        {
            var settings = new DependencySettings();
            configure?.Invoke(settings);

            if (settings.AddConnectionStringProvider)
            {
                instance.AddSingleton<IConnectionStringProvider, ConnectionStringProvider>();
            }

            return instance;
        }
    }
}
