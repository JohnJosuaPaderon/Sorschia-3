using System.Collections.Generic;

namespace Sorschia
{
    internal sealed class SessionVariables : ISessionVariables
    {
        private readonly Dictionary<string, object> _source = new Dictionary<string, object>();

        public object this[string key]
        {
            get
            {
                return _source[key];
            }
            set
            {
                _source[key] = value;
            }
        }

        public void AddOrUpdate(string key, object value)
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

        public bool TryGetValue(string key, out object result)
        {
            return _source.TryGetValue(key, out result);
        }

        public bool TryGetValue<T>(string key, out T result)
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
