using System;
using Microsoft.Extensions.DependencyInjection;

namespace Sorschia
{
    internal sealed class DependencyProvider : IDependencyProvider
    {
        public DependencyProvider(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private readonly IServiceProvider _serviceProvider;

        public T Get<T>(bool required = false)
        {
            var result = _serviceProvider.GetService<T>();

            if (required && result == null)
            {
                throw new SorschiaException($"Required dependency: '{typeof(T).FullName}'");
            }

            return result;
        }
    }
}
