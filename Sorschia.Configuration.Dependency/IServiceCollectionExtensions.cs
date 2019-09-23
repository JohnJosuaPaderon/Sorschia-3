using Microsoft.Extensions.DependencyInjection;
using Sorschia.Data;
using System;

namespace Sorschia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSorschiaConfiguration(this IServiceCollection instance, Action<SorschiaConfigurationDependencySettings> configure = null)
        {
            var settings = new SorschiaConfigurationDependencySettings();
            configure?.Invoke(settings);

            if (settings.AddConnectionStringProvider)
            {
                instance.AddSingleton<IConnectionStringProvider, ConnectionStringProvider>();
            }

            return instance;
        }
    }
}
