using Prism.Ioc;

namespace Sorschia
{
    internal sealed class DependencyProvider : IDependencyProvider
    {
        public DependencyProvider(IContainerProvider containerProvider)
        {
            _containerProvider = containerProvider;
        }

        private readonly IContainerProvider _containerProvider;

        public T Get<T>(bool required = false)
        {
            var result = _containerProvider.Resolve<T>();

            if (required && result == null)
            {
                throw new SorschiaException($"Required dependency: '{typeof(T).FullName}'");
            }

            return result;
        }
    }
}
