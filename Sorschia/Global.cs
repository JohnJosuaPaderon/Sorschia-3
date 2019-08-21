using System;

namespace Sorschia
{
    /// <summary>
    /// Exposes globally used variables
    /// </summary>
    public static class Global
    {
        private static Func<IDependencyProvider> _initializeDependencyProvider;

        private static IDependencyProvider _dependencyProvider;

        /// <summary>
        /// Gets the dependency provider
        /// </summary>
        public static IDependencyProvider DependencyProvider
        {
            get => TryGet(ref _dependencyProvider, _initializeDependencyProvider);
        }

        private static T TryGet<T>(ref T backingField, Func<T> initialize)
        {
            if (Equals(backingField, default(T)) && initialize != null)
            {
                backingField = initialize();
            }

            return backingField;
        }

        /// <summary>
        /// Set an initializer for <see cref="DependencyProvider"/>
        /// </summary>
        /// <param name="initialize"></param>
        public static void Initialize(Func<IDependencyProvider> initialize)
        {
            _initializeDependencyProvider = initialize ?? throw new SorschiaException("Initialize function cannot be null.");
        }
    }
}
