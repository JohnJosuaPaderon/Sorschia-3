using System;
using System.Collections.Generic;
using System.Text;

namespace Sorschia.Caching
{
    public class SorschiaCacheKeyBuilder
    {
        public SorschiaCacheKeyBuilder(Type resultType = null)
        {
            if (resultType != null)
            {
                _constraints.Add("result-type", resultType.FullName);
            }
        }

        private readonly Dictionary<string, object> _constraints = new Dictionary<string, object>();

        public SorschiaCacheKeyBuilder AddConstraint(string key, object value)
        {
            lock (_constraints)
            {
                if (string.IsNullOrWhiteSpace(key))
                {
                    throw new SorschiaCachingException("Key cannot be null or white space.");
                }

                if (_constraints.ContainsKey(key))
                {
                    throw new SorschiaCachingException("Key already exists.");
                }

                _constraints.Add(key, value);

                return this;
            }
        }

        public string Build()
        {
            lock (_constraints)
            {
                var builder = new StringBuilder();

                foreach (var pair in _constraints)
                {
                    builder.AppendFormat("{0}={1}+", pair.Key, pair.Value?.ToString() ?? "null");
                }

                builder.Append("[cache]");

                return builder.ToString();
            }
        }

        public static SorschiaCacheKeyBuilder GetInstance(Type resultType = null)
        {
            return new SorschiaCacheKeyBuilder(resultType);
        }

        public static SorschiaCacheKeyBuilder GetInstance<T>()
        {
            return new SorschiaCacheKeyBuilder(typeof(T));
        }
    }
}
