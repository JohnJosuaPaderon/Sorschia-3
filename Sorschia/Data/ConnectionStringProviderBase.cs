using Sorschia.Security;
using System.Collections.Generic;
using System.Security;

namespace Sorschia.Data
{
    public abstract class ConnectionStringProviderBase
    {
        private readonly Dictionary<string, SecureString> _source = new Dictionary<string, SecureString>();

        public string this[string key]
        {
            get
            {
                if (string.IsNullOrWhiteSpace(key))
                {
                    throw new SorschiaDataException("Connection String Key cannot be null or white space.");
                }

                TryLoad();

                if (_source.TryGetValue(key, out SecureString result))
                {
                    return SecureStringConverter.Convert(result);
                }
                else
                {
                    throw new SorschiaDataException("Connection String Key doesn't exists in the collection.");
                }
            }
        }

        protected bool IsLoaded { get; private set; }

        protected abstract void Load();

        private void TryLoad()
        {
            if (!IsLoaded)
            {
                Load();
                IsLoaded = true;
            }
        }

        protected void AddToSource(string key, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new SorschiaDataException("Connection String Key cannot be null or white space.");
            }

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new SorschiaDataException("Connection String cannot be null or white space.");
            }

            if (_source.ContainsKey(key))
            {
                throw new SorschiaDataException("Connection String Key already exists!");
            }

            _source.Add(key, SecureStringConverter.Convert(connectionString));
        }
    }
}
