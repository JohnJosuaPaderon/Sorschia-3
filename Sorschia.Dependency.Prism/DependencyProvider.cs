using Unity;

namespace Sorschia
{
    internal sealed class DependencyProvider : IDependencyProvider
    {
        public DependencyProvider(IUnityContainer container)
        {
            _container = container;
        }

        private readonly IUnityContainer _container;

        public T Get<T>(bool required = false)
        {
            var result = _container.Resolve<T>();

            if (required && result == null)
            {
                throw new SorschiaException($"Required: dependency: '{typeof(T).FullName}'");
            }

            return result;
        }
    }
}
