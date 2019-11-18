using System;
using System.Collections.Generic;

namespace Sorschia
{
    [Obsolete]
    internal sealed class SessionVariables : ISessionVariables
    {
        private readonly Dictionary<string, object> _source = new Dictionary<string, object>();

        public object this[string key]
        {
            get
            {
                lock (_source)
                {
                    return _source[key];
                }
            }
            set
            {
                lock (_source)
                {
                    _source[key] = value;
                }
            }
        }

        public void AddOrUpdate(string key, object value)
        {
            lock (_source)
            {
                if (_source.ContainsKey(key))
                {
                    _source[key] = value;
                }
                else
                {
                    _source.Add(key, value);
                } 
            }
        }

        public bool TryGetValue(string key, out object result)
        {
            lock (_source)
            {
                return _source.TryGetValue(key, out result); 
            }
        }

        public bool TryGetValue<T>(string key, out T result)
        {
            lock (_source)
            {
                result = default(T);

                if (TryGetValue(key, out object objValue) && objValue is T value)
                {
                    result = value;
                    return true;
                }

                return false; 
            }
        }
    }
}
