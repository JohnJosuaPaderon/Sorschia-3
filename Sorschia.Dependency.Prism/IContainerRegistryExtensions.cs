using Prism.Ioc;
using Sorschia.Security;
using System;

namespace Sorschia
{
    public static class IContainerRegistryExtensions
    {
        public static IContainerRegistry AddSorschia(this IContainerRegistry instance, Action<SorschiaDependencySettings> configure = null)
        {
            void AddSecurity(SorschiaDependencySettings.SecuritySettings securitySettings)
            {
                if (securitySettings.AddCryptor)
                {
                    instance.RegisterSingleton<ICryptor, SimpleCryptor>();
                }
            }

            var settings = new SorschiaDependencySettings();
            configure?.Invoke(settings);

            if (settings.AddDependencyProvider)
            {
                instance.RegisterSingleton<IDependencyProvider, DependencyProvider>();
            }

            if (settings.AddSessionVariables)
            {
                instance.RegisterSingleton<ISessionVariables, SessionVariables>();
            }

            AddSecurity(settings.Security);

            return instance;
        }
    }
}
