using Microsoft.Extensions.DependencyInjection;
using Sorschia.Security;
using System;

namespace Sorschia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddSorschia(this IServiceCollection instance, Action<DependencySettings> configure = null)
        {
            void AddSecurity(DependencySettings.SecuritySection security)
            {
                if (security.AddCryptor)
                {
                    instance.AddSingleton<ICryptor, SimpleCryptor>();
                }
            }

            var settings = new DependencySettings();
            configure?.Invoke(settings);

            if (settings.AddDependencyProvider)
            {
                instance.AddSingleton<IDependencyProvider, DependencyProvider>();
            }

            // Obsolete: Version 0.3.0
            //if (settings.AddSessionVariables)
            //{
            //    switch (settings.SessionVariablesLifetime)
            //    {
            //        case ServiceLifetime.Singleton:
            //            instance.AddSingleton<ISessionVariables, SessionVariables>();
            //            break;
            //        case ServiceLifetime.Scoped:
            //            instance.AddScoped<ISessionVariables, SessionVariables>();
            //            break;
            //        case ServiceLifetime.Transient:
            //            instance.AddTransient<ISessionVariables, SessionVariables>();
            //            break;
            //        default: throw new SorschiaException($"Unsupported value of type of '{typeof(ServiceLifetime).FullName}'");
            //    }
            //}

            AddSecurity(settings.Security);

            return instance;
        }
    }
}
