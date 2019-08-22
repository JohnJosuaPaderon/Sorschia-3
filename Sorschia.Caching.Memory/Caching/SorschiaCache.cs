using Microsoft.Extensions.Caching.Memory;
using System;

namespace Sorschia.Caching
{
    internal sealed class SorschiaCache : ISorschiaCache
    {
        public SorschiaCache(IMemoryCache cache)
        {
            _cache = cache;
        }

        private readonly IMemoryCache _cache;

        private TimeSpan? GetExpirationFromSeconds(long? expirationSeconds)
        {
            if (expirationSeconds != null)
            {
                return TimeSpan.FromSeconds(expirationSeconds ?? 0);
            }

            return null;
        }

        private void ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new SorschiaCachingException($"Parameter '{key}' is null or white space.");
            }
        }

        public bool Exists(string key)
        {
            ValidateKey(key);

            lock (_cache)
            {
                return _cache.TryGetValue(key, out _);
            }
        }

        public bool Exists(string key, out object value)
        {
            ValidateKey(key);

            lock (_cache)
            {
                return _cache.TryGetValue(key, out value);
            }
        }

        public bool Exists<T>(string key, out T value)
        {
            ValidateKey(key);

            lock (_cache)
            {
                return _cache.TryGetValue(key, out value);
            }
        }

        public void Remove(string key)
        {
            ValidateKey(key);

            lock (_cache)
            {
                _cache.Remove(key);
            }
        }

        public object Save(string key, object value, TimeSpan? expiration = null, bool continueOnNull = false)
        {
            ValidateKey(key);

            lock (_cache)
            {
                if (continueOnNull || value != null)
                {
                    if (expiration != null)
                    {
                        _cache.Set(key, value, expiration.Value);
                    }
                    else
                    {
                        _cache.Set(key, value);
                    }
                }
            }

            return value;
        }

        public object Save(string key, object value, long? expirationSeconds = null, bool continueOnNull = false)
        {
            return Save(key, value, GetExpirationFromSeconds(expirationSeconds), continueOnNull);
        }

        public T Save<T>(string key, T value, TimeSpan? expiration = null, bool continueOnDefault = false)
        {
            ValidateKey(key);

            lock (_cache)
            {
                if (continueOnDefault || !Equals(value, default(T)))
                {
                    if (expiration != null)
                    {
                        _cache.Set(key, value, expiration.Value);
                    }
                    else
                    {
                        _cache.Set(key, value);
                    }
                }
            }

            return value;
        }

        public T Save<T>(string key, T value, long? expirationSeconds = null, bool continueOnDefault = false)
        {
            return Save(key, value, GetExpirationFromSeconds(expirationSeconds), continueOnDefault);
        }
    }
}
