using System;

namespace Sorschia.Caching
{
    public interface ISorschiaCache
    {
        object Save(string key, object value, TimeSpan? expiration = null, bool continueOnNull = false);
        object Save(string key, object value, long? expirationSeconds = null, bool continueOnNull = false);
        T Save<T>(string key, T value, TimeSpan? expiration = null, bool continueOnDefault = false);
        T Save<T>(string key, T value, long? expirationSeconds = null, bool continueOnDefault = false);
        void Remove(string key);
        bool Exists(string key);
        bool Exists(string key, out object value);
        bool Exists<T>(string key, out T value);
    }
}
