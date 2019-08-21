namespace Sorschia
{
    /// <summary>
    /// Represents a resolver of dependency used by Sorschia
    /// </summary>
    public interface IDependencyProvider
    {
        /// <summary>
        /// Return an instance of type of <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Get<T>();
    }
}
