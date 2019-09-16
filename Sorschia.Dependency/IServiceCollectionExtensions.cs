using Microsoft.Extensions.DependencyInjection;
using Sorschia.Security;
using System;

namespace Sorschia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSorschiaSessionVariables(this IServiceCollection instance, ServiceLifetime serviceLifetime)
        {
            switch (serviceLifetime)
            {
                case ServiceLifetime.Singleton: return instance.AddSingleton<ISessionVariables, SessionVariables>();
                case ServiceLifetime.Scoped: return instance.AddScoped<ISessionVariables, SessionVariables>();
                case ServiceLifetime.Transient: return instance.AddTransient<ISessionVariables, SessionVariables>();
                default: return instance;
            }
        }

        public static IServiceCollection AddSorschia(this IServiceCollection instance, Action<SorschiaDependencyConfiguration> configure = null)
        {
            void AddSecurity(SorschiaDependencyConfiguration.SecurityConfiguration securityConfiguration)
            {
                if (securityConfiguration.AddCryptor)
                {
                    instance.AddSingleton<ICryptor, SimpleCryptor>();
                }
            }

            var configuration = new SorschiaDependencyConfiguration();
            configure?.Invoke(configuration);

            if (configuration.AddDependencyProvider)
            {
                instance.AddSingleton<IDependencyProvider, DependencyProvider>();
            }

            AddSecurity(configuration.Security);

            return instance;
        }
    }
}
