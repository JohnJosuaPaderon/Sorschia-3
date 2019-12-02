using Prism.Ioc;
using Sorschia.Security;
using System;

namespace Sorschia
{
    public static class IContainerRegistryExtensions
    {
        public static IContainerRegistry AddSorschia(this IContainerRegistry instance, Action<DependencySettings> configure = null)
        {
            void AddSecurity(DependencySettings.SecuritySection security)
            {
                if (security.AddCryptor)
                {
                    instance.RegisterSingleton<ICryptor, SimpleCryptor>();
                }
            }

            var settings = new DependencySettings();
            configure?.Invoke(settings);

            if (settings.AddDependencyProvider)
            {
                instance.RegisterSingleton<IDependencyProvider, DependencyProvider>();
            }

            // Obsolete: Version 0.3.0
            //if (settings.AddSessionVariables)
            //{
            //    instance.RegisterSingleton<ISessionVariables, SessionVariables>();
            //}

            AddSecurity(settings.Security);

            return instance;
        }
    }
}
