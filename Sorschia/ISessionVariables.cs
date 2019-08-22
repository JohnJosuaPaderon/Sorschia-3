namespace Sorschia
{
    public interface ISessionVariables
    {
        object this[string key] { get; set; }
        bool TryGetValue(string key, out object result);
        bool TryGetValue<T>(string key, out T result);
        void AddOrUpdate(string key, object value);
    }
}
